using System;

namespace NumbersToTextFormat
{

    class NumbersToTextApp
    {
        private readonly DigitTranslator _translator;

        public NumbersToTextApp(INumbersTextLibrarian librarian)
        {
        _translator = new DigitTranslator(librarian);

        }
        public string Translate(int number)
        {
            string result;

            result = _translator.Translate(number);

            return result;
        }
    }
}
