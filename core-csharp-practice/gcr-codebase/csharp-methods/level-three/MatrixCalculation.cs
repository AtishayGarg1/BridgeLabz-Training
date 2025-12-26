using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelthree
{
    internal class MatrixCalculation
    {
        static void Main(string[] args)
        {
            //Build two 3x3 matrices
            int[,] X = BuildMatrix(3, 3);
            int[,] Y = BuildMatrix(3, 3);

            Console.WriteLine("Matrix X");
            Show(X);

            Console.WriteLine("Matrix Y");
            Show(Y);

            Console.WriteLine("X + Y");
            Show(SumMatrix(X, Y));

            Console.WriteLine("X - Y");
            Show(DiffMatrix(X, Y));

            Console.WriteLine("X * Y");
            Show(ProductMatrix(X, Y));

            Console.WriteLine("Transpose of X");
            Show(FlipMatrix(X));

            Console.WriteLine("Determinant (3x3): " + Det3(X));

            double[,] inv = Inverse3(X);
            if(inv != null)
            {
                Console.WriteLine("Inverse of X");
                Show(inv);
            }
            else
            {
                Console.WriteLine("Inverse not possible");
            }
        }

        //Function to build a matrix with random integers
        static int[,] BuildMatrix(int r, int c)
        {
            int[,] mat = new int[r, c];
            Random rand = new Random();

            for(int i = 0; i < r; i++)
                for(int j = 0; j < c; j++)
                    mat[i, j] = rand.Next(1, 10);

            return mat;
        }

        //Function to add two matrices
        static int[,] SumMatrix(int[,] x, int[,] y)
        {
            int r = x.GetLength(0);
            int c = x.GetLength(1);
            int[,] res = new int[r, c];

            for(int i = 0; i < r; i++)
                for(int j = 0; j < c; j++)
                    res[i, j] = x[i, j] + y[i, j];

            return res;
        }

        //Function to subtract two matrices
        static int[,] DiffMatrix(int[,] x, int[,] y)
        {
            int r = x.GetLength(0);
            int c = x.GetLength(1);
            int[,] res = new int[r, c];

            for(int i = 0; i < r; i++)
                for(int j = 0; j < c; j++)
                    res[i, j] = x[i, j] - y[i, j];

            return res;
        }

        //Function to multiply two matrices
        static int[,] ProductMatrix(int[,] x, int[,] y)
        {
            int r = x.GetLength(0);
            int n = x.GetLength(1);
            int c = y.GetLength(1);

            int[,] res = new int[r, c];

            for(int i = 0; i < r; i++)
                for(int j = 0; j < c; j++)
                    for(int k = 0; k < n; k++)
                        res[i, j] += x[i, k] * y[k, j];

            return res;
        }

        //Function to transpose a matrix
        static int[,] FlipMatrix(int[,] m)
        {
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            int[,] t = new int[c, r];

            for(int i = 0; i < r; i++)
                for(int j = 0; j < c; j++)
                    t[j, i] = m[i, j];

            return t;
        }

        //Function to calculate determinant of 2x2 matrix
        static int Det2(int[,] m)
        {
            return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
        }

        //Function to calculate determinant of 3x3 matrix
        static int Det3(int[,] m)
        {
            return
                m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
                m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
                m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
        }

        //Function to calculate inverse of 2x2 matrix
        static double[,] Inverse2(int[,] m)
        {
            double d = Det2(m);
            if(d == 0) return null;

            double[,] inv = new double[2, 2];

            inv[0, 0] = m[1, 1] / d;
            inv[0, 1] = -m[0, 1] / d;
            inv[1, 0] = -m[1, 0] / d;
            inv[1, 1] = m[0, 0] / d;

            return inv;
        }

        //Function to calculate inverse of 3x3 matrix
        static double[,] Inverse3(int[,] m)
        {
            double d = Det3(m);
            if(d == 0) return null;

            double[,] inv = new double[3, 3];

            inv[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / d;
            inv[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) / d;
            inv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / d;

            inv[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) / d;
            inv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / d;
            inv[1, 2] = (m[0, 2] * m[1, 0] - m[0, 0] * m[1, 2]) / d;

            inv[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / d;
            inv[2, 1] = (m[0, 1] * m[2, 0] - m[0, 0] * m[2, 1]) / d;
            inv[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) / d;

            return inv;
        }

        //Function to display matrix
        static void Show(int[,] m)
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //Function to display matrix
        static void Show(double[,] m)
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                    Console.Write(Math.Round(m[i, j], 2) + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
