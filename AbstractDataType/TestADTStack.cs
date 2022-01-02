/*
    Author: Yizhek Shenk
    Creation date: 26.12.21
    Desctiption: TeatStack 
 */
using AbstractDataType;
using System;

namespace TeatStack
{
    class TestADTStack
    {
        static void Main(string[] args)
        {
            ADTStack<int> stack = new ADTStack<int>(3);
           
            //With catching errors
            Console.WriteLine("stack.IsEmpty() = " + stack.IsEmpty());
            try
            {
                Console.WriteLine(stack.Top());
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine(stack.Pop());
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                stack.Print();
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            
            //Without catching errors
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("stack.IsEmpty() = " + stack.IsEmpty());
            stack.Print();
            try
            {
                Console.Write("stack.Pop() = ");
                Console.WriteLine(stack.Pop());
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.Write("stack.Top() = ");
                Console.WriteLine(stack.Top());
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                stack.Print();
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("GetNumOfItems = " + GetNumOfItems(stack));
            Console.WriteLine("IsPalindrome = " + IsPalindrome("abcde"));
            Console.WriteLine("IsPalindrome = " + IsPalindrome("abccba"));
            Console.WriteLine("AreBalancedParathesis = " + AreBalancedParathesis("{[()]}")); 
            Console.WriteLine("AreBalancedParathesis = " + AreBalancedParathesis("{[)]}"));
            InsertAtBottom(stack,5);
            stack.Print();
            Reverse(stack);
            stack.Print();
        }
        public static int GetNumOfItems(ADTStack<int> stack)
        {
            ADTStack<int> tmpstack = new ADTStack<int>(5);
            int cunter = 0;
            while (!stack.IsEmpty())
            {
                tmpstack.Push(stack.Pop());
                ++cunter;
            }
            while (!tmpstack.IsEmpty())
            {
                stack.Push(tmpstack.Pop());
            }
            return cunter;
        }
        public static bool IsPalindrome(string str)
        {
            ADTStack<char> stack = new ADTStack<char>(str.Length / 2);
            for (int i = str.Length / 2; i < str.Length; i++)
            {
                stack.Push(str[i]);
            }
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (stack.Pop() != str[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool AreBalancedParathesis(string exp)
        {
            bool isMatching(char character1, char character2)
            {
                if (character1 == '(' && character2 == ')')
                {
                    return true;
                }
                else if (character1 == '{' && character2 == '}')
                {
                    return true;
                }
                else if (character1 == '[' && character2 == ']')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            ADTStack<char> brackets = new ADTStack<char>(exp.Length);
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '[' || exp[i] == '(')
                {
                    brackets.Push(exp[i]);
                }
                if (exp[i] == '}' || exp[i] == ']' || exp[i] == ')')
                {
                    if (brackets.IsEmpty()) 
                    { 
                        return false; 
                    }
                    else if (!isMatching(brackets.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }
            return brackets.IsEmpty();
        }
        public static void InsertAtBottom(ADTStack<int> stack, int item) 
        {
            if (stack.IsEmpty())
            {
                stack.Push(item);
                return;
            }
            int tmp = stack.Pop();
            InsertAtBottom(stack, item);
            stack.Push(tmp);
        }
        public static void Reverse(ADTStack<int> stack)
        {
            if (stack.IsEmpty())
            {
                return;
            }
            int tmp = stack.Pop();
            Reverse(stack);
            InsertAtBottom(stack, tmp);
        }
    }
}
