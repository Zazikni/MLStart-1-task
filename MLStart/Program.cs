using System;
using System.Linq;


namespace MLStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] k1 = GenerateArrayInt(5, 19);
            WriteArrayInt(k1);
            Console.WriteLine("------------------");
            double[] x = GenerateArrayRandomDouble(-12.0, 15.0, 13);
            WriteArrayDouble(x);
            Console.WriteLine("------------------");
            double[,] k2 = GenerateMatrix(k1, x);
            Console.WriteLine("------------------");



        }

        private static double[,] GenerateMatrix(int[] k1, double[] x)
        {
            double[,] array = new double[k1.Length, x.Length];
            for (int i = 0; i < k1.Length; i++)
            {
                int k_elem = k1[i];

                for (int j = 0;j<x.Length;j++)
                {
                    double x_elem = x[j];
                    int[] elements = new int[] { 5, 7, 11, 15 };


                    if (k_elem == 9)
                    {
                        array[i, j] = Math.Sin(Math.Sin(Math.Pow((x_elem / (x_elem + 0.5)), x_elem)));
                    }
                    else if (elements.Contains(k_elem))
                    {
                        //array[i, j] = Math.Pow((0.5/(Math.Tan(2*x_elem) + (2/3))), Math.Cbrt(Math.Cbrt(x_elem)));
                    }
                    else
                    {
                        array[i, j] = Math.Tan(   Math.Pow(    ((Math.Pow(Math.E, (1-x_elem)/Math.PI)  / 3)  / 4)    , 3)   );
                    }





                }
                Console.Write($"\n");

            }

            return array;
        }

        static int CountOddInRange(int start, int end)
        {
            if (start % 2 != 0)
            {
                start -= 1;
            }
            if (end % 2 != 0)
            {
                end += 1;
            }
            return (end - start) / 2;
        }

        static double[] GenerateArrayRandomDouble(double start, double end, int size)
        {
            double[] array = new double[size];
            var randomizer = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (randomizer.NextDouble() * (Math.Max(start, end) - Math.Min(start, end))) + Math.Min(start, end);
            }
            return array;
        }

        static int[] GenerateArrayInt(int start, int end)
        {
            int[] array = new int[CountOddInRange(start, end)];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[0] == 0)
                {
                    array[i] = start % 2 != 0 ? start : start + 1;
                }
                else
                {
                    array[i] = array[i - 1] + 2;
                }

            }

            return array;
        }
        static void WriteArrayInt(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
        }
        static void WriteArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
        }
    }
}
    