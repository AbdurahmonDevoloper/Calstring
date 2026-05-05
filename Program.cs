using System;

class Program
{
    static void Main()
    {
        Console.Write("Ifodani kiriting: ");
        string input = Console.ReadLine();

        int i = 0;
        int result = 0;
        int currentNumber = 0;
        char operation = '+';

        while (i < input.Length)
        {
            char c = input[i];

            // 1. Raqam yig‘ish
            if (c >= '0' && c <= '9')
            {
                currentNumber = currentNumber * 10 + (c - '0');
            }

            // 2. Operator yoki oxir bo‘lsa hisoblash
            if (c == '+' || c == '-' || i == input.Length - 1)
            {
                if (operation == '+')
                {
                    result += currentNumber;
                }
                else if (operation == '-')
                {
                    result -= currentNumber;
                }

                operation = c;
                currentNumber = 0;
            }

            i++;
        }

        Console.WriteLine("Natija: " + result);
    }
}