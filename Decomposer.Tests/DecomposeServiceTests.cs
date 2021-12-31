using Decomposer.Domain.Creator;
using Decomposer.Domain.Entities;
using Decomposer.Domain.Exception;
using Decomposer.Domain.Factory;
using Decomposer.Services;
using Decomposer.Services.Interfaces;
using Decomposer.Tests.Generator;
using Moq;
using Xunit;

namespace Decomposer.Tests
{
    public class DecomposeServiceTests
    {
        private readonly DecomposeService decomposeService;
        private readonly NumberFactoryMethod factoryMethod;
        public DecomposeServiceTests()
        {
            factoryMethod = new NumberFactory();
            decomposeService = new DecomposeService(factoryMethod);
        }

        [Theory]
        [MemberData(nameof(DecomposeGenerator.GetResultNumberDecomposed_Pass), MemberType = typeof(DecomposeGenerator))]
        public void Should_Return_CousinDivisersCountingZeroLarger(ResultNumberDecomposed resultNumberDecomposed)
        {
            bool areOk = false;
            decomposeService.CalculatedCousinPrime(resultNumberDecomposed);

            if (resultNumberDecomposed.CousinDivisers.Count > 0)
                areOk = true;

            Assert.True(areOk);
        }

        /// <summary>
        /// Testando a interação entre as camadas.
        /// </summary>
        /// <param name="number"></param>
        [Theory]
        [InlineData(0)]
        public void Should_Return_NumberExceptionByDiviserPerZero(int number)
        {

            var result = Assert.Throws<NumberException>(() =>decomposeService.MakeOperation(number));
            Assert.IsType<NumberException>(result);

        }
    }
}
