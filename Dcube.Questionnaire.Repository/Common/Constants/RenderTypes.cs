namespace DCube.Questionnaire.Repository.Common.Constants;

/// <summary>
/// Provides constant values representing different UI render types for questionnaire fields.
/// </summary>
public struct RenderTypes
{
    /// <summary>
    /// Represents a single-line text box input.
    /// </summary>
    public const int TextBox = 1;

    /// <summary>
    /// Represents a numeric input field.
    /// </summary>
    public const int Number = 2;

    /// <summary>
    /// Represents a drop-down selection input.
    /// </summary>
    public const int DropDown = 3;

    /// <summary>
    /// Represents a multi-select input, allowing selection of multiple options.
    /// </summary>
    public const int MultiSelect = 4;

    /// <summary>
    /// Represents a date and time picker input.
    /// </summary>
    public const int DateTimePicker = 5;

    /// <summary>
    /// Represents a checkbox input.
    /// </summary>
    public const int CheckBox = 6;

    /// <summary>
    /// Represents a radio button input.
    /// </summary>
    public const int RadioButton = 7;

    /// <summary>
    /// Represents a multi-line text area input.
    /// </summary>
    public const int TextArea = 8;

    /// <summary>
    /// Represents a rich text editor input.
    /// </summary>
    public const int RichTextEditor = 9;

    /// <summary>
    /// Represents an auto-search input, typically with suggestions or autocomplete.
    /// </summary>
    public const int AutoSearch = 10;

    /// <summary>
    /// Represents a file upload input.
    /// </summary>
    public const int FileUpload = 11;
}