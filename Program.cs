using System;

class Program
{
    static void Main()
    {
        Console.Write("Ifodani kiriting: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input)) return;

        int i = 0;
        int result = 0;
        int currentNumber = 0;
        char operation = '+';

        while (i < input.Length)
        {
            char c = input[i];

            // 1. Raqamni tekshirish va yig'ish (Metod orqali)
            if (IsDigit(c))
            {
                currentNumber = currentNumber * 10 + (c - '0');
            }

            // 2. Operator yoki oxir bo‘lsa hisoblash
            if (IsOperator(c) || i == input.Length - 1)
            {
                // Hisoblash qismini alohida metodga oldik
                result = Calculate(result, currentNumber, operation);

                operation = c;
                currentNumber = 0;
            }

            i++;
        }

        Console.WriteLine("Natija: " + result);
    }

    // --- Alohida metodlar ---

    // Belgini raqam ekanligini tekshirish
    static bool IsDigit(char c)
    {
        return c >= '0' && c <= '9';
    }

    // Belgini operator ekanligini tekshirish
    static bool IsOperator(char c)
    {
        return c == '+' || c == '-';
    }

    // Matematik amalni bajarish
    static int Calculate(int total, int number, char op)
    {
        if (op == '+')
        {
            return total + number;
        }
        else if (op == '-')
        {
            return total - number;
        }
        return total;
    }
}