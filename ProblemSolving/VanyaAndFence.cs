using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.ProblemSolving
{
    internal class VanyaAndFence
    {
        public VanyaAndFence()
        {
            var lineOne = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var lineTwo = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            int roadWidth = 0;
            for (int i = 0; i <lineOne[0]; i++)
            {
                if (lineTwo[i] > lineOne[1])
                {
                    roadWidth += 2;
                }
                else
                {
                    roadWidth++; 
                }
            }

            Console.WriteLine(roadWidth);

        }
    }
}
