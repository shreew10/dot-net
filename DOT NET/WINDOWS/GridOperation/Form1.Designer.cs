
namespace GridOperation
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_State = new System.Windows.Forms.ListBox();
            this.btn_clear_1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_active = new System.Windows.Forms.CheckBox();
            this.clb_company = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_largeCap = new System.Windows.Forms.RadioButton();
            this.rb_midcap = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.dgv_department = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_department)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(215, 69);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(217, 22);
            this.tb_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location";
            // 
            // cb_city
            // 
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Items.AddRange(new object[] {
            "jalna",
            "parbhani",
            "pune",
            "satara",
            "aurangabad",
            "nanded",
            "sangli",
            "kolhapur",
            "mumbai"});
            this.cb_city.Location = new System.Drawing.Point(215, 131);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(217, 24);
            this.cb_city.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lb_State);
            this.panel1.Controls.Add(this.btn_clear_1);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_active);
            this.panel1.Controls.Add(this.clb_company);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rb_largeCap);
            this.panel1.Controls.Add(this.rb_midcap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_city);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 686);
            this.panel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "State";
            // 
            // lb_State
            // 
            this.lb_State.FormattingEnabled = true;
            this.lb_State.ItemHeight = 16;
            this.lb_State.Items.AddRange(new object[] {
            "Maharashtra",
            "Uttar Pradesh",
            "Goa",
            "Madhya Pradesh",
            "Karnataka",
            "Tamil Nadu",
            "Kerala",
            "New Delhi",
            "Rajasthan"});
            this.lb_State.Location = new System.Drawing.Point(215, 239);
            this.lb_State.Name = "lb_State";
            this.lb_State.Size = new System.Drawing.Size(217, 100);
            this.lb_State.TabIndex = 37;
            // 
            // btn_clear_1
            // 
            this.btn_clear_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_1.Location = new System.Drawing.Point(337, 588);
            this.btn_clear_1.Name = "btn_clear_1";
            this.btn_clear_1.Size = new System.Drawing.Size(95, 30);
            this.btn_clear_1.TabIndex = 31;
            this.btn_clear_1.Text = "Clear";
            this.btn_clear_1.UseVisualStyleBackColor = true;
            this.btn_clear_1.Click += new System.EventHandler(this.btn_clear_1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(215, 588);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 30);
            this.btn_save.TabIndex = 30;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Status";
            // 
            // cb_active
            // 
            this.cb_active.AutoSize = true;
            this.cb_active.Location = new System.Drawing.Point(215, 371);
            this.cb_active.Name = "cb_active";
            this.cb_active.Size = new System.Drawing.Size(68, 21);
            this.cb_active.TabIndex = 34;
            this.cb_active.Text = "Active";
            this.cb_active.UseVisualStyleBackColor = true;
            // 
            // clb_company
            // 
            this.clb_company.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.clb_company.FormattingEnabled = true;
            this.clb_company.Items.AddRange(new object[] {
            "Tata",
            "MahindraAndMahindra",
            "Kia",
            "MarutiSuzuki",
            "Fiat",
            "Eicher"});
            this.clb_company.Location = new System.Drawing.Point(215, 439);
            this.clb_company.Name = "clb_company";
            this.clb_company.Size = new System.Drawing.Size(217, 106);
            this.clb_company.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "CapSize";
            // 
            // rb_largeCap
            // 
            this.rb_largeCap.AutoSize = true;
            this.rb_largeCap.Location = new System.Drawing.Point(341, 193);
            this.rb_largeCap.Name = "rb_largeCap";
            this.rb_largeCap.Size = new System.Drawing.Size(91, 21);
            this.rb_largeCap.TabIndex = 29;
            this.rb_largeCap.TabStop = true;
            this.rb_largeCap.Text = "LargeCap";
            this.rb_largeCap.UseVisualStyleBackColor = true;
            // 
            // rb_midcap
            // 
            this.rb_midcap.AutoSize = true;
            this.rb_midcap.Location = new System.Drawing.Point(215, 193);
            this.rb_midcap.Name = "rb_midcap";
            this.rb_midcap.Size = new System.Drawing.Size(76, 21);
            this.rb_midcap.TabIndex = 28;
            this.rb_midcap.TabStop = true;
            this.rb_midcap.Text = "MidCap";
            this.rb_midcap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department Number";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(215, 10);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(217, 22);
            this.tb_id.TabIndex = 0;
            this.tb_id.Visible = false;
            // 
            // dgv_department
            // 
            this.dgv_department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_department.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_edit,
            this.btn_delete});
            this.dgv_department.Location = new System.Drawing.Point(484, 46);
            this.dgv_department.Name = "dgv_department";
            this.dgv_department.RowHeadersWidth = 51;
            this.dgv_department.RowTemplate.Height = 24;
            this.dgv_department.Size = new System.Drawing.Size(1379, 349);
            this.dgv_department.TabIndex = 8;
            this.dgv_department.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_department_CellContentClick);
            // 
            // btn_edit
            // 
            this.btn_edit.HeaderText = "Action";
            this.btn_edit.MinimumWidth = 6;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseColumnTextForButtonValue = true;
            this.btn_edit.Width = 125;
            // 
            // btn_delete
            // 
            this.btn_delete.HeaderText = "DeleteAction";
            this.btn_delete.MinimumWidth = 6;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseColumnTextForButtonValue = true;
            this.btn_delete.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 801);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_department);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_department)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_department;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lb_State;
        private System.Windows.Forms.Button btn_clear_1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_active;
        private System.Windows.Forms.CheckedListBox clb_company;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_largeCap;
        private System.Windows.Forms.RadioButton rb_midcap;
        private System.Windows.Forms.DataGridViewButtonColumn btn_edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
    }
}

