namespace UniversityStudentsProject;

public class ProgramTerminal
{
    public IProgram CreateProgram(ProgramType type)
    {
        return ProgramFactory.Create(type);
    }

    public IProgram AddProfile(IProgram program, ProfileType profile)
    {
        return profile switch
        {
            ProfileType.Teamwork => new TeamworkDecorator(program),
            ProfileType.Solo => new SoloDecorator(program),
            _ => throw new ArgumentOutOfRangeException(nameof(profile))
        };
    }

    public IExecutionStrategy CreateExecutionStrategy(int choice)
    {
        return choice switch
        {
            1 => new CafeStrategy(),
            2 => new HallwayStrategy(),
            3 => new HomeStrategy(),
            _ => throw new ArgumentOutOfRangeException(nameof(choice))
        };
    }

    public ProgramType SelectProgram()
    {
        while (true)
        {
            Console.WriteLine("Изберете индивидуална програма:");
            Console.WriteLine("1. Учене с разбиране");
            Console.WriteLine("2. Преписване за напреднали");
            Console.WriteLine("3. Зубрене до скъсване");
            Console.Write("Вашият избор: ");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        return ProgramType.StudyWithUnderstanding;

                    case 2:
                        return ProgramType.Copying;

                    case 3:
                        return ProgramType.Cramming;
                }
            }

            Console.WriteLine("Невалиден избор. Моля, опитайте отново.");
            Console.WriteLine();
        }
    }

    public ProfileType SelectProfile()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Изберете допълнителен профил:");
            Console.WriteLine("1. Работа в екип");
            Console.WriteLine("2. Соло изпълнител");
            Console.Write("Вашият избор: ");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        return ProfileType.Teamwork;

                    case 2:
                        return ProfileType.Solo;
                }
            }

            Console.WriteLine("Невалиден избор. Моля, опитайте отново.");
        }
    }

    public IExecutionStrategy SelectExecutionStrategy()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Изберете място за изпълнение:");
            Console.WriteLine("1. В кафенето");
            Console.WriteLine("2. В коридора");
            Console.WriteLine("3. Вкъщи");
            Console.Write("Вашият избор: ");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        return new CafeStrategy();

                    case 2:
                        return new HallwayStrategy();

                    case 3:
                        return new HomeStrategy();
                }
            }

            Console.WriteLine("Невалиден избор. Моля, опитайте отново.");
        }
    }
}