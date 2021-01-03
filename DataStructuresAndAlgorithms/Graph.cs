﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class Graph
    {
        private Dictionary<int, List<int>> adjacentList;
        private int numberOfNodes;

        public Graph()
        {
            adjacentList = new Dictionary<int, List<int>>();
            numberOfNodes = 0;
        }

        public void AddVertex(int value)
        {
            adjacentList.Add(value, new List<int>());
            numberOfNodes++;
        }

        public void AddEdges(int value1, int value2)
        {
            adjacentList[value1].Add(value2);
            adjacentList[value2].Add(value1);
        }

        public void ShowConnections()
        {
            foreach (var item in adjacentList)
            {
                List<int> nodeConnections = adjacentList[item.Key];
                StringBuilder connections = new StringBuilder();
                foreach (int edge in nodeConnections)
                {
                    connections.Append(edge).Append(" ");
                }
                Console.WriteLine(item.Key + "-->" + connections);
            }
        }
    }
}
