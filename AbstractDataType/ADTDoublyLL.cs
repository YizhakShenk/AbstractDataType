/*============================
    Author: Yizhek Shenk
    Creation date: 24.10.21
    Desctiption: Doubly linked list
 */
using System;

namespace AbstractDataType
{
    class ADTDoublyLL<T>
    {
        public class Node
        {
            private T _value;
            private Node _next;
            private Node _prev;
            public Node(T value)
            {
                this._value = value;
                this._next = null;
                this._prev = null;
            }
            public Node(T value, Node next, Node prev)
            {
                this._value = value;
                this._next = next;
                this._prev = prev;
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
            public Node GetPrev()
            {
                return _prev;
            }
            public void SetPrev(Node prev)
            {
                this._prev = prev;
            }
            public override string ToString()
            {
                return (" " + _value);
            }

        }
        //------------------------------------------------//
        private Node _head, _tail;

        public ADTDoublyLL()
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
                _head.SetPrev(new Node(value, _head, null));
                _head = _head.GetPrev();
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
                Node tmp = new Node(value, null, _tail);
                _tail.SetNext(tmp);
                _tail = tmp;
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
                _head.SetPrev(null);
            }
            return item.GetValue();
        }
        public T LLPopTail()
        {
            if (_head == null)
            {
                throw new ApplicationException("The list is empty (LLPopTail)");
            }
            Node item = _tail;
            if (_head == _tail)
            {
                _head = _tail = null;
            }
            else
            {
                _tail = _tail.GetPrev();
                _tail.SetNext(null);
            }
            return item.GetValue();
        }
        public bool LLIsEmpty()
        {
            return (_head == null);
        }
        public int LLFind(T value)
        {
            int index = 0;
            Node item = _head;
            if (_head == null)
            {
                throw new ApplicationException("The list is empty (LLFind)");
            }
            while (!(item.GetValue().Equals(value)))
            {
                if (item.GetNext() == null)
                {
                    throw new ApplicationException("There is not such value(LLFind)");
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
                throw new ApplicationException("The list is empty (LLGetNode)");
            }
            Node item = _head;

            for (int i = 0; i < index; ++i)
            {
                if (item.GetNext() == null)
                {
                    throw new ApplicationException("There is not such index (LLGetNode)");
                }
                item = item.GetNext();
            }
            return item;
        }
        public void LLAppende(ADTDoublyLL<T> other)
        {
            if (_head == null && other._head == null)
            {
                throw new ApplicationException("The First and second list is empty (LLAppende)");
            }
            if (_head == null)
            {
                throw new ApplicationException("The First list is empty (LLAppende)");
            }
            if (other._head == null)
            {
                throw new ApplicationException("The second list is empty (LLAppende)");
            }
            this._tail.SetNext(other._head);
            other._head.SetPrev(this._tail);
            this._tail = other._tail;
        }
        public void LLPrint()
        {
            if (_head == null)
            {
                throw new ApplicationException("The List is empty (ptint)");
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
        public void LLPushAt(int index, T value)
        {
            if (index == 0)
            {
                LLPushHead(value);
            }
            else
            {
                Node temp = _head;

                for (int i = 0; i < index; ++i)
                {
                    if (temp == null)
                    {
                        throw new ApplicationException("There is not such index (LLPushAt)");
                    }
                    temp = temp.GetNext();
                }
                if (temp == null)
                {
                    LLPushTail(value);
                }
                else
                {
                    Node item = new Node(value, temp, temp.GetPrev());
                    temp.GetPrev().SetNext(item);
                    temp.SetPrev(item);
                }
            }
        }
        public T LLPopAt(int index)
        {
            if (_head == null)
            {
                throw new ApplicationException("The list is empty (LLPopAt)");
            }
            if (index == 0)
            {
                return LLPopHead();
            }
            Node temp = _head;
            for (int i = 0; i < index; ++i)
            {
                if (temp == null || temp.GetNext() == null)
                {
                    throw new ApplicationException("There is no such index (LLPopAt)");
                }
                temp = temp.GetNext();
            }
            if (temp == _tail)
            {
                return LLPopTail();
            }
            else
            {
                T value = temp.GetValue();
                temp.GetNext().SetPrev(temp.GetPrev());
                temp.GetPrev().SetNext(temp.GetNext());
                return value;
            }
        }
        public void LLPrintHeadToTail()
        {
            if (_head == null)
            {
                throw new ApplicationException("The List is empty (LLPrintHeadToTail)");
            }
            else
            {
                Node item = _head;
                while (item != null)

                {
                    Console.Write(item.GetValue() + "--> ");
                    item = item.GetNext();
                }
                Console.Write("null\n");
            }
        }

        public void LLPrintTailToHead()
        {
            if (_head == null)
            {
                throw new ApplicationException("The List is empty (LLPrintTailToHead)");
            }
            else
            {
                Node item = _tail;
                while (item != null && item != _head.GetPrev())
                {
                    Console.Write(item.GetValue() + " <--");
                    item = item.GetPrev();
                }
                Console.Write("null\n");
            }
        }
    }
}
