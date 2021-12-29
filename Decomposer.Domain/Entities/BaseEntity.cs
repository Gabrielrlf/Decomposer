using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Decomposer.Domain.Entities
{
    public class BaseEntity
    {
        [JsonPropertyName("Entrada")]
        public int EntryNumber { get; set; }
        [JsonPropertyName("Divisores")]
        public List<int> DividingNumbers { get; set; }

        public void PrintDividingNumbers()
        {
            Console.Write("Números divisores: ");
            DividingNumbers.ForEach(delegate (int a)
            {
                Console.Write($"{a} ");
            });

        }
    }
}
