using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Stack
{
    public class StackArray<T>
    {
        public int Size { get; set; }
        public T[] Values { get; set; }

        public int Top { get; set; }

        public StackArray(int size) 
        { 
            Size = size;
            Values = new T[size];
            //Top is set as -1 so when we add first element to the stack it is position at strat of array
            Top = -1;
            Console.WriteLine(Values[0]);
        }

        public void Push(T value)
        {
            Top++;
            Values[Top] = value;
        }
        public T Pop()
        {
            T popedElement = Values[Top];
            Top--;
            return popedElement;
        }
        public T Peek()
        {
            return Values[Top];
        }


    }
}
