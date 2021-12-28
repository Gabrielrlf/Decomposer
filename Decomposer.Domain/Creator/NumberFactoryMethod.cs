using Decomposer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Domain.Creator
{
    public abstract class NumberFactoryMethod
    {
        public ResultNumberDecomposed ReturnResult(NumberToDecompose numberToDecompose)
        {
            return ReturnDecomposedNumber(numberToDecompose);
        }

        public NumberToDecompose MakeDecomposeNumber(int numberA)
        {
            return CreateNumberToDecompose(numberA);
        }

        protected abstract NumberToDecompose CreateNumberToDecompose(int numberA);
        protected abstract ResultNumberDecomposed ReturnDecomposedNumber(NumberToDecompose numberToDecompose);
    }
}
