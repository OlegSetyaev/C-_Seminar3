// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.



Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
int a = 0;
for (int i = 0; i < num.Length / 2; i++)
{
    if (num[i] != num[num.Length - 1 - i])
    {
        System.Console.WriteLine(num + " -> НЕТ");
        break;
    }
    a = 1;
}
if (a == 1)
{
    System.Console.WriteLine(num + " -> ДА");
}