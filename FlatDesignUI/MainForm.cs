using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatDesignUI
{
    public partial class MainForm : Form
    {
        private Pages currentPage = Pages.Dashboard;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.btnDashboard.BackColor = Color.White;
            this.btnDashboard.Font = new Font("Tahoma", 12, FontStyle.Bold);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.currentPage = Pages.Dashboard;

            this.btnDashboard.BackColor = Color.White;
            this.btnDashboard.Font = new Font("Tahoma", 12, FontStyle.Bold);

            this.btnUsers.BackColor = Color.FromArgb(242, 242, 242);
            this.btnUsers.Font = new Font("Tahoma", 12, FontStyle.Regular);

            this.dashboardControl.Visible = true;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.currentPage = Pages.User;

            this.btnUsers.BackColor = Color.White;
            this.btnUsers.Font = new Font("Tahoma", 12, FontStyle.Bold);

            this.btnDashboard.BackColor = Color.FromArgb(242, 242, 242);
            this.btnDashboard.Font = new Font("Tahoma", 12, FontStyle.Regular);

            this.dashboardControl.Visible = false;
        }
    } // class
} // namespace
