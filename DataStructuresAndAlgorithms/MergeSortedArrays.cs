using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class MergeSortedArrays
    {
        public MergeSortedArrays()
        {

        }

        public int[] MergeTwoSortedArrays(int[] array1 , int[] array2)
        {
            int len1 = array1.Length;
            int len2 = array2.Length;
            int[] mergedArray = new int[len1 + len2];

            int i = 0, j = 0, k = 0;
            while(i < len1 && j < len2)
            {
                if(array1[i] > array2[j])
                {
                    mergedArray[k++] = array2[j++];

                }

                else if(array1[i] < array2[j])
                {
                    mergedArray[k++] = array1[i++];
                }

                else
                {
                    mergedArray[k++] = array1[i++];
                    mergedArray[k++] = array2[j++];
                }
            }

            if(i < len1)
            {
                while(i < len1)
                {
                    mergedArray[k++] = array1[i++];
                }
            }

            if( j < len2)
            {
                while(j < len2)
                {
                    mergedArray[k++] = array2[j++];
                }
            }
            return mergedArray;
        }
    }
}
