// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// Method
// int CountPositiveNums(string[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         int value = int.Parse(arr[i]);
//         if (value > 0) count++;
//     }
//     return count;
// }

// Code
// Console.WriteLine("Введите несколько целых чисел через пробел");
// string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine($"Количество введенных положительных чисел: {CountPositiveNums(array)}");

//  Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).



// Method
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}

// Code
Console.Write("Введите размер массива: ");
int a = int.Parse(Console.ReadLine()!);
var num = GetArray(a);
Console.WriteLine($"[{String.Join(", ", num)}]");
Array.Sort(num);
foreach (var i in num)
    Console.Write($"{i} ");
    