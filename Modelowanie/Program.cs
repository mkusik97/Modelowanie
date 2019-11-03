using System;

namespace Modelowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid g = new Grid();

            string tmp;
            int select = 1;
            do
            {
                Console.WriteLine("Please select one method:\n 1.)Method30 2.)Method90 3.)Method120 4.)Method225\n 0.) Exit");
                tmp = Console.ReadLine();
                select = int.Parse(tmp);

                switch (select)
                {
                    case 1:
                        g.Method30(16, 31);
                        Console.WriteLine();
                        break;
                    case 2:
                        g.Method90(16, 31);
                        Console.WriteLine();
                        break;
                    case 3:
                        g.Method120(16, 31);
                        Console.WriteLine();
                        break;
                    case 4:
                        g.Method225(16, 31);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("You didn't select any method");
                        break;
                }

            } while (select != 0);
        }

        public class Grid
        {
            public static int value = 1;
            public int[,] Method90(int m, int n)
            {
                int[,] array = new int[m, n];
                array[0, n / 2] = value;

                for (int i = 0; i < m - 1; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0 && (array[i, n - 1] != array[i, j + 1]))
                            array[i + 1, j] = value;
                        else if (j == n - 1 && (array[i, j - 1] != array[i, 0]))
                            array[i + 1, j] = value;
                        else if (j != 0 && j != n - 1 && (array[i, j - 1] != array[i, j + 1]))
                            array[i + 1, j] = value;

                        Console.Write(array[i, j]);
                    }

                    Console.WriteLine();
                }

                return array;
            }
            public int[,] Method30(int m, int n)
            {
                int[,] array = new int[m, n];
                array[0, n / 2] = value;

                for (int i = 0; i < m - 1; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0 && ((array[i, n - 1] == 1 && array[i, j] == 0 && array[i, j + 1] == 0) || (array[i, n - 1] == 0 && array[i, j] == 1 && array[i, j + 1] == 1) || (array[i, n - 1] == 0 && array[i, j] == 1 && array[i, j + 1] == 0) || (array[i, n - 1] == 0 && array[i, j] == 0 && array[i, j + 1] == 1)))
                            array[i + 1, j] = value;
                        else if (j == n - 1 && ((array[i, j - 1] == 1 && array[i, j] == 0 && array[i, 0] == 0) || (array[i, j - 1] == 0 && array[i, j] == 1 && array[i, 0] == 1) || (array[i, j - 1] == 0 && array[i, j] == 1 && array[i, 0] == 0) || (array[i, j - 1] == 0 && array[i, j] == 0 && array[i, 0] == 1)))
                            array[i + 1, j] = value;
                        else if (j != 0 && j != n - 1 && ((array[i, j - 1] == 1 && array[i, j] == 0 && array[i, j + 1] == 0) || (array[i, j - 1] == 0 && array[i, j] == 1 && array[i, j + 1] == 1) || (array[i, j - 1] == 0 && array[i, j] == 1 && array[i, j + 1] == 0) || (array[i, j - 1] == 0 && array[i, j] == 0 && array[i, j + 1] == 1)))
                            array[i + 1, j] = value;

                        Console.Write(array[i, j]);
                    }

                    Console.WriteLine();
                }

                return array;
            }

            public int[,] Method120(int m, int n)
            {
                int[,] array = new int[m, n];
                array[0, n / 2] = value;

                for (int i = 0; i < m - 1; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0 && ((array[i, n - 1] == 1 && array[i, j] == 1 && array[i, j + 1] == 0) || (array[i, n - 1] == 1 && array[i, j] == 0 && array[i, j + 1] == 1) || (array[i, n - 1] == 1 && array[i, j] == 0 && array[i, j + 1] == 0) || (array[i, n - 1] == 0 && array[i, j] == 1 && array[i, j + 1] == 1)))
                            array[i + 1, j] = value;
                        else if (j == n - 1 && ((array[i, j - 1] == 1 && array[i, j] == 1 && array[i, 0] == 0) || (array[i, j - 1] == 1 && array[i, j] == 0 && array[i, 0] == 1) || (array[i, j - 1] == 1 && array[i, j] == 0 && array[i, 0] == 0) || (array[i, j - 1] == 0 && array[i, j] == 1 && array[i, 0] == 1)))
                            array[i + 1, j] = value;
                        else if (j != 0 && j != n - 1 && ((array[i, j - 1] == 1 && array[i, j] == 1 && array[i, j + 1] == 0) || (array[i, j - 1] == 1 && array[i, j] == 0 && array[i, j + 1] == 1) || (array[i, j - 1] == 1 && array[i, j] == 0 && array[i, j + 1] == 0) || (array[i, j - 1] == 0 && array[i, j] == 1 && array[i, j + 1] == 1)))
                            array[i + 1, j] = value;

                        Console.Write(array[i, j]);
                    }

                    Console.WriteLine();
                }

                return array;
            }

            public int[,] Method225(int m, int n)
            {
                int[,] array = new int[m, n];
                array[0, n / 2] = value;

                for (int i = 0; i < m - 1; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0 && ((array[i, n - 1] == 1 && ((array[i, j] + array[i, j + 1]) == 1)) || ((array[i, n - 1] + array[i, j] + array[i, j + 1]) == 0) || ((array[i, n - 1] + array[i, j] + array[i, j + 1]) == 3)))
                            array[i + 1, j] = value;
                        else if (j == n - 1 && ((array[i, j - 1] == 1 && ((array[i, j] + array[i, 0]) == 1)) || ((array[i, j - 1] + array[i, j] + array[i, 0]) == 0) || ((array[i, j - 1] + array[i, j] + array[i, 0]) == 3)))
                            array[i + 1, j] = value;
                        else if (j != 0 && j != n - 1 && ((array[i, j - 1] == 1 && ((array[i, j] + array[i, j + 1]) == 1)) || ((array[i, j - 1] + array[i, j] + array[i, j + 1]) == 0) || ((array[i, j - 1] + array[i, j] + array[i, j + 1]) == 3)))
                            array[i + 1, j] = value;

                        Console.Write(array[i, j]);
                    }

                    Console.WriteLine();
                }

                return array;
            }
        }
    }
}

