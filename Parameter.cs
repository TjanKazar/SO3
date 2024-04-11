using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO3
{
    public class Parameter
    {
        public int Weight { get; set; }
        public string? Name { get; set; }
        public int Value { get; set; }

        public Parameter()
        {
        }

        public Parameter(int weight, string? name, int value)
        {
            Weight = weight;
            Name = name;
            Value = value;
        }
    }
}
