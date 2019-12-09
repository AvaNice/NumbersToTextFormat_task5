using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToTextFormat
{
    class NumbersToTextUI
    {
        public int GetUserNumber()
        {
            int input;

            Console.Write(TextMessages.ENTER_NUMBER);

            input = Convert.ToInt32(Console.ReadLine());
            
            return input;
        }

        public void Show(string result)
        {
            Console.WriteLine(result);
        }
    }
}
