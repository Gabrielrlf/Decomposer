using System;

namespace Decompose.Util
{
    public class DecomposerUtil
    {
        public bool ValidateDivider(int number1, int number2) => number1 % number2 == 0 ? true : false;
    }
}
