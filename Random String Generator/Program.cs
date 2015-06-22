using System;

namespace RandomStringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fixed size");
            RandomStringGenerator RSG = new RandomStringGenerator();
            for (int i = 0; i < 5; i++)
                Console.WriteLine(RSG.Generate(25));

            Console.WriteLine("Variable size");
            RSG = new RandomStringGenerator();
            for (int i = 0; i < 5; i++)
                Console.WriteLine(RSG.Generate(15,25));

            Console.WriteLine("Using pattern");
            RSG = new RandomStringGenerator();
            for (int i = 0; i < 5; i++)
                Console.WriteLine(RSG.Generate("LLln*ssssL"));

            Console.WriteLine("Using only letters and numbers");
            RSG = new RandomStringGenerator();
            // Or we can use the constructor
            RSG.UseSpecialCharacters = false;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(RSG.Generate(30));

            Console.WriteLine("Using only special characters and numbers");
            RSG = new RandomStringGenerator();
            // Or we can use the constructor
            RSG.UseUpperCaseCharacters = false;
            RSG.UseLowerCaseCharacters = false;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(RSG.Generate(30));

            Console.WriteLine("Using your own alphabet");
            RSG = new RandomStringGenerator(false,true,true,false);
            // Or we can use the constructor
            RSG.LowerCaseCharacters = "абвгдежзиклмнопрстуфхчшщюяьъ".ToCharArray();
            for (int i = 0; i < 5; i++)
                Console.WriteLine(RSG.Generate(30));

            Console.WriteLine("Using special limits");
            RSG = new RandomStringGenerator();
            RSG.MinLowerCaseCharacters = 2;
            RSG.MinSpecialCharacters = 20;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(RSG.Generate(35));

            Console.WriteLine("Using each character only once");
            RSG = new RandomStringGenerator();
            RSG.MinLowerCaseCharacters = 25;
            RSG.RepeatCharacters = false;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(RSG.Generate(25));

            Console.WriteLine("Using custom alphabet, pattern and unique chars");
            RSG = new RandomStringGenerator();
            RSG.LowerCaseCharacters = "абвгдежзиклмнопрстуфхчшщюяьъ".ToCharArray();
            RSG.RepeatCharacters = false;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(RSG.Generate("lllnlllnlllsssL"));

            Console.WriteLine("Unique strings test");
            RSG = new RandomStringGenerator(false,false,true,false); // numbers only
            RSG.UniqueStrings = true;
            for (int i = 0; i < 9; i++)
                Console.WriteLine(RSG.Generate(16));

            Console.ReadKey(); // stop
        }
    }
}
