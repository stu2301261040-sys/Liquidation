namespace UniversityStudentsProject;

public class TeamworkDecorator : ProgramDecorator
{
    public TeamworkDecorator(IProgram program) : base(program) { }

    public override string GetDescription() =>
        program.GetDescription() + " + работа в екип";
}
