//показывает в терминале все что входит в массив
void PrintArray (int[] nums)
{
    Console.Write("Данные которые ввел пользователь: ");
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}

//Рандом сл. чисел в массиве
void FillArray(int[] nums)
{
    int length = nums.Length;
    for (int i =0; i < length; i++)
    {
        Console.WriteLine($"Введите {i+1} число:");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void CounterPositiveNumber (int[] nums)
{
    int counter = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        if(nums[i] > 0)
        {
            counter++;
        }
    }
    Console.WriteLine($"Количество позитивных чисел который ввел пользователь:{counter}");

}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadacha41 ()
{
    Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.WriteLine("Сколько чисел вы планируете ввестить?");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[sizeArray];
    FillArray(array);
    PrintArray(array);
    CounterPositiveNumber(array);
}

// Задача 42: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadacha42 ()
{
    Console.WriteLine("Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");

    Console.Write("b1 = ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k1 = ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b2 = ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k2 = ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    double x = (b1-b2)/(k2-k1);
    double y = (k2*b1-k1*b2)/(k2-k1);
    Console.WriteLine($"Точка пересечения ({x}; {y})");
}


Console.Clear();

//Zadacha41 ();
Zadacha42 ();