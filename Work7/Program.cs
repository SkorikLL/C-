void PrintArrayDouble (double[,] nums)
{
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{nums[i, j]} ");
        }
        
        Console.WriteLine();
    }
}

void PrintArray(int[,] nums)
{
    Console.WriteLine("Массив:");
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{nums[i, j]} ");
        }
        
        Console.WriteLine();
    }
}

//Рандом сл. чисел в массиве Double
void FillArrayDouble(double[,] nums, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            nums[i, j] = Math.Round(rand.NextDouble() * (maxValue - minValue) + minValue, 1);
        }
    }
}

//Рандом сл. чисел в массиве 
void FillArray(int[,] nums, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            nums[i, j] = rand.Next(minValue, maxValue);
        }
    }
}

void ArithmeticAverageEachColums(int[,] nums)
{
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    double sum = 0;
    double ArithmeticAverage = 0;
    double couner = 0;
    Console.WriteLine("Cреднее арифметическое элементов в каждом столбце: ");
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sum=sum+nums[i, j];
            couner++;
        }
        Console.Write($"{ArithmeticAverage = Math.Round(sum/couner,2)} ");
        sum = 0;
        couner = 0;
    }

}


// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
void Zadacha47 ()
{
    Console.WriteLine("Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.");
    Console.WriteLine("Введите размер массива m (строка): ");
    int rowArray = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите размер массива n (столбец): ");
    int columnArray = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rowArray, columnArray];
    int minValueRandom = -25;
    int maxValueRandom = 25;
    FillArrayDouble(array, minValue: minValueRandom, maxValue: maxValueRandom);
    PrintArrayDouble(array);
}

// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void Zadacha50 ()
{
    Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    int rowArray = 4;
    int columnArray = 4;
    int[,] array = new int[rowArray, columnArray];
    int minValueRandom = -10;
    int maxValueRandom = 25;
    FillArray(array, minValue: minValueRandom, maxValue: maxValueRandom);
    PrintArray(array);
    Console.WriteLine("Номер строки: ");
    int rowIndex = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Номер столбеца: ");
    int columnIndex = Convert.ToInt32(Console.ReadLine());

    if(rowIndex > array.GetLength(0) || columnIndex > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет!");
    }
    else
    {
        Console.WriteLine($"Значение матрицы {rowIndex}, {columnIndex} = {array[rowIndex, columnIndex]}");
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Zadacha52 ()
{
    Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    int rowArray = 4;
    int columnArray = 4;
    int[,] array = new int[rowArray, columnArray];
    int minValueRandom = 1;
    int maxValueRandom = 25;
    FillArray(array, minValue: minValueRandom, maxValue: maxValueRandom);
    PrintArray(array);
    ArithmeticAverageEachColums(array);

}

Console.Clear();

//Zadacha47 ();
//Zadacha50 ();
Zadacha52 ();