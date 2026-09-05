using UniversityStudentsProject;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var university = University.Instance;

Console.WriteLine("======================================");
Console.WriteLine("          === УНИВЕРСИТЕТ ===");
Console.WriteLine("======================================");
Console.WriteLine();

Console.WriteLine("Студентите се завръщат в университета.");
Console.WriteLine("Те са готови да направят своя избор от терминала.");
Console.WriteLine();

var terminal = new ProgramTerminal();

Console.WriteLine("======================================");
Console.WriteLine("        === ТЕРМИНАЛ ===");
Console.WriteLine("======================================");
Console.WriteLine();

var programType = terminal.SelectProgram();

var program = terminal.CreateProgram(programType);

var profile = terminal.SelectProfile();

program = terminal.AddProfile(program, profile);

var executionStrategy = terminal.SelectExecutionStrategy();

program.SetExecutionStrategy(executionStrategy);

Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine("          === ВАШИЯТ ИЗБОР ===");
Console.WriteLine("======================================");

Console.WriteLine($"Програма: {program.GetDescription()}");

Console.WriteLine();
Console.WriteLine("Изпълнение:");

program.Execute();

Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine($"Университет: {university.Name}");
Console.WriteLine("======================================");

Console.WriteLine();
Console.WriteLine("Натиснете произволен клавиш за край...");
Console.ReadKey();