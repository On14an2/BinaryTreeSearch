using System;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.Add("собака");
            tree.Add("як");
            tree.Add("кит");
            tree.Add("слон");
            tree.Add("кот");
            tree.Add("белка");

            Console.WriteLine("Обход дерева в прямом порядке:");
            tree.TraverseInOrder();

            Console.ReadLine();
        }
    }
}