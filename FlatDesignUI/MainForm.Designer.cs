namespace FlatDesignUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnMenuBar = new System.Windows.Forms.Panel();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblDashboardMenu = new System.Windows.Forms.Label();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnLeftSide = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.dashboardControl = new FlatDesignUI.DashboardControl();
            this.pnHeader.SuspendLayout();
            this.pnMenuBar.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnLeftSide.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(234)))));
            this.pnHeader.Controls.Add(this.pnMenuBar);
            this.pnHeader.Controls.Add(this.pnLogo);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1031, 70);
            this.pnHeader.TabIndex = 0;
            // 
            // pnMenuBar
            // 
            this.pnMenuBar.Controls.Add(this.lblUsers);
            this.pnMenuBar.Controls.Add(this.lblDashboardMenu);
            this.pnMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuBar.Location = new System.Drawing.Point(240, 0);
            this.pnMenuBar.Name = "pnMenuBar";
            this.pnMenuBar.Size = new System.Drawing.Size(631, 70);
            this.pnMenuBar.TabIndex = 1;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUsers.ForeColor = System.Drawing.Color.White;
            this.lblUsers.Location = new System.Drawing.Point(187, 23);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(55, 23);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "Users";
            // 
            // lblDashboardMenu
            // 
            this.lblDashboardMenu.AutoSize = true;
            this.lblDashboardMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDashboardMenu.ForeColor = System.Drawing.Color.White;
            this.lblDashboardMenu.Location = new System.Drawing.Point(36, 23);
            this.lblDashboardMenu.Name = "lblDashboardMenu";
            this.lblDashboardMenu.Size = new System.Drawing.Size(101, 23);
            this.lblDashboardMenu.TabIndex = 0;
            this.lblDashboardMenu.Text = "Dashboard";
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.lblLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(240, 70);
            this.pnLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(26, 21);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(183, 29);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Flat Design UI";
            // 
            // pnLeftSide
            // 
            this.pnLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnLeftSide.Controls.Add(this.btnUsers);
            this.pnLeftSide.Controls.Add(this.btnDashboard);
            this.pnLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeftSide.Location = new System.Drawing.Point(0, 70);
            this.pnLeftSide.Name = "pnLeftSide";
            this.pnLeftSide.Size = new System.Drawing.Size(240, 497);
            this.pnLeftSide.TabIndex = 1;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnUsers.Location = new System.Drawing.Point(0, 65);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(240, 65);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(240, 65);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Controls.Add(this.dashboardControl);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(240, 70);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(791, 497);
            this.pnMain.TabIndex = 2;
            // 
            // dashboardControl
            // 
            this.dashboardControl.BackColor = System.Drawing.Color.White;
            this.dashboardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dashboardControl.Location = new System.Drawing.Point(0, 0);
            this.dashboardControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboardControl.Name = "dashboardControl";
            this.dashboardControl.Size = new System.Drawing.Size(791, 497);
            this.dashboardControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 567);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeftSide);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flat Design UI - Developed by Thanaphon SPK";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnMenuBar.ResumeLayout(false);
            this.pnMenuBar.PerformLayout();
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnLeftSide.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnLeftSide;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnMenuBar;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblDashboardMenu;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDashboard;
        private DashboardControl dashboardControl;
    }
}

