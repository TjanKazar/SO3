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
            List<string> AltNames = new();
            List<string> ParamNames = SO3.GetParamNames(parametri_table);

            foreach (string ParamName in ParamNames)
            {
                Console.WriteLine(ParamName);
                
            }
            Console.WriteLine(ParamNames.Count());

            int columnCount = parametri_table.Columns.Count;

            for (int j = 1; j < columnCount; j += 2) 
            {
                string headerText = parametri_table.Columns[j].HeaderText;
                AltNames.Add(headerText.Substring(0, headerText.Length - 7));
            }

            // Iterate through DataGridView rows starting from the second row and up to the second-to-last row
            for (int i = 0; i < parametri_table.Rows.Count - 1; i++) // Start from index 1 to skip the header row, and stop before the last row
            {

                // Create a list to store Parameter objects for the current Alternative
                List<Parameter> parameters = new List<Parameter>();

                // Iterate through DataGridView columns starting from the second column
                for (int j = 1; j < columnCount; j += 2) // Start from index 1 to skip the name column, and increment by 2 to get every second column
                {
                    // Extract value and weight from the current cell
                    int value = Convert.ToInt32(parametri_table.Rows[i].Cells[j].Value);
                    int weight = Convert.ToInt32(parametri_table.Rows[i].Cells[j + 1].Value); // Assume weight is in the next column

                    // Create Parameter object and add it to the list of parameters
                    Parameter parameter = new Parameter(weight, ParamNames[j-1], value);
                    parameters.Add(parameter);
                }

                // Create Alternative object with the list of parameters and add it to alternatives list
                Alternative alternative = new(AltNames[i], parameters);
                alternatives.Add(alternative);
            }

            // Display the names list
            Console.WriteLine("Names list:");
            foreach (string name in AltNames)
            {
                Console.WriteLine(name);
            }

            // Display the contents of the alternatives list
            Console.WriteLine("Alternative list:");
            foreach (Alternative alternative in alternatives)
            {
                Console.WriteLine($"Alternative Name: {alternative.ime}");
                Console.WriteLine("Parameters:");
                foreach (Parameter parameter in alternative.parametri)
                {
                    Console.WriteLine($"  Name: {parameter.Name}, Value: {parameter.Value}, Weight: {parameter.Weight}");
                }
            }
        }




    }
}
