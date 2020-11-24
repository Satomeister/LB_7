using System;
using System.Collections.Generic;
using System.Text;

namespace LB_7_2
{
    class MyMatrix
    {
        private double[,] data;

        public int M { get; set; }
        public int N { get; set; }

        public MyMatrix(int m, int n)
        {
            M = m;
            N = n;
            data = new double[m, n];
        }

        public void getMatrix()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(String.Format("{0,3}", data[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
