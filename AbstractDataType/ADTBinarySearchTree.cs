/*
    Author: Yizhek Shenk
    Creation date: 14.11.21
    Desctiption: Binary Search Tree 
 */
using System;


namespace AbstractDataType
{
    public class ADTBinarySearchTree
    {
        private NodeBinary<int> _root;




        public ADTBinarySearchTree()
        {
            _root = null;
        }
        public NodeBinary<int> GetRoot()
        {
            return _root;
             
        }
        public enum TravetsalOrder
        {
            PreOrder,
            InOrder,
            PostOrder
        }
        public enum TreeOperation
        {
            NumNodes,
            SumNodes,
            MaxNode,
            MinNode,
            MaxMaxNode,
            MinMinNode,
        }
        public enum TreeProperties
        {
            AnyEven,
            AllEven,
            FullTree

        }
        public void TreePrint(TravetsalOrder traversalMode)
        {
            if (_root == null)
            {
                throw new ApplicationException("The Binary Tree is empty");
            }
            if (traversalMode == ADTBinarySearchTree.TravetsalOrder.InOrder)
            {
                SubtreePrintInOrder(_root);
            }
            if (traversalMode == ADTBinarySearchTree.TravetsalOrder.PreOrder)
            {
                SubtreePrintPreOrder(_root);
            }
            if (traversalMode == ADTBinarySearchTree.TravetsalOrder.PostOrder)
            {
                SubtreePrintPostOrder(_root);
            }
        }

        public int TreeOpExecution(TreeOperation requiredOperation)
        {
            if (_root == null)
            {
                throw new ApplicationException("The Tree is empty");
            }
            else if (requiredOperation == TreeOperation.NumNodes)
            {
                return SubtreeNumOfNodes(_root);
            }
            else if (requiredOperation == TreeOperation.SumNodes)
            {
                return SubtreeNodesSum(_root);
            }
            else if (requiredOperation == TreeOperation.MaxNode)
            {
                return SubtreeMaxNode(_root);
            }
            else if (requiredOperation == TreeOperation.MinNode)
            {
                return SubtreeMinNode(_root);
            }
            else if (requiredOperation == TreeOperation.MaxMaxNode)
            {
                return SubtreeMaxMaxNode(_root);
            }
            else if (requiredOperation == TreeOperation.MinMinNode)
            {
                return SubtreeMinMinNode(_root);
            }
            return 0;
        }
        public bool TreeProperty(TreeProperties EvenMode)
        {
            if (_root == null)
            {
                throw new ApplicationException("The Tree is empty");
            }
            else if (EvenMode == TreeProperties.AnyEven)
            {
                return IsAnyEven(_root);
            }
            else if (EvenMode == TreeProperties.AllEven)
            {
                return AreAllEven(_root);
            }
            else if (EvenMode == TreeProperties.FullTree)
            {
                return IsFullTree(_root);
            }

            return false;
        }

