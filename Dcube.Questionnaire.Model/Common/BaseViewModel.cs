namespace DCube.Questionnaire.Model.Common;

/// <summary>
/// Represents the base view model with common audit and identity properties.
/// </summary>
public interface IBaseViewModel
{
    /// <summary>
    /// Gets or sets the unique numeric identifier.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was created (UTC).
    /// </summary>
    public DateTime CreatedOn { get; set; }

    /// <summary>
    /// Gets a <see cref="DateTimeViewModel"/> representation of the <see cref="CreatedOn"/> property.
    /// </summary>
    public DateTimeViewModel Created => new DateTimeViewModel(CreatedOn);

    /// <summary>
    /// Gets or sets the date and time when the entity was last modified (UTC).
    /// </summary>
    public DateTime ModifiedOn { get; set; }

    /// <summary>
    /// Gets a <see cref="DateTimeViewModel"/> representation of the <see cref="ModifiedOn"/> property.
    /// </summary>
    public DateTimeViewModel Modified => new DateTimeViewModel(ModifiedOn);

    /// <summary>
    /// Gets or sets the username or identifier of the creator.
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the username or identifier of the last modifier.
    /// </summary>
    public string ModifiedBy { get; set; }
}

/// <summary>
/// Provides formatted representations of a <see cref="DateTime"/> value.
/// </summary>
/// <param name="dateValue">The date and time value to format.</param>
public class DateTimeViewModel(DateTime dateValue)
{
    /// <summary>
    /// Gets the original <see cref="DateTime"/> value.
    /// </summary>
    public DateTime DateValue => dateValue;

    /// <summary>
    /// Gets the date in "yyyy-MM-dd" format.
    /// </summary>
    public string DateFormat => dateValue.ToString("yyyy-MM-dd");

    /// <summary>
    /// Gets the time in "HH:mm:ss" format.
    /// </summary>
    public string TimeFormat => dateValue.ToString("HH:mm:ss");

    /// <summary>
    /// Gets the date and time in "yyyy-MM-dd HH:mm:ss" format.
    /// </summary>
    public string DateTimeFormat => dateValue.ToString("yyyy-MM-dd HH:mm:ss");
}