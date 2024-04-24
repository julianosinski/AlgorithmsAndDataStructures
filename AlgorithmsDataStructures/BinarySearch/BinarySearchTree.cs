using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.BinarySearch
{
    public class TreeNode
    {
        public int Key { get; set; }
        public string Name {  get; set; }
        public TreeNode? LeftChild { get; set; }
        public TreeNode? RightChild { get; set; }

        public TreeNode(int key,string name)
        {
            Key = key;
            Name = name;
        }
    }
    public class BinarySearchTree
    {
        public TreeNode? Root { get; set; }

        public void Insert(int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }

        public TreeNode Find(int key)
        {
            return FindItem(Root, key);
        }

        public void InOrderTraversal()
        {
            InOrder(Root);
        }
        public void PreOrderTraversal()
        {
            PreOrder(Root);
        }

        public void PostOrderTraversal()
        {
            PostOrder(Root);
        }

        //recursicve
        TreeNode InsertItem(TreeNode? node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);

            if(node == null) { return newNode; }// base case,stops tree traversing
            //Traverse tree, find, insert
            if (key<node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key, value);
            }
            else
            {
                node.RightChild = InsertItem(node.RightChild, key, value);
            }
            return node; //alows to come for new created child to previouse node
        }
        TreeNode? FindItem(TreeNode? node, int key)
        {
            if(node == null) return null;
            if (key < node.Key)
            {
                node = FindItem(node.LeftChild, key);
            }
            else if(key>node.Key) {
                node = FindItem(node.RightChild, key);
            }
            return node;
        }

        //Traversals
        //L,Node,R
        void InOrder(TreeNode node)
        {
            if(node != null)
            {
                InOrder(node.LeftChild);
                Console.Write("{0}, ", node.Key);
                InOrder(node.RightChild);
            }
            return;
        }
        //Node,L,R
        void PreOrder(TreeNode node) 
        {
            Console.Write("{0}, ", node.Key);
            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }
            if(node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
            return;
        }
        //L,R,Node
        void PostOrder(TreeNode node)
        {
            if(node != null)
            {
                PostOrder(node.LeftChild);
                PostOrder(node.RightChild);
                Console.Write("{0}, ", node.Key);
            }
            return;
        }
    }
}
