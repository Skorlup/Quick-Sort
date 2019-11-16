using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var masiv = new int[100];
            masiv = Push(masiv);
            var left = 0;
            var right = masiv.Length - 1;

            Qsort(masiv, left, right);
            Write(masiv);

            Console.ReadKey();
        }
        static void Qsort(int[] masiv, int left, int right)
        {
             if (left >= right)
             {
                return;
             }

            var pivot = Sorting(masiv, left, right);
            Qsort(masiv, left, pivot - 1);
            Qsort(masiv, pivot + 1, right);

            return;
        }
        static int Sorting(int[] masiv, int left, int right)
        {
            var pointer = left;
            // Опорный элемент находится под right 
            for (int x = left; x <= right; x++)
            {
                if (masiv[x] < masiv[right])
                {
                    Swap(masiv, pointer, x);
                    pointer++;
                }
            }

            Swap(masiv, pointer, right);
            return pointer;
        }
        static int[] Push(int[] masiv)
        {
            var random = new Random();
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = random.Next(1, 100);
                if (masiv[i] < 10)
                {
                    Console.Write(" " + masiv[i] + " ");
                }
                else
                {
                    Console.Write(masiv[i] + " ");
                }

            }
            return masiv;
        }
        static int[] Swap(int[] masiv, int x, int y)
        {
            int t = masiv[x];
            masiv[x] = masiv[y];
            masiv[y] = t;
            return masiv;
        }
        static void Write(int[] masiv)
        {
            Console.WriteLine("\n");
            for (int v = 0; v < masiv.Length; v++)
            {
                if (masiv[v] < 10)
                {
                    Console.Write(" " + masiv[v] + " ");
                }
                else
                {
                    Console.Write(masiv[v] + " ");
                }
            }
        }
    }
}
