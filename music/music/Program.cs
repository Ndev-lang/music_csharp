using System;
using System.Threading;
using System.Collections.Generic;
namespace music
{
    class ms
    {
        static void Main()
        {
            
            Console.WriteLine("write music:");
            List<string> ms = new List<string>();
            string m;
            int c = 0;
            while (true)
            {
                c += 1;
                m = Console.ReadLine();
                ms.Add(m);
                if (c == 16)
                {
                    break;
                }
            }
            Console.WriteLine("music:");
            foreach (string tx in ms)
            {
                Thread.Sleep(2000);
                Console.WriteLine("========================================");
                Console.WriteLine("♫ " + tx + " ♫");
            }
            Console.ReadLine();
        }
    }
}
