using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial.oop
{
    internal class Delegate
    {
        //public delegate void HelloFunctionDelegate(string Message);

        //class Pragim
        //{
        //    public static void Main()
        //    {
        //        // calling the instance
        //        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        //        del("hello from delegate");
        //    }

        //    // signature method must match delegate i mean the (void) 
        //    public static void Hello(string strMessage)
        //    {
        //        Console.WriteLine(strMessage);
        //    }
        //}

        // DELEGATE USEAGE
        //    class Pragim
        //    {
        //        public static void Main()
        //        {
        //            // Create a list to store Employee objects
        //            List<Employee> empList = new List<Employee>();

        //            // Add Employee objects to the list with their details
        //            empList.Add(new Employee { ID = 101, Name = "Mary", Salary = 500, Experience = 5 });
        //            empList.Add(new Employee { ID = 102, Name = "Mike", Salary = 400, Experience = 4 });
        //            empList.Add(new Employee { ID = 103, Name = "John", Salary = 600, Experience = 6 });
        //            empList.Add(new Employee { ID = 104, Name = "Todd", Salary = 300, Experience = 3 });

        //            // Call the PromoteEmployee method and pass the list of employees and a condition for promotion
        //            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
        //        }

        //    }

        //    // Define a delegate that takes an Employee object and returns a boolean
        //    delegate bool IsPromotable(Employee empl);

        //    class Employee
        //    {
        //        public int ID { get; set; } // Property to store the employee’s ID.
        //        public string Name { get; set; } // Property to store the employee’s Name.
        //        public int Salary { get; set; } // Property to store the employee’s Salary.
        //        public int Experience { get; set; } // Property to store the employee’s Experience.

        //        // Defines a static method named PromoteEmployee that takes a list of Employee objects and a delegate as arguments.
        //        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligibleToPromote)
        //        {
        //            // Loop through each employee in the list
        //            foreach (Employee employee in employeeList)
        //            {
        //                // Check if the employee is eligible for promotion using the delegate
        //                if (isEligibleToPromote(employee))
        //                {
        //                    // Print the employee's name followed by "promoted" if they are eligible
        //                    Console.WriteLine(employee.Name + " promoted");
        //                }
        //            }
        //        }
        //    }


        // multicast delegate
        

    }

    }
