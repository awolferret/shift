using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine("на сколько сдаинуть массив?");
            int shiftNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оригинальный массив");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            for (int i = 0; i < shiftNumber; ++i)
            {
                int bufferNumber = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    array[j - 1] = array[j];
                }
                array[array.Length - 1] = bufferNumber;
            }
            Console.WriteLine("\nНовый массив");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}