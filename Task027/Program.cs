// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11 82 -> 10 9012 -> 12

Console.Clear();

int getUserValue(string message)
{
  Console.WriteLine(message);
  int userValue = int.Parse(Console.ReadLine());
  return userValue;
}

int GetSumOfDigits (int userValue)
{
   int sum = 0;
   while (userValue > 0)
   {
    sum = sum + userValue % 10;
    userValue = userValue / 10;
   }
   return sum;
}
int number = getUserValue ($"Введите число:");
int sum = GetSumOfDigits (number);
Console.WriteLine($"Сумма цифр в числе = " + sum);
