using AlgorithmsDataStructures.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Graphs
{
    public class GraphAdjacencyList
    {
        //Graph Node class is located in GraphAdjacencyMatrix.cs
        List<System.Collections.Generic.LinkedList<GraphNode>> alist = new List<System.Collections.Generic.LinkedList<GraphNode>>();
        public GraphAdjacencyList() {
            //alist = new List<>();
        }

        public void AddNode(GraphNode node)
        {
            System.Collections.Generic.LinkedList<GraphNode> currentList = new System.Collections.Generic.LinkedList<GraphNode>();
            currentList.AddFirst(node);
            alist.Add(currentList);
        }
        public void AddEdge(int src, int dst)
        {
            System.Collections.Generic.LinkedList<GraphNode> currentList = alist[src];
            GraphNode dstNode = alist[dst].First.Value;
            currentList.AddLast(dstNode);
        }
        public bool CheckEdge(int src, int dst)
        {
            System.Collections.Generic.LinkedList<GraphNode> currentList = alist[src];
            GraphNode dstNode = alist[dst].First.Value;

            return currentList.Contains(dstNode);
        }
        
        public void PrintGraphAdjacencyList()
        {
            foreach (System.Collections.Generic.LinkedList<GraphNode> item in alist)
            {
                foreach(GraphNode node in item)
                {
                    Console.Write(node.data + "->");
                }
                Console.WriteLine();
            }
        }

    }
}
