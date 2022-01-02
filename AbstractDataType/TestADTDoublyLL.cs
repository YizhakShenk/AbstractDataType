/*============================
    Author: Yizhek Shenk
    Creation date: 24.10.21
    Desctiption: Testing Doubly linked list
    problems: LLAppende
 */
using System;
using AbstractDataType;

namespace TastDoublyLL
{
    class TestADTDoublyLL
    {
        static void Main(string[] args)
        {
            ADTDoublyLL<person> listPerson = new ADTDoublyLL<person>();

            person p1 = new person("Avi", 22);
            person p2 = new person("Haim", 26);
            person p3 = new person("Dudi", 28);
            person p4 = new person("Udi", 35);
            Console.WriteLine("(LLCountItems) " + listPerson.LLCountItems());
            listPerson.LLPushHead(p3);
            listPerson.LLPushHead(p2);
            listPerson.LLPushHead(p1);
            listPerson.LLPushTail(p4);
            Console.WriteLine("(LLCountItems) " + listPerson.LLCountItems());
            listPerson.LLClear();
            Console.WriteLine("(LLCountItems) " + listPerson.LLCountItems());
            listPerson.LLPushHead(p3);
            listPerson.LLPushHead(p2);
            listPerson.LLPushHead(p1);
            listPerson.LLPushTail(p4);
            Console.WriteLine("(LLIsEmpty) " + listPerson.LLIsEmpty());
            listPerson.LLClear();
            Console.WriteLine("(LLIsEmpty) " + listPerson.LLIsEmpty());
            listPerson.LLPushHead(p3);
            listPerson.LLPushHead(p2);
            listPerson.LLPushHead(p1);
            listPerson.LLPushTail(p4);

            ADTDoublyLL<person> listPerson1 = new ADTDoublyLL<person>();
            listPerson1.LLPushHead(p3);
            listPerson1.LLPushHead(p2);
            listPerson1.LLPushHead(p1);
            listPerson1.LLPushTail(p4);
            //listPerson.LLPrintHeadToTail();
            //listPerson.LLPrintTailToHead();

            //Without catching errors
            {
                try
                {
                    Console.WriteLine("(LLPopHead) " + listPerson.LLPopHead());
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    Console.WriteLine("(LLPopTail) " + listPerson.LLPopTail());
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    Console.WriteLine("(LLFind) " + listPerson.LLFind(p3));
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    Console.WriteLine("(LLGetNode) " + listPerson.LLGetNode(1));
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    listPerson.LLPushAt(2, p3);
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Printing list (LLPushAt)");
                listPerson.LLPrint();
                try
                {
                    Console.WriteLine("(LLPopAt) " + listPerson.LLPopAt(2));
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    listPerson.LLAppende(listPerson1);
                    Console.WriteLine("Printing listPerson + listPerson1");
                    listPerson.LLPrint();
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            //With catching errors
            listPerson.LLClear();
            {
                try
                {
                    Console.WriteLine(listPerson.LLPopHead());
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                listPerson.LLPushTail(p4);
                listPerson.LLClear();
                try
                {
                    Console.WriteLine(listPerson.LLPopTail());
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    Console.WriteLine(listPerson.LLFind(p3));
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    Console.WriteLine(listPerson.LLGetNode(1));
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    listPerson.LLPushAt(5, p3);
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    listPerson.LLPopAt(5);
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    listPerson.LLPrint();
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                listPerson1.LLClear();
                try
                {
                    listPerson.LLAppende(listPerson1);
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
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
                return ("name = " + this._name + ", " + "age = " + this._age);
            }

        }

    }
}

