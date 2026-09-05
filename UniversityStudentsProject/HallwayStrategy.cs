namespace UniversityStudentsProject;

public class HallwayStrategy : IExecutionStrategy
{
    public void Execute(string programName)
    {
        Console.WriteLine($"Изпълнение на „{programName}“ в коридора.");
    }
}
