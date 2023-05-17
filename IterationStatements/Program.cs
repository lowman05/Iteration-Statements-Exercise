using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //for(int i = 0; i < 5; i++) 
        //    {
        //      Console.WriteLine(i);             
        //    }
        //for(int i = 0; i < 5; i++)
        //    {
        //      Console.WriteLine(i);
        //    }
        //for (int i = 0; i < 5; i++)
        //    { 
        //      Console.WriteLine(i);
        //    } 
        //for (int i = 0; i < 5; i++)
        //    {
        //      Console.WriteLine(i);
        //    }
        //for (int i = 0; i < 5; i++)
        //    {
        //      Console.WriteLine(i);
        //    }
        //for (int i = 0; i < 5; i++)
        //    {
        //      Console.WriteLine(i);
        //    }
        /*for (int i = 0; i < 5; i++)
              {
                Console.WriteLine(i);
              }
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }*/
        

        
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintTwoThousand();
            Triples();
            EqualOrNot(1, 2);
            EvenOrOdd();
            PosOrNeg();
            OfVotingAge();
            InRange();
            TimesTable();
        }

        public static void TimesTable()
        {
            Console.WriteLine("Enter a number to get multiplication table");
            var myNum=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(myNum * i); 
            }
        }

        public static void InRange()
        {
            Console.WriteLine("Please enter a number");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num >= -10 && num <= 10)
            {
                Console.WriteLine("The number you chose is in range");
            }
            else
                Console.WriteLine("The number you chose is out of range");          
        }
        public static void OfVotingAge()
        {
            Console.WriteLine("Enter your age");
            var i = Convert.ToInt32(Console.ReadLine());

            if (i > 18)
            {
                Console.WriteLine("You can vote");
            }
            else
                Console.WriteLine("Sorry, you are not yet old enough to vote");
        }       
        public static void PosOrNeg()
        {
            Console.WriteLine("Enter a number");
            var i = Convert.ToInt32(Console.ReadLine());

            if (i > 0)
            {
                Console.WriteLine($"The number {i} is positive");
            }
            else 
                Console.WriteLine($"The number {i} is negative");
        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number");
            var i = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine($"The number {i} is even.");
            }
            else 
                Console.WriteLine($"The number {i} is odd."); 
            
        }
            public static void EqualOrNot(int num1, int num2)
            {

                var equality = (num1 == num2) ? true : false;
                Console.WriteLine(equality);

            }
            public static void Triples()
            {
                for (int h = 3; h <= 999; h += 3)
                {
                    Console.WriteLine(h);
                }
            }
            public static void PrintTwoThousand()
            {
                for (int i = 1000; i >= -1000; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
