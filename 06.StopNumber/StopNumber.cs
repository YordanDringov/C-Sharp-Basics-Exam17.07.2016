using System;
using System.Collections.Generic;

class StopNumber
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int lastNumber = int.Parse(Console.ReadLine());
        int stopNumber = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = lastNumber; i >= firstNumber; i--)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                if (i == stopNumber)
                {
                    break;
                }
                numbers.Add(i);
            }
        }

        Console.WriteLine(String.Join(" ", numbers));
    }
}

