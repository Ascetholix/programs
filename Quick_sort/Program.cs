// Бистрая сортировка

void PrintArray(int[] arg)
{
  for (int i = 0; i < arg.Length; i++)
  {
    Console.Write($"{arg[i]} ");
  }
  Console.WriteLine();
}

int[] QuickSort(int[] arg, int minIndex, int maxIndex)
{
  int left = minIndex;       // в начале левая граница
  int right = maxIndex;      // в начале правая граница
  int pivot = arg[(left + right) / 2]; // Опорный элемент

  if (left >= right) return arg;

  while (left <= right)   // Разделение масиива на два
  {
    while (arg[left] < pivot) left++;
    while (arg[right] > pivot) right--;
    
    if (left <= right)       // песрестановка элемкнтов массива
    {
      int tmp = arg[left];
      arg[left] = arg[right];
      arg[right] = tmp;
      left++;
      right--;
    }
  }
  QuickSort(arg, minIndex, right);  // вызов для правой ветки массива от мин до правой границы
  QuickSort(arg, left, maxIndex);   // вызов для левой ветки массива от левой граници до макс

  return arg;
}

int[] array = { 2, 5, 4, 7, 8, 9, 6, 3, 1 };
PrintArray(array);
array = QuickSort(array, 0, array.Length - 1);
PrintArray(array);