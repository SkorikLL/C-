
void PrintArray(int[,] nums, string message = "Вывод массива")
{
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    Console.WriteLine(message);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{nums[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
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

void OrderArrayDiminution(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        for (int x = 0; x < columns - 1; x++)
        {
            if (array[i, x] < array[i, x + 1])
            {
            int temp = array[i, x + 1];
            array[i, x + 1] = array[i, x];
            array[i, x] = temp;
            }
        }
        }
    }
}

void SumMinRowArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int sum = 0;
    int min = 0;
    int index = 0;
    int minIndex = 0;

    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            min = min + array[i, j];
        }
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum = sum + array[i, j];
            index = i;
        }

        if(min > sum)
        {
            min = sum;
            minIndex = index;
        }

        Console.Write($"{i}\t{sum}");
        sum = 0;
        Console.WriteLine();
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов = {min}, индекс строки: {minIndex}");
}

void SumArray (int[,] firstArray, int[,] secondArray)
{
    int firstArrayRows = firstArray.GetLength(0);
    int firstArrayColumns = firstArray.GetLength(1);
    int secondArrayRows = secondArray.GetLength(0);
    int secondArrayColumns = secondArray.GetLength(1);
    int sum = 0;

    for (int i = 0; i < firstArrayRows; i++)
    {
        for (int j = 0; j < firstArrayColumns; j++)
        {
            sum = sum + firstArray[i, j];
        }
    }

    for (int i = 0; i < secondArrayRows; i++)
    {
        for (int j = 0; j < secondArrayColumns; j++)
        {
            sum = sum + secondArray[i, j];
        }
    }
    Console.WriteLine($"Сумма двух массивов = {sum}");

}

//Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54 ()
{
    Console.WriteLine("Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    int rowArray = 4;
    int columnArray = 4;
    int[,] array = new int[rowArray, columnArray];
    int minValueRandom = 1;
    int maxValueRandom = 25;
    FillArray(array, minValue: minValueRandom, maxValue: maxValueRandom);
    PrintArray(array);
    OrderArrayDiminution(array);
    PrintArray(array);
}



//Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Zadacha56 ()
{
    Console.WriteLine("Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    int rowArray = 4;
    int columnArray = 5;
    int[,] array = new int[rowArray, columnArray];
    int minValueRandom = 1;
    int maxValueRandom = 25;
    FillArray(array, minValue: minValueRandom, maxValue: maxValueRandom);
    PrintArray(array);
    SumMinRowArray(array);
}

//Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Zadacha61 ()
{
    Console.WriteLine("Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
    int rowArray = 2;
    int columnArray = 2;
    int[,] firstArray = new int[rowArray, columnArray];
    int[,] secondArray = new int[rowArray, columnArray];
    int minValueRandom = 1;
    int maxValueRandom = 25;
    FillArray(firstArray, minValue: minValueRandom, maxValue: maxValueRandom);
    PrintArray(firstArray);

    FillArray(secondArray, minValue: minValueRandom, maxValue: maxValueRandom);
    PrintArray(secondArray);

    SumArray(firstArray, secondArray);
}

Console.Clear();

//Zadacha54 ();
//Zadacha56 ();
Zadacha61 ();