// Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
while(number > 0){
    number--;
    if (((number % 2) == 0 ))
    Console.Write($"{number}, ");
}
