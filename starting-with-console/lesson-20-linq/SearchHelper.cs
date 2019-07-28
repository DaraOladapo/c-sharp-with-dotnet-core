using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson_20_linq
{
    class SearchHelper
    {
public static void FindAndReplace(List<string> Names, string inputString)
        {
            try
            {
                var Name = Names.First<string>(opt => opt.ToLower().Contains(inputString));
                var NameToReplace = Name;
                var IndexToReplace = Names.IndexOf(Name);
                System.Console.WriteLine($"What do you want to replace {Name} with?");
                var Replacement = Console.ReadLine();
                Names[IndexToReplace] = Replacement;
                Console.WriteLine($"{NameToReplace} has been changed to {Names[IndexToReplace]}");
            }
            catch
            {
                Console.WriteLine($"Nothing found or something went on very baaad.");
            }
        }
    }
}
