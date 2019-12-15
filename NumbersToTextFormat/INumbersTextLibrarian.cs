using System.Collections.Generic;

namespace NumbersToTextFormat
{
    interface INumbersTextLibrarian
    {
        string Zero { get; }

        string Minus { get; }

        string Spliter { get; }

        IDictionary<int, string> FemaleSingleWord { get; }

        IDictionary<int, string> HigherRanks { get; }

        IDictionary<int, string> Hundreds { get; }

        IDictionary<int, string> MaleSingleWord { get; }

        IDictionary<int, string> MillionEnds { get; }

        IDictionary<int, string> Tens { get; }

        IDictionary<int, string> ThousandEnds { get; }
    }
}