using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class StringReversal
    {
        public StringReversal()
        {

        }

        public string ReverseString(string item)
        {
            var splitItem = item.ToCharArray();
            var newArray = new Char[splitItem.Length];
            for (int i = 0; i < splitItem.Length; i++)
            {
                newArray[i] = splitItem[splitItem.Length - 1 - i];
            }

            var reverseString = new String(newArray);
            return reverseString;
        }

        public string ReverseString2(string item)
        {
            String reverseString = String.Empty;
            for (int i = item.Length-1; i>=0; i--)
            {
                reverseString = reverseString + item[i];
            }

            return reverseString;
        }
    }
}
