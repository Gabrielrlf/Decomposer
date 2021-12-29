using Decomposer.Domain.Creator;
using Decomposer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Domain.Factory
{
    public class NumberFactory : NumberFactoryMethod
    {
        protected override NumberToDecompose CreateNumberToDecompose(int numberA)
        {
            return new NumberToDecompose()
            {
                EntryNumber = numberA
            };
        }

        protected override ResultNumberDecomposed ReturnDecomposedNumber(NumberToDecompose numberToDecompose)
        {
            return new ResultNumberDecomposed()
            {
                EntryNumber = numberToDecompose.EntryNumber,
                DividingNumbers = numberToDecompose.DividingNumbers
            };
        }
    }
}
