

using System.ComponentModel.Design;
using System.Text.Json;

namespace C__tutorial.Conditional_Statement
{
    internal class Conditional
    {
        // conditional statement
       public void Statement()
        {
            // int x = 40;
            // int y = 30;
            // int z = 50;
            // if (y > z)
            // {
            //     Console.WriteLine("y is greater");
            // }
            // else if (y > x)  
            // {
            //     Console.WriteLine("x is greater");
            // }
            //else
            // {
            //     Console.WriteLine(" z is the greatest");
            // } 
            // ternary operator
            //int age = 20;
            //int year = 2024; 
            //var result = (age >= 20 && year == 2024) ? "your age is 20 and year is 2024" : "you are lower than 20 and not 2024";
            //Console.WriteLine(result);

            //Console.WriteLine("Please enter a number");
            //int myData = int.Parse(Console.ReadLine());
            //if (myData == 10 || myData == 20)
            //{
            //    Console.WriteLine("correct");
            //}
            //else
            //{
            //    Console.WriteLine("incorrect");
            //}

            //convert int to string and ternary operator
            //Console.WriteLine("enter your age");
            //string question = Console.ReadLine();
            //int age = Convert.ToInt32(question);
            //string newAge = age.ToString();
            //var totalAge = (age > 20) ? "you are older" : "you are younger ";
            //Console.WriteLine(totalAge);

            //Console.WriteLine("Please enter a number");
            //int myData = int.Parse(Console.ReadLine());
            //       switch
            //        switch (myData)
            //        {
            //            case 10:
            //                Console.WriteLine("you entered 10");
            //                break;

            //            case 20:
            //                Console.WriteLine("you entered 20");
            //                break;

            //            case 30:
            //                Console.WriteLine("you entered 30");
            //            break;
            //            default:
            //              Console.WriteLine("you didnt entered 10, 20, or 30");
            //              break;
            //        }
            //switch (myData)
            //{
            //    case 10:
            //    case 20:
            //    case 30:
            //        Console.WriteLine("you type {0}", myData);
            //        break;
            //        default:
            //        Console.WriteLine("you didnt type 10, 20, 30");
            //        break;
            //        default:
            //        Console.WriteLine("you didnt entered 10, 20, or 30");
            //        break;
            //}

            //switch, goto and break statement, but not good to use goto statement
            int TotalCoffeeCost = 0;
            // start is to enable the programe to run again from start and its called LABEL
            Start:
            Console.WriteLine("Please Select Your coffe Size: 1 - Small, 2 - Medium, 3 - large");
            int UserChoice = int.Parse(Console.ReadLine());
            switch(UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1; 
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;
                case 3:
                    TotalCoffeeCost += 3;
                    break;
                    default:
                    Console.WriteLine("your choice {0} is invalid", UserChoice);
                    goto Start;
                    // goto case 1;
            }
        Decide:
            Console.WriteLine("Do you want to buy another coffe - Yes or No?");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                    default:
                    Console.WriteLine("Your choice of {0} is invalid please try again", UserDecision);
                    goto Decide;
            }
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
        }

    }
}