using System;

namespace AbstractDataType
{
    class Searching
    {
        static void Main(string[] args)
        {
            //int[] arrLiniar = { 9, 6, 8, 3, 6, 11, 4, 6, 5 };
            //Console.WriteLine("arrLiniar");
            //Console.WriteLine(LiniarSearch(8, arrLiniar)); //index 2 
            //Console.WriteLine(LiniarSearch(1, arrLiniar)); // -1
            //int[] arrBinaryI = { 2, 3, 8, 15,5};
            //Console.WriteLine("arrBinaryI");
            //Console.WriteLine(BinarySearchIterative(2, arrBinaryI)); //0
            //Console.WriteLine(BinarySearchIterative(8, arrBinaryI)); //2
            //Console.WriteLine(BinarySearchIterative(15, arrBinaryI)); //3
            //Console.WriteLine(BinarySearchIterative(10, arrBinaryI)); //-1
            int[] arrBinaryR = { 2, 3, 8, 15,5 };
            Console.WriteLine("arrBinaryR");
            Console.WriteLine(BinarySearchIRecursiv(2, arrBinaryR, 0,5)); //0
            Console.WriteLine(BinarySearchIRecursiv(3, arrBinaryR, 0,5)); //2
            Console.WriteLine(BinarySearchIRecursiv(15, arrBinaryR, 0,5)); //3
            Console.WriteLine(BinarySearchIRecursiv(10, arrBinaryR, 0,5)); //-1
        }
        public static int LiniarSearch(int item, int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int BinarySearchIterative(int item, int[] arr)
        {
            int min = 0, max = arr.Length - 1;
            int mid ;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (arr[mid] < item)
                {
                    min= mid+1;
                }
                else if (arr[mid] > item)
                {
                    max= mid-1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
        public static int BinarySearchIRecursiv(int item, int[] arr ,int min, int max)
        {
            if (min + 1 < max)
            {
                int mid = (min + max) / 2;

                if (arr[mid] < item)
                {
                    min = mid;
                }
                else if (arr[mid] > item)
                {
                    max = mid;
                }
                else
                {
                    return mid;
                }
                return BinarySearchIRecursiv(item, arr, min, max);
            }
            else if (arr[min] == item)
            {
                return min;
            }
            else if(arr[max] == item)
            {
                return max;
            }
            return -1;
        }
    }
}
