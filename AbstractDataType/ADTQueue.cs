/*
    Author: Yizhek Shenk
    Creation date: 02.01.21
    Desctiption: Queue
 */
using System;

namespace AbstractDataType
{
    class ADTQueue<T>
    {
        private T[] _arr;
        private int _head;
        private int _tail;
        private int size;
        public ADTQueue(int length)
        {
            if (length <= 0)
            {
                throw new ApplicationException("The length should be greater than 0");
            }
            _arr = new T[length];
            _head = 0;
            _tail = length -1;
            size = length;
    }
        public void Enqueue(T item)
        {
            if (_head == _tail + 1)
            //if (_tail == size - 1)
            {
                throw new ApplicationException("the queue is file (Enqueue)");
            }
            else
            {
                _arr[++_head] = item;
                
            }
        }
        public T Dequeue()
        {
            if(_head == _tail + 1)
            {
                throw new ApplicationException("the queue is empty (Dequeue)");
            }
            else
            {
                return _arr[_head++];
            }
        }
        public bool IsEmpty()
        {
            return (_tail == size - 1);
        }
        public void Print()
        {
            if(_head == _tail + 1)
            {
                throw new ApplicationException("the queue is empty (Print)");
            }
            else
            {
                for (int i = _head; i <= _tail; i++)
                {
                    Console.WriteLine(_arr[i]+ " ,");
                }
            }
        }
    }
    
}
