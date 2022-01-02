/*
    Auther: Yizhek Shenk
    Creation date: 17.10.21
    Desctiption: Singly linked list
 */
using System;

namespace AbstractDataType
{
    public class ADTSinglyLL<T>
    {
        public class Node
        {
            private T _value;
            private Node _next;
            public Node(T value)
            {
                this._value = value;
                this._next = null;
            }
            public Node(T value, Node next)
            {
                this._value = value;
                this._next = next;
            }

            public T GetValue()
            {
                return _value;
            }
            public void SetValue(T value)
            {
                this._value = value;
            }
            public Node GetNext()
            {
                return _next;
            }
            public void SetNext(Node next)
            {
                this._next = next;
            }
            public override string ToString()
            {
                return ("" + _value);
            }

        }

        //--------------------//
        private Node _head, _tail;

        public ADTSinglyLL()
        {
            _tail = _head = null;
        }
        public int LLCountItems()
        {
            Node item = _head;
            int counter = 0;
            while (item != null)
            {
                item = item.GetNext();
                ++counter;
            }
            return counter;
        }
        public void LLClear()
        {
            _head = _tail = null;
        }
        public void LLPushHead(T value)
        {
            if (_head == null)
            {
                _head = _tail = new Node(value);
            }
            else
            {
                _head = new Node(value, _head);
            }
        }
        public void LLPushTail(T value)
        {
            if (_head == null)
            {
                _head = _tail = new Node(value);
            }
            else
            {
                Node tmp = new Node(value);
                _tail.SetNext(tmp);
                _tail = tmp;
            }
        }
        public bool LLIsEmpty()
        {
            return (_head == null);
        }
        public void LLPrint()
        {
            if (_head == null)
            {
                throw new ApplicationException("The List is empty (LLPrint)");
            }
            else
            {
                Node item = _head;
                while (item != null)
                {
                    Console.WriteLine(item.GetValue());
                    item = item.GetNext();
                }
            }
        }
        public T LLPopHead()
        {
            if (_head == null)
            {
                throw new ApplicationException("The list is empty (LLPopHead)");
            }
            Node item = _head;
            if (_head == _tail)
            {
                _head = _tail = null;
            }
            else
            {
                _head = _head.GetNext();
            }
            return item.GetValue();
        }
        public T LLPopTail()
        {
            if (_head == null)
            {
                throw new ApplicationException("The list is empty (LLPopTail)");
            }
            T temp = _tail.GetValue();

            if (_head == _tail)
            {
                _head = _tail = null;
            }
            else
            {
                Node item = _head;
                while (item.GetNext() != _tail)
                {
                    item = item.GetNext();
                }
                item.SetNext(null);
                _tail = item;
            }
            return temp;
        }
        public void LLPushAt(int index, T value)
        {
            Node item = new Node(value);
            Node temp = _head;
            int i;
            if (_head == null)
            {
                if (index != 0)
                {
                    throw new ApplicationException("There is no such index (LLPushAt)");
                }
            }
            if (index == 0)
            {
                LLPushHead(value);
                return;
            }
            for (i = 0; i < index; ++i)
            {
                if (temp.GetNext() == null)
                {
                    throw new ApplicationException("There is no such index (PushAt)");
                }
                temp = temp.GetNext();
            }
            item.SetNext(temp.GetNext());
            temp.SetNext(item);
            if (temp == _tail)
            {
                _tail = item;
            }
        }
        public T LLPopAt(int index)
        {
            if (_head == null)
            {
                throw new ApplicationException("The List is empty (LLPopAt)");
            }
            if (index == 0)
            {
                return LLPopHead();
            }
            if (_head == _tail)
            {
                if (index != null)
                {
                    throw new ApplicationException("There is no such index (LLPopAt)");
                }
            }
            Node prev = _head;
            Node item = _head.GetNext();

            for (int i = 0; i < index; ++i)
            {
                if (item.GetNext() == null)
                {
                    throw new ApplicationException("There is no such index (LLPopAt)");
                }
                prev = item;
                item = item.GetNext();
            }
            T temp = item.GetValue();
            item.SetNext(item.GetNext());
            if (_tail == item)
            {
                _tail = prev;
            }
            return temp;
        }
        public int LLFind(T value)
        {
            if (_head == null)
            {
                throw new ApplicationException("The List is empty (LLFind)");
            }
            int index = 0;
            Node item = _head;
            while (!(item.GetValue().Equals(value)))
            {
                if (item.GetNext() == null)
                {
                    throw new ApplicationException("There is no such value (LLFind)");
                }
                item = item.GetNext();
                ++index;
            }
            return index;

        }
        public Node LLGetNode(int index)
        {
            if (_head == null)
            {
                throw new ApplicationException("The List is empty (LLGetNode)");
            }
            Node item = _head;
            for (int i = 0; i < index; i++)
            {
                if (item.GetNext() == null)
                {
                    throw new ApplicationException("There is no such index (LLGetNode)");
                }
                item = item.GetNext();
            }
            return item;
        }
        public void LLApppend(ADTSinglyLL<T> newList)
        {
            this._tail.SetNext(newList._head);
            this._tail = newList._tail;
        }
        public void LLReverseItr()
        {
            if (_head == null)
            {
                throw new ApplicationException("The List is empty (LLReverseItr)");
            }
            if (_head == _tail)
            {
                return;
            }
            Node prev = null, current = _head, next = null;
            while (current != null)
            {
                next = current.GetNext();
                current.SetNext(prev);
                prev = current;
                current = next;
            }
            _head = prev;
        }
        //public static Node LLReverse(Node head)
        //{
        //    if (head == null || head.GetNext() == null) 
        //    {
        //        return head;
        //    }
        //    Node rest = LLReverse(head.GetNext());
        //    head.GetNext().SetNext(head)  ;
        //    head.SetNext(null);
        //    return rest;
        //}
        //public void LLFlipItr()
        //{
        //    if (_head == null)
        //    {
        //        throw new ApplicationException("the list is empty");
        //    }
        //    if (_head == _tail)
        //    {
        //        return;
        //    }
        //    Node prev = _head;
        //    Node item = _head.GetNext();
        //    Node temp = item.GetNext();
        //    while (temp != null)
        //    {
        //        item.SetNext(prev);
        //        prev = item;
        //        item = temp;
        //        temp = temp.GetNext();
        //    }
        //    temp = _head;
        //    _head = item;
        //    _head.SetNext(prev);
        //    _tail = temp;
        //    _tail.SetNext(null);
        //}
        public static Node RecursiveFlip(Node node)
        {
            if (node == null || node.GetNext() == null)
            {
                return node;
            }
            Node tenp = RecursiveFlip(node.GetNext());
            node.GetNext().SetNext(node);
            node.SetNext(null);
            return tenp;
        }
    }
}