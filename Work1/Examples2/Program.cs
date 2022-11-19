// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Введите первре число");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double numberB = Convert.ToDouble(Console.ReadLine());

if (numberA > numberB ){
    Console.WriteLine($"Max = {numberA}, Min = {numberB} ");
}
else if (numberB > numberA ){
    Console.WriteLine($"Max = {numberB}, Min = {numberA}");
}
else {
    Console.WriteLine($"Вы ввели одинаковые числа");
}
