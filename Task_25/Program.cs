// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// ______________

Console.Write("Ведите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

double Step(int a1, int b1)
{
    double res = Math.Pow(a1, b1);
    return res;
}
double result = Step(a, b);
Console.WriteLine(result);