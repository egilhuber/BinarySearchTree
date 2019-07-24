using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinarySearchTree
    {
        //member variables
        public Node root;
        public Node current;
        public Node parent;
        //ctor
        public BinarySearchTree()
        {
            root = null;
        }
        //member methods


        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                current = root;
                while (true)
                {
                    parent = current;
                    if (newNode.Data < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            newNode.Parent = parent;
                            return;

                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            newNode.Parent = parent;
                            return;
                        }
                    }
                }
            }

        }



        public bool Search(int el, Node root)
        {
            current = root;
            if (current == null)
            {
                return false;
            }
            if (el == current.Data)
            {
                return true;
            }
            if (el < current.Data)
            {
                return this.Search(el, current.Left);
            }
            else
            {
                return this.Search(el, current.Right);
            }
        }







        //last line of main bits
    }
}


