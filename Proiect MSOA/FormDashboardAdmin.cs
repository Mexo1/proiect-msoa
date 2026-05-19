using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect_MSOA
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chartClase.Series.Clear();
            chartClase.ChartAreas.Clear();
            chartClase.ChartAreas.Add(new ChartArea("ChartArea1"));

            Series s = new Series("Elevi");
            s.ChartType = SeriesChartType.Column;

            s.Points.AddXY("9A", 28);
            s.Points.AddXY("9B", 31);
            s.Points.AddXY("10A", 26);
            s.Points.AddXY("10B", 30);

            chartClase.Series.Add(s);
            chartClase.Titles.Clear();
            chartClase.Titles.Add("Elevi pe clase");
        }
    }
}
