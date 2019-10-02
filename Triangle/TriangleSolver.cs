using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//computational side//
namespace Triangle
{
    public static class TriangleSolver
        {
        //initializing sides//
        public static string Analyze(int SideA, int SideB, int SideC)
        {
            string return_string = string.Empty;
            int longest = 0;
            //conditions for triangle using if else//
            if (SideA > SideB)
            {
                if (SideA > SideC)

                {
                    longest = SideA;
                }

                else

                {

                    longest = SideC;
                }
            }

            else if (SideB > SideC)

            {
                longest = SideB;
            }

            else

            {
                longest = SideC;
            }

            int sum_of_sides = SideA + SideB + SideC;
            int sum_of_smaller_sides = sum_of_sides - longest;

            string type_of_triangle = string.Empty;
            string triangle = string.Empty;

            if (sum_of_smaller_sides > longest)
            {
             triangle = "Triangle formed\n";

                if ((SideA != SideB) && (SideA != SideC) && (SideB != SideC))

                {
                    type_of_triangle = " Formed Triangle is Scalene\n";
                }

                else if ((SideA == SideB) && (SideB == SideC))
                {
                            type_of_triangle = " Formed Triangle is Equilateral Triangle\n";
                }

                else

                {
                    type_of_triangle = "Formed Triangle is Isosceles\n";
                }

                return_string = triangle + type_of_triangle;
            }

            else

            {
                return_string = "No triangle can be formed\n";
            }

            return return_string;
        }
    }
}
