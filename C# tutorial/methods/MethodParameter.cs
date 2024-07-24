using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial.methods
{
    internal class MethodParameter
    {
      class Program
        {
            //public static void Main(string[] args)
            //{
            //    int i = 0;
            //    SingleMethod(ref i);
            //    Console.WriteLine(i);
            //}

            //// value parameter type is without ref
            //public static void SingleMethod (ref int j) // ref changes the value parameter to refrence parameter 
            //{
            //    // using the ref will call j instead of I because of the ref added 
            //    j = 101;
            //}

            //////////
            //Output (out) Parameter is use when you want a method to return more than one value
            //public static void Main(string[] args)
            //{
            //    int Total = 0;
            //    int Product = 0;
            //    Calculate(10, 20, out Total, out Product);
            //    Console.WriteLine("sum ={0} && Product = {1}", Total, Product);
            //}

            //public static void Calculate(int FN, int SN, out int Sum, out int Product)
            //{
            //    Sum = FN + SN;
            //    Product = FN * SN;
            //} 

            ///////////////
            ////Array parameter
            //public static void Main(string[] args)
            //{
            //    // Create an array of integers called "Numbers" with a length of 3.
            //    int[] Numbers = new int[3];

            //    // Assign specific values to the elements of the "Numbers" array.
            //    Numbers[0] = 101;
            //    Numbers[1] = 102;
            //    Numbers[2] = 103;

            //    //Call the ParamsMethod
            //    ParamsMethod();
            //    ParamsMethod(Numbers);
            //    ParamsMethod(1, 2, 3, 4, 5);
            //}
            //// we uses the keyword params for array parameter
            //// Define a method called ParamsMethod that accepts a variable number of integer arguments.
            //// The "params" keyword allows us to pass an array of integers or individual integers.
            //public static void ParamsMethod(params int[] Numbers)
            //{
            //    // Print the number of elements in the "Numbers" array.
            //    Console.WriteLine("There are {0} elements", Numbers.Length);

            //    // Iterate through each element in the array and print its value.
            //    foreach (int i in Numbers)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


        }
    }
}
