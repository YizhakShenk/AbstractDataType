/*
    Author: Yizhek Shenk
    Creation date: 20.12.21
    Desctiption: Sorting 
 */
using System;

namespace AbstractDataType
{
    class Sorting
    {
        static void Main(string[] args)
        {
            int[] arrB = { 8, 99, 37, 3, 2, 78, 54, 5 };
            Console.WriteLine("before " + "[{0}]", string.Join(",", arrB));
            BubbleSort(arrB);
            Console.WriteLine("after " + "[{0}]", string.Join(",", arrB));

            int[] arrI = { 8, 99, 37, 3, 2, 78, 54, 5 };
            Console.WriteLine("before " + "[{0}]", string.Join(",", arrI));
            InsertionSort(arrI);
            Console.WriteLine("after " + "[{0}]", string.Join(",", arrI));
        }
        public static void BubbleSort(int[] arr)
        {
            int len = arr.Length - 1;
            bool ifSortd = true;
            for (int i = 0; i < len && ifSortd; ++i)
            {
                ifSortd = false;
                for (int j = 0; j < len - i; ++j)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                        ifSortd = true;
                    }
                }
            }
        }
        
        public static void InsertionSort(int[] arr)
        {
            int i, j, tmp;
            for (i = 1; i < arr.Length; ++i)
            {
                tmp = arr[i];
                for (j = i - 1; j >= 0 && arr[j] > tmp; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = tmp;
            }
        }
    }
}
