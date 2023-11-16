using System;

namespace Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(3, "Alper");
            myDictionary.Add(34, "Nevzat");
            myDictionary.Add(26, "Kaan");

            myDictionary.List();
            Console.WriteLine(myDictionary.Count);
            myDictionary.ID();
        }
    }
}
