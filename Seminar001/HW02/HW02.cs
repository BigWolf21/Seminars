using static Library;
/* Задача 4: Напишите программу, 
которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

// GetText("Введите три любых числа, для поиска среди них максимального");
int numberA = GetNumber("Первое число - ");
int numberB = GetNumber("Второе число - ");
int numberC = GetNumber("Третье число - ");

int max = Maximum(numberA, numberB);
int max2 = Maximum(max, numberC); 
GetText($"max = {max2}");

About();