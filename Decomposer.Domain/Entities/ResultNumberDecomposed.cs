using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Decomposer.Domain.Entities
{
    public class ResultNumberDecomposed : BaseEntity
    {
        public ResultNumberDecomposed()
        {
            CousinDivisers = new();
        }

        [JsonPropertyName("Primos")]
        public List<int> CousinDivisers { get; set; }

        public void PrintPrimeDivisers()
        {
            Console.Write("\nNúmeros primos: ");
            CousinDivisers.ForEach(delegate (int a)
            {
                Console.Write($"{a} ");
            });

        }
    }
}
