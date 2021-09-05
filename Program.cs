using System;

class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite n: ");
            int n = int.Parse(Console.ReadLine());
            int i;
            
            for (i=1;i<=10000;i++){        
                if (i%n==2){                    
                    Console.WriteLine(i);
                }
            }
        }
    }