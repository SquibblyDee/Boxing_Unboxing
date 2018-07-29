using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boxing/Unboxing:");
            // Create an empty List of type object
            List<object> boxedList = new List<object>();
            // Add the following values to the list: 7, 28, -1, true, "chair"
            boxedList.Add(7);
            boxedList.Add(28);
            boxedList.Add(-1);
            boxedList.Add(true);
            boxedList.Add("chair");
            // Loop through the list and print all values (Hint: Type Inference might help here!)
            int sum = 0;
            foreach(var index in boxedList)
            {
                Console.WriteLine(index);
                // Add all values that are Int type together and output the sum
                if(index is int)
                {
                    int integer = Convert.ToInt32(index);
                    sum+=integer;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
