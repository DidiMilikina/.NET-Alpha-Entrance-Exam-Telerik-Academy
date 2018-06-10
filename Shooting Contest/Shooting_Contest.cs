using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting_Contest
{
    class Shooting_Contest
    {
        static void Main(string[] args)
        {
            long numberOfTargets = long.Parse(Console.ReadLine());
            long georgeSpeed = long.Parse(Console.ReadLine());
            long georgeLatency = long.Parse(Console.ReadLine());
            long peterSpeed = long.Parse(Console.ReadLine());
            long peterLatency = long.Parse(Console.ReadLine());

            long george = georgeLatency * 2 + numberOfTargets * georgeSpeed;
            long peter = peterLatency * 2 + numberOfTargets * peterSpeed;

            if (george < peter)
            {
                Console.WriteLine("George");
            }
            else if (george > peter)
            {
                Console.WriteLine("Peter");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
