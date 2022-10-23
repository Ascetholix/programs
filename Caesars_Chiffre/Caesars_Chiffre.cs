// Шифр Цезаря

Console.Write("Введите текст на латинице: ");
string text = Console.ReadLine();
Console.Write("Введите ключ цифру от 1 до 25: ");
int num = Convert.ToInt32(Console.ReadLine());

char ch;
char[] charArray = new char[text.Length]; // массив символов
int len = 26;
string caesar = string.Empty;

Console.Write("1 текст: ");
for (int i = 0; i < text.Length; i++)
{
  Console.Write($"{text[i]}");
}

Console.WriteLine();
Console.Write("2 текст: ");
for (int i = 0; i < text.Length; i++)  // Переводим тест в вверхный регистр
{
  charArray[i] = char.ToUpper(text[i]);
  Console.Write($"{charArray[i]}");
}

Console.WriteLine();
Console.Write("Шифр Цезаря: ");
for (int i = 0; i < text.Length; i++)   // Перемешаем текст на позицую num
{
  ch = Convert.ToChar((((int)charArray[i] + num) % 65) + 65);
  caesar = caesar + ch;
}

Console.WriteLine(caesar);