// See https://aka.ms/new-console-template for more information

int[] SmallChoice(int[] ar)
{
  int small = ar[0];
  int smallIndex = 0;

  for (int i = 0; i < ar.Length; i++)
  {
    if (ar[i] < small)
    {
      small = ar[i];
      smallIndex = i;
    }
  }
  return smallIndex;
}
int[] array = { 5, 4, 7, 9, 6, 3, 8, 2, 1 };
int[] sortArrya = new int[array.Length];

for (int i = 0; i <array.Length; i++)
{
  
}
