using Decompose.Util;
using Decomposer.Domain.Creator;
using Decomposer.Domain.Entities;
using Decomposer.Domain.Factory;
using Decomposer.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Decomposer.Services
{
    public class DecomposeService : IDecomposeService
    {
        private readonly DecomposerUtil decomposerUtil = new DecomposerUtil();
        private readonly NumberFactoryMethod _numberFactoryMethod;
        public DecomposeService(NumberFactoryMethod numberFactoryMethod) => _numberFactoryMethod = numberFactoryMethod;

        public void CalculatedCousinPrime(ResultNumberDecomposed resultNumberDecomposed)
        {
            for (int initialIndex = 0; initialIndex < resultNumberDecomposed.DividingNumbers.Count; initialIndex++)
            {
                int numberIndex = resultNumberDecomposed.DividingNumbers[initialIndex];
                int amountPrime = 0;

                if (decomposerUtil.ValidatedDivider(numberIndex, 2))
                    continue;

                for (int countingPrime = 1; countingPrime <= numberIndex; countingPrime++)
                {
                    if (numberIndex % countingPrime == 0)
                        amountPrime++;
                }

                if (amountPrime == 2)
                    resultNumberDecomposed.PrimeDivisers.Add(resultNumberDecomposed.DividingNumbers[initialIndex]);
            }
        }

        public List<int> DecompouseNumber(NumberToDecompose numberToDecompose)
        {
            for (int i = 1; i <= numberToDecompose.EntryNumber; i++)
            {
                int resultDivider = numberToDecompose.EntryNumber / i;

                if (decomposerUtil.ValidatedDivider(numberToDecompose.EntryNumber, i))
                    numberToDecompose.DividingNumbers.Add(resultDivider);
            }

            return numberToDecompose.DividingNumbers;
        }
    }
}
