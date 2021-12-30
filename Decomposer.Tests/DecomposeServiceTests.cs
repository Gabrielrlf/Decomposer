using Decomposer.Services.Interfaces;
using Moq;
using Xunit;

namespace Decomposer.Tests
{
    public class DecomposeServiceTests
    {
        private readonly Mock<IDecomposeService> decomposeService;

        public DecomposeServiceTests()
        {
            decomposeService = new();
        }
    }
}
