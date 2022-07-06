// Задача 27: 
//Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int ost = num % 10;
        sum += ost;
        num = num / 10;
    }
    return sum;
}

int sum = Sum(number);
Console.WriteLine($"Сумма цифр числа {number} = {sum}");
