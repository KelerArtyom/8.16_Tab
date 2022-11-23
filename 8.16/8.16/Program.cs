using System;
using System.Runtime.CompilerServices;

public class Mainclass
{
    public static void Main()
    {
        int max = 0;
        int[,] a = new int[12, 3];
        Random random = new Random();
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                a[i, j] = random.Next(5000, 10000);
            }
        }
                Console.WriteLine("Работник\tМесяц");
        Console.WriteLine(" \t  1\t  2\t  3");
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i} \t {a[i-1, 0]} \t {a[i - 1, 1]}\t {a[i - 1, 2]}");
        }
        a:
        Console.WriteLine("");
        Console.WriteLine("Выберите команду:");
        Console.WriteLine("1) Максимальная зарплата");
        Console.WriteLine("2) Работник с максимальным окладом");
        Console.WriteLine("3) Месяц с самым большим максимальным окладом");
        Console.WriteLine("Введите номер:...");
        int cmd = int.Parse(Console.ReadLine());
        if (cmd == 1)
        {
            max = a.Cast<int>().Max();
            Console.WriteLine("");
            Console.WriteLine($"Максимальная зарплата: {max}");
            Console.WriteLine("----------------------------------");
            goto a;
        }
        else if (cmd == 2)
        {
            max = a.Cast<int>().Max();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a[i, j]==max)
                    {

                        Console.WriteLine("");
                        Console.WriteLine($"Работник с самым большим окладом идет номером {i+1} в списке ({a[i, j]})");
                        Console.WriteLine("----------------------------------");
                        goto a;
                    }
                }
            }
        }
        else if (cmd == 3)
        {
            int month_1 = 0;
            int month_2 = 0;
            int month_3 = 0;
            for (int i = 0; i < 12; i++)
            { 
                month_1 = month_1 + a[i, 0];
            }
            for (int i = 0; i < 12; i++)
            {
                
                month_2 = month_2 + a[i, 1];
            }
            for (int i = 0; i < 12; i++)
            {
                
                month_3 = month_3 + a[i, 2];
            }
            int test = Math.Max(Math.Max(month_1, month_2),month_3);
            Console.WriteLine("");
            if (test == month_1)
            {
                Console.WriteLine($"Месяц с самым большим максимальным окладом: 1 ({month_1})");
            }
            else if (test == month_2)
            {
                Console.WriteLine($"Месяц с самым большим максимальным окладом: 2 ({month_2})");
            }
            else if (test == month_3)
            {
                Console.WriteLine($"Месяц с самым большим максимальным окладом: 3 ({month_3})");
            }
            Console.WriteLine("----------------------------------");
            goto a;
        }
    }
}
