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
        public NumberToDecompose CreateDecomposeModel(int numberA)
        {
            return _numberFactoryMethod.MakeDecomposeNumber(numberA);
        }

        public NumberToDecompose CreateDecomposeModel(int numberA, List<int> decomposer)
        {
            throw new NotImplementedException();
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

        public bool IsCousinPrime(int numberA)
        {
            throw new NotImplementedException();
        }
    }
}
