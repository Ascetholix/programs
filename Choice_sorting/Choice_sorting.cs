// Сортировка выбором

void ChoiceSort(int[] arg)
{
  for (int i = 0; i < arg.Length - 1; i++)
  {
    int minIndex = i;
    for (int j = i + 1; j < arg.Length; j++)
    {
      if (arg[j] < arg[minIndex])
      {
        minIndex = j;
      }
      int tmp = arg[i];
      arg[i] = arg[minIndex];
      arg[minIndex] = tmp;
    }
  }
}

int[] array = { 5, 2, 4, 7, 8, 9, 6, 3, 1 };

Console.WriteLine("Первый массив: [" + string.Join(", ", array) + "]");

ChoiceSort(array);

Console.WriteLine(string.Join(" ", array));