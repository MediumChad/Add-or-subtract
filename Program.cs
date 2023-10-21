// See https://aka.ms/new-console-template for more information
class addnsubtract
{
    static void Main()
    {
        Console.WriteLine("Would you like to Add(A) or Subtract(S)?");
        string letter = Console.ReadLine();
        bool isA = IsletterA(letter);
        bool isS = IsLetterS(letter);

        if(isA)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine($"The result of {num1} + {num2} is: {result}");
        }
        else if (isS)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32((string) Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32((string) Console.ReadLine());

            int result = num1 - num2;
            Console.WriteLine($"The result of {num1} - {num2} is; {result}");
        }
        else 
        { Console.WriteLine("Yeah.... Just go ahead and turn off your computer");
        }

        static bool IsletterA(string letter)
        {
            return letter.ToLower() == "a";
        }
        static bool IsLetterS(string letter)
        {
            return letter.ToLower() == "s";
        }
        
    }
}
