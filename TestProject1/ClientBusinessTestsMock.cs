using DCube.Questionnaire.Business;
using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Repository;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using Microsoft.Extensions.Logging;
using Moq;

namespace DCube.Questionnaire.Unit;

/// <summary>
/// Contains example unit test demonstrating how to mock the <see cref="IUnitOfWork"/> interface and its repositories for use with <see cref="ClientBusiness"/>.
/// </summary>
public partial class ClientBusinessTests
{
    /// <summary>
    /// Example test showing how to mock <see cref="IUnitOfWork"/> and its repository properties for use in unit testing <see cref="ClientBusiness"/>.
    /// </summary>
    [Fact]
    public void Example_Mock_IUnitOfWork()
    {
        // Arrange: Create mocks for repositories
        var clientRepoMock = new Mock<IClientRepository>();
        var clientExtRepoMock = new Mock<IClientExtensionRepository>();
        var userRepoMock = new Mock<IUserRepository>();

        // Arrange: Create mock for IUnitOfWork
        var unitOfWorkMock = new Mock<IUnitOfWork>();

        // Setup the IUnitOfWork to return the repository mocks
        unitOfWorkMock.Setup(u => u.Clients).Returns(clientRepoMock.Object);
        unitOfWorkMock.Setup(u => u.ClientExtensions).Returns(clientExtRepoMock.Object);
        unitOfWorkMock.Setup(u => u.Users).Returns(userRepoMock.Object);

        // Optionally, setup SaveChangesAsync and ExecuteAsync
        unitOfWorkMock.Setup(u => u.SaveChangesAsync()).ReturnsAsync(1);
        unitOfWorkMock.Setup(u => u.ExecuteAsync(It.IsAny<Func<Task>>()))
            .Returns<Func<Task>>(f => f());

        // Now you can inject unitOfWorkMock.Object into your ClientBusiness
        var loggerMock = new Mock<ILogger<ClientBusiness>>();
        var userContextMock = new Mock<IUserContext>();
        var sut = new ClientBusiness(loggerMock.Object, userContextMock.Object, unitOfWorkMock.Object);

        // Act & Assert: Use sut in your tests, setup repository mocks as needed
    }
}
