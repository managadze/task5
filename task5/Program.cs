using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            double[,] arr = new double[8, 8];
            double[] elements = new double[65];
            int x;
            Console.WriteLine(@"Как вы хотите заполнить массив?
1) Автоматически
2) Ввести вручную");

            int what = 0;
            bool ok = true;
            do
            {
                try
                {
                    what = Int32.Parse(Console.ReadLine());
                    ok = true;
                    if ((what < 1) || (what > 2)) ok = false;
                }
                catch
                {
                    ok = false;
                    Console.WriteLine("Ошибка, введите целое число");
                }
            } while (!ok);
            switch (what)
            {
                case 1:
                    {
                        for (int i = 1; i < elements.Length; i++)
                        {
                            elements[i] = i;
                        }
                    }
                    break;
                case 2:
                    {
                        for (int i = 1; i < elements.Length; i++)
                        {
                            Console.WriteLine($"Введите {i}-ый элемент");
                            do
                            {
                                try
                                {
                                    elements[i] = Double.Parse(Console.ReadLine());
                                    ok = true;
                                    if ((what < 1) || (what > 2))
                                    {
                                        ok = false;
                                        Console.WriteLine("Ошибка, такого действия нет");
                                    }
                                }
                                catch
                                {
                                    ok = false;
                                    Console.WriteLine("Ошибка, введите действительное число");
                                }
                            } while (!ok);
                        }
                    }
                    break;
            }
            Console.WriteLine();

            int count = 1;
            for (int i = 0; i < 8; i++)
            {
                x = i;
                if (i % 2 == 1)
                {
                    for (int j = 0; j <= i; j++, x--)
                    {
                        arr[j, x] = elements[count++];
                        arr[7 - j, 7 - x] = elements[65 - count + 1];
                    }
                }
                else
                {
                    for (int j = 0; j <= i; j++, x--)
                    {
                        arr[x, j] = elements[count++];
                        arr[7 - x, 7 - j] = elements[65 - count + 1];
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(String.Format("{0,5:0}", arr[i, j]));
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
