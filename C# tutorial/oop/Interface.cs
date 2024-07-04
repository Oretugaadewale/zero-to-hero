using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial.oop
{
    //interface Icustomer1
    //{
    //    void Print1();
    //}

    //interface Icustomer2 : Icustomer1
    //{
    //    void Print2();
    //}

    //public class Customer : Icustomer2
    //{
    //    public void Print2()
    //    {
    //        Console.WriteLine("print 2");
    //    }

    //    public void Print1()
    //    {
    //        Console.WriteLine("print 1");
    //    }

    //    public static void Main()
    //    {
    //        Customer C = new Customer();
    //        C.Print1();
    //        C.Print2();
    //    }
    //}


    //internal class Interface
    //{
    //  interface Icustomer
    //    {
    //        void Print();
    //    }

    //    interface I2
    //    {
    //        void Answer();
    //    }
    //      class can inherit multiple interface
    //    class Customer : Icustomer, I2
    //    {
    //        public void Answer()
    //        {
    //            Console.WriteLine("interface inheritance 2");
    //        }

    //        public void Print()
    //        {
    //            Console.WriteLine("hello interface");
    //        }
    //    }


    //    public static void Main(string[] args)
    //    {
    //        Customer C = new Customer();
    //        C.Print(); 
    //        C.Answer();
    //    }
    //}


    //Explicit class Interface

    //interface I1
    //{
    //    void InterfaceMethod();
    //}

    //interface I2
    //{
    //    void InterfaceMethod();
    //}

    //public class Program : I1, I2
    //{
    //    void I1.InterfaceMethod() // you dont use access modifier here
    //    {
    //        Console.WriteLine("hello I1 ");
    //    }

    //    void I2.InterfaceMethod()
    //    {
    //        Console.WriteLine("hello I2 ");
    //    }


    //    public static void Main()
    //    {
    //        // we can use any of this to call the method
    //        //Program P = new Program();
    //        //((I1)P).InterfaceMethod();
    //        //((I2)P).InterfaceMethod();

    //        I1 i1 = new Program();
    //        I2 i2 = new Program();
    //        i1.InterfaceMethod();
    //        i2.InterfaceMethod();
    //    }
    //}

   

}

