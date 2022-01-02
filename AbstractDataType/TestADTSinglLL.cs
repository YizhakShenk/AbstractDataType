/*============================
    Auther: Yizhek Shenk
    Creation date: 17.10.21
    Desctiption: Testing Singly linked list
 */
using System;
using AbstractDataType;

namespace TastSinglLL
{
    class TestADTSinglLL
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Testing Singly linked list");
            ADTSinglyLL<person> listPerson = new ADTSinglyLL<person>();
            ADTSinglyLL<int> listPerson1 = new ADTSinglyLL<int>();
            listPerson1.LLPushHead(4);
            listPerson1.LLPushHead(5);
            listPerson1.LLPushHead(6);
            listPerson1.LLPushHead(8);
            //person p1 = new person("Avi", 22);
            //person p2 = new person("Haim", 26);
            //person p3 = new person("Dudi", 28);
            //person p4 = new person("Udi", 35);
            //person p5 = new person("shenk", 20);
            //listPerson.LLPushHead(p2);
            //listPerson.LLPushHead(p1);
            //listPerson.LLPushTail(p3);
            //listPerson.LLPushTail(p4);
            listPerson1.LLPrint();
            //listPerson.RecursiveFlip();
            //listPerson1.LLReverseItr();
            listPerson1.LLPrint();
        }
        //    Console.WriteLine("(LLIsEmpty)" + listPerson.LLIsEmpty()); 
        //    Console.WriteLine("At first (LLCountItems) = " + listPerson.LLCountItems());
        //    listPerson.LLPushHead(p2);
        //    listPerson.LLPushHead(p1);
        //    listPerson.LLPushTail(p3);
        //    listPerson.LLPushTail(p4);
        //    Console.WriteLine("(LLIsEmpty)" + listPerson.LLIsEmpty());
        //    Console.WriteLine("Printing After using LLPushHead and LLPushTail listPerson");
        //    listPerson.LLPrint();
        //    Console.WriteLine("After entering data (LLCountItems) = " + listPerson.LLCountItems());
        //    ADTSinglyLL<person> listPerson1 = new ADTSinglyLL<person>();
        //    listPerson1.LLPushHead(p4);
        //    listPerson1.LLPushHead(p3);
        //    listPerson1.LLPushHead(p2);
        //    listPerson1.LLPushHead(p1);
        //    listPerson.LLApppend(listPerson1);
        //    Console.WriteLine("Printing After using LLApppend listPerson1");
        //    listPerson.LLPrint();
        //    listPerson.LLClear();
        //    Console.WriteLine("After deleting the data (LLCountItems) = " + listPerson.LLCountItems());
        //    //Without catching errors
        //    {
        //        listPerson.LLPushTail(p1);
        //        listPerson.LLPushTail(p2);
        //        listPerson.LLPushTail(p3);
        //        listPerson.LLPushTail(p4);
        //        try
        //        {
        //            Console.WriteLine("(LLPopHead)" + listPerson.LLPopHead());
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            Console.WriteLine("(LLPopTail)" + listPerson.LLPopTail());
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            Console.WriteLine("Printing After using LLPopHead and LLPopTail listPerson (LLPrint)");
        //            listPerson.LLPrint();
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            Console.WriteLine("(LLPushAt) ");
        //            listPerson.LLPushAt(0, p4);
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            Console.WriteLine("(LLPopAt) " + listPerson.LLPopAt(1));
                   
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        Console.WriteLine("Printing After using LLPushAt and LLPopAt listPerson (LLPrint)");
        //        listPerson.LLPrint();
        //        try
        //        {
        //            Console.WriteLine("(LLFind) " + listPerson.LLFind(p2));
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            Console.WriteLine("(LLGetNode) " + listPerson.LLGetNode(2));
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //    }
        //    //With catching errors
        //    listPerson.LLClear();
        //    {
        //        try
        //        {
        //            listPerson.LLPopHead();
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            listPerson.LLPopTail();
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            listPerson.LLPrint();
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            listPerson.LLPushAt(3, p4);
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            listPerson.LLPopAt(1);
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //             listPerson.LLFind(p2);
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            listPerson.LLGetNode(2);
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        Console.WriteLine("=============================");
        //        try
        //        {
        //            listPerson1.LLPopAt(5);
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //            listPerson1.LLFind(p5);
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        try
        //        {
        //             listPerson1.LLGetNode(5);
        //        }
        //        catch (ApplicationException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //    }
        //}
    }
    class person
    {
        private string _name;
        private int _age;

        public person(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
        public override string ToString()
        {
            return ("name = " + this._name + ", age = " + this._age);
        }
    }
}


