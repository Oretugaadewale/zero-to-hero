using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial.Abstract
{
    //Abstract
    //public abstract class Customer 
    //{
    //    public abstract void Print();  
    //}

    //public class Program:Customer
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine("How are you wale");
    //    }
    //    static void Main(string[] args)
    //    {
    //        //Program P = new Program();
    //        //P.Print();
    //        Customer c = new Program();
    //        c.Print();

    //   }
    //}

    //abstract
    //public abstract class Sum
    //{
    //    public abstract int Answer();
    //}
    //public class Calculate : Sum
    //{
    //    public override int Answer()
    //    {
    //        int a = 5; int b = 6;
    //        return a + b;
    //    }
    //    public static void Main()
    //    {
    //        Calculate C = new Calculate();
    //        int Result = C.Answer();
    //        Console.WriteLine(Result);
    //    }
    //}

    // diff btw abstract and interface
    //public abstract class Customer
    //{
    //    // abstract accept both field and implementation in its method
    //    int ID;
    //    public void Print()
    //    {
    //        Console.WriteLine("This is abstract");
    //    }
    //}

    //interface
    //public interface ICustomer
    //{
    //// this wont work interface method wont accept field or implementation
    //    void Print();
    //    //int Id
    //}
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {

        //}
   // }
}



