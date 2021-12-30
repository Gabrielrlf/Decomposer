using Decompose.Util;
using Decomposer.Domain.Creator;
using Decomposer.Domain.Entities;
using Decomposer.Domain.Exception;
using Decomposer.Domain.Factory;
using Decomposer.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Decomposer.Services
{
    public class DecomposeService : IDecomposeService
    {
        private readonly DecomposerUtil decomposerUtil = new();
        private readonly NumberFactoryMethod _numberFactory;
        public DecomposeService(NumberFactoryMethod numberFactoryMethod) => _numberFactory = numberFactoryMethod;

        public void CalculatedCousinPrime(ResultNumberDecomposed resultNumberDecomposed)
        {
            for (int initialIndex = 0; initialIndex < resultNumberDecomposed.DividingNumbers.Count; initialIndex++)
            {
                int numberIndex = resultNumberDecomposed.DividingNumbers[initialIndex];
                int amountPrime = 0;

                for (int countingPrime = 1; countingPrime <= numberIndex; countingPrime++)
                {
                    if (numberIndex % countingPrime == 0)
                        amountPrime++;
                }

                if (amountPrime == 2)
                    resultNumberDecomposed.CousinDivisers.Add(resultNumberDecomposed.DividingNumbers[initialIndex]);
            }
        }

        public void DecompouseNumber(NumberToDecompose numberToDecompose)
        {
            for (int i = 1; i <= numberToDecompose.EntryNumber; i++)
            {
                int resultDivider = numberToDecompose.EntryNumber / i;

                if (decomposerUtil.ValidateDivider(numberToDecompose.EntryNumber, i))
                    numberToDecompose.DividingNumbers.Add(resultDivider);
            }
        }

        public ResultNumberDecomposed MakeOperation(int number)
        {
            try
            {
                var decomposeNumber = _numberFactory.MakeDecomposeNumber(number);
                DecompouseNumber(decomposeNumber);
                var result = _numberFactory.ReturnResult(decomposeNumber);
                CalculatedCousinPrime(result);
                return result;
            }
            catch (Exception e)
            {
                throw new NumberException(e.Message);
            }
        }
    }
}
