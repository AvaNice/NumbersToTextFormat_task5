namespace NumbersToTextFormat
{
    public interface INumbersToTextUI
    {
        string GetUserNumber();
        bool IsOneMore();
        void Show(string result);
    }
}