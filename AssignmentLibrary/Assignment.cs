namespace AssignmentLibrary;

public class Assignment
{
    public string Title { get; private set; }
    public string Description { get; private set; }

    public Assignment(string title, string description)
    {
        Validate(title, nameof(title));

        Title = title;
        Description = description;
    }

    public void Update(string newTitle, string newDescription)
    {
        // BUG: Missing validation here
        ValidateInputs(newTitle, newDescription);

        Title = newTitle;
        Description = newDescription;
    }

    private void Validate(string input, string fieldName)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException($"{fieldName} cannot be blank or whitespace.");
    }

    private void ValidateInputs(string title, string description)
    {
        Validate(title, nameof(title));
        Validate(description, nameof(description));
    }
}
