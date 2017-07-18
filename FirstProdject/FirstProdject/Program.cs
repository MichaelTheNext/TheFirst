using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProdject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            bool flag = true;
            int leng = 0;
            do
            {
                Console.WriteLine("Укажите длину массива");
                flag = true;

                try
                {
                    leng = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка при вводе числа");
                    flag = false;
                    Console.ReadLine();
                }
                Console.Clear();
            }
            while (flag == false);


            Console.WriteLine("Выберите метод сортировки массива:");
            Console.WriteLine("1. Bubble sort");
            Console.WriteLine("2. Selection sort");
            Console.WriteLine("3. Insertion sort");
            Console.WriteLine("4. Merge sort");
            int a = 0;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при вводе числа");
            }

            Console.Clear();
            switch (a)
            {
                case 1:
                    Bubble_sort(leng);
                    break;
                case 2:
                    Selection_sort(leng);
                    break;
                default:
                    Console.WriteLine("???");
                    break;
            }

            Console.ReadLine();
        }
        static void Bubble_sort(int leng)
        {
            Console.WriteLine("Вы выбрали: Bubble sort ");
            Console.WriteLine("Случайный массив из [" + leng + "] элементов:");
            int[] mas = new int[leng];
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(0, 10);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("");
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < (mas.Length - i - 1); j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        temp = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортирован:");
            for (int i = 0; i < mas.Length; i++)
            {

                Console.Write(mas[i] + " ");
            }
            Console.Read();
        }
        static void Selection_sort(int leng)
        {
            Console.WriteLine("Вы выбрали: Selection sort ");
            Console.WriteLine("Случайный массив из [" + leng + "] элементов:");
            int[] mas = new int[leng];
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(0, 10);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("");
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[min] > mas[j])
                    {
                        min = j;
                    }

                }
                int temp = mas[i];
                mas[i] = mas[min];
                mas[min] = temp;
            }
            Console.WriteLine("Отсортирован:");
            for (int i = 0; i < mas.Length; i++)
            {

                Console.Write(mas[i] + " ");
            }
            Console.Read();
        }
    }
}