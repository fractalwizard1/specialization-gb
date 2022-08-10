using System;
class Program
{

    static void Main(string[] args)

    {
        string str1, str2, str3, str4;

        Console.Write("Введите первый массив строк:");

        str1 = Console.ReadLine();

        Console.Write("Введите второй массив строк:");

        str2 = Console.ReadLine();

        Console.Write("Введите третий массив строк:");

        str3 = Console.ReadLine();

        Console.Write("Введите четвертый массив строк:");

        str4 = Console.ReadLine();

       

        string[] Array =
        {
            str1,
            str2,
            str3,
            str4
            };

        var result = new string[Array.Length];
        var realSize = 0;
        foreach (var value in Array)
        {
            if (value.Length <= 3)
            {
                result[realSize] = value;
                realSize++;
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));

    }
}
//Написать программу,которая из имеющещегося массива строк,формирует массив из строк длинна которых меньше либо равна 3-м символам.   






