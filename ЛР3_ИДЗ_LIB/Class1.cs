using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_IDZ_LIB
{
    public class Matrix
    {
        private int m;
        private int n;
        public int[,] numbers;
        public Matrix(int pM, int pN)
        {
            m = pM;
            n = pN;
            numbers = new int[n,m];
            Console.WriteLine("Введите значение матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("[" + (i+1) + "," + (j+1) + "]: ");
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    Console.Write(matrix.numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void GetStrMin(Matrix matrix)
        {
            for (int i = 0; i < matrix.m; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < matrix.n; j++)
                {
                    if (matrix.numbers[i, j] < min) min=matrix.numbers[i, j];
                }
                Console.Write(min + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void PrintResultMatrix(Matrix matrix)
        {
            int min = int.MaxValue;
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if (matrix.numbers[i, j] < min) min= matrix.numbers[i, j];
                }
            }

            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if(matrix.numbers[i, j] % 3 == 0)
                    {
                        Console.Write(min + " ");
                    }
                    else Console.Write(matrix.numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
