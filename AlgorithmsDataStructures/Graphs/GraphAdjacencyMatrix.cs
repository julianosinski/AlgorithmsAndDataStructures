using AlgorithmsDataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Graphs
{
    public class GraphNode
    {
        
        public char data;
        public GraphNode(char data) { this.data = data; }
    }
    public class GraphAdjacencyMatrix
    {
        List<int> findNodesInt = new List<int>();
        List<GraphNode> nodes = new List<GraphNode>();//just for visualisation
        int[,] adjacencyMatrix;
        public GraphAdjacencyMatrix(int size)
        {
            adjacencyMatrix = new int[size,size];
        }

        public void AddNode(GraphNode node)
        {
            nodes.Add(node);
        }
        public void AddEdge(int src, int dst)
        {
            adjacencyMatrix[src,dst] = 1;
        }
        public bool CheckEdge(int src, int dst)
        {
            if (adjacencyMatrix[src,dst] == 1)
            {
                return true;
            }
            return false;
        }
        public void AddEdges(List<int> srcNodes, List<int> dstNodes)
        {
            for(int i = 0; i < srcNodes.Count; i++)
            {
                AddEdge(srcNodes[i], dstNodes[i]);
                //adjacencyMatrix[srcNodes[i], dstNodes[i]] = 1;
            }
        }
        public void PrintAdjacencyMatrix()
        {
            Console.Write("  ");
            for(int v = 0; v<nodes.Count; v++)
            {
                Console.Write(nodes[v].data + " ");
            }
            Console.WriteLine();
            for(int i = 0; i < adjacencyMatrix.GetLength(0); i++)//rows
            {
                Console.Write(nodes[i].data+" ");
                for (int j = 0; j < adjacencyMatrix.GetLength(1); j++)//columns
                {
                    Console.Write(adjacencyMatrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        
        public void DepthFirstSearch(int src)
        {
            bool[] visited = new bool[adjacencyMatrix.GetLength(0)];
            DFSHelper(src, visited);
            foreach(int f in findNodesInt)
            {
                Console.WriteLine(f);
            }
        }
        void DFSHelper(int src, bool[] visited)
        {
            if (visited[src]) //base case
            {
                return;
            }
            else
            {
                visited[src] = true;
                findNodesInt.Add(src);
                //Console.WriteLine(nodes[src].data);
            }
            for(int i = 0;i < adjacencyMatrix.GetLength(0); i++)
            {
                if (adjacencyMatrix[src,i] != 0)
                {
                    DFSHelper(i,visited);
                }
            }
        }

    }
}
