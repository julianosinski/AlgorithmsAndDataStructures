using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Queue
{
    public class QueueArray<T>
    {
        public int Size { get; set; }
        public T[] Items { get; set; }
        int front, rear;

        public QueueArray(int size)
        {
            Size = size;
            Items = new T[Size];
            front = 0;
            rear = -1;
        }

        public void AddEnqueue(T item)
        {
            rear++;
            Items[rear] = item;
        }

        public void RemoveDequeue()
        {
            front++;
            if (front == Size)
            {
                front = 0;
            }
        }
        public T Peek()
        {
            return Items[front];
        }

        public void ReadAllItems()
        {
            for(int i = front; i<=rear; i++)
            {
                Console.WriteLine(Items[i]);
            }
        }

    }
}
