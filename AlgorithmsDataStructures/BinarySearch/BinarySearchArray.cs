using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.BinarySearch
{
    public class BinarySearchArray
    {
        int[] array;
        int startIndex, endIndex;
        // you can only search for sorted data
        public BinarySearchArray(int[] arrayToSearch)
        {
            this.array = arrayToSearch;
            startIndex = 0;
            endIndex = arrayToSearch.Length-1;
        }

        public int FindValueIndex(int value)
        {
            int midle = 0;
            while (startIndex<=endIndex)
            {
                midle = (startIndex + endIndex) / 2;
                if (array[midle] == value)
                {
                    return midle;
                }
                else if (array[midle] > value) //look from the valu on the left side of midle 
                {
                    endIndex = midle-1; // set value to midle and move one position left
                }
                else //look from the valu on the right side of midle 
                {
                    startIndex = midle+1; //set value to midle and move one position right
                }
            }
            return -1;
        }

    }
}
