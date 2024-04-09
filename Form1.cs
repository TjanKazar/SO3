using System.Windows.Forms;
using System;

namespace SO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            // Define the columns for the DataGridView
            parametri_table.Columns.Add("Column1", "Column 1");
            parametri_table.Columns.Add("Column2", "Column 2");
            parametri_table.Columns.Add("Column3", "Column 3");

            // Generate dummy data and add rows to the DataGridView
            for (int i = 0; i < 10; i++)
            {
                // Generate random dummy text
                string text1 = GenerateDummyText(10);
                string text2 = GenerateDummyText(15);
                string text3 = GenerateDummyText(20);

                // Add a new row with the generated text
                parametri_table.Rows.Add(text1, text2, text3);
            }
        }

        // Function to generate random dummy text
        private string GenerateDummyText(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
