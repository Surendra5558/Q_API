namespace DCube.Questionnaire.Unit;

using DCube.Questionnaire.Business;
using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using DCube.Questionnaire.Repository;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

public partial class ClientBusinessTests
{
    private readonly Mock<ILogger<ClientBusiness>> _loggerMock = new();
    private readonly Mock<IUserContext> _userContextMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();
    private readonly Mock<IClientRepository> _clientRepoMock = new();
    private readonly Mock<IClientExtensionRepository> _clientExtRepoMock = new();
    private readonly Mock<IUserRepository> _userRepoMock = new();

    private ClientBusiness CreateSut()
    {
        _unitOfWorkMock.SetupGet(u => u.Clients).Returns(_clientRepoMock.Object);
        _unitOfWorkMock.SetupGet(u => u.ClientExtensions).Returns(_clientExtRepoMock.Object);
        _unitOfWorkMock.SetupGet(u => u.Users).Returns(_userRepoMock.Object);
        return new ClientBusiness(_loggerMock.Object, _userContextMock.Object, _unitOfWorkMock.Object);
    }

    [Fact]
    public async Task GetAsync_ReturnsQueryableClientViewModels()
    {
        // Arrange
        var clients = new List<Client>
        {
            new() { Id = 1, Name = "A", CreatedBy = 10, ModifiedBy = 20, CreatedOn = DateTime.UtcNow, ModifiedOn = DateTime.UtcNow }
        }.AsQueryable();
        var clientExts = new List<ClientExtension>
        {
            new() { ClientId = 1, LegalName = "LegalA", Address = "Addr", PhoneNumber = "123", ContactPerson = "CP", ContactPersonEmail = "cp@email.com", ContactPersonPhone = "555" }
        }.AsQueryable();
        var users = new List<User>
        {
            new() { Id = 10, FirstName = "John", LastName = "Doe" },
            new() { Id = 20, FirstName = "Jane", LastName = "Smith" }
        }.AsQueryable();

        _clientRepoMock.Setup(r => r.GetAsync()).ReturnsAsync(clients);
        _clientExtRepoMock.Setup(r => r.GetAsync()).ReturnsAsync(clientExts);
        _userRepoMock.Setup(r => r.GetAsync()).ReturnsAsync(users);

        var sut = CreateSut();

        // Act
        var result = await sut.GetAsync();

        // Assert
        var list = result.ToList();
        Assert.Single(list);
        Assert.Equal("A", list[0].Name);
        Assert.Equal("LegalA", list[0].LegalName);
        Assert.Equal("John Doe", list[0].CreatedBy);
        Assert.Equal("Jane Smith", list[0].ModifiedBy);
    }

    [Fact]
    public async Task GetByIdAsync_ReturnsClientViewModel_WhenFound()
    {
        // Arrange
        var client = new Client { Id = 1, Name = "A", CreatedBy = 10, ModifiedBy = 20, CreatedOn = DateTime.UtcNow, ModifiedOn = DateTime.UtcNow };
        var clientExt = new ClientExtension { ClientId = 1, LegalName = "LegalA", Address = "Addr", PhoneNumber = "123", ContactPerson = "CP", ContactPersonEmail = "cp@email.com", ContactPersonPhone = "555" };
        var userCreated = new User { Id = 10, FirstName = "John", LastName = "Doe" };
        var userModified = new User { Id = 20, FirstName = "Jane", LastName = "Smith" };

        _clientRepoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(client);
        _clientExtRepoMock.Setup(r => r.GetAsync()).ReturnsAsync(new[] { clientExt }.AsQueryable());
        _userRepoMock.Setup(r => r.GetByIdAsync(10)).ReturnsAsync(userCreated);
        _userRepoMock.Setup(r => r.GetByIdAsync(20)).ReturnsAsync(userModified);

        var sut = CreateSut();

        // Act
        var result = await sut.GetByIdAsync(1);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("A", result.Name);
        Assert.Equal("LegalA", result.LegalName);
        Assert.Equal("John Doe", result.CreatedBy);
        Assert.Equal("Jane Smith", result.ModifiedBy);
    }

    [Fact]
    public async Task GetByIdAsync_ThrowsKeyNotFoundException_WhenNotFound()
    {
        _clientRepoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync((Client)null);
        var sut = CreateSut();

        await Assert.ThrowsAsync<KeyNotFoundException>(() => sut.GetByIdAsync(1));
    }

