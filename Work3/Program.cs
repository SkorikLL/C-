// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Zadacha19 ()
{
    Console.WriteLine("Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());

// Проверка пользователя, корректно он ввел данные или нет.
    while(number >= 100000 ||  number <= 9999)
    {
        if (number >= 1000000 ||  number <= 9999)
        {
            Console.WriteLine("Вы ввели не пятизначное число, плвторите попытку");
            number = Convert.ToInt32(Console.ReadLine());
        }
    }

    string str = number.ToString();

    if(str [0] == str [4] && str [1] == str [3])
    {
        Console.WriteLine($"Является палиндромом - {number}");
    }
     else
     {
        Console.WriteLine($"Не является палиндромом - {number}");
     }

}

 // Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Zadacha21 ()
{
    Console.WriteLine("Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Random rand = new Random ();
    int x1 = rand.Next (-10, 11);
    int y1 = rand.Next (-10, 11);
    int z1 = rand.Next (-10, 11);
    Console.WriteLine($"Корлинаты точки А ({x1}, {y1}, {z1})");
    int x2 = rand.Next (-10, 11);
    int y2 = rand.Next (-10, 11);
    int z2 = rand.Next (-10, 11);   
    Console.WriteLine($"Корлинаты точки А ({x2}, {y2}, {z2})");

    double distance = 0;
    //Math.Sqrt(x) корень числа х
    //Math.Pow(x, 2) х^2
    distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    //Math.Round(distance, 2) округляет число до 2 знаком после запятой.
    Console.WriteLine($"Расточние между двумя точек в 3D пространстве равно {Math.Round(distance, 2)}");
}

 // Задача 22 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Zadacha22 ()
{
    Console.WriteLine("Задача 21 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    Console.WriteLine("Введите число (N)");
    int N = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <=N; i++)
    {
        Console.WriteLine(i + "\t" + Math.Pow(i, 3));
    }
}

Console.Clear();

//Zadacha19 ();
//Zadacha21 ();
Zadacha22 ();

