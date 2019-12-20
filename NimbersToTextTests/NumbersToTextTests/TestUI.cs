using NumbersToTextFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToTextTests
{
    class TestUI : INumbersToTextUI
    {
        public string UsetInput { get; set; }
        public string UserOutput { get; set; }

        public string GetUserNumber()
        {
            return UsetInput;
        }

        public bool IsOneMore()
        {
            throw new NotImplementedException();
        }

        public void Show(string result)
        {
            UserOutput = result;
        }
    }
}
