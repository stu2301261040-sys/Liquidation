namespace UniversityStudentsProject;

public class SoloDecorator : ProgramDecorator
{
    public SoloDecorator(IProgram program) : base(program) { }

    public override string GetDescription() =>
        program.GetDescription() + " + соло изпълнител";
}
