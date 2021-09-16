using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_SnakeLadder
{
    class UC2_Between1to6
    {
        public static void randomplayer()
        {
            Random random = new Random();
            Console.WriteLine("Random Die ");
            for (int die = 0; die < 7; die++)
            {
                Console.WriteLine(random.Next(0, 7));
            }

            //Console.ReadLine();
        }

    }
}
