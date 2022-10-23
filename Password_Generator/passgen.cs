// генератор паролей

char ch;                     // символ
int numChar;                 // Номер символа в таблице ASCII
int lenPass = 10;            // длина пароля задаеться пользователем
string pass = string.Empty;  // пустая строка

for (int i = 0; i < lenPass; i++)
{
  numChar = new Random().Next(33, 127);
  ch = Convert.ToChar(numChar);
  pass = pass + ch;
}
Console.WriteLine($"Длина пароля = {lenPass}");
Console.WriteLine($"Генерация = {pass}");

