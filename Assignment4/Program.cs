using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList list= new ArrayList() { "Boat", "house", "cat", "river", "cupboard" };
            Console.WriteLine("plurals :");
            for (int i= 0;i<list.Count;i++)
            Console.WriteLine(list[i]+"s");

            list[1] = "home";
            Console.WriteLine("\nElemenr at 2 :");
            Console.WriteLine(list[1]);


            list.Add("songare");
            Console.WriteLine("\nNO of elements:");
            Console.WriteLine(list.Count);

            Console.WriteLine("\nElement of length 7 :");
            for (int i = 0; i <list.Count; i++)
            {
                string s = (string)list[i];
                if(s.Length==7)
                Console.WriteLine(s);
            }

            Console.WriteLine("\nElemenr at 3 position :");
            Console.WriteLine(list[2]);

            Console.WriteLine("\nElements in acsending order :");
            list.Sort();
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            Console.WriteLine("\nElements in reverse order :");
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
            Console.ReadLine();
        }
    }
}
