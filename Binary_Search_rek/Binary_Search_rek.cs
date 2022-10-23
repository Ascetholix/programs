// Бинарный поис рекурсия

string BinarySearch(int[] arg, int low, int high, int items) // Метод поиска. Возврат стринг так как                    
{                                         // инт нет пустого возврата 
  while (low <= high)
  {
    int mid = (low + high) / 2;
    int guess = arg[mid];

    if (guess == items)
    {
      return Convert.ToString(mid);
    }
    else if (guess > items)
    {
      return Convert.ToString(BinarySearch(arg, low, mid - 1, items));
    }
    else
    {
      return Convert.ToString(BinarySearch(arg, mid + 1, high, items));
    }
  }
  return "Нечего";
}

int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int item = 8;

Console.WriteLine(BinarySearch(list, 0, list.Length, item));