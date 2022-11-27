// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void Zadacha25 ()
{
    Random rand = new Random ();
    int randomNumber = rand.Next (1, 10);
    int randomPower = rand.Next (1, 5);
    Console.WriteLine("Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.");
   //Без цикла double result = Math.Pow (randomNumber, randomPower);
   int result = randomNumber;
    for (int i = 1; randomPower > i; i++)
    {
        result=randomNumber*result;
    }
    Console.WriteLine($" {randomNumber}^{randomPower} = {result}");
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Zadacha27 ()
{
    Random rand = new Random ();
    int randomNumber = rand.Next (1, 1000);
    Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

    int result = 0;
    int remainder = 0;
    int number = randomNumber;
    while (number > 0)
    {
        remainder = number % 10;
        result = result + remainder; 
        number = number / 10;
    }
    Console.WriteLine($" Введенное число {randomNumber}, сумма цифр в числе: {result}");

}

void PrintArray (int[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void Zadacha29 ()
{
    int size = 8;
    int[] array = new int[size];
    int index = 0;

    while(index < array.Length)
    {
        array[index] = new Random().Next(-20, 21);
        index++;
    }
    Console.WriteLine("Массив до сортировки");  
    PrintArray(array);

    int min= array[0];
    int temp;
    int pozitivArrI;
    int pozitivArrJ;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < 0)
            {
                pozitivArrI = array[i] * -1;
            }
            else
            {
                pozitivArrI = array[i];
            }
            
            if (array[j] < 0)
            {
                pozitivArrJ = array[j] * -1;
            }
            else
            {
                pozitivArrJ = array[j];
            }

            if (pozitivArrI > pozitivArrJ)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    Console.WriteLine("Массив после сортировки");  
    PrintArray(array);

 
}

Console.Clear();

//Zadacha25 ();
//Zadacha27 ();
Zadacha29 ();

