// Сумма массива рекурсия

int Sum(int[] arg, int i = 0)
{
  int len = arg.Length;
  if (i == len) return 0;
  else 
  {
    int result = Sum(arg, i + 1);
    return arg[i] + result; 
  }
}
int Count(int[] arg, int i = 0)
{
  int len = arg.Length;
  if (i == len) return 0;
  else 
  {
    int result = Count(arg, i + 1);
    return 1 + result; 
  }
}

int[] ar = { 2, 4, 5, 6, 8, 7, 1, 3 };
int sum = Sum(ar);
int count = Count(ar);
Console.WriteLine(sum);
Console.WriteLine(count);


