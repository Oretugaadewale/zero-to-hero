//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__tutorial.StaticandInstance
//{
//    class Circle
//    {
//        // we use static on PI because it constant it doesn't change
//        static float _PI = 3.141f; // declared PI ALREADY
//        int _Radius;

//        public Circle(int Radius) 
//        {
//            this._Radius = Radius;
//            // we had already declare PI NO need to add it here
//        }

//        // if method is static and not an instance
//        public  static void Print()
//        {
//            // static
//        }
//        public float CalculateArea()
//        {
//            // we us circle.pi because PI is static this keyowrd wont work for static 
//            return Circle._PI * this._Radius * this._Radius;
//        }

//        public static void Main(string[] args)
//        {
//            Circle C1 = new Circle(5);
//            float Area1 = C1.CalculateArea();
//            //here is how will call it if its static
//            //Circle.Print();
//            Console.WriteLine("Area = {0}", Area1);

//            Circle C2 = new Circle(6);
//            float Area2 = C2.CalculateArea();
//            Console.WriteLine("Area = {0}", Area2);
//        }
//    }


//}
