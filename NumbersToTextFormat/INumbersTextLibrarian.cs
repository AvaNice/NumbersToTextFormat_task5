using System.Collections.Generic;

namespace NumbersToTextFormat
{
    interface INumbersTextLibrarian
    {
        string Zero { get; }

        string Minus { get; }

        string Spliter { get; }

        Dictionary<int, string> FemaleSingleWord { get; }

        Dictionary<int, string> HigherRanks { get; }

        Dictionary<int, string> Hundreds { get; }

        Dictionary<int, string> MaleSingleWord { get; }

        Dictionary<int, string> MillionEnds { get; }

        Dictionary<int, string> Tens { get; }

        Dictionary<int, string> ThousandEnds { get; }
    }
}