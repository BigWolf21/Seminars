using static Library;
/* Задача 2: Напишите программу,
которая на вход принимает два числа и 
выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

GetText("Введите два числа, для поиска из них большего и меньшего:");
int numberA = GetNumber("Первое число - ");
int numberB = GetNumber("Второе число - ");

if (numberA > numberB)
{
  GetText($"Число -{numberA}- больше, чем число -{numberB}-");
}
else
{
  GetText($"Число -{numberA}- меньше, чем число -{numberB}");
}
