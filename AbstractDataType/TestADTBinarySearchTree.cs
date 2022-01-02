/*
    Author: Yizhek Shenk
    Creation date: 14.11.21
    Desctiption: Binary Search Tree 
 */
using System;


namespace AbstractDataType
{
    class TestADTBinarySearchTree
    {
        static void Main(string[] args)
        {

            ADTBinarySearchTree treeInt = new ADTBinarySearchTree();
            ADTBinarySearchTree treeInt1 = new ADTBinarySearchTree();
            //Console.WriteLine(treeInt.TreeAdd(2)); //--> true

            //Console.WriteLine(treeInt.TreeAdd(2)); //--> false
            treeInt.TreeAdd(2);
            treeInt.TreeAdd(1);
            treeInt.TreeAdd(3);
            treeInt1.TreeAdd(2);
            treeInt1.TreeAdd(1);
            treeInt1.TreeAdd(3);
            treeInt.TreeAdd(2);
            treeInt.TreeAdd(98);
            treeInt.TreeAdd(26);
            treeInt.TreeAdd(16);
            treeInt.TreeAdd(234);
            Console.WriteLine(treeInt.TreeIsDataFound(98));  //--> true
            Console.WriteLine(treeInt.TreeIsDataFound(88));  //--> false
            Console.WriteLine(treeInt.TreeOpExecution(ADTBinarySearchTree.TreeOperation.NumNodes));
            Console.WriteLine(treeInt.TreeOpExecution(ADTBinarySearchTree.TreeOperation.SumNodes));
            Console.WriteLine(treeInt.TreeOpExecution(ADTBinarySearchTree.TreeOperation.MaxNode));
            Console.WriteLine(treeInt.TreeOpExecution(ADTBinarySearchTree.TreeOperation.MinNode));
            Console.WriteLine(treeInt.TreeOpExecution(ADTBinarySearchTree.TreeOperation.MinMinNode));
            Console.WriteLine(treeInt.TreeOpExecution(ADTBinarySearchTree.TreeOperation.MaxMaxNode));
            Console.WriteLine(treeInt.TreeProperty(ADTBinarySearchTree.TreeProperties.AnyEven));
            Console.WriteLine(treeInt.TreeProperty(ADTBinarySearchTree.TreeProperties.AllEven));
            treeInt.TreePrint(ADTBinarySearchTree.TravetsalOrder.PreOrder);
            Console.WriteLine(treeInt.TreeProperty(ADTBinarySearchTree.TreeProperties.FullTree));
            Console.WriteLine(IsSimilerTree(treeInt.GetRoot(),treeInt1.GetRoot()));






        }
        public static bool IsSimilerTree(NodeBinary<int> node, NodeBinary<int> other)
        {
            if (node == null && other == null)
            {
                return true;
            }
            if ((node.GetRight() == null && other.GetRight() != null) || (node.GetRight() != null && other.GetRight() == null)
                || (node.GetLeft() == null && other.GetLeft() != null) || (node.GetLeft() != null && other.GetLeft() == null))
            {
                return false;
            }
            return IsSimilerTree(node.GetLeft(), other.GetLeft()) && IsSimilerTree(node.GetRight(), other.GetRight());
        }
        


    }
}
