// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int [] IntNum(int n)
{
    int[] result = new int[n];
    int count = n;
    for (int i = 0; i < n; i++)
    {
        result[i] = count;
        count--;
    }
    return result;
}

Random rnd = new Random();
int n = rnd.Next(1,10);

System.Console.WriteLine(n);
System.Console.WriteLine();
System.Console.WriteLine(String.Join(",", IntNum(n)));

