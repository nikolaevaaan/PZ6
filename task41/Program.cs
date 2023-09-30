// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


using System;

namespace task41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел: ");
            int count = int.Parse(Console.ReadLine());
            int[] mass = new int[count];
            Array(mass);
        }    

        static void Array(int[] arr)
        {
            int sum = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    arr[i] = number;

                    if (arr[i] != 0 && arr[i] > 0)
                    {
                        sum++;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректное число. Повторите попытку.");
                    i--; 
                }
            }

            Console.WriteLine("Количество положительных чисел: " + sum);
        }
    }
}
