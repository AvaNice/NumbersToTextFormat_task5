using Serilog;
using System;

namespace NumbersToTextFormat
{
    class NumbersToTextUI
    {
        public string GetUserNumber()
        {
            string input;

            Console.Write(TextMessages.ENTER_NUMBER);

            input = Console.ReadLine();
            
            return input;
        }

        public void Show(string result)
        {
            Console.WriteLine(result);
        }

        public bool IsOneMore()
        {
            string input;
            bool result;

            Console.WriteLine(TextMessages.NEED_MORE);
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case TextMessages.YES:
                case TextMessages.YES_ENG:
                case TextMessages.YES_TRANS:
                    result = true;
                    break;

                case TextMessages.NO:
                case TextMessages.NO_ENG:
                case TextMessages.NO_TRANS:
                    result = false;
                    break;

                default:
                    Log.Logger.Information($"UI default. User input {input}");
                    Console.WriteLine(TextMessages.CANT_READ_MODE);

                    return IsOneMore();
            }

            return result;
        }
    }
}
