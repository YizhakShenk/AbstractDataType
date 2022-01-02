using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDataType
{
    public class NodeBinary<T>
    {
        private T _value;
        private NodeBinary<T> _left, _right, _father;
        public NodeBinary(T item)
        {
            _value = item;
            _left = _right = _father = null;
        }
        public NodeBinary(T item, NodeBinary<T> father)
        {
            _value = item;
            _father = father;
            _left = _right = null;
        }
        public T GetValue()
        {
            return _value;
        }
        public NodeBinary<T> GetLeft()
        {
            return _left;
        }
        public NodeBinary<T> GetRight()
        {
            return _right;
        }
        public NodeBinary<T> GetFather()
        {
            return _father;
        }
        public void SetValue(T value)
        {
            _value = value;
        }
        public void SetLeft(NodeBinary<T> left)
        {
            _left = left;
        }
        public void SetRight(NodeBinary<T> right)
        {
            _right = right;
        }

        public void SetFather(NodeBinary<T> father)
        {
            _father = father;
        }
    }
}
