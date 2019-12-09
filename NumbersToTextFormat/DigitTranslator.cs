using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersToTextFormat
{
    class DigitTranslator
    {
        #region Constants
        private const int RANKS_IN_SUPREME = 3;
        private const int SUPREME_UNIT = 0;
        private const int SUPREME_THOUSAND = 1;
        private const int SUPREME_MILLION = 2;
        private const int SUPREME_BILLION = 3;
        private const int RANK_DIVIDER = 10;
        private const int HUNDRED_RANK = 0;
        private const int UNITS_RANK = 1;
        private const int TENS_RANK = 2;
        private const int COUNT_SINGLE_WORD = 19;
        #endregion

        private NumbersTextLibrarian _lib;

        private bool _isZeroHighRank = false;

        public DigitTranslator(NumbersTextLibrarian lib)
        {
            _lib = lib;
        }

        public string Translate(int number)
        {
            if(number == 0)
            {
                return _lib.Zero;
            }

            StringBuilder result = new StringBuilder();

            if (IsNegative(number))
            {
                result.Append(_lib.Minus);
                number = Math.Abs(number);
            }

            Stack<int> splitedNumber = SplitNumber(number);

            while (splitedNumber.Count > 0)
            {

                switch (splitedNumber.Count % RANKS_IN_SUPREME)
                {
                    case HUNDRED_RANK:

                        result.Append(TransformHundred(splitedNumber));

                        break;

                    case UNITS_RANK:

                        result.Append(TransformSingleWord(splitedNumber.Pop(), splitedNumber));

                        break;

                    case TENS_RANK:

                        result.Append(TransformTens(splitedNumber));

                        break;

                    default:

                        //TODO log;

                        break;
                }

            }

            _isZeroHighRank = false;

            return result.ToString();
        }

        private Stack<int> SplitNumber(int number)
        {
            var splitedNumber = new Stack<int>();

            while (number > RANK_DIVIDER - 1)
            {
                splitedNumber.Push(number % RANK_DIVIDER);
                number = number / RANK_DIVIDER;
            }

            splitedNumber.Push(number);

            return splitedNumber;
        }

        private string TransformHundred(Stack<int> splitedNumber)
        {
            string result;

            int first = splitedNumber.Pop();

            _isZeroHighRank = IsZero(first);

            result = _lib.Hundreds[first];

            return result;
        }

        private string TransformTens(Stack<int> splitedNumber)
        {
            string result;

            int first = splitedNumber.Pop();
            int second = splitedNumber.Pop();
            int full = (first * RANK_DIVIDER) + second;

            if (full > COUNT_SINGLE_WORD)
            {
                result = $"{_lib.Tens[first]}{TransformSingleWord(second, splitedNumber)}";
            }
            else
            {

                result = TransformSingleWord(full, splitedNumber);
            }

            return result;
        }

        private string TransformSingleWord(int number, Stack<int> splitedNumber)
        {
            StringBuilder result = new StringBuilder();

            switch (splitedNumber.Count / RANKS_IN_SUPREME)
            {
                case SUPREME_UNIT:

                    result.Append(_lib.MaleSingleWord[number]);

                    break;

                case SUPREME_THOUSAND:

                    result.Append(_lib.FemaleSingleWord[number]);
                    if (!_isZeroHighRank)
                    {
                        result.Append(_lib.HigherRanks[SUPREME_THOUSAND]);
                        result.Append(_lib.ThousandEnds[number]);
                    }

                    break;

                case SUPREME_MILLION:

                    result.Append(_lib.MaleSingleWord[number]);
                    if (!_isZeroHighRank)
                    {
                        result.Append(_lib.HigherRanks[SUPREME_MILLION]);
                        result.Append(_lib.MillionEnds[number]);
                    }

                    break;

                case SUPREME_BILLION:

                    result.Append(_lib.MaleSingleWord[number]);
                    result.Append(_lib.HigherRanks[SUPREME_BILLION]);
                    result.Append(_lib.MillionEnds[number]);

                    break;

                default:

                    //TODO log

                    break;
            }

            return result.ToString();
        }

        private bool IsZero(int number)
        {
            if (number == 0)
            {

                return true;
            }

            return false;
        }

        private bool IsNegative(int number)
        {
            if (number < 0)
            {

                return true;
            }

            return false;
        }
    }
}
