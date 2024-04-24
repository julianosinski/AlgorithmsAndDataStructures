using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public class ArrayOperations
    {
        int[] intArray = new int[6];
        int firstEmptyIndex = 0;

        public void printArray()
        {
            for(int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }
        public void insertToTheEnd(int value)
        {
            if (firstEmptyIndex == intArray.Length) { return; }
            intArray[firstEmptyIndex] = value;
            firstEmptyIndex++;
        }
        public void insertToTheStart(int value)
        {
            insertToThePosition(value, 0);
        }

        public void insertToThePosition(int value, int index)
        {
            if (firstEmptyIndex == intArray.Length) { return; }
            for (int i = firstEmptyIndex; i > index; i--)
            {
                intArray[i] = intArray[i - 1];
            }
            intArray[index] = value;
            firstEmptyIndex++;
        }

        public void clearEnd()
        {
            if (firstEmptyIndex == 0) { return; }
            firstEmptyIndex--;
            intArray[firstEmptyIndex] = 0;
        }

        public void clearStart()
        {
            clearAtPosition(0);
        }

        public void clearAtPosition(int index)
        {
            for(int i = index+1; i < firstEmptyIndex; i++)
            {
                intArray[i-1] = intArray[i];
            }
            clearEnd();
        }


    }

}
