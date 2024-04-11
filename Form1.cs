

using OxyPlot.Series;
using OxyPlot;
using OxyPlot.WindowsForms;

namespace SO3
{
    public partial class Form1 : Form
    {
        public List<Alternative> alternatives = new List<Alternative>();
        public string columnName;

        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView();
            errorText1.Hide();
        }

        private void PopulateDataGridView()
        {
            parametri_table.Columns.Add("parametri", "Alternative →\nParametri ↓");

        }
        private void dodaj_alternativo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Alternative_name.Text))
            {
                string columnName1 = Alternative_name.Text + "Value";
                string columnName2 = Alternative_name.Text + "Weight";
                parametri_table.Columns.Add(columnName1, Alternative_name.Text + " Točke :");
                parametri_table.Columns.Add(columnName2, Alternative_name.Text + " Utež :");

            }
            else
            {
                errorText1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alternatives.Clear();

            List<string> AltNames = new List<string>();
            for (int i = 1; i < parametri_table.Columns.Count; i += 2)
            {
                string headerText = parametri_table.Columns[i].HeaderText;
                AltNames.Add(headerText.Substring(0, headerText.Length - 7));
            }

            for (int altIndex = 0; altIndex < AltNames.Count; altIndex++)
            {
                List<Parameter> parametri = new List<Parameter>();

                for (int rowIndex = 0; rowIndex < parametri_table.Rows.Count - 1; rowIndex++)
                {
                    Parameter param = new Parameter();

                    string paramName = parametri_table.Rows[rowIndex].Cells[0].Value?.ToString();
                    string valueText = parametri_table.Rows[rowIndex].Cells[1 + altIndex * 2].Value?.ToString();

                    string weightText = parametri_table.Rows[rowIndex].Cells[2 + altIndex * 2].Value?.ToString();

                    int value, weight;
                    if (int.TryParse(valueText, out value) && int.TryParse(weightText, out weight))
                    {
                        param.Name = paramName;
                        param.Value = value;
                        param.Weight = weight;

                        parametri.Add(param);

                        Console.WriteLine($"Parameter: Name: {param.Name}, Value: {param.Value}, Weight: {param.Weight}");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid value or weight in row {rowIndex + 1}");
                    }
                }

                Alternative alt = new Alternative
                {
                    ime = AltNames[altIndex],
                    parametri = parametri
                };
                alt.Value = Alternative.VrednostAlternative(alt);

                alternatives.Add(alt);
            }
            Console.WriteLine("Names list:");
            foreach (string name in AltNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Alternative list:");
            foreach (Alternative alternative in alternatives)
            {
                Console.WriteLine($"Alternative Name: {alternative.ime}");
                Console.WriteLine($"Alternative Value: {alternative.Value}");

                Console.WriteLine("Parameters:");
                foreach (Parameter parameter in alternative.parametri)
                {
                    Console.WriteLine($"  Name: {parameter.Name}, Value: {parameter.Value}, Weight: {parameter.Weight}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Primerjava_Alternativ Graf1 = new Primerjava_Alternativ(alternatives);
            Graf1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            utezi Graf2 = new utezi(alternatives);
            Graf2.Show();
        }
    }
}
