using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Import
using System.Windows.Forms.DataVisualization.Charting;
#endregion Import

namespace FlatDesignUI
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            
            for(int i = 0; i < 10; i++)
            {
                this.chartDashboard.Series[0].Points.Add(new DataPoint(i, random.Next(0, 100)));
                this.chartDashboard.Series[1].Points.Add(new DataPoint(i, random.Next(0, 100)));
            }
        }
    } // class
} // namespace
