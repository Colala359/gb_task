// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

using System.Runtime.InteropServices;

string[] printArr(string[] str)
{
    Console.WriteLine(string.Join(", ", str));
    return str;
}
string[] CreateArray(int n)
{
    string[] array = new string[n];
    Console.WriteLine($"Введите {n} строк через Enter:");
    for (int i = 0; i < n; i++)
    {
        array[i] = Console.ReadLine()!;
    }
    return array;
}

int CountString(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3) count++;
    }
    Console.WriteLine($"Количество строк с <= 3 символа: {count}");
    return count;
}

string[] ResultArray(string[] str, int count)
{
    string[] resArr = new string[count];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3) resArr[j] = str[i];
    }
    return resArr;
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(n);
int h = CountString(array);
string[] array2 = new string[h];
array2 = ResultArray(array, h);
Console.WriteLine("Массив до:");
printArr(array);
Console.WriteLine("Массив после:");
printArr(array2);

