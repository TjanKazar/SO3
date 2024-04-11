using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SO3
{
    public partial class utezi : Form
    {
        public List<Alternative> alternatives { get; set; }

        public utezi(List<Alternative> alternatives)
        {
            InitializeComponent();
            this.alternatives = alternatives;
            ShowPieChart();
        }

        private void ShowPieChart()
        {
            var model = new PlotModel
            {
                Title = "Pie Chart of Weight Parameters",
                Background = OxyColors.White
            };

            var pieSeries = new PieSeries();

            if (alternatives != null)
            {
                Alternative a = alternatives[0];
                for (int i = 0; i < a.parametri.Count; i++) 
                {
                    pieSeries.Slices.Add(new PieSlice(a.parametri[i].Name, a.parametri[i].Weight));
                }
            }

            model.Series.Add(pieSeries);

            plotView1.Model = model;
        }
    }
}
