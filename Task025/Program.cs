// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int GetExtentOfNumber (int numberA, int numberB)
{
  int result = 1;
  for (int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
  return result;
}
  Console.Write("Введите число A: ");
  int numberA = int.Parse(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = int.Parse(Console.ReadLine());

  int exponentiation = GetExtentOfNumber(numberA, numberB);
  Console.WriteLine($"Число А в степени В = " + exponentiation);