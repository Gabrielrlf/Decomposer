using System;

namespace Decompose.Util
{
    public class DecomposerUtil
    {
        public bool ValidatedDivider(int number1, int number2) => number1 % number2 == 0 ? true : false;
        public bool IsNumberOne(int number1) => number1 == 1 ? true : false;
    }
}
