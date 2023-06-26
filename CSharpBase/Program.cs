using System;

namespace CSharpBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[,] arr2 = { { 1, 2, 3 }, { 1, 2, 3 } };

            int[][] arr3 = { new int[] { 1, 2, 3, 4 }, new[] { 1, 2, 3 }, new int[2] { 1, 2 } };

            Console.WriteLine(arr);
            Console.WriteLine(arr2);
            Console.WriteLine(arr3);

            foreach (int a in arr)
            {
                if (a % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(a);
            }

            Console.WriteLine();

            foreach (int a in arr2)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();

            foreach (int[] a in arr3)
            {
                foreach (int a2 in a)
                {
                    Console.WriteLine(a2);

                }
                Console.WriteLine();
            }

            int DoOperation(int op, int a, int b)
            {
                return 1;

            }

            int result = DoOperation(4, 2, 3);
            Console.WriteLine(result);




            Console.WriteLine(Test.Abc);
            Console.WriteLine((int)Test.Abc);
        }

        enum Test
        {
            Abc = 1,
            Red,
        };

    }
}
