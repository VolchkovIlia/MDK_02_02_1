using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
public class Mainclass
{
    public static void Main(string[] args)
    {
        Tasks tasks = new Tasks();
        do
        {
            Console.Write("Выберите номер задачи: \n[1] Два числа\n[2] 5 < ... < 10\n[3] ... = 5 или ... = 10\n[4] Банк\n[5] Банк+\nВыбор: "); int ans = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine(); switch (ans)
            {
                case 1:
                    tasks.FirstTask(); break;
                case 2:
                    tasks.SecondTask();
                    break;
                case 3:
                    tasks.ThirdTask(); break;
                case 4:
                    tasks.FourthTask();
                    break;
                case 5:
                    tasks.FifthTask(); break;
                default:
                    Console.WriteLine("Некорректное число!");
                    break;
            }
            Console.WriteLine();
        }
        while (true);
    }
}
public class Tasks
{
    public void FirstTask()
    {
        Console.Write("Введите два числа через пробел: ");
        string Nums = Console.ReadLine()?.Trim() ?? "0 0"; int[] arrNums = Array.ConvertAll(Nums.Split(' '), int.Parse);
        if (arrNums.Length > 2) { Console.WriteLine("Введите два числа!"); }
        if (arrNums[0] > arrNums[1])
        {
            Console.WriteLine("Первое число больше второго");
        }
        else if (arrNums[0] < arrNums[1])
        {
            Console.WriteLine("Первое число меньше второго");
        }
        else
        {
            Console.WriteLine("Числа равны");
        }
    }
    public void SecondTask()
    {
        Console.Write("Введите число: ");
        int Num = int.Parse(Console.ReadLine() ?? "0"); if (Num > 5 && Num < 10)
        {
            Console.WriteLine("Число больше 5-ти и меньше 10-ти");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }
    }
    public void ThirdTask()
    {
        Console.Write("Введите число: "); int Num = int.Parse(Console.ReadLine() ?? "0");
        if (Num == 5 || Num == 10)
        {
            Console.WriteLine("Число равно 5-ти, либо равно 10-ти");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }
    }
    public void FourthTask()
    {
        Console.WriteLine("Введите сумму вашего вклада: "); double SumInvest = Convert.ToDouble(Console.ReadLine());
        if (SumInvest >= 0 && SumInvest < 100)
        {
            Console.WriteLine($"Сумма вклада с процентами: {SumInvest += SumInvest / 100 * 7}");
        }
        else if (SumInvest >= 100 && SumInvest <= 200)
        {
            Console.WriteLine($"Сумма вклада с процентами: {SumInvest += SumInvest / 100 * 9}");
        }
        else if (SumInvest > 200)
        {
            Console.WriteLine($"Сумма вклада с процентами: {SumInvest += SumInvest / 100 * 12}");
        }
        else { Console.WriteLine("Неверная сумма вклада!"); }

    }
    public void FifthTask()
    {
        Console.WriteLine("Введите сумму вашего вклада: ");
        double SumInvest = Convert.ToDouble(Console.ReadLine()); if (SumInvest >= 0 && SumInvest < 100)
        {
            Console.WriteLine($"Сумма вклада с процентами и бонусом: {SumInvest += (SumInvest / 100 * 7) + 15}");
        }
        else if (SumInvest >= 100 && SumInvest <= 200)
        {
            Console.WriteLine($"Сумма вклада с процентами и бонусом: {SumInvest += (SumInvest / 100 * 9) + 15}");
        }
        else if (SumInvest > 200)
        {
            Console.WriteLine($"Сумма вклада с процентами и бонусом: {SumInvest += (SumInvest / 100 * 12) + 15}");
        }
        else { Console.WriteLine("Неверная сумма вклада!"); }
    }
}
