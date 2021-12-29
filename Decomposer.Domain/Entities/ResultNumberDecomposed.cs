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
            PrimeDivisers = new List<int>();
        }
        [JsonPropertyName("Primos")]
        public List<int> PrimeDivisers { get; set; }
        public void PrintPrimeDivisers()
        {
            Console.Write("\nNúmeros primos: ");
            PrimeDivisers.ForEach(delegate (int a)
            {
                Console.Write($"{a} ");
            });

        }
    }
}
