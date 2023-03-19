// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int IsNumers(ref string index)
{
  bool numers = int.TryParse(index, out int volue);
  while(numers == false)
  {
    Console.Write("Вы ввели не число, повторите попытку: ");
    index = Console.ReadLine();
    numers = int.TryParse(index, out volue);
  }
  return volue;
}

int CountArray(int n)
{
  if (n == 0)
    return 1;
  int count = 0;
  while (n != 0) // n > 0
  {
    n /= 10;
    count++;
  }
  return count;
}

void SumArray(int[] array, int n)
{
  Console.Write($"Сумма чисел числа {n}");
  int sum = 0;
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = n % 10;
    n /= 10;
    sum += array[i];
  }
  Console.WriteLine($" = {sum}");
}

Console.Clear();
Console.Write($"Введите число, что бы узнать сумму его чисел: ");
string index = Console.ReadLine();
int[] array = new int[CountArray(IsNumers(ref index))];
int ind = Convert.ToInt32(IsNumers(ref index));
SumArray(array, ind);