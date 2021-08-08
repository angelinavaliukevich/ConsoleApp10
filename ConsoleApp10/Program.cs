using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args) 

        {
            int m=0 , A=0, numbers ;
            Console.Write("Столбцов: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Строк: ");
            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            Console.WriteLine();

            Console.WriteLine("Заполни матрицу");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" mas[" + i + "," + j + "]: " + mas[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 4; j++)
                   
                     Console.WriteLine(m); }
            {
                for (int i = 0; i > 3; i++) ;
                for (int j = 0; j > 4; j++) ;
                Console.WriteLine(A);

                static int[] MyReverse(int[] array)
                {
                    int buf = 0;
                    int n = array.Length;
                    int j = n - 1;

                    for (int k = 0; k < j; k++)
                    {
                        buf = array[k];
                        array[k] = array[j];
                        array[j] = buf;
                        j--;
                    }

                    return array;
                }
            }
        }
        }
    }


