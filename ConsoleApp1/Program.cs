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

            // Вводится строка, состоящая из слов разделенных точками. Длина строки может быть разной. Сформировать и вывести подстроку, расположенную между второй и пятой точками исходной строки. Если в строке менее пяти точек, то вывести всю исходную строку.
            Console.WriteLine("Введите строку, состоящую из слов, разделенных точками:");
            Console.WriteLine("Введите строку, состоящую из слов, разделенных точками:");
            string inputString = Console.ReadLine();

            string[] segments = inputString.Split('.');

            if (segments.Length >= 5)
            {
                string result = string.Join(".", segments, 2, 3);
                Console.WriteLine("Результат: " + result);
            }
            else
            {
                Console.WriteLine("Результат: " + inputString);
            }
            Console.ReadKey();

            // Вводится строка, изображающая двоичную запись целого положительного числа. Вывести строку, изображающую десятичную запись этого же числа.
            Console.WriteLine("Введите строку, изображающую двоичную запись целого положительного числа:");
            string binaryString = Console.ReadLine();

            int decimalNumber = Convert.ToInt32(binaryString, 2);

            Console.WriteLine("Десятичная запись числа: " + decimalNumber);

            Console.ReadKey();

            // Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Определить и вывести на экран самое длинное слово, а так же размер этого слова.
            Console.WriteLine("Введите строку, состоящую из слов, разделенных подчеркиваниями:");
            string inputtString = Console.ReadLine();

            string[] words = inputtString.Split('_');

            string longestWord = "";
            int maxLength = 0;

            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    longestWord = word;
                }
            }

            if (!string.IsNullOrEmpty(longestWord))
            {
                Console.WriteLine("Самое длинное слово: " + longestWord);
                Console.WriteLine("Длина самого длинного слова: " + maxLength);
            }
            else
            {
                Console.WriteLine("Строка не содержит слов, разделенных подчеркиваниями.");
            }
            Console.ReadKey();
        }
    }
}

