namespace AssignmentLibrary;

public class Assignment
{
    private const string BlankFieldMessage = "{0} cannot be blank or whitespace.";

    public string Title { get; private set; }
    public string Description { get; private set; }

    public Assignment(string title, string description)
    {
        ValidateInputs(title, description);

        Title = title;
        Description = description;
    }

    public void Update(string newTitle, string newDescription)
    {
        ValidateInputs(newTitle, newDescription);

        Title = newTitle;
        Description = newDescription;
    }

    private void Validate(string input, string fieldName)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException(string.Format(BlankFieldMessage, fieldName));
    }

    private void ValidateInputs(string title, string description)
    {
        Validate(title, nameof(title));
        Validate(description, nameof(description));
    }
}
