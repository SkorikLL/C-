// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

Console.WriteLine("Введите первре число");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double numberB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третие число");
double numberC = Convert.ToDouble(Console.ReadLine());

double max = numberA;
if (max > numberB && max > numberC){
    Console.WriteLine($"Max = {max}");
}
else if (numberB > numberC){
    max = numberB;
    Console.WriteLine($"Max = {max}");
}
else{
    max = numberC;
    Console.WriteLine($"Max = {max}");
}
