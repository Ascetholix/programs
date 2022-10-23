//  Шифр Виженера

string UpperText(string arg) // Перевод в вверхный регистр
{
  char ch;
  string text = string.Empty;

  for (int i = 0; i < arg.Length; i++)
  {
    ch = char.ToUpper(arg[i]);
    text = text + ch;
  }
  return text;
}

int[] CoutText(string arg)  // Счетчик текста перевод из ASCII в от 0 до 25
{
  int len = 26;
  int[] cout = new int[arg.Length];

  for (int i = 0; i < arg.Length; i++)
  {
    char ch = 'A';
    for (int j = 0; j < len; j++)
    {
      if (arg[i] == ch)
      {
        cout[i] = j;
      }
      ch++;
    }
  }
  return cout;
}

Console.Write("Введите текст на латинице: ");
string text = Console.ReadLine();
Console.Write("Введите текст ключ : ");
string key = Console.ReadLine();

char ch;
int len = 26;
int j = 0;

string vigener = string.Empty;  // шифр
string dvigener = string.Empty; //дешифровка

int[] coutKey = new int[key.Length];  // значение ключа каждый символ от 0 до 25
int[] coutText = new int[text.Length]; //  значение текста каждый символ от 0 до 25
int[] coutVig = new int[text.Length];  //  значение шифра каждый символ от 0 до 25
// int[] coutRvig = new int[text.Length];

text = UpperText(text);
key = UpperText(key);

coutKey = CoutText(key);
coutText = CoutText(text);

for (int i = 0; i < text.Length; i++)  // шифровка
{
  ch = Convert.ToChar(((coutText[i] + coutKey[j])) % len + 65);
  j++;
  if (j == coutKey.Length)   // если j== длине ключа то j = 0
  {
    j = 0;
  }
  vigener = vigener + ch;
}

coutVig = CoutText(vigener);
j = 0;

for (int i = 0; i < vigener.Length; i++)
{
  ch = Convert.ToChar(((coutVig[i] - coutKey[j]) + len) % len + 65);
  j++;
  if (j == coutKey.Length)
  {
    j = 0;
  }
  dvigener = dvigener + ch;
}

Console.Write("Исходный текст: ");
Console.WriteLine(text);

Console.Write("Ключ: ");
Console.WriteLine(key);

Console.Write("Шифр виженера: ");
Console.WriteLine(vigener);

Console.Write("Дешифровка: ");
Console.WriteLine(dvigener);

