
namespace StudentDetails_WF
{
    partial class Form1
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
            this.txt_rollNo = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.lst_state = new System.Windows.Forms.ListBox();
            this.rdb_f = new System.Windows.Forms.RadioButton();
            this.rdb_m = new System.Windows.Forms.RadioButton();
            this.chb_subject = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_studentDetails = new System.Windows.Forms.DataGridView();
            this.Edit_Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete_Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_rollNo
            // 
            this.txt_rollNo.Location = new System.Drawing.Point(152, 26);
            this.txt_rollNo.Name = "txt_rollNo";
            this.txt_rollNo.Size = new System.Drawing.Size(165, 20);
            this.txt_rollNo.TabIndex = 0;
            this.txt_rollNo.Visible = false;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(152, 63);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(165, 20);
            this.txt_name.TabIndex = 1;
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Items.AddRange(new object[] {
            "Mumbai",
            "Pune",
            "Sangli",
            "Satara",
            "Rantagiri",
            "Kolhapur",
            "Solapur",
            "Beed",
            "Latur",
            "Jalana",
            "Sindhudurg",
            "Jalgaon",
            "Nagpur",
            "Dhule",
            "Nandurbar",
            "Chandrapur",
            "Nashik"});
            this.cmb_city.Location = new System.Drawing.Point(152, 106);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(165, 21);
            this.cmb_city.TabIndex = 3;
            // 
            // lst_state
            // 
            this.lst_state.FormattingEnabled = true;
            this.lst_state.Items.AddRange(new object[] {
            "Maharashtra",
            "Goa",
            "Gujarat",
            "Madhya Pradesh",
            "Karnataka",
            "Kerala",
            "Uttarakhand",
            "Jammu & Kashmir",
            "Himchal Pradesh",
            "West bengal",
            "Utter Pradesh",
            "Andhra Pradesh",
            "Assam"});
            this.lst_state.Location = new System.Drawing.Point(152, 153);
            this.lst_state.Name = "lst_state";
            this.lst_state.Size = new System.Drawing.Size(165, 43);
            this.lst_state.TabIndex = 4;
            // 
            // rdb_f
            // 
            this.rdb_f.AutoSize = true;
            this.rdb_f.Location = new System.Drawing.Point(152, 221);
            this.rdb_f.Name = "rdb_f";
            this.rdb_f.Size = new System.Drawing.Size(31, 17);
            this.rdb_f.TabIndex = 5;
            this.rdb_f.TabStop = true;
            this.rdb_f.Text = "F";
            this.rdb_f.UseVisualStyleBackColor = true;
            // 
            // rdb_m
            // 
            this.rdb_m.AutoSize = true;
            this.rdb_m.Location = new System.Drawing.Point(243, 221);
            this.rdb_m.Name = "rdb_m";
            this.rdb_m.Size = new System.Drawing.Size(34, 17);
            this.rdb_m.TabIndex = 6;
            this.rdb_m.TabStop = true;
            this.rdb_m.Text = "M";
            this.rdb_m.UseVisualStyleBackColor = true;
            // 
            // chb_subject
            // 
            this.chb_subject.FormattingEnabled = true;
            this.chb_subject.Items.AddRange(new object[] {
            "C",
            "C++",
            "Java",
            "Python",
            "Dot Net",
            "Php"});
            this.chb_subject.Location = new System.Drawing.Point(152, 255);
            this.chb_subject.Name = "chb_subject";
            this.chb_subject.Size = new System.Drawing.Size(165, 94);
            this.chb_subject.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chb_subject);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rdb_m);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rdb_f);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lst_state);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_city);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_rollNo);
            this.panel1.Location = new System.Drawing.Point(36, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 421);
            this.panel1.TabIndex = 8;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(242, 375);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(152, 375);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subjects:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Roll No. :";
            this.label1.Visible = false;
            // 
            // dgv_studentDetails
            // 
            this.dgv_studentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit_Action,
            this.Delete_Action});
            this.dgv_studentDetails.Location = new System.Drawing.Point(36, 487);
            this.dgv_studentDetails.Name = "dgv_studentDetails";
            this.dgv_studentDetails.Size = new System.Drawing.Size(970, 229);
            this.dgv_studentDetails.TabIndex = 9;
            this.dgv_studentDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_studentDetails_CellContentClick);
            // 
            // Edit_Action
            // 
            this.Edit_Action.HeaderText = "Edit";
            this.Edit_Action.Name = "Edit_Action";
            this.Edit_Action.Text = "Edit";
            this.Edit_Action.UseColumnTextForButtonValue = true;
            // 
            // Delete_Action
            // 
            this.Delete_Action.HeaderText = "Delete";
            this.Delete_Action.Name = "Delete_Action";
            this.Delete_Action.Text = "Delete";
            this.Delete_Action.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 749);
            this.Controls.Add(this.dgv_studentDetails);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rollNo;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.ListBox lst_state;
        private System.Windows.Forms.RadioButton rdb_f;
        private System.Windows.Forms.RadioButton rdb_m;
        private System.Windows.Forms.CheckedListBox chb_subject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_studentDetails;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_Action;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_Action;
    }
}

