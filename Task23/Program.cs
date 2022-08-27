// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Значения кубов чисел от 1 до {n} равны:");
if(n >= 0){
    for(int i = 1; i <= n; i++){
    Console.Write($"{Math.Pow(i, 3)}, ");
    }
}
else{   // Для отрицательного числа n 
    for(int i = 1; i >= n; i--){
    Console.Write($"{Math.Pow(i, 3)}, ");
    }
}
Console.WriteLine("");