using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class BSTNode
    {
        public int value { get; set; }
        public BSTNode left { get; set; }
        public BSTNode right { get; set; }

        public BSTNode(int _value)
        {
            value = _value;
            left = null;
            right = null;
        }
    }

    public class BinarySearchTree
    {
        public BSTNode root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            if(root == null)
            {
                root = new BSTNode(value);
                return;
            }

            var currentNode = root;

            while (true)
            {
                if(value < currentNode.value)
                {
                    if(currentNode.left == null)
                    {
                        currentNode.left = new BSTNode(value);
                        return;
                    }

                    currentNode = currentNode.left;
                }

                if(value > currentNode.value)
                {
                    if(currentNode.right == null)
                    {
                        currentNode.right = new BSTNode(value);
                        return;
                    }

                    currentNode = currentNode.right;
                }
            }
        }

        public BSTNode LookUp(int value)
        {
            if(root == null)
            {
                return null;
            }

            var currentNode = root;
            while (currentNode != null)
            {
                if (value < currentNode.value)
                {
                    currentNode = currentNode.left;
                }

                else if(value > currentNode.value)
                {
                    currentNode = currentNode.right;
                }

                else
                {
                    return currentNode;
                }
            }

            return null;
        }


        int COUNT = 5;
        public void printTree(BSTNode node)
        {
            print2DUtil(root, 0);
        }

        private void print2DUtil(BSTNode root, int space)
        {
            // Base case  
            if (root == null)
                return;

            // Increase distance between levels  
            space += COUNT;

            // Process right child first  
            print2DUtil(root.right, space);

            // Print current node after space  
            // count  
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.Write(root.value + "\n");

            // Process left child  
            print2DUtil(root.left, space);
        }
    }
}
