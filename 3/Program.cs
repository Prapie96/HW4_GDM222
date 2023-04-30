using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int numbernode = int.Parse(Console.ReadLine());

        List<int> edges = new List<int>();
        while (true)
        {
            int edge = int.Parse(Console.ReadLine());
            if (edge >= numbernode || edge < 0)
            {
                break;
            }
            edges.Add(edge);
        }

        int sourcenode = int.Parse(Console.ReadLine());
        int destinationnode = int.Parse(Console.ReadLine());

        int[,] adjMatrix = new int[numbernode, numbernode];
        for (int i = 0; i < edges.Count; i += 2)
        {
            int NodeA = edges[i];
            int NodeB= edges[i + 1];
            adjMatrix[NodeA, NodeB] = 1;
        }

        int[,] path = (int[,])adjMatrix.Clone();
        for (int k = 0; k < numbernode; k++)
        {
            for (int i = 0; i < numbernode; i++)
            {
                for (int j = 0; j < numbernode; j++)
                {
                    path[i, j] = path[i, j] == 1 || (path[i, k] == 1 && path[k, j] == 1) ? 1 : 0;
                }
            }
        }

        if (path[sourcenode, destinationnode] == 1)
        {
            Console.WriteLine("Reachable");
        }
        else
        {
            Console.WriteLine("Unreachable");
        }
         }
}   
