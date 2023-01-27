using System;

namespace Brogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 11, 40, 40, 11, 12, 13, 14, 15, 16, 17, 18, 18, 1, 1, 1, 69 };
            List<int> list = new List<int>();
            
            for (int i = 0; i < Array.Length; i++)
            { 
                int Test = Array[i];
                for (int j = 0; j < Array.Length; j++)
                {
                    if (Test == Array[j] && j != i)
                    {
                        if (!list.Contains(Array[j]))
                        {
                            list.Add(Array[j]);
                        }
                    }
                }
            }
            if (list.Count > 0)
            {
                Console.Write("Dessa siffror förkommer mer än en gång: ");
                foreach (int i in list)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}