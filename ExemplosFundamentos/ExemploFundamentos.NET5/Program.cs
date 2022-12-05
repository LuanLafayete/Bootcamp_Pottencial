using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] p;

            for (int contador = 0; contador < n; contador++)
            {                
                p = Console.ReadLine().Split(' ');
                string A = p[0];
                string B = p[1];            
                
                if (A.Length == B.Length)
                {
                    Console.WriteLine("encaixa");
                }
                else if(A.EndsWith(B))       
                {
                    Console.WriteLine("encaixa");
                }
                else
                {
                    Console.WriteLine("nao encaixa");
                }
            }
        }

    }
}