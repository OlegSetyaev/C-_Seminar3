// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
for (i = 1; i < n; i++)
{
    int N = i * i * i;
    System.Console.Write($"{N}, ");
}
System.Console.WriteLine($"{n * n * n}");