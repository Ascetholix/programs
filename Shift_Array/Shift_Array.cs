// Сдвиг массива
void ShiftArray(int[] arg, int shift)
{
  int n = arg.Length;
  int[] arr = new int[n];

  for (int i = 0; i < n; i++)
  {
    arr[i] = arg[i];
  }
  for (int i = 0; i < n; i++)
  {
    arg[(i + shift) % n] = arr[i];
  }
}



int[] array = { 5, 2, 4, 7, 8, 9, 6, 3, 1 };
int shift = 5;
Console.WriteLine("Первый массив: [" + string.Join(", ", array) + "]");
System.Console.WriteLine($"Сдвиг {shift}");
ShiftArray(array, shift);

Console.WriteLine(string.Join(" ", array));
Console.ReadLine();