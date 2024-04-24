using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.LinkedList
{
    public class LinkedList<T>
    {
        public Node<T>? Head { get; set; }

        public void InsertFirst(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = data;
            newNode.Next = Head;
            Head = newNode;
        }

        public void InsertLast(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = data;

            //To avoid Dereference of posible null reference, Head can be null in this case we canot acces Head.Next   
            if (Head == null) { Head = newNode; return; }

            Node<T> currentNode = Head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = newNode;
        }

        public void DisplayLinkedList()
        {
            Node<T>? currentNode = Head;
            while(currentNode != null)
            {
                currentNode.DisplayNode();
                currentNode = currentNode.Next;
            }
        }
        public Node<T>? DeleteFirst()
        {
            Node<T>? deletedNode = Head; //keap reference so we can call destructor

            //To avoid Dereference of posible null reference, Head can be null in this case we canot acces Head.Next  
            if (Head != null)
            {
                Head = Head.Next; //logicly deleting node = Head.Next; //logicly deleting node
            }
            return deletedNode;
        }
    }
}
