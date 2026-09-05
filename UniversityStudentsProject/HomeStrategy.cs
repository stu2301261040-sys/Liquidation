namespace UniversityStudentsProject;

public class HomeStrategy : IExecutionStrategy
{
    public void Execute(string programName)
    {
        Console.WriteLine($"Изпълнение на „{programName}“ вкъщи.");
    }
}
