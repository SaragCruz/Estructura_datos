using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Problema5
{
    class program
    {
        static void Main(string[] args)

        {
            Queue colac1 = new Queue();
            Queue colac2 = new Queue();
            Queue colac3 = new Queue();

            colac1.Enqueue(1);
            colac1.Enqueue(2);
            colac1.Enqueue(3);


            while(colac1.Count > 0)
            {
                int co = 0;
                co = (int)colac1.Dequeue();
                Console.WriteLine($"cola1: {co}");
                
            }
            
        }
    }
}
