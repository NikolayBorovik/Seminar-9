// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Random rnd = new Random();
int n = rnd.Next(1, 20);
int m = rnd.Next(1, 10);
System.Console.WriteLine($"{n},{m}");

int SumOfIntNum (int n, int m)
{
    int count = 0;
    for (int i = m; i <= n; i++)
    {
        count += i;
    }
    return count;
}

int result = SumOfIntNum(n, m);

System.Console.WriteLine (result);
