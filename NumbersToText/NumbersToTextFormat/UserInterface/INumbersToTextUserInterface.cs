namespace NumbersToTextFormat
{
    public interface INumbersToTextUserInterface
    {
        string GetUserNumber();
        bool IsOneMore();
        void Show(string result);
    }
}