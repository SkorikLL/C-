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
// Поиск второй цифры в числе который ввел пользователь.
    int result = number % 100 /10;
    Console.WriteLine($"Второрая цифра этого числа:{result}");
}

// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Zadacha13VarianString ()
{
    Console.WriteLine("Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number <= 99)
    {
       Console.WriteLine("третьей цифры нет");  
    }
    else
    {
        string str = number.ToString();
        Console.WriteLine(str[2]);  
    }
}
void Zadacha13Varian2 ()
{
    Console.WriteLine("Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number <= 99)
    {
       Console.WriteLine("третьей цифры нет");  
    }
    else
    {
        int numberLength = number;
        int Length = 0;
        // Узнаем длину числа
        while(numberLength > 0)
        {
            numberLength/= 10;
            Length++;
        }

        int j = 1;
        for (int i = 0; i < Length - 3; i++)
        {
            j = j * 10;
        }

        int result = (number / j)%10;
        Console.WriteLine($"Третья цифра заданного число: {result}");
    }
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Zadacha15 ()
{
    Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    Console.WriteLine("Введите день недели (1-7)");
    int number = Convert.ToInt32(Console.ReadLine());

    // Проверка пользователя, корректно он ввел данные или нет.
    while(number >= 8 ||  number <= 0)
    {
        if (number >= 8 ||  number <= 0)
        {
            Console.WriteLine("Повторите попытку");
            number = Convert.ToInt32(Console.ReadLine());
        }
    }

    if(number >= 6)
    {
        Console.WriteLine($"{number} - выходной");
    }
    else
    {
        Console.WriteLine($"{number} - рабочий день");
    }
}
Console.Clear();

//Zadacha10 ();
//Zadacha13VarianString ();
//Zadacha13Varian2 ();
Zadacha15 ();