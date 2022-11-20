// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Zadacha10 ()
{
    Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());

// Проверка пользователя, корректно он ввел данные или нет.
    while(number >= 1000 ||  number <= 99)
    {
        if (number >= 1000 ||  number <= 99)
        {
            Console.WriteLine("Вы ввели не трёхзначое число, плвторите попытку");
            number = Convert.ToInt32(Console.ReadLine());
        }
    }

    int result = number % 100 /10;
    Console.WriteLine($"Второрая цифра этого числа:{result}");

}

Console.Clear();

//Zadacha10 ();

