using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Дан целочисленный массив, состоящий из N элементов (N > 0). Преобразовать массив, прибавив к четным числам первый элемент. Первый и последний элементы массива не изменять. Вывести новый полученный массив.
        m1:
            try {
                Console.WriteLine("Введите количество элементов в массиве");
                int n = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                Console.WriteLine("Введите элементы массива :");
                if (n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    } 
                    for (int i = 1;i < n; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            array[i] += array[0];
                        }
                    }
                    Console.WriteLine("Новый массив : ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                else { Console.WriteLine("Введите число больше 0"); }
            }
            catch (FormatException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Введите число!");
                goto m1;
                }
            Console.ReadKey();
        // Дан целочисленный массив, состоящий из N элементов (N > 0). Если в наборе имеются только положительные четные числа, то вывести True; в противном случае вывести False.
        m2:
            try {
                Console.WriteLine("Введите количество элементов в массиве :");
                int N = int.Parse(Console.ReadLine());
                bool flag = true;
                int[] array = new int[N];
                Console.WriteLine("Введите элементы массива :");
                if(N > 0)
                {
                    for(int i = 0;i < N; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    for(int i = 0; i < N; i++)
                    {
                        if (array[i] > 0 && array[i] % 2 == 0)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    Console.WriteLine(flag);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Введите число!");
                goto m2;
            }
            Console.ReadKey();
        }

        }
    }

