using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SO3
{
    public partial class AnalizaObcutljivosti : Form
    {
        private List<Alternative> alternatives;
        private string selectedParameter;

        public AnalizaObcutljivosti(List<Alternative> alternatives, string selectedParameter)
        {
            InitializeComponent();
            this.alternatives = alternatives;
            this.selectedParameter = selectedParameter;
            ShowLineGraph();
        }

        private void ShowLineGraph()
        {
            var model = new PlotModel
            {
                Title = $"Analiza občutljivosti {selectedParameter}",
                Background = OxyColors.White
            };

            var categoryAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Utež",
                Minimum = 0,
                Maximum = 10
            };

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Vrednost parametrov"
            };

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);

            foreach (Alternative alt in alternatives)
            {
                var lineSeries = new LineSeries
                {
                    Title = alt.ime
                };

                for (int weight = 0; weight <= 10; weight++)
                {
                    int parameterValue = CalculateParameterValue(alt, weight);
                    lineSeries.Points.Add(new DataPoint(weight, parameterValue));
                }

                model.Series.Add(lineSeries);
            }

            plotView1.Model = model;
        }

        private int CalculateParameterValue(Alternative alt, int weight)
        {
            if (alt.parametri.Exists(p => p.Name == selectedParameter))
            {
                Parameter parameter = alt.parametri.Find(p => p.Name == selectedParameter);
                parameter.Weight = weight;
                List<Parameter> param = [parameter];
                Alternative a = new Alternative("test", param);

                int reuslt = Alternative.VrednostAlternative(a);
                return reuslt;
            }
            else
            {
                return 0;
            }
        }
    }
}
