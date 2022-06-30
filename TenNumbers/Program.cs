using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TenNumbers
{
    /// <summary>
    /// Класс хранящий в себе данные
    /// </summary>
    class Keeper
    {
        /// <summary>
        /// Создание массива
        /// </summary>
        public int[] Array = new int[10];
        /// <summary>
        /// Метод инициализирующий массив нулями
        /// </summary>
        public Keeper()
        {
            for (int i = 0; i < 10; i++)
            {
                Array[i] = 0;
            }
        }
        /// <summary>
        /// Метод запрашивающий десять чисел
        /// </summary>
        public void RequestNUM()
        {
            Console.WriteLine("Введите десять целых чисел: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + ": ");
                Array[i] = int.Parse(Console.ReadLine());
            }
        }
        /// <summary>
        /// Метод выводящий массив на экран
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" {0}", Array[i]);
            }
            Console.Write("\n");
        }
        /// <summary>
        /// Метод сортирующий массив по убыванию
        /// </summary>
        public void Sort()
        {
            int tmp = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {               
                    if (Array[j] < Array[j + 1])
                    {
                        tmp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = tmp;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Keeper Mas = new Keeper();
            Mas.Print();
            Mas.RequestNUM();
            Console.WriteLine("Пользовательский массив: ");
            Mas.Print();
            Mas.Sort();
            Console.WriteLine("Отсортированный массив:");
            Mas.Print();
        }
    }
}
