//Бинарный поиск

string BinarySearch(int[] arg, int arg1) // Метод поиска. Возврат стринг так как                    
{                                         // инт нет пустого возврата 
  int low = 0;
  int high = arg.Length - 1;

  while (low <= high)
  {
    int mid = (low + high) / 2;
    int guess = arg[mid];
    
    if (guess == arg1)
    {
      return Convert.ToString(mid);
    }
    else if (guess > arg1)
    {
      high = mid - 1;
    }
    else
    {
      low = mid + 1;
    }
  }
  return "Нечего";
}

int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int item = 8;

Console.WriteLine(BinarySearch(list, item));

