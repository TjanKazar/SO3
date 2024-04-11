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
        public Alternative() { }

        public Alternative(string? ime, List<Parameter>? parametri)
        {
            this.ime = ime;
            this.parametri = parametri;
        }

        public int VrednostAlternative(Alternative alt)
        {
            int seštevek;
            foreach (Parameter p in alt.parametri)
            {
                int točke = p.Value * p.Weight;
                seštevek = +točke;
            }
            return 0;
        }
    }
}
