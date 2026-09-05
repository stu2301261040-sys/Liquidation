namespace UniversityStudentsProject;

public class CafeStrategy : IExecutionStrategy
{
    public void Execute(string programName)
    {
        Console.WriteLine($"Изпълнение на „{programName}“ в кафенето.");
    }
}
