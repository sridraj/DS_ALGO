using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class FindFirstRecurringCharacter
    {
        public FindFirstRecurringCharacter()
        {

        }

        public int FindFirstRecurringNumberUsingHash(int[] items)
        {
            var temp = new Hashtable();

            for(int i = 0; i < items.Length; i++)
            {
                if(temp.ContainsKey(items[i]))
                {
                    return items[i];
                }
                temp[items[i]] = items[i];
            }
            return 0;
        }

        public int FindFirstRecurringNumberUsingList(int[] items)
        {
            var temp = new List<int>();

            for (int i = 0; i < items.Length; i++)
            {
                if (temp.Contains(items[i]))
                {
                    return items[i];
                }
                temp.Add(items[i]);
            }
            return 0;
        }

    }
}
