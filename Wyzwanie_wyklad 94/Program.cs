using System;

namespace Wyzwanie_wyklad_94
{
    class Program
    {
        static void Main(string[] args)
        {
            string input="";
            string dataType;
            int caseIdea;
            bool invalidString=false;
            bool invalidInt = false;
            bool forBoolean;
            
            Console.WriteLine("Please enter anything You like");
            input = Console.ReadLine();
            char[] stringArray = input.ToCharArray();
            Console.WriteLine("Please define the data type You used");
            Console.WriteLine("Use 1 for String\nUse 2 for Integer\nUse 3 for Boolean.");
            dataType = Console.ReadLine();
            caseIdea = int.Parse(dataType);

            switch (caseIdea)
            {
                case 1:
                    foreach(char litera in stringArray)
                    {
                        if (char.IsLetter(litera))
                        {
                            continue;
                        }
                        else
                        {
                           invalidString = true;
                        }

                    }

                    Console.WriteLine($"You've entered {input}");
                    if (invalidString == true)
                    {
                        Console.WriteLine("String is invalid");
                    }
                    else
                    {
                        Console.WriteLine("It's a valid string");
                    }
                    break;
                case 2:
                    foreach (char cyfra in stringArray)
                    {
                        if (char.IsDigit(cyfra))
                        {                           
                            continue;
                        }
                        else
                        {                           
                            invalidInt = true;
                        }

                    }
                    Console.WriteLine($"You've entered {input}");
                    if (invalidInt == true)
                    {
                        Console.WriteLine("Int is invalid");
                    }
                    else
                    {
                        Console.WriteLine("It's a valid Integer.");
                    }
                    break;
                case 3:
                    forBoolean = bool.Parse(input);
                    if (forBoolean == true)
                    {
                        Console.WriteLine("The bool is True.");
                    }
                    else
                    {
                        Console.WriteLine("The bool is false.");
                    }
                    break;
                default:
                    Console.WriteLine("bullshitery");
                    break;
            }
                Console.ReadKey();
        }
    }
}
