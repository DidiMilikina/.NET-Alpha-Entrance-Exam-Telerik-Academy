using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_code
{
    class Alien_code
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var beggining = '\0';
            var end = '\0';
            var current = 0;
            var currentLetter = '\0';
            var output = "";

            for (var i = 0; i < input.Length / 2; i++)
            {
                beggining = input[i];
                end = input[input.Length - 1 - i];

                if (beggining == ' ' || end == ' ')
                {
                    currentLetter = ' ';
                }
                else
                {
                    current = Math.Abs(beggining - end);
                    currentLetter = (char)(current + 97);
                }

                output += currentLetter;
            }

            if (input.Length % 2 == 1)
                output += input[input.Length / 2];

            Console.Write(output);
        }
    }
}
