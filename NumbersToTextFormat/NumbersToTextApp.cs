using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToTextFormat
{

    class NumbersToTextApp
    {
        private readonly DigitTranslator _app = new DigitTranslator(new NumbersTextLibrarian());
        private readonly NumbersToTextUI UI = new NumbersToTextUI();

        public void Start()
        {
            try
            {
                int input = Convert.ToInt32(UI.GetUserNumber());

                string result = _app.Translate(input);

                UI.Show(result);
            }

            catch(FormatException ex)
            {
                //TODO LOG
                UI.Show(TextMessages.INCORRECT_INPUT);
            }

            catch(OverflowException ex)
            {
                UI.Show(TextMessages.TO_BIG_NUMBER);
                //TODO LOG
            }

            Start();
        }
    }
}
