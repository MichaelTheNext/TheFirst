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
                case 3:
                    Insertion_sort(leng);
                    break;
                case 4:
                    Marge_sort(leng);
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
        static void Insertion_sort(int leng)
        {
            Console.WriteLine("Вы выбрали: Insertion sort ");
            Console.WriteLine("Случайный массив из [" + leng + "] элементов:");
            int[] mas = new int[leng];
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(0, 10);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("");
            int j,x,c=0;
            for (int i = 1; i < mas.Length; i++)
            {
                x = mas[i];
                j = i;
                while (j > 0)
                {
                    if (mas[j - 1] > x)
                    {
                        int temp = mas[j];
                        mas[j] = mas[j - 1];
                        mas[j - 1] = temp;
                        c++;

                    }
                    j--;
                   
                }
            }
            Console.WriteLine("Отсортирован:");
            for (int i = 0; i < mas.Length; i++)
            {

                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Число итераций:"+c);
            Console.Read();
        }
        static void Marge_sort(int leng)
        {
            Console.WriteLine("Вы выбрали: Marge sort ");
            Console.WriteLine("Случайный массив из [" + leng + "] элементов:");
            int[] mas = new int[leng];
            int c = 0;
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(0, 10);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("");

            c=c+sorting(mas, 0, mas.LongLength-1);

            Console.WriteLine("Отсортирован:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Число итераций:" + c);
            Console.Read();
        }
        static int sorting(int[] arr, long first, long last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp, c=0;
            long i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                    c++;
                }
            }
            if (j > first) sorting(arr, first, j);
            if (i < last) sorting(arr, i, last);
            return c;
        }

    }
}