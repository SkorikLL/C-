void RecursionNumberMultipleOfThree (int m, int n)
{
    if (m > n) return;
    if (m % 3 == 0 )
    {
        Console.Write($"{m} ");
    }
    m++;
    RecursionNumberMultipleOfThree (m, n);

}

int RecursionSum (int m, int n)
{
    if (m < n) return RecursionSum (n, m);
    else if (n != 0)
    {
        return m + RecursionSum (m, n - 1);
    }
    else 
        return 0;

}

int RecursionFunAkkerman (int m, int n)
{
        if (m == 0) {
            return n + 1;
        } 
        else if (n == 0 && m > 0) {
            return RecursionFunAkkerman(m - 1, 1);
        } 
        else {
            return RecursionFunAkkerman(m - 1, RecursionFunAkkerman(m, n - 1));
        }

}

//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
void Zadacha64 ()
{
    Console.WriteLine("Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.");
    Console.Write("Значения M = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Значения N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    RecursionNumberMultipleOfThree(m, n);

}

//Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
void Zadacha66 ()
{
    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.");
    Console.Write("Значения M = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Значения N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{RecursionSum(m, n)}");
}

// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
void Zadacha68 ()
{
    Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    Console.Write("Значения M = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Значения N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{RecursionFunAkkerman(m, n)}");

}

Console.Clear();


//Zadacha64 ();
Zadacha66 ();
//Zadacha68 ();