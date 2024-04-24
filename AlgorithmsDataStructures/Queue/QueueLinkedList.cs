using AlgorithmsDataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Queue
{
    public class QueueLinkedList<T> : IQueue<T>
    {
        Node<T>? front, rear;

        public void AddEnqueue(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = data;
            //when we are adding first node
            if (rear != null) { rear.Next = newNode; } else { front = newNode; } 
            rear = newNode;
        }

        public T? Peek()
        {
            return front.Data;
        }

        public void RemoveDequeue()
        {
            front = front.Next;
        }

        public void ReadAllItems()
        {
            Node<T> curentNode = front;
            while(curentNode != null)
            {
                Console.WriteLine(curentNode.Data);
                curentNode = curentNode.Next;
            }
        }
    }
}
