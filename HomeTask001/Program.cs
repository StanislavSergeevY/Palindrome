// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Degree(int n, int s)
{
  Console.Write($"Число: {n}, в степени: {s} = ");
  double x = Math.Pow(n,s);
  return x;
}

Console.Clear();
Console.Write("Введите число: ");
  int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
  int s = Convert.ToInt32(Console.ReadLine());
Console.Write(Degree(n, s));