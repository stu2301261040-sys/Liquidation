namespace UniversityStudentsProject;

public class TrainingProgram : IProgram
{
    private readonly string name;
    private IExecutionStrategy? strategy;

    public TrainingProgram(string name)
    {
        this.name = name;
    }

    public string GetDescription() => name;

    public void SetExecutionStrategy(IExecutionStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void Execute()
    {
        if (strategy == null)
            throw new InvalidOperationException("Не е избрано място за изпълнение.");

        strategy.Execute(name);
    }
}
