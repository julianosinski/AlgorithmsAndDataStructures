using AlgorithmsDataStructures.BinarySearch;
using AlgorithmsDataStructures.Graphs;
using AlgorithmsDataStructures.LinkedList;
using AlgorithmsDataStructures.Queue;
using AlgorithmsDataStructures.Recursion;
using AlgorithmsDataStructures.Sort;
using AlgorithmsDataStructures.Stack;
using System.Collections;
using System.Collections.Immutable;

public class Program
{
    static void Main(string[] args)
    {
        BinarySearchArrayDemo();
    }

    static void ListReference()
    {
        List<int> listUnSorted = new List<int>();
        listUnSorted.Add(13);
        listUnSorted.Add(2);
        listUnSorted.Add(-3);
        List<int> list = new List<int>(listUnSorted);
        list.Sort();
        Console.WriteLine(list.IndexOf(list.Max()));
        listUnSorted.ForEach(x => Console.Write("{0}, ", x));
    }

    static void ArrayReference()
    {
        int[] arrayUnSorted = { 13, 2, 4, 5, -6 };
        int[] array = new int[arrayUnSorted.Length];
        Array.Copy(arrayUnSorted, array, arrayUnSorted.Length);
        Array.Sort(array);
        foreach (var item in arrayUnSorted)
        {
            Console.Write("{0}, ", item);
        }
    }

    static void GraphDemo()
    {
        GraphAdjacencyMatrix graph = new GraphAdjacencyMatrix(6);
        //GraphAdjacencyList graph = new GraphAdjacencyList();
        graph.AddNode(new GraphNode('A'));
        graph.AddNode(new GraphNode('B'));
        graph.AddNode(new GraphNode('C'));
        graph.AddNode(new GraphNode('D'));
        graph.AddNode(new GraphNode('E'));
        graph.AddNode(new GraphNode('F'));

        
        graph.AddEdge(0,1);//A to B
        graph.AddEdge(4,0);//E to A
        graph.AddEdge(1,2);//B to C
        graph.AddEdge(2,3);//C to D
        graph.AddEdge(1,4);//B to E
        graph.AddEdge(4,2);//E to C
        graph.AddEdge(2,4);//C to E
        
        /*
        int[] srcsArr = {1,2,2,3,4,5,5};
        int[] dstsArr = { 2, 3, 4, 2, 5, 2, 4 };
        List<int> srcsList = new List<int>(srcsArr);
        List<int> dstsList = new List<int>(dstsArr);

        graph.AddEdges(srcsList, dstsList);
        */
        graph.PrintAdjacencyMatrix();
        graph.DepthFirstSearch(0);
        //graph.PrintGraphAdjacencyList();
    }
    static void BinaryTreeTraversalDemo()
    {
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        #region populateTree
        binarySearchTree.Insert(10, "Julek");
        binarySearchTree.Insert(7, "Zeynep");
        binarySearchTree.Insert(6, "Patryk");
        binarySearchTree.Insert(11, "Lukasz");
        binarySearchTree.Insert(1, "Rosiak");
        binarySearchTree.Insert(20, "Alina");
        binarySearchTree.Insert(8, "Norbert");
        binarySearchTree.Insert(14, "Teresa");
        binarySearchTree.Insert(22, "Patrycja");
        binarySearchTree.Insert(9, "Zocha");
        #endregion 
        binarySearchTree.InOrderTraversal();
    }
    static void RecursionDemo()
    {
        Recursion myRecursion = new Recursion();
        Console.WriteLine(myRecursion.Factorial(4));
    }

    

    static void SortingMetods()
    { 
        int[] arrayToSort = { 7, 4, 3, 8, 6, 9, 11 };
        List<int> listToSort = new List<int>();
        MergeSort mergeSort = new MergeSort();
        mergeSort.Sort(arrayToSort);

        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.Sort(arrayToSort);

        /* fewer than 16 elements, it uses an insertion sort O(n^2)
        size biger than 2 * log^N it usese HeapSort O(n*log(n))
        Otherwise, it uses a Quicksort algorithm O(n*log(n)) - Worst case O(n^2)*/
        Array.Sort(arrayToSort);
        listToSort.Sort();
        
        foreach (int item in arrayToSort)
        {
            Console.Write("{0},", item);
        }
    }
    static void BinarySearchTreeDemo()
    {
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        binarySearchTree.Insert(15, "Julek");
        binarySearchTree.Insert(8, "Zeynep");
        binarySearchTree.Insert(-7, "Hubsik");
        binarySearchTree.Insert(14, "Mati");
        binarySearchTree.Insert(14, "Zbyszek");
        binarySearchTree.Insert(4, "Mariusz");

        Console.WriteLine(binarySearchTree.Find(-7).Name);
    }

    static void BinarySearchArrayDemo()
    {
        int[] mySortedArray = { -13, -5, -1, 0, 4, 6, 7, 11 };

        BinarySearchArray binarySearchArray = new BinarySearchArray(mySortedArray);
        Console.WriteLine(binarySearchArray.FindValueIndex(-1));
    }

    static void QueueDemo()
    {
        QueueLinkedList<String> queueLinkedList = new QueueLinkedList<String>();
        QueueArray<String> queueArray = new QueueArray<string>(10);
        queueLinkedList.AddEnqueue("a");
        queueLinkedList.AddEnqueue("b");
        queueLinkedList.AddEnqueue("c");

        queueLinkedList.ReadAllItems();
        Console.WriteLine();

        queueLinkedList.RemoveDequeue();
        queueLinkedList.ReadAllItems();
        Console.WriteLine();

        queueLinkedList.AddEnqueue("Teddy");
        queueLinkedList.RemoveDequeue();
        Console.WriteLine(queueLinkedList.Peek());
    }

    static void StackDemo()
    {
        StackArray<string> myStackArray = new StackArray<string>(5);
        StackLinkedList<string> myStackLinkedList = new StackLinkedList<string>();
        myStackLinkedList.Push("tak?");
        myStackLinkedList.Push("nie?");
        Console.WriteLine(myStackLinkedList.Peek());
        Console.WriteLine(myStackLinkedList.Pop());
        Console.WriteLine(myStackLinkedList.Peek());
    }

    static void LinkedListDemo()
    {
        AlgorithmsDataStructures.LinkedList.LinkedList<string> myLinkedList = new AlgorithmsDataStructures.LinkedList.LinkedList<string>();

        Console.WriteLine(myLinkedList.DeleteFirst());
        myLinkedList.InsertLast("Franek"); 
        myLinkedList.InsertFirst("Zuzia");
        myLinkedList.InsertFirst("Kasia"); 
        myLinkedList.InsertFirst("Hubsik");
        myLinkedList.InsertLast("Skolus");
        myLinkedList.InsertFirst("Piotr");

        myLinkedList.DisplayLinkedList();
        Console.WriteLine();
        Console.WriteLine(myLinkedList.DeleteFirst().Data);
        Console.WriteLine();
        myLinkedList.DisplayLinkedList();
    }
}
