using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<object> randomValues = new List<object>();

        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            if (random.Next(2) == 0) 
            {
                float randomFloat = (float)(random.NextDouble() * 100); 
                randomValues.Add(randomFloat);
            }
            else
            {
                int randomInt = random.Next(1, 101); 
                randomValues.Add(randomInt);
            }
        }

        Console.WriteLine("Сгенерированные значения:");
        foreach (var value in randomValues)
        {
            Console.WriteLine(value);
        }

        double sum = SumValues(randomValues);
        Console.WriteLine($"Сумма значений: {sum}");
    }

    static double SumValues(List<object> values)
    {
        double sum = 0;

        foreach (var value in values)
        {
            if (value is int intValue)
            {
                sum += intValue;
            }
            else if (value is float floatValue)
            {
                sum += floatValue;
            }
        }

        return sum;
    }
}