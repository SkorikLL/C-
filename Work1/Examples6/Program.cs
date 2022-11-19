// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());


if ((numberA % 2) == 0 ){
    Console.WriteLine($"{numberA} да");
}
else {
    Console.WriteLine($"{numberA} нет");
}