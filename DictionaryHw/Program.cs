using System;
using System.Collections.Generic;

namespace DictionaryHw
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> nameList = new MyDictionary<int, string>();
            nameList.Add(78, "Süeda");
            nameList.Add(86, "Burcu");



            Console.WriteLine(nameList);


        }
    }
}
