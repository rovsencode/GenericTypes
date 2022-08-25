using GenericTypes.Models;
using System;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {


           Mylist <int> list = new Mylist <int> (3);
            list.Add(4);
            list.Add(5);
            list.Add(7);
            list.Add(8);
            //  list.Clear();
         //   list.Remove(5);
             //list.reverse();
           

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
          //  Console.WriteLine("index: " + list.LastIndexof(7));



        }

    }
}
