using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace lesson_10_repeating_program_steps
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            int[] arrayOfInts = { 6, 8, 9, 0, 2, 5, 45 };
            for (int i = 0; i < arrayOfInts.Length; i++)
            {
             //dostuff   
            }
            //List
            List<string> Names=new List<string>(){
            "James Robinson",
            "James Paterson",
            "Smith Rogers"
            };
            foreach (var Name in Names)
            {
             System.Console.WriteLine(Name);
            }
            //ObservableCollection
            ObservableCollection<string> NamesOfPeople=new ObservableCollection<string>(){
            "Smith Rogers",
            "James Paterson",
            "James Robinson"
            };
              foreach (var Name in NamesOfPeople)
            {
             System.Console.WriteLine(Name);
            }
            while (true)
            {
               //do stuff 
            }
        }
        }
    
    }
