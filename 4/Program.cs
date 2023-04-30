using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        List<int> Nodenondi = new List<int>();
        for (int i = 0; ; i++)
        {
            int Firstnode = int.Parse(Console.ReadLine());
            if (Firstnode >= size || Firstnode < 0)
            {
                break;
            }
            int Secondnode = int.Parse(Console.ReadLine());
            if (Secondnode >= size || Secondnode < 0)
            {
                break;
            }
            if (Firstnode == Secondnode)
            {
                break;
            }
            else
            {
                Nodenondi.Add(Firstnode);
                Nodenondi.Add(Secondnode);
            }
        }

        List<int> usedNodes = Nodenondi.Select(x => x % size).Distinct().ToList();
        int countNodes = usedNodes.Count - 2;
        Console.WriteLine("Output is : {0}", countNodes);
    }
}