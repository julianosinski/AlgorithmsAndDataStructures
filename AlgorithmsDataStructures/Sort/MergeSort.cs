using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Sort
{
    public class MergeSort
    {
        //recursice function
        public void Sort(int[] array)
        {
            int length = array.Length;
            if(length <= 1) return; //base case, no need to divide array further 

            int middle = length / 2;
            int[] leftArr = new int[middle];
            int[] rightArr = new int[length - middle];

            //dividing array in two
            int i = 0;
            int j = 0;
            for(; i < length; i++) {
                if(i<middle)
                {
                    leftArr[i] = array[i];
                    Console.Write("L"+leftArr[i]+", ");
                }
                else
                {
                    rightArr[j] = array[i];
                    Console.Write("R"+rightArr[j] + ", ");
                    j++;
                }
            }
            Console.WriteLine();

            Sort(leftArr);
            Sort(rightArr);
            Merge(leftArr,rightArr, array);
            return; //climbing back of the tree
        }
        public void Merge(int[] leftArray, int[] rightArray, int[] array)
        {
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            /*
                Console.WriteLine("leftArray.Length: {0}, array.Length/2: {1}", leftArray.Length, array.Length/2);
                Console.WriteLine("rightArray.Length: {0}, array.Length-array.Length/2: {1}", rightArray.Length, array.Length - (array.Length / 2));
            */
            int i = 0, l = 0, r = 0; //indices

            //compere elemnts of array and put smaller in array until one of arrays is empty
            while(l < leftSize && r< rightSize) 
            {
                if (leftArray[l] < rightArray[r])
                {
                    array[i] = leftArray[l];
                    i++;
                    l++;
                }
                else
                {
                    array[i] = rightArray[r];
                    i++;
                    r++;
                }
            }
            //right and left array might not be the same size
            while (l < leftSize) //if l<leftSize it means that leftArray is biger than rightArray 
            {
                array[i] = leftArray[l];
                i++; l++;
            }
            while (r < rightSize) //if r<rightSize it means that rightArray is biger than leftArray
            {
                array[i] = rightArray[r]; 
                i++; r++;
            }
        }
    }
}
