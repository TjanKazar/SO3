using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO3
{
    internal class SO3
    {
        public static Alternative GetWinner(List<Alternative> alts)
        {
            Alternative winner= new();
            foreach (Alternative alt in alts)
            {
                if (alt.Value > winner.Value)
                {
                    winner = alt;
                }
            }
            return winner;
        }
        public static List<string> GetParamNames(DataGridView parametri_table)
        {
            List<string> ParamNames = new List<string>();

            int rowCount = parametri_table.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                string paramName = parametri_table.Rows[i].Cells[0].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(paramName))
                {
                    ParamNames.Add(paramName);
                }
                Console.WriteLine("param name :" + paramName);
            }

            return ParamNames;
        }
    }
}
