using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree sandbox = new BinarySearchTree();
            sandbox.Add(12);
            sandbox.Search(12, sandbox.root) ;
            if (sandbox.Search(12, sandbox.root) == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            sandbox.Add(14);
            sandbox.Add(16);
            sandbox.Add(8);
            sandbox.Search(8, sandbox.root);
            if (sandbox.Search(8, sandbox.root) == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            sandbox.Add(24);
            sandbox.Add(2);
            if (sandbox.Search(64, sandbox.root) == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
            
        }
    }
}
