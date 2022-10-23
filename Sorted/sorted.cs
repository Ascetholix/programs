// Сортировка
void PrintArray(int[] ar)           //Вывод
{
  for (int i = 0; i < ar.Length; i++)
  {
    Console.Write($"{ar[i]} ");
  }
  Console.WriteLine();
}

int[] Sorted(int[] arg)             // Сортировка
{
  for (int i = 0; i < arg.Length; i++)
  {
    for (int j = 0; j < arg.Length; j++)
    {
      if (arg[i] < arg[j])           // < Увилечение. > Уменшение
      {
        int h = arg[i];
        arg[i] = arg[j];
        arg[j] = h;
      }
    }
  }
  return arg;
}

int[] list = { 5, 4, 7, 9, 3, 1, 6, 7, 8 };
PrintArray(list);

list = Sorted(list);

PrintArray(list);

