namespace Neeroga_System
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.assNewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 6, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assNewUsersToolStripMenuItem,
            this.viewPatientToolStripMenuItem,
            this.consultantsToolStripMenuItem,
            this.userManagerToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1453, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // assNewUsersToolStripMenuItem
            // 
            this.assNewUsersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assNewUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.assNewUsersToolStripMenuItem.Name = "assNewUsersToolStripMenuItem";
            this.assNewUsersToolStripMenuItem.Size = new System.Drawing.Size(164, 44);
            this.assNewUsersToolStripMenuItem.Text = "Register Patient ";
            this.assNewUsersToolStripMenuItem.Click += new System.EventHandler(this.assNewUsersToolStripMenuItem_Click);
            // 
            // viewPatientToolStripMenuItem
            // 
            this.viewPatientToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPatientToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewPatientToolStripMenuItem.Name = "viewPatientToolStripMenuItem";
            this.viewPatientToolStripMenuItem.Size = new System.Drawing.Size(141, 44);
            this.viewPatientToolStripMenuItem.Text = "Appointment";
            this.viewPatientToolStripMenuItem.Click += new System.EventHandler(this.viewPatientToolStripMenuItem_Click);
            // 
            // consultantsToolStripMenuItem
            // 
            this.consultantsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.consultantsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultantsToolStripMenuItem.Name = "consultantsToolStripMenuItem";
            this.consultantsToolStripMenuItem.Size = new System.Drawing.Size(126, 44);
            this.consultantsToolStripMenuItem.Text = "Consultants";
            this.consultantsToolStripMenuItem.Click += new System.EventHandler(this.consultantsToolStripMenuItem_Click);
            // 
            // userManagerToolStripMenuItem
            // 
            this.userManagerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userManagerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
            this.userManagerToolStripMenuItem.Size = new System.Drawing.Size(146, 44);
            this.userManagerToolStripMenuItem.Text = "User Manager";
            this.userManagerToolStripMenuItem.Click += new System.EventHandler(this.userManagerToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(87, 44);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(709, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 94);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Neeroga Clinic Center";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Neeroga_System.Properties.Resources.login_page_background_images_hd_9;
            this.ClientSize = new System.Drawing.Size(1453, 560);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem assNewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}