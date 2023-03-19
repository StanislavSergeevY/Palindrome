// Задача 29: Напишите программу, которая будет создавать массив из 8 символов
// и заполнять значениями от пользователя
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int IsNumers()
{
  string index = Console.ReadLine();
  bool numers = int.TryParse(index, out int volue);
  while(numers == false)
  {
    Console.Write("Вы ввели не число, повторите попытку: ");
    index = Console.ReadLine();
    numers = int.TryParse(index, out volue);
  }
  return volue;
}

void ArrayFree(int[] array)
{
  Console.Write("Заполнять массив в ручную? y/n: ");
  string x = Console.ReadLine();
  if(x.ToLower() == "y")
  {
    for (int i = 0; i < array.Length; i++)
    {
      Console.Write($"Введите значение индекса [{i}] массива: ");
      array[i] = IsNumers();
    }
  } 
  else if(x.ToLower() == "n")
  {
    for (int ii = 0; ii < array.Length; ii++)
    {
      array[ii] = new Random().Next(-50, 51);
    }
  }
  else
    Console.WriteLine($"Введено не корректно значение, массив будет заполнен нулями!");
}

Console.Clear();
Console.Write($"Введите размер массива: ");
int[] array = new int[IsNumers()];
ArrayFree(array);
Console.WriteLine($"Ваш массив размером: {array.Length}, заполнен следующими значениями: [{string.Join(", ", array)}]"); 
// Размер массива задаётся пользователем.
// Значения массива могут быть заполненны как вручную так и рандомно.
// Защита от ввода символов.