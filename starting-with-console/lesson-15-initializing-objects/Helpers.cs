namespace lesson_15_initializing_objects
{
    class Helpers
    {
     public static string TryPluralize(double Quantity, string Value){
        //  if(Quantity>1)
        //     return $"{Value}s";
        //  else
        //     return $"{Value}";

        var ReturnValue=Quantity>1?$"{Value}s":$"{Value}";
        return ReturnValue;
     }   
    }
}