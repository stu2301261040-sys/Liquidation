namespace UniversityStudentsProject;

public static class ProgramFactory
{
    public static IProgram Create(ProgramType type)
    {
        return type switch
        {
            ProgramType.StudyWithUnderstanding =>
                new TrainingProgram("учене с разбиране"),

            ProgramType.Copying =>
                new TrainingProgram("преписване за напреднали"),

            ProgramType.Cramming =>
                new TrainingProgram("зубрене до скъсване"),

            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };
    }
}
