//показывает в терминале все что входит в массив
void PrintArray (int[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}

void PrintArrayDouble (double[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}

//Рандом сл. чисел в массиве
void fillArray(int[] nums, int minValue = 0, int maxValue = 11)
{
    Random rand = new Random();
    int length =nums.Length;
    for (int i =0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}

//Рандом сл. чисел в массиве Double
void fillArrayDouble(double[] nums, int minValue = 0, int maxValue = 11)
{
    Random rand = new Random();
    int length =nums.Length;
    for (int i =0; i < length; i++)
    {
        nums[i] = Math.Round(rand.NextDouble() * (maxValue - minValue) + minValue, 2);
    }
}

//Количество четных чисел в массиве
void findEvenElement(int[] nums)
{
    int length =nums.Length;
    int evenNumber = 0;

    for (int i =0 ; i < length; i++)
    {
        if(nums[i]%2 == 0)
        {
            evenNumber++;
        }
    }
    Console.WriteLine($"Количество четных чисел: {evenNumber}"); 
}

//Сумма элемеентов с нечетными индексами
void findSumElementOddIndex(int[] nums)
{
    int length =nums.Length;
    int sum = 0;

    for (int i =0 ; i < length; i++)
    {
        if(i%2 != 0)
        {
            sum = nums[i] + sum; 
        }
    }
    Console.WriteLine($"Сумма элемеентов с нечетными индексами: {sum}"); 
}

double findMaxElement (double[] nums)
{
    int length = nums.Length;
    double MaxElement = nums[0];

    for (int i = 0 ; i < length; i++)
    {
        if(MaxElement < nums [i])
        {
            MaxElement = nums [i]; 
        }
    }
    return MaxElement; 
    
}

double findMinElement (double[] nums)
{
    int length = nums.Length;
    double MinElement = nums[0];

    for (int i = 0 ; i < length; i++)
    {
        if(MinElement > nums [i])
        {
            MinElement = nums [i]; 
        }
    }
    return MinElement;  
    
}



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void Zadacha34 ()
{
    int size = 4;
    int[] array = new int[size];
    int minValueRandom = 100;
    int maxValueRandom = 1000;
    fillArray(array, minValue: minValueRandom, maxValue: maxValueRandom);
    Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");  
    PrintArray(array); 
    findEvenElement(array);
}

// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
void Zadacha36 ()
{
    int size = 4;
    int[] array = new int[size];
    int minValueRandom = -20;
    int maxValueRandom = 41;
    fillArray(array, minValue: minValueRandom, maxValue: maxValueRandom);
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.");  
    PrintArray(array);
    findSumElementOddIndex(array);
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void Zadacha38 ()
{
    int size = 4;
    double[] array = new double[size];
    int minValueRandom = -100;
    int maxValueRandom = 101;
    fillArrayDouble(array, minValue: minValueRandom, maxValue: maxValueRandom);
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");  
    PrintArrayDouble(array);
    double maxElement = findMaxElement(array);
    double minElement = findMinElement(array);
    Console.WriteLine($"Максимальный элемент массива:{maxElement}");
    Console.WriteLine($"Минимальный элемент массива:{minElement}");    
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива равняется {Math.Round(maxElement - minElement, 2)}");  
}


Console.Clear();


//Zadacha34 ();
//Zadacha36 ();
Zadacha38 ();