        private void SubtreePrintInOrder(NodeBinary<int> currentNode)
        {
            if (currentNode == null)
            {
                return;
            }
            SubtreePrintInOrder(currentNode.GetLeft());
            Console.WriteLine(currentNode.GetValue());
            SubtreePrintInOrder(currentNode.GetRight());
        }
        private void SubtreePrintPreOrder(NodeBinary<int> currentNode)
        {
            if (currentNode == null)
            {
                return;
            }
            Console.WriteLine(currentNode.GetValue());
            SubtreePrintPreOrder(currentNode.GetLeft());
            SubtreePrintPreOrder(currentNode.GetRight());
        }
        private void SubtreePrintPostOrder(NodeBinary<int> currentNode)
        {
            if (currentNode == null)
            {
                return;
            }
            SubtreePrintPostOrder(currentNode.GetLeft());
            SubtreePrintPostOrder(currentNode.GetRight());
            Console.WriteLine(currentNode.GetValue());
        }
        public void TreeClear()
        {
            _root = null;
        }
        public bool TreeAdd(int item)
        {
            if (_root == null)
            {
                _root = new NodeBinary<int>(item);
                return true;
            }
            NodeBinary<int> temp = _root;
            NodeBinary<int> tempFather = _root;
            while (temp != null)
            {
                if (temp.GetValue() > item)
                {
                    tempFather = temp;
                    temp = temp.GetLeft();
                }
                else if (temp.GetValue() < item)
                {
                    tempFather = temp;
                    temp = temp.GetRight();
                }
                else
                {
                    return false;
                }
            }
            NodeBinary<int> newNode = new NodeBinary<int>(item);
            if (tempFather.GetValue() > newNode.GetValue())
            {
                tempFather.SetLeft(newNode);
            }
            else
            {
                tempFather.SetRight(newNode);
            }
            return true;
        }
        public bool TreeIsDataFound(int item)
        {
            NodeBinary<int> temp = _root;
            while (temp != null)
            {
                if (temp.GetValue() > item)
                {
                    temp = temp.GetLeft();
                }
                else if (temp.GetValue() < item)
                {
                    temp = temp.GetRight();
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        private int SubtreeNumOfNodes(NodeBinary<int> currentNode)
        {
            if (currentNode == null)
            {
                return 0;
            }
            return SubtreeNumOfNodes(currentNode.GetLeft())
                + SubtreeNumOfNodes(currentNode.GetRight())
                + 1;
        }
        private int SubtreeNodesSum(NodeBinary<int> currentNode)
        {
            if (currentNode == null)
            {
                return 0;
            }
            return SubtreeNodesSum(currentNode.GetLeft())
                + SubtreeNodesSum(currentNode.GetRight())
                + currentNode.GetValue();
        }
        private int SubtreeMaxNode(NodeBinary<int> currentNode)
        {
            if (currentNode.GetRight() == null)
            {
                return currentNode.GetValue();
            }
            return SubtreeMaxNode(currentNode.GetRight());
        }
        private int SubtreeMinNode(NodeBinary<int> currentNode)
        {
            if (currentNode.GetLeft() == null)
            {
                return currentNode.GetValue();
            }
            return SubtreeMinNode(currentNode.GetLeft());
        }
        private int SubtreeMaxMaxNode(NodeBinary<int> currentNode)
        {
            int max = currentNode.GetValue();
            if (currentNode.GetLeft() != null)
            {
                max = Math.Max(max, SubtreeMaxMaxNode(currentNode.GetLeft()));
            }
            if (currentNode.GetRight() != null)
            {
                max = Math.Max(max, SubtreeMaxMaxNode(currentNode.GetRight()));
            }
            return max;
        }
        private int SubtreeMinMinNode(NodeBinary<int> currentNode)
        {
            int min = currentNode.GetValue();
            if (currentNode.GetLeft() != null)
            {
                min = Math.Min(min, SubtreeMinMinNode(currentNode.GetLeft()));
            }
            if (currentNode.GetRight() != null)
            {
                min = Math.Min(min, SubtreeMinMinNode(currentNode.GetRight()));
            }
            return min;
        }

        private bool IsAnyEven(NodeBinary<int> currentNode)
        {
            if (currentNode == null)
            {
                return false;
            }
            if (currentNode.GetValue() % 2 == 0)
            {
                return true;
            }
            return IsAnyEven(currentNode.GetRight()) || IsAnyEven(currentNode.GetLeft());
        }

        private bool AreAllEven(NodeBinary<int> currentNode)
        {
            if (currentNode == null)
            {
                return true;
            }
            if (currentNode.GetValue() % 2 != 0)
            {
                return false;
            }
            return AreAllEven(currentNode.GetRight()) && AreAllEven(currentNode.GetLeft());
        }
        private bool IsFullTree(NodeBinary<int> currentNode)
        {
            if (currentNode == null)
            {
                return true;
            }
            if ((currentNode.GetRight() == null && currentNode.GetLeft() != null) || (currentNode.GetLeft() == null && currentNode.GetRight() != null))
            {
                return false;
            }
            return IsFullTree(currentNode.GetLeft()) && IsFullTree(currentNode.GetRight());
        }
        
    }
}


