﻿// 1)Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] => 2
/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива:  ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("массив: ");
        PrintArray(numbers);
        int count = 0;

        for (int z = 0; z < numbers.Length; z++)
            if (numbers[z] % 2 == 0)
                count++;

        Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

        void FillArrayRandomNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100, 1000);
            }
        }
        void PrintArray(int[] numbers)
        {
            Console.Write("[ ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}*/
//2 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Введите размер массива  ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("массив: ");
        PrintArray(numbers);
        int sum = 0;

        for (int z = 1; z < numbers.Length; z += 2)
            sum = sum + numbers[z];

        Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

        void FillArrayRandomNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(1, 10);
            }
        }
        void PrintArray(int[] numbers)
        {
            Console.Write("[ ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}*/
//3)Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива  ");
        int size = Convert.ToInt32(Console.ReadLine());
        double[] numbers = new double[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("массив: ");
        PrintArray(numbers);
        double min = int.MaxValue;
        double max = int.MinValue;

        for (int z = 0; z < numbers.Length; z++)
        {
            if (numbers[z] > max)
            {
                max = numbers[z];
            }
            if (numbers[z] < min)
            {
                min = numbers[z];
            }
        }

        Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
        Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

        void FillArrayRandomNumbers(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
            }
        }
        void PrintArray(double[] numbers)
        {
            Console.Write("[ ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}*/