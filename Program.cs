using System;

namespace SimpleConsoleCalculator
{

  class Program
  {
    static int x = 0;
    static int y = 0;
    static int result = 0;
    static string[] modes = new string[] {

      "Addition",
      "Subtraction",
      "Multiplication",
      "Division",
      "Exit",
    };
    static int optionSelected = 0;
    static string separator = "\t<====<< >>====>";

    static void Start()
    {

      Console.Clear();
      BuildOptions(modes);
      switch (optionSelected)
      {

        case 1: CalculatorSettings(ECalculatorMode.Addition); break;
        case 2: CalculatorSettings(ECalculatorMode.Subtraction); break;
        case 3: CalculatorSettings(ECalculatorMode.Multiplication); break;
        case 4: CalculatorSettings(ECalculatorMode.Division); break;
        case 5: Console.Clear(); System.Environment.Exit(0); break;
        default: Start(); break;
      }

      Console.WriteLine($"The result is {result}");
      
      Console.ReadKey();

      Start();
    }

    static void Main(string[] args)
    {

      Console.Clear();
      Console.WriteLine("<> <===< WELCOME TO THE SIMPLE CONSOLE CALCULATOR!! >===> <>");
      Console.ReadKey();
      Start();
      
    }

    static void BuildOptions(string[] array, string message = "Which option?", string pointer = "=>")
    {
      Console.WriteLine($"\t{message}\n");

      Console.WriteLine($"{separator}\n");

      foreach (var item in array)
      {

        Console.WriteLine($"[{Array.IndexOf(array, item) + 1}]\t{item}");
      }

      Console.WriteLine($"\n{separator}");

      Console.Write($"\n\t{pointer} ");
      Int32.TryParse(Console.ReadLine(), out optionSelected);

    }

    static void CalculatorSettings(ECalculatorMode mode)
    {

      switch((short)mode)
      {

        case 1:
          Calculate();
          result = x + y;
          break;
        case 2:
          Calculate();
          result = x - y;
          break;
        case 3:
          Calculate();
          result = x * y;
          break;
        case 4:
          result = x / y;
          break;
      }
    }

    static void Calculate()
    {

      Console.WriteLine($"\n{separator}");
      Console.Write("\nSelect the first value\n\t=> ");
      Int32.TryParse(Console.ReadLine(), out x);
      Console.Write("\nSelect the second value\n\t=> ");
      Int32.TryParse(Console.ReadLine(), out y);
    }
  }

  enum ECalculatorMode
  {
    Addition = 1,
    Subtraction = 2,
    Multiplication = 3,
    Division = 4,

  }

}
