using Serilog;
using System;

namespace NumbersToTextFormat
{

    public class NumbersToTextApplication : ITranslatorApplication
    {
        private readonly DigitTranslator _translator;
        private readonly INumbersToTextUserInterface _userInterface;

        public NumbersToTextApplication(INumbersTextToLibrarian librarian, INumbersToTextUserInterface userInterface)
        {
            _translator = new DigitTranslator(librarian);
            _userInterface = userInterface;
        }

        public void Run(int number)
        {
            string result;

            result = _translator.Translate(number);
            _userInterface.Show(result);
        }
        public void Run()
        {
            Run(GetUserNumber());
        }

        private int GetUserNumber()
        {
            string input = string.Empty;
            int number;

            try
            {
                input = _userInterface.GetUserNumber();
                number = Convert.ToInt32(input);

                return number;
            }
            catch (FormatException ex)
            {
                Log.Logger.Error($"{ex.Message} User input {input}");
                _userInterface.Show(TextMessages.INCORRECT_INPUT);
            }
            catch (OverflowException ex)
            {
                Log.Logger.Error($"{ex.Message} User input {input}");
                _userInterface.Show(TextMessages.TO_BIG_NUMBER);
            }

            return GetUserNumber();
        }
    }
}
