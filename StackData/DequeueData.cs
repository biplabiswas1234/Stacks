using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackDataStructure
{
    internal class DequeueData
    {
        Queue<int> Number = new Queue<int>();
        public void Display()
        {
            Number.Enqueue(56);
            Number.Enqueue(30);
            Number.Enqueue(70);
            Console.WriteLine("Before dequeue");
            foreach (int i in Number)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("After dequeue");
            //Number.Dequeue();
            //Number.Dequeue();
            //Number.Dequeue();
            int count=Number.Count;
            for(int i = 0; i <count; i++)
            {
                Number.Dequeue();
                Console.WriteLine("After {0}th dequeue" ,i+1);
                foreach (int j in Number)
                {
                    Console.WriteLine(j);
                }

            }
        }

    }
}
