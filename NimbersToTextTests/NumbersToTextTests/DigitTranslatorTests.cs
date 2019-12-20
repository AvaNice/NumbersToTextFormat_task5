using NumbersToTextFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NumbersToTextTests
{
    public class DigitTranslatorTests
    {
        [Theory]
        [InlineData(3, "три")]
        [InlineData(0, "ноль")]
        [InlineData(-3, "минус три")]
        [InlineData(1000, "одна тысяча")]
        [InlineData(12313, "двенадцать тысяч триста тринадцать")]
        [InlineData(200000023, "двести миллионов двадцать три")]
        [InlineData(1000000001, "один миллиард один")]
        [InlineData(-109820, "минус сто девять тысяч восемьсот двадцать")]
        public void TranslateNumderToRussianTest(int number, string expected)
        {
            string actual;
            RussianNumbersLibrarian librarian = new RussianNumbersLibrarian();
            DigitTranslator digitTranslator = new DigitTranslator(librarian);

            actual = digitTranslator.Translate(number);

            Assert.Equal(expected, actual);
        }
    }
}
