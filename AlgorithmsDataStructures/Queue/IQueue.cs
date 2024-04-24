using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Queue
{
    public interface IQueue<T>
    {
        public void AddEnqueue(T item);
        public void RemoveDequeue();
        public T Peek();
    }
}
