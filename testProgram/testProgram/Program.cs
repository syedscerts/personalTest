using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the rows of the pyramid:");
            int rowNum = Convert.ToInt32(Console.ReadLine());
            do
            {
                DrawPyramid(rowNum);
                Console.Write("Enter the rows of the pyramid:");
                rowNum = Convert.ToInt32(Console.ReadLine());
            } while (rowNum != 0);




        }
        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
