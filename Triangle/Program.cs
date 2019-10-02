using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//created project named triangle//
namespace Triangle
{
    class Program
    {
        public static int Menu_Select()
        {
            string my_input = string.Empty;
            bool loop_flag = false;
            //selecting options using while loop//
            while (loop_flag == false)

            {
                Console.WriteLine("1----->Please enter triangle dimensions.");
                Console.WriteLine("2----->To exit.\n");
                Console.WriteLine("Select from the options given above:\n");

                my_input = Console.ReadLine();

                if (my_input != "1" && my_input != "2")

                {
                    Console.WriteLine("Not a valid option, select again:\n");
                }

                else

                {
                    loop_flag = true;
                }
            }

            Console.WriteLine();
            return int.Parse(my_input);
        }

        public static int Input_Validation(string option_selected)
        {
            int tNumber = 1;
            bool isRight = false;

            while (isRight == false)

            {
                Console.WriteLine($"Enter {option_selected} of the triangle:");
                string my_input = Console.ReadLine();
                Console.WriteLine();

                bool result = (int.TryParse(my_input, out tNumber));
                //using if and else if// 
                if (result == false)

                {
                    Console.WriteLine("Not a valid input, please try again with integer values above zero\n");
                }

                else if (tNumber == 0)

                {
                    Console.WriteLine("Side cannot be zero.\n");
                }

                else if (tNumber < 0)

                {
                    Console.WriteLine("Side cannot be zero.\n");
                }

                else if (tNumber > 25852)

                {
                    Console.WriteLine("Maximum integer range is 25852\n");
                }

                else

                {
                    isRight = true;
                    Console.WriteLine($"{option_selected} of triangle is: {tNumber}.\n");
                }
            }

            return tNumber;
        }


        static void Main(string[] args)
        {
            int option;
            option = Menu_Select();

            while (option != 2)
            {
                //using switch case for validation and printing sides//
                switch (option)

                {
                    case 1:

                        int SideA;
                        int SideB;
                        int SideC;

                        SideA = Input_Validation("Side A");
                        SideB = Input_Validation("Side B");
                        SideC = Input_Validation("Side C");

                        Console.WriteLine("Given sides of triangle are {0}, {1} and {2}\n", SideA, SideB, SideC);
                        Console.WriteLine(TriangleSolver.Analyze(SideA, SideB, SideC));
                        break;

                        default:
                        break;
                }

                option = Menu_Select();

            }

        }
    }
}
