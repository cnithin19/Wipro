using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Array
    {
        public void show(int[] a)
        {
            foreach (int i in a) {

                Console.WriteLine(i);
            }
        }
        //method overloading
        public void show(int[,] a)
        {
            Console.WriteLine("Array is : ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        public void show(int[][] a)
        {
            Console.WriteLine("Jagged ");
            for (int i = 0; i < a.Length; i++) { 
                for(int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]+ " ");
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 ,58};
            int[] array3 = new int[3] { 7, 8, 9 };
            Array obj = new Array();
            //2D  array
            Console.WriteLine("Enter row and column number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array4 = new int[n, m];
            Console.WriteLine("Enter {0} elements :", array4.Length);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array4[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            obj.show(array4);

            // jagged array

            int[][] jag= new int[2][];
            jag[0] = array1;
            jag[1] = array2;
            obj.show(jag);

        }
    }
}
