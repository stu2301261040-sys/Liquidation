namespace UniversityStudentsProject;

public sealed class University
{
    private static readonly Lazy<University> instance =
        new(() => new University());

    public static University Instance => instance.Value;

    public string Name { get; } = "Университет";

    private University() { }
}
