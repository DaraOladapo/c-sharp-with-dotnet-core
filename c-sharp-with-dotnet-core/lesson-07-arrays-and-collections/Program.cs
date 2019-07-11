using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace lesson_07_arrays_and_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            string[] arrayOfStrings = new string[5];
            arrayOfStrings[2] = "Jill and Scott";
            int[] arrayOfInts = { 6, 8, 9, 0, 2, 5, 45 };
            var intAtIndex5 = arrayOfInts[5];
            //System.Console.WriteLine(intAtIndex5);
            //System.Console.WriteLine(arrayOfStrings[2]);

            //List
            List<string> Names = new List<string>(){
            "James Robinson",
            "James Paterson",
            "Smith Rogers"
            };
            foreach (var Name in Names)
            {
                System.Console.WriteLine(Name);
            }
            //ObservableCollection
            ObservableCollection<string> NamesOfPeople = new ObservableCollection<string>(){
            "Smith Rogers",
            "James Paterson",
            "James Robinson"
            };
            foreach (var Name in NamesOfPeople)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
