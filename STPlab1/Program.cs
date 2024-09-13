using System;
using System.Runtime.CompilerServices;

namespace STPlab1
{
    public class Program
    {
        public class invalid_argument: ArgumentException
        {
            public invalid_argument(string mes)
            {
                Console.WriteLine(mes);
            }
        }
        static int[] GenerateArray(int length)
        {
            int Min = -20;
            int Max = 100;

            int[] arr = new int[length];
            Random randNum = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }
            return arr;
        }
        static void Main(string[] args)
        {

        }
        public static int FindIndex(int[] vec, int[] seq)
        {
            if (seq.Length > vec.Length)
            {
                throw new invalid_argument("seq cannot be longer than vec");
            }
            for (int i = 0; i <= vec.Length - seq.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < seq.Length; j++)
                {
                    if (vec[i + j] != seq[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    return i;
                }
            }
            throw new invalid_argument("seq is not found in vec");
        }
        public static double[] ShiftLeft(double[] arr, int shift)
        {
            if (shift < 0) throw new invalid_argument("shift cannot be < 0");
            int n = arr.Length;
            shift = shift % n;

            double[] temp = new double[shift];
            Array.Copy(arr, temp, shift);

            for (int i = 0; i < n - shift; i++)
            {
                arr[i] = arr[i + shift];
            }
            for (int i = 0; i < shift; i++)
            {
                arr[n - shift + i] = temp[i];
            }
            return arr;
        }
        public static int[] SumArray(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            {
                throw new invalid_argument(String.Format("Different lengths = {0} b.Length = {1}", a.Length, b.Length));
            } 

            int[] sums = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                sums[i] = a[i] + b[i];
            }
            return sums;
        }
    }
}
