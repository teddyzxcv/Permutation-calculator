using System;

namespace Permutation_calculator
{
    class Program
    {
        public static bool CheckEqualPerm(int[] A, int[] B)
        {

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                    return false;
            }
            return true;
        }

        public static int[] PermutationCal(int[] A, int[] B)
        {
            int[] Output = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                Output[i] = B[A[i] - 1];
            }
            return Output;
        }
        static void writeArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void printArr(int[] a, int[] b, int n)
        {
            if (CheckEqualPerm(PermutationCal(b, a), PermutationCal(a, b)))
            {
                Console.Write("|");
                for (int i = 0; i < n; i++)
                    Console.Write((i + 1) + " ");
                Console.Write("|");
                Console.WriteLine();
                Console.Write("|");
                for (int i = 0; i < n; i++)
                    Console.Write(b[i] + " ");
                Console.Write("|");
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine();

            }


        }
        static void heapPermutation(int[] a, int[] b, int size, int n)
        {
            // if size becomes 1 then prints the obtained
            // permutation
            if (size == 1)
            {
                printArr(a, b, n);

            }

            for (int i = 0; i < size; i++)
            {
                heapPermutation(a, b, size - 1, n);

                // if size is odd, swap 0th i.e (first) and
                // (size-1)th i.e (last) element
                if (size % 2 == 1)
                {
                    int temp = b[0];
                    b[0] = b[size - 1];
                    b[size - 1] = temp;
                }

                // If size is even, swap ith and
                // (size-1)th i.e (last) element
                else
                {
                    int temp = b[i];
                    b[i] = b[size - 1];
                    b[size - 1] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] a = new int[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int[] b = new int[length];
            for (int i = 0; i < length; i++)
            {
                b[i] = i + 1;
                Console.WriteLine(b[i]);
            }
            heapPermutation(a, b, a.Length, a.Length);


        }
    }
}
