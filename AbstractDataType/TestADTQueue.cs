/*
    Author: Yizhek Shenk
    Creation date: 02.01.22
    Desctiption: TestQueue 
 */
using AbstractDataType;
using System;

namespace TestQueue
{
    class TestADTQueue
    {
        static void Main(string[] args)
        {
            ADTQueue<int> queue = new ADTQueue<int>(5);
            queue.IsEmpty();
            //queue.Dequeue();
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(6);


            Console.WriteLine("------------");
            queue.Print();





        }
    }
}
