using System;

namespace Day15PPBinarySearchTree
{
    internal class BinarySearchTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program!");
            BinarySearchTree<int> bst = new BinarySearchTree<int>(3);
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display();
        }
    }
}