using OxyPlot;
using OxyPlot.Axes;

namespace SO3
{
    public partial class Primerjava_Alternativ : Form
    {
        public List<Alternative> alternatives { get; set; }

        public Primerjava_Alternativ(List<Alternative> alternatives)
        {
            InitializeComponent();
            this.alternatives = alternatives;

            var model = new PlotModel
            {
                Title = "Primerjava Alternativ",
                Background = OxyColors.White
            };

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                IsPanEnabled = false,
                IsZoomEnabled = false 
            };

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom, 
                MinimumPadding = 0, 
                MaximumPadding = 0.06, 
                AbsoluteMinimum = 0 
            };

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);

            var barSeries = new OxyPlot.Series.BarSeries();
            barSeries.IsStacked = false;

            if (alternatives != null)
            {
                foreach (Alternative alt in alternatives)
                {
                    barSeries.Items.Add(new OxyPlot.Series.BarItem(alt.Value));
                    categoryAxis.Labels.Add(alt.ime); 
                }
            }

            model.Series.Add(barSeries);

            plotView1.Model = model;
        }
    }


}

