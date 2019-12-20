using Serilog;
using System;

namespace NumbersToTextFormat
{
    public class Program
    {
        static void Main(string[] args = null)
        {
            INumbersTextToLibrarian librarian;
            ITranslatorApplication translator;
            INumbersToTextUI userInterface;

            librarian = new RussianNumbersLibrarian();
            userInterface = new NumbersToTextUI();
            translator = new NumbersToTextApplication(librarian, userInterface);

            ConfigLogger();

            if (args.Length > 0)
            {
                int number;

                if (int.TryParse(args[0], out number))
                {
                    translator.Run(number);
                }
                else
                {
                    userInterface.Show(TextMessages.CANT_READ_ARGS);
                }
            }

            do
            {
                translator.Run();
            }
            while (userInterface.IsOneMore());
        }

        private static void ConfigLogger()
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
               .WriteTo.File("log.txt").CreateLogger();
        }
    }
}
