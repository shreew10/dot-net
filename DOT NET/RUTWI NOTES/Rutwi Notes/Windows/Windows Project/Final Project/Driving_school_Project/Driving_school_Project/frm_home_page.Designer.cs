
namespace Driving_school_Project
{
    partial class frm_home_page
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
            this.ms_home = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admissionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_logout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_home,
            this.masterDateToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_home
            // 
            this.ms_home.Name = "ms_home";
            this.ms_home.Size = new System.Drawing.Size(52, 20);
            this.ms_home.Text = "Home";
            this.ms_home.Click += new System.EventHandler(this.ms_home_Click);
            // 
            // masterDateToolStripMenuItem
            // 
            this.masterDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyToolStripMenuItem,
            this.staffDetailsToolStripMenuItem,
            this.feeDetailsToolStripMenuItem});
            this.masterDateToolStripMenuItem.Name = "masterDateToolStripMenuItem";
            this.masterDateToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.masterDateToolStripMenuItem.Text = "Master Data";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // staffDetailsToolStripMenuItem
            // 
            this.staffDetailsToolStripMenuItem.Name = "staffDetailsToolStripMenuItem";
            this.staffDetailsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.staffDetailsToolStripMenuItem.Text = "Staff Details";
            this.staffDetailsToolStripMenuItem.Click += new System.EventHandler(this.staffDetailsToolStripMenuItem_Click);
            // 
            // feeDetailsToolStripMenuItem
            // 
            this.feeDetailsToolStripMenuItem.Name = "feeDetailsToolStripMenuItem";
            this.feeDetailsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.feeDetailsToolStripMenuItem.Text = "Fee Details";
            this.feeDetailsToolStripMenuItem.Click += new System.EventHandler(this.feeDetailsToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionDetailsToolStripMenuItem,
            this.paymentDetailsToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // admissionDetailsToolStripMenuItem
            // 
            this.admissionDetailsToolStripMenuItem.Name = "admissionDetailsToolStripMenuItem";
            this.admissionDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.admissionDetailsToolStripMenuItem.Text = "Admission Details";
            this.admissionDetailsToolStripMenuItem.Click += new System.EventHandler(this.admissionDetailsToolStripMenuItem_Click);
            // 
            // paymentDetailsToolStripMenuItem
            // 
            this.paymentDetailsToolStripMenuItem.Name = "paymentDetailsToolStripMenuItem";
            this.paymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.paymentDetailsToolStripMenuItem.Text = "Payment Details";
            this.paymentDetailsToolStripMenuItem.Click += new System.EventHandler(this.paymentDetailsToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyTrainingToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // dailyTrainingToolStripMenuItem
            // 
            this.dailyTrainingToolStripMenuItem.Name = "dailyTrainingToolStripMenuItem";
            this.dailyTrainingToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dailyTrainingToolStripMenuItem.Text = "Daily Training";
            this.dailyTrainingToolStripMenuItem.Click += new System.EventHandler(this.dailyTrainingToolStripMenuItem_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(1283, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // frm_home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 668);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_home_page";
            this.Text = "DRIVING SCHOOL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admissionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyTrainingToolStripMenuItem;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.ToolStripMenuItem ms_home;
    }
}

