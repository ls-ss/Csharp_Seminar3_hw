// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());

// Выделяем две последние цифры веденного числа и переставляем эти цифры местами
int m = n % 100;
int mm = (m % 10) * 10;
mm += m / 10;

Console.WriteLine((n / 1000 == mm) ? "Да" : "Нет");
