
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_determinant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            int determinant=0;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter a number:");
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                
                }
            
            }
            Console.WriteLine("*******Matrice******");
            for (int k = 0; k < 3; k++)
            {
                for (int m = 0; m < 3; m++)
                {
                    Console.Write("{0}",array[k,m]+" ");
                    
                 
                }
                Console.WriteLine("");

            }
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    determinant += (array[x, 0] * array[(x + 1) % 3, 1] * array[(x + 2) % 3, 2]) - (array[x, 2] * array[(x + 1) % 3, 1] * array[(x + 2) % 3, 0]);

                }

            }
            Console.WriteLine("determinant:{0}",determinant);
            Console.ReadLine();
        }
    }
}
