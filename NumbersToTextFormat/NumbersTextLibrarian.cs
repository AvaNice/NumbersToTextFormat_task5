using System.Collections.Generic;

namespace NumbersToTextFormat
{
    class NumbersTextLibrarian : INumbersTextLibrarian
    {
        public string Minus { get; } = "минус";
        public string Spliter { get; } = " ";
        public string Zero { get; } = "ноль";

        public Dictionary<int, string> Tens { get; }
            = new Dictionary<int, string>
            {
                { 2, "двадцать" },
                { 3, "тридцать" },
                { 4, "сорок" },
                { 5, "пятьдесят" },
                { 6, "шестьдесят" },
                { 7, "семьдесят" },
                { 8, "восемьдесят" },
                { 9, "девяносто" },
            };

        public Dictionary<int, string> HigherRanks { get; }
            = new Dictionary<int, string>
            {
                { 1, "тысяч" },
                { 2, "миллион" },
                { 3, "миллиард" },
            };

        public Dictionary<int, string> Hundreds { get; }
           = new Dictionary<int, string>
           {
                {0, "" },
                {1,"сто" },
                { 2, "двести" },
                { 3, "триста" },
                { 4, "четыреста" },
                { 5, "пятьсот" },
                { 6, "шестьсот" },
                { 7, "семьсот" },
                { 8, "восемьсот" },
                { 9, "девятьсот" },
           };

        public Dictionary<int, string> MaleSingleWord { get; }
            = new Dictionary<int, string>
            {
                {0, "" },
                { 1, "один" },
                { 2, "два" },
                { 3, "три" },
                { 4, "четыре" },
                { 5, "пять" },
                { 6, "шесть" },
                { 7, "семь" },
                { 8, "восемь" },
                { 9, "девять" },
                { 10, "десять" },
                { 11, "одинадцать" },
                { 12, "двенадцать" },
                { 13, "тринадцать" },
                { 14, "четырнадцать" },
                { 15, "пятнадцать" },
                { 16, "шестнадцать" },
                { 17, "семнадцать" },
                { 18, "восемнадцать" },
                { 19, "десятнадцать" },
            };

        public Dictionary<int, string> ThousandEnds { get; }
            = new Dictionary<int, string>
            {
                { 0, "" },
                { 1, "а" },
                { 2, "и" },
                { 3, "и" },
                { 4, "и" },
                { 5, "" },
                { 6, "" },
                { 7, "" },
                { 8, "" },
                { 9, "" },
                { 10, "" },
                { 11, "" },
                { 12, "" },
                { 13, "" },
                { 14, "" },
                { 15, "" },
                { 16, "" },
                { 17, "" },
                { 18, "" },
                { 19, "" },
            };

        public Dictionary<int, string> MillionEnds { get; }
            = new Dictionary<int, string>
            {
                { 0, "ов" },
                { 1, "" },
                { 2, "а" },
                { 3, "а" },
                { 4, "а" },
                { 5, "ов" },
                { 6, "ов" },
                { 7, "ов" },
                { 8, "ов" },
                { 9, "ов" },
                { 10, "ов" },
                { 11, "ов" },
                { 12, "ов" },
                { 13, "ов" },
                { 14, "ов" },
                { 15, "ов" },
                { 16, "ов" },
                { 17, "ов" },
                { 18, "ов" },
                { 19, "ов" },

            };



        public Dictionary<int, string> FemaleSingleWord { get; }
            = new Dictionary<int, string>
            {
                {0, "" },
                { 1, "одна" },
                { 2, "две" },
                { 3, "три" },
                { 4, "четыре" },
                { 5, "пять" },
                { 6, "шесть" },
                { 7, "семь" },
                { 8, "восемь" },
                { 9, "девять" },
                { 10, "десять" },
                { 11, "одинадцать" },
                { 12, "двенадцать" },
                { 13, "тринадцать" },
                { 14, "четырнадцать" },
                { 15, "пятнадцать" },
                { 16, "шестнадцать" },
                { 17, "семнадцать" },
                { 18, "восемнадцать" },
                { 19, "десятнадцать" },
            };
    }
}
