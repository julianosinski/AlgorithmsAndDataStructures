﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.LinkedList
{
    public class Node<T>
    {
        public T? Data {  get; set; } 
        public Node<T>? Next { get; set; } 

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}
