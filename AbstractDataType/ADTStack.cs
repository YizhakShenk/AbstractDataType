/*
    Author: Yizhek Shenk
    Creation date: 26.12.21
    Desctiption: Stack 
 */
using System;

namespace AbstractDataType
{
    public class ADTStack<T>
    {
        private T[] _arr;
        private int _index;
        private const int _GrowsOnDemandFactor = 2;
        public ADTStack(int size)
        {
            if (size <= 0)
            {
                 throw new ApplicationException("The size should be greater than 0");
            }
            _arr = new T[size];
            _index = -1;

        }
        public void Push(T item)
        {
            if (_index == _arr.Length-1)
            {
                T[] tmpStack = new T[_arr.Length*_GrowsOnDemandFactor];
                Array.Copy(_arr, 0, tmpStack, 0, _index+1);
                _arr = tmpStack;
            }
            _index++;
            _arr[_index] = item;
        }
        public T Pop()
        {
            if (_index == -1)
            {
                throw new ApplicationException("the stack is emptty (Pop)");
            }
            return _arr[_index--];

        }
        public T Top()
        {
            if (_index == -1)
            {
                throw new ApplicationException("the stack is emptty (Top)");
            }

            return _arr[_index];
        }
        public bool IsEmpty()
        {
            return _index == -1 ;
        }
        public void Print()
        {
            if (_index < 0)
            {
                throw new ApplicationException("the list is empty (Print)");
            }
            Console.WriteLine("printing the stack");
            //if (_arr[i] != null){Console.WriteLine(string.Join(" ,", _arr));}
            for (int i = 0; i <= _index; ++i)
            {
                if (_arr[i] != null) { Console.Write(_arr[i] + " ,"); }
            }
            Console.WriteLine();
        }
    }
}
