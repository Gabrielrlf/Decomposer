using Decomposer.Domain.Creator;
using Decomposer.Domain.Entities;
using Decomposer.Domain.Exception;
using Decomposer.Domain.Factory;
using Decomposer.Tests.Generator;
using System;
using System.Collections.Generic;
using Xunit;

namespace Decomposer.Tests
{
    public class NumberTests
    {
        private readonly NumberFactoryMethod numberFactory;
        public NumberTests()
        {
            numberFactory = new NumberFactory();
        }

        [Theory]
        [InlineData(0)]
        public void Should_ReturnException_ByDividerPerZero(int numberDivider)
        {
            var result = Assert.Throws<NumberException>(() => numberFactory.MakeDecomposeNumber(numberDivider));
            Assert.IsType<NumberException>(result);

        }

        [Theory]
        [MemberData(nameof(NumberGenerator.GetNumberToDecompose_Pass), MemberType = typeof(NumberGenerator))]
        public void Should_ReturnModelTypeResultNumberDecompose(NumberToDecompose numberToDecompose)
        {
            Assert.IsType<ResultNumberDecomposed>(numberFactory.ReturnResult(numberToDecompose));
        }

        [Theory]
        [MemberData(nameof(NumberGenerator.GetNumberToDecompose_Fail), MemberType = typeof(NumberGenerator))]
        public void Should_ReturnException_ByDividerPerZeroInReturnResult(NumberToDecompose numberToDecompose)
        {
            numberToDecompose.EntryNumber = 0;
            var result = Assert.Throws<NumberException>(() => numberFactory.ReturnResult(numberToDecompose));
            Assert.IsType<NumberException>(result);
        }
    }
}