    [Fact]
    public async Task CreateAsync_AddsClientAndExtension_WhenNameIsUnique()
    {
        // Arrange
        var model = new ClientCreateModel { Name = "A", LegalName = "LegalA", Address = "Addr", PhoneNumber = "123", ContactPerson = "CP", ContactPersonEmail = "cp@email.com", ContactPersonPhone = "555" };
        _clientRepoMock.Setup(r => r.GetAsync()).ReturnsAsync(new List<Client>().AsQueryable());
        _unitOfWorkMock.Setup(u => u.ExecuteAsync(It.IsAny<Func<Task>>()))
            .Returns<Func<Task>>(f => f());
        _clientRepoMock.Setup(r => r.AddAsync(It.IsAny<Client>())).Returns(Task.CompletedTask);
        _clientExtRepoMock.Setup(r => r.AddAsync(It.IsAny<ClientExtension>())).Returns(Task.CompletedTask);
        _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).ReturnsAsync(1);

        var sut = CreateSut();

        // Act
        var result = await sut.CreateAsync(model);

        // Assert
        Assert.Equal(2, result); // 1 for client, 1 for extension
        _clientRepoMock.Verify(r => r.AddAsync(It.IsAny<Client>()), Times.Once);
        _clientExtRepoMock.Verify(r => r.AddAsync(It.IsAny<ClientExtension>()), Times.Once);
    }

    [Fact]
    public async Task CreateAsync_ThrowsInvalidOperationException_WhenNameExists()
    {
        var model = new ClientCreateModel { Name = "A" };
        _clientRepoMock.Setup(r => r.GetAsync()).ReturnsAsync(new List<Client> { new() { Name = "A" } }.AsQueryable());

        var sut = CreateSut();

        await Assert.ThrowsAsync<InvalidOperationException>(() => sut.CreateAsync(model));
    }

    [Fact]
    public async Task UpdateAsync_UpdatesClientAndExtension_WhenValid()
    {
        // Arrange
        var model = new ClientUpdateModel { Id = 1, Name = "A", LegalName = "LegalA", Address = "Addr", PhoneNumber = "123", ContactPerson = "CP", ContactPersonEmail = "cp@email.com", ContactPersonPhone = "555" };
        var client = new Client { Id = 1, Name = "Old" };
        var clientExt = new ClientExtension { Id = 2, ClientId = 1 };

        _clientRepoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(client);
        _clientRepoMock.Setup(r => r.GetAsync()).ReturnsAsync(new List<Client>().AsQueryable());
        _clientExtRepoMock.Setup(r => r.GetAsync()).ReturnsAsync(new List<ClientExtension> { clientExt }.AsQueryable());
        _unitOfWorkMock.Setup(u => u.ExecuteAsync(It.IsAny<Func<Task>>()))
            .Returns<Func<Task>>(f => f());
        _clientRepoMock.Setup(r => r.UpdateAsync(1, client)).Returns(Task.CompletedTask);
        _clientExtRepoMock.Setup(r => r.UpdateAsync(2, clientExt)).Returns(Task.CompletedTask);
        _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).ReturnsAsync(1);

        var sut = CreateSut();

        // Act
        var result = await sut.UpdateAsync(model);

        // Assert
        Assert.Equal(1, result);
        _clientRepoMock.Verify(r => r.UpdateAsync(1, client), Times.Once);
        _clientExtRepoMock.Verify(r => r.UpdateAsync(2, clientExt), Times.Once);
    }

    [Fact]
    public async Task UpdateAsync_ThrowsKeyNotFoundException_WhenClientNotFound()
    {
        var model = new ClientUpdateModel { Id = 1, Name = "A" };
        _clientRepoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync((Client)null);

        var sut = CreateSut();

        await Assert.ThrowsAsync<KeyNotFoundException>(() => sut.UpdateAsync(model));
    }

    [Fact]
    public async Task UpdateAsync_ThrowsInvalidOperationException_WhenNameExists()
    {
        var model = new ClientUpdateModel { Id = 1, Name = "A" };
        var client = new Client { Id = 1, Name = "Old" };
        _clientRepoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(client);
        _clientRepoMock.Setup(r => r.GetAsync()).ReturnsAsync(new List<Client> { new() { Id = 2, Name = "A" } }.AsQueryable());

        var sut = CreateSut();

        await Assert.ThrowsAsync<InvalidOperationException>(() => sut.UpdateAsync(model));
    }

    [Fact]
    public async Task DeleteAsync_UpdatesClient_WhenFound()
    {
        var client = new Client { Id = 1, Name = "A" };
        _clientRepoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(client);
        _clientRepoMock.Setup(r => r.UpdateAsync(1, client)).Returns(Task.CompletedTask);
        _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).ReturnsAsync(1);

        var sut = CreateSut();

        var result = await sut.DeleteAsync(1);

        Assert.Equal(1, result);
        _clientRepoMock.Verify(r => r.UpdateAsync(1, client), Times.Once);
    }

    [Fact]
    public async Task DeleteAsync_ThrowsKeyNotFoundException_WhenNotFound()
    {
        _clientRepoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync((Client)null);

        var sut = CreateSut();

        await Assert.ThrowsAsync<KeyNotFoundException>(() => sut.DeleteAsync(1));
    }
}