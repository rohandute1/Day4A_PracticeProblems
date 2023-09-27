using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A_PracticeProblem
{
    class Addition
    {
        public static Logger log = LogManager.GetCurrentClassLogger();
        public void Sum(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                log.Error("Please enter positive intergers only.");
                Console.WriteLine("Please enter positive intergers only.");
            }
            else
            {
                int add = x + y;
                Console.WriteLine("Addition of two positive integers: " + add);
                log.Info("Addition of two positive integers: " + add);
            }
        }
    }
}
