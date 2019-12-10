using Serilog;
using System;

namespace NumbersToTextFormat
{
    class Program
    {
        static void Main(string[] args = null)
        {
            NumbersTextLibrarian librarian;
            NumbersToTextApp app;
            NumbersToTextUI userInterface;

            librarian = new NumbersTextLibrarian();
            app = new NumbersToTextApp(librarian);
            userInterface = new NumbersToTextUI();

            CreateLog();

            Start(userInterface, app);
        }

        private static void Start(NumbersToTextUI userInterface, NumbersToTextApp app)
        {
            string input = string.Empty;
            int number;
            string result;

            try
            {
                do
                {
                    input = userInterface.GetUserNumber();
                    number = Convert.ToInt32(input);
                    result = app.Translate(number);
                    userInterface.Show(result);
                }
                while (userInterface.IsOneMore());
            }
            catch (FormatException ex)
            {
                Log.Logger.Error($"{ex.Message} User input {input}");
                userInterface.Show(TextMessages.INCORRECT_INPUT);
                Start(userInterface, app);
            }
            catch (OverflowException ex)
            {
                Log.Logger.Error($"{ex.Message} User input {input}");
                userInterface.Show(TextMessages.TO_BIG_NUMBER);
                Start(userInterface, app);
            }
        }

        private static void CreateLog()
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
               .WriteTo.File("log.txt").CreateLogger();
        }
    }
}
