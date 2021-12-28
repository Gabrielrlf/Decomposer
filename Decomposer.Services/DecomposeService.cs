using Decompose.Util;
using Decomposer.Domain.Entities;
using Decomposer.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Decomposer.Services
{
    public class DecomposeService : IDecomposeService
    {
        private readonly DecomposerUtil decomposerUtil = new DecomposerUtil();
        public List<int> DecompouseNumber(NumberToDecompose numberToDecompose)
        {
            for (int i = 1; i <= numberToDecompose.NumberA; i++)
            {
                int resultDivider = numberToDecompose.NumberA / i;

                if (decomposerUtil.ValidatedDivider(numberToDecompose.NumberA, i))
                    numberToDecompose.DividingNumbers.Add(resultDivider);
            }

            return numberToDecompose.DividingNumbers;
        }

        public bool IsCousinPrime(int numberA)
        {
            throw new NotImplementedException();
        }
    }
}
