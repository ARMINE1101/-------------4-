﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомндуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] GetArrayStringConsole (string inConsolSimvol)
{
    string[] arraySimvol = new string[inConsolSimvol.Length];
    arraySimvol = inConsolSimvol.Split(",");
    return arraySimvol;
}
string[] GetArrayThreeSimvol (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayThreeSimvol = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            arrayThreeSimvol[j] = simvol;
            j++;
        }
    }
    return arrayThreeSimvol;
}
void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
Console.Write("Введите набор символов через знак (,) - ");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
string inStringSimvol = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
string[] arraySimvol = GetArrayStringConsole(inStringSimvol);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
Console.WriteLine();
Console.Write("Введенные символы - ");
Print(arraySimvol);
Console.WriteLine();
Console.Write("Введенные символы длинной меньше либо равны 3 - ");
Print(GetArrayThreeSimvol(arraySimvol));
Console.WriteLine();

