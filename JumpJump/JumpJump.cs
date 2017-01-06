using System;
using System.Linq;

namespace JumpJump
{
    class JumpJump
    {
        static void Main()
        {
            //                     0123456789
            string instructions = "201";
            for (int step = 0; step <= instructions.Length;)
            {
                if ((int)Char.GetNumericValue(instructions[step]) % 2 == 0)
                {
                    step += instructions[step] - '0';
                }
                else if (instructions[step] % 2 != 0)
                {
                    step -= instructions[step] - '0';
                }
                else if (instructions[step] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", step);
                    break;
                }
            }
        }
    }
}
