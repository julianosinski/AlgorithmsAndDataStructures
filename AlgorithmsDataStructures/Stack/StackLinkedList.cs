using AlgorithmsDataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Stack
{
    public  class StackLinkedList<T>
    {
        Node<T>? top;
        public void Push(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = value;
            newNode.Next = top;
            top = newNode;
        }
        public T Peek()
        {
            return top.Data;
        }
        public T Pop()
        {
            Node<T> popedNode = top;
            top = top.Next;
            return popedNode.Data;
        }
    }

   
}
