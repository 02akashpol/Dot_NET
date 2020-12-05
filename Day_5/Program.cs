using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDACBatchesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number batches in CDAC");
            int size = Convert.ToInt32(Console.ReadLine());

            int[][][] CDACBatches = new int[size][][];

            for(int i=0; i<size; i++)
            {
                Console.WriteLine("Enter the number of students in {0} batch : ", i+1);
                int stdBatch =  Convert.ToInt32(Console.ReadLine());

                CDACBatches[i] = new int[stdBatch][];

                for(int j=0; j<stdBatch; j++)
                {
                    CDACBatches[i][j] = new int[2];

                    Console.WriteLine("Enter the {0} student marks of CPP module from the {1} batch : ", j+1, i+1);
                    int CPP = Convert.ToInt32(Console.ReadLine());

                    CDACBatches[i][j][0] = CPP;

                    Console.WriteLine("Enter the {0} student marks of CPP module from the {1} batch : ", j+1, i+1);
                    int DS = Convert.ToInt32(Console.ReadLine());

                    CDACBatches[i][j][1] = DS;
                }
            }

            for(int i=0; i<CDACBatches.Length; i++)
            {
                for(int j=0; j<CDACBatches[i].Length; j++)
                {
                    Console.WriteLine("{0} Student marks from {1} batch : ", j+1, i+1);
                    Console.WriteLine("CPP : "+ CDACBatches[i][j][0]);
                    Console.WriteLine("DS : " + CDACBatches[i][j][1]);
                }
            }

            Console.ReadLine();
        }
    }
}
