using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NumbersToTextFormat
{
    public interface INumbersTextToLibrarian
    {
        string Zero { get; }
        string Minus { get; }
        string Spliter { get; }

        ReadOnlyDictionary<int, string> FemaleSingleWord { get; }
        ReadOnlyDictionary<int, string> HigherRanks { get; }
        ReadOnlyDictionary<int, string> Hundreds { get; }
        ReadOnlyDictionary<int, string> MaleSingleWord { get; }
        ReadOnlyDictionary<int, string> MillionEnds { get; }
        ReadOnlyDictionary<int, string> Tens { get; }
        ReadOnlyDictionary<int, string> ThousandEnds { get; }
    }
}