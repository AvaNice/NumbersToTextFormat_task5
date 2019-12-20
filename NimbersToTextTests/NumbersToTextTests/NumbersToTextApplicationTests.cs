﻿using NumbersToTextFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NumbersToTextTests
{
    public class NumbersToTextApplicationTests
    {
        private readonly TestUI _userInterface = new TestUI();
        private readonly RussianNumbersLibrarian _librarian = new RussianNumbersLibrarian();

        [Theory]
        [InlineData("0", "ноль")]
        [InlineData("-109820", "минус сто девять тысяч восемьсот двадцать")]
        [InlineData("-10", "минус десять")]
        public void TranslateNumderToRussianTest(string userInput, string expected)
        {
            string actual;

            _userInterface.UsetInput = userInput;

            NumbersToTextApplication application 
                = new NumbersToTextApplication(_librarian, _userInterface);

            application.Run();

            actual = _userInterface.UserOutput;

            Assert.Equal(expected, actual);
        }
    }
}