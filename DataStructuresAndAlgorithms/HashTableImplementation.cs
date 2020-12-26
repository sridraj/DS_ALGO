using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class Node
    {
        public Node(string key, int value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public int Value { get; set; }
    }
    public class HashTableImplementation
    {
        public class Nodes : List<Node> { };
        private int hashSize;
        private Nodes[] hashTable;

        public HashTableImplementation(int size)
        {
            hashTable = new Nodes[size];
            hashSize = size;
        }

        private int FindHashLocation(string key)
        {
            int location = 0;

            for(int i = 0; i < key.Length; i++)
            {
                location = (location + (int)key[i] * i) % hashSize;
            }

            return location;
        }

        public Nodes[] SetValue (string key, int value )
        {
            int address = FindHashLocation(key);

            Node node = new Node(key , value);

            if(hashTable[address] == null)
            {
                hashTable[address] = new Nodes() { node };
            }

            else
            {
                hashTable[address].Add(node);
            }

            return hashTable;
        }

        public int GetValue(string key)
        {
            int location = FindHashLocation(key);

            var currentBucket = hashTable[location];
            if(currentBucket != null)
            {
                for(int i = 0; i < currentBucket.Count; i++)
                {
                    if(currentBucket[i].Key == key)
                    {
                        return currentBucket[i].Value;
                    }
                }
            }

            return 0;
        }

        public List<string> GetKeys()
        {
            var keys = new List<string>();
            for(int i = 0; i < hashTable.Length; i++)
            {
                if(hashTable[i] != null)
                {
                    foreach(var item  in hashTable[i])
                    {
                        keys.Add(item.Key);
                    }
                }
            }

            return keys;
        }
    }
}
