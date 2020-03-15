using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {        
        static void Main(string[] args)
        {
            List<int> dv = DataEntry();
            Controller(dv);              
        }

        static List<int> DataEntry()
        {
            int x;
            List<int> a = new List<int>();

            do
            {
                Console.WriteLine("Enter elements (1-10): ");
             
                x = Convert.ToInt32(Console.ReadLine());
            }while( x < 0 || x > 10) ;

                    // a = new int[x];
                for (int i = 0; i < x; i++)
                {
                
                    Console.WriteLine($"Enter value for element {i} : ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (x > -1 && x < 11)
                    {
                        a.Add(y);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry");
                    }
                }
            return a;
        }

        static IEnumerable<int> SortIT(List<int> a) 
        {
            // LINQ & Lambda expression follows
            IEnumerable<int> sd = a.OrderByDescending(v => v);
            Console.WriteLine("Your list is : ");
            
            return sd;      
        }

        static string FindIT(List<int> a) 
        {
            Console.WriteLine("Enter value to search for : ");
            int vl = Convert.ToInt32(Console.ReadLine());

           int ec = a.Count(v => v == vl);
            if (ec > 0)
            {
                return "\nValue found";
                
            }
            else 
            {
                return "\nNo match";
            }
            
        }

        static void Controller(List<int> a) 
        {
            // List<int> dv;
            Console.WriteLine("1. Find Value");
            Console.WriteLine("2. View List");
            Console.WriteLine("3. Quit");
            int x = Convert.ToInt32(Console.ReadLine());
            
                switch (x)
                {
                    case 1:
                    Console.WriteLine(FindIT(a));    
                        break;
                    case 2:
                        //IEnumerable<int> ev = SortIT(a);
                        foreach (int e in a)
                            Console.WriteLine(e);
                        break;
                    case 3:
                        break;
                }
                

           
        }
        
    }
}