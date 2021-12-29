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
        [JsonPropertyName("Primos")]
        public List<int> PrimeDivisers { get; set; }
    }
}
