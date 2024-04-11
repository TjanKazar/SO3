using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO3
{
    public class Alternative
    {
        public string? ime { get; set; }
        public List<Parameter>? parametri { get; set; }
        public int Value { get; set; }
        public Alternative() { }

        public Alternative(string? ime, List<Parameter>? parametri, int value) : this(ime, parametri)
        {
            Value = value;
        }

        public Alternative(string? ime, List<Parameter>? parametri)
        {
            this.ime = ime;
            this.parametri = parametri;
        }

        public static int VrednostAlternative(Alternative alt)
        {
            int sestevek = 0;
            foreach (Parameter p in alt.parametri)
            {
                int točke = p.Value * p.Weight;
                sestevek += točke; 
            }
            if (sestevek != 0)
                return sestevek;
            else
            {
                Console.WriteLine("vrednost alternative null, nekaj ni vrede");
                return 0;
            }
        }
    }
}
