namespace UniversityStudentsProject;

public interface IProgram
{
    string GetDescription();
    void Execute();
    void SetExecutionStrategy(IExecutionStrategy strategy);
}
