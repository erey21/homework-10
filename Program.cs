using System;
using System.Collections.Generic;

namespace homework_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 10");

            Console.WriteLine("Введите количество элементов в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите элементы цельночисленного массива: ");
            int[] array = new int[n];

            //создание списков чет\нечет
            List<int> chet = new List<int>();
            List<int> ne_chet = new List<int>();

            for (int i = 0; i < array.Length; i++) {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    chet.Add(array[i]);
                }
                else {
                    ne_chet.Add(array[i]);
                }
            }
            chet.Sort();
            ne_chet.Sort();
            Console.WriteLine("Чётный массив: ");
            foreach (int num in chet)
            {
                Console.WriteLine(num) ;
            }

            Console.WriteLine("Нечётный массив: ");
            foreach (int num in ne_chet) {
                Console.WriteLine(num);
            }


        }
    }
}
