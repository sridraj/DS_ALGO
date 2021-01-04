using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class Recursion_StringReversal
    {
        public Recursion_StringReversal()
        {

        }

        public string ReverseString(string value)
        {
            if(value.Length == 0)
            {
                return string.Empty;
            }

            return ReverseString(value.Substring(1)) + value[0];
        }
    }
}
