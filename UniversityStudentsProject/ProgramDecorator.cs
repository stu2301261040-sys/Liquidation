namespace UniversityStudentsProject;

public abstract class ProgramDecorator : IProgram
{
    protected readonly IProgram program;

    protected ProgramDecorator(IProgram program)
    {
        this.program = program;
    }

    public abstract string GetDescription();

    public void SetExecutionStrategy(IExecutionStrategy strategy)
    {
        program.SetExecutionStrategy(strategy);
    }

    public void Execute()
    {
        program.Execute();
    }
}
