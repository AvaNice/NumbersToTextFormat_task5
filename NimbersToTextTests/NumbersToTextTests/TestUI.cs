using NumbersToTextFormat;
using System;

namespace NumbersToTextTests
{
    internal class TestUI : INumbersToTextUserInterface
    {
        public string UsetInput { get; set; } = "0";
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
