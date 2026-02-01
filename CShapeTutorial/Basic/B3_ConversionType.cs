using System;

namespace CShapeTutorial.Basic
{
    public class B3_ConversionType
    {
        // Boxing and Unboxing
        // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
        public void ImplicitConversion()
        {
            int myInt = 13;
            double myDouble = myInt; 
            Console.WriteLine($"Implicit Conversion: {myInt} -> {myDouble}");
        }

        public void ExplicitConversion()
        {
            long myLong = 1234;
            int myInt = (int) myLong;
            Console.WriteLine($"Explicit Conversion: {myLong} -> {myInt}");
        }

        public void ConversionHelperParse()
        {
            int myInt = int.Parse("1234");
            string boolString = "true";
            bool myBool = Convert.ToBoolean(boolString);
        }
        
        public void ConversionExample()
        {
            ImplicitConversion();
            ExplicitConversion();
        }
    }
}