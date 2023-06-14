using System;

namespace Wyzwanie_wyklad_94
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter anything You like");
            var input = Console.ReadLine();

            Console.WriteLine("Please define the data type You used");
            Console.WriteLine("Use 1 for String\nUse 2 for Integer\nUse 3 for Boolean.");
            var hasDataTypeBeenParsed = int.TryParse(Console.ReadLine(), out var typeSymbol);

            if (string.IsNullOrWhiteSpace(input) || !hasDataTypeBeenParsed || typeSymbol > 3 || typeSymbol < 1)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            
            Console.WriteLine($"You've entered {input}");
            
            switch (typeSymbol)
            {
                case 1:
                    var isStringValid = true;
                    foreach(var character in input)
                    {
                        if (!char.IsLetter(character))
                        {
                            isStringValid = false;
                            break;
                        }
                    }
                    Console.WriteLine(isStringValid ? "Valid String" : "Invalid String");
                    break;
                case 2:
                    var isValidNumber = int.TryParse(input, out _);
                    Console.WriteLine(isValidNumber ? "Valid Integer" : "Invalid Integer");
                    break;
                case 3:
                    var isValidBoolean = bool.TryParse(input, out var booleanValue);
                    Console.WriteLine(isValidBoolean ? $"Valid Boolean: {booleanValue}" : "Invalid Boolean");
                    break;
            }
                Console.ReadKey();
        }
    }
}
