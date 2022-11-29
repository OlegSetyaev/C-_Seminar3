// Программа, для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.


System.Console.WriteLine("Введите колличество кустов: ");
int coll = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (coll < 3)
{
    System.Console.WriteLine("Мало кустов!");
}
int[] array = new int[coll];
System.Console.WriteLine("Введите колличество ягод на кустах");
for (int i = 0; i < coll; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < coll; i++)
{
    if (i == 0)
    {
        if (array[i] + array[coll - 1] + array[i + 1] > max)
        {
            max = (array[i] + array[coll - 1] + array[i + 1]);
        }
    }
    else if (i == coll - 1)
    {
        if ((array[i] + array[i - 1] + array[0]) > max)
        {
            max = array[i] + array[i - 1] + array[0];
        }
    }
    else
    {
        if (array[i] + array[i - 1] + array[i + 1] > max)
        {
            max = array[i] + array[i - 1] + array[i + 1];
        }
    }
}
System.Console.WriteLine(max);

