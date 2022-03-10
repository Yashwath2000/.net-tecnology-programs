using System;

namespace diagonal
{
    class sumofdiagonals
    {
        static void Main(string[] args)
        {
            int maxrow, maxcol, sum = 0;
            int[,] Matrix;
            Console.WriteLine("\n-----sum of diagonals of matrix------\n");
            Console.Write("\n enter the number of rows:");
            maxrow = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nenter the number of coloums:");
            maxcol = Convert.ToInt32(Console.ReadLine());

            if (maxrow != maxcol)
            {
                Console.WriteLine("\n the dimensions entered are not of Square Matrix");
                Console.WriteLine("\nexiting the programs..");
                return;
            }
            Matrix = new int[maxrow, maxcol];
            for (int i = 0; i < maxrow; i++)
            {
                for (int j = 0; j < maxcol; j++)
                {
                    Console.Write("\nenter the ({0},{1}th element of the matrix: ", (i + 1), (j + 1));
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n the entered matrix is:");
            for (int i = 0; i < maxrow; i++)
            {
                for (int j = 0; j < maxcol; j++)
                {
                    Console.Write(" " + Matrix[i, j]);
                    if (i == j)
                    {
                        sum += Matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n the sum of diagonals is " + sum);
        }
    }
}
