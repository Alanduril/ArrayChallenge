using System;

namespace Wyzwanie_wyklad_94
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use var instead of named type, do not define/declare variables before they need to be used
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
                    //inconsistent naming, use English, use var 
                    foreach(char litera in stringArray)
                    {
                        //reverse if to decrease complexity
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
                    //when using boolean in if statement, no need to compare them to true or false 
                    //ternary operator could be used in this case to shorten the code
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
                    //naming + var
                    foreach (char cyfra in stringArray)
                    {
                        //reverse if
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
                    //no need for == true
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
