
namespace EmployeeFormDay2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.rdb_f = new System.Windows.Forms.RadioButton();
            this.rdb_m = new System.Windows.Forms.RadioButton();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.chk_list_subject = new System.Windows.Forms.CheckedListBox();
            this.cmb_state = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1_dob = new System.Windows.Forms.DateTimePicker();
            this.button_save = new System.Windows.Forms.Button();
            this.lnk_label = new System.Windows.Forms.LinkLabel();
            this.lbl_display_id = new System.Windows.Forms.Label();
            this.lbl_display_name = new System.Windows.Forms.Label();
            this.lbl_display_status = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_status = new System.Windows.Forms.CheckBox();
            this.pnl_display_data = new System.Windows.Forms.Panel();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rd_female = new System.Windows.Forms.RadioButton();
            this.chb_check = new System.Windows.Forms.CheckBox();
            this.lbl_display_gender = new System.Windows.Forms.Label();
            this.lbl_display_city = new System.Windows.Forms.Label();
            this.lbl_display_sub = new System.Windows.Forms.Label();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.clb_display_subject = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_display_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Subject";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(36, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 658);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "State";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Enabled = false;
            this.lbl_id.Location = new System.Drawing.Point(30, 24);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(32, 17);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "007";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(33, 54);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(127, 22);
            this.txt_name.TabIndex = 3;
            // 
            // rdb_f
            // 
            this.rdb_f.AutoSize = true;
            this.rdb_f.Location = new System.Drawing.Point(33, 151);
            this.rdb_f.Name = "rdb_f";
            this.rdb_f.Size = new System.Drawing.Size(37, 21);
            this.rdb_f.TabIndex = 4;
            this.rdb_f.TabStop = true;
            this.rdb_f.Text = "F";
            this.rdb_f.UseVisualStyleBackColor = true;
            // 
            // rdb_m
            // 
            this.rdb_m.AutoSize = true;
            this.rdb_m.Location = new System.Drawing.Point(157, 151);
            this.rdb_m.Name = "rdb_m";
            this.rdb_m.Size = new System.Drawing.Size(40, 21);
            this.rdb_m.TabIndex = 5;
            this.rdb_m.TabStop = true;
            this.rdb_m.Text = "M";
            this.rdb_m.UseVisualStyleBackColor = true;
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Items.AddRange(new object[] {
            "Mumbai",
            "Pune",
            "Jalna",
            "Aurangabad",
            "Thane",
            "Parbhani",
            "Nanded",
            "Nagpur",
            "Kolhapur",
            "Satara",
            "Sangli"});
            this.cmb_city.Location = new System.Drawing.Point(33, 188);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(164, 24);
            this.cmb_city.TabIndex = 6;
            // 
            // chk_list_subject
            // 
            this.chk_list_subject.FormattingEnabled = true;
            this.chk_list_subject.Items.AddRange(new object[] {
            "C",
            "C++",
            "Java",
            "Python",
            "php",
            "C#",
            "Ruby",
            "Html",
            "Css",
            "React"});
            this.chk_list_subject.Location = new System.Drawing.Point(33, 244);
            this.chk_list_subject.Name = "chk_list_subject";
            this.chk_list_subject.Size = new System.Drawing.Size(164, 123);
            this.chk_list_subject.TabIndex = 7;
            // 
            // cmb_state
            // 
            this.cmb_state.FormattingEnabled = true;
            this.cmb_state.Items.AddRange(new object[] {
            "Maharashtra",
            "TamilNadu",
            "Goa",
            "Karnataka",
            "Bihar",
            "Delhi",
            "Up",
            "Mp"});
            this.cmb_state.Location = new System.Drawing.Point(33, 422);
            this.cmb_state.Name = "cmb_state";
            this.cmb_state.Size = new System.Drawing.Size(164, 24);
            this.cmb_state.TabIndex = 8;
            // 
            // dateTimePicker1_dob
            // 
            this.dateTimePicker1_dob.Location = new System.Drawing.Point(33, 528);
            this.dateTimePicker1_dob.Name = "dateTimePicker1_dob";
            this.dateTimePicker1_dob.Size = new System.Drawing.Size(206, 22);
            this.dateTimePicker1_dob.TabIndex = 9;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(33, 618);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // lnk_label
            // 
            this.lnk_label.AutoSize = true;
            this.lnk_label.Location = new System.Drawing.Point(144, 624);
            this.lnk_label.Name = "lnk_label";
            this.lnk_label.Size = new System.Drawing.Size(37, 17);
            this.lnk_label.TabIndex = 11;
            this.lnk_label.TabStop = true;
            this.lnk_label.Text = "Web";
            // 
            // lbl_display_id
            // 
            this.lbl_display_id.AutoSize = true;
            this.lbl_display_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display_id.Location = new System.Drawing.Point(14, 30);
            this.lbl_display_id.Name = "lbl_display_id";
            this.lbl_display_id.Size = new System.Drawing.Size(61, 17);
            this.lbl_display_id.TabIndex = 12;
            this.lbl_display_id.Text = "label10";
            // 
            // lbl_display_name
            // 
            this.lbl_display_name.AutoSize = true;
            this.lbl_display_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display_name.Location = new System.Drawing.Point(17, 82);
            this.lbl_display_name.Name = "lbl_display_name";
            this.lbl_display_name.Size = new System.Drawing.Size(61, 17);
            this.lbl_display_name.TabIndex = 13;
            this.lbl_display_name.Text = "label11";
            // 
            // lbl_display_status
            // 
            this.lbl_display_status.AutoSize = true;
            this.lbl_display_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display_status.Location = new System.Drawing.Point(17, 128);
            this.lbl_display_status.Name = "lbl_display_status";
            this.lbl_display_status.Size = new System.Drawing.Size(61, 17);
            this.lbl_display_status.TabIndex = 14;
            this.lbl_display_status.Text = "label12";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox_status);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.rdb_f);
            this.panel2.Controls.Add(this.rdb_m);
            this.panel2.Controls.Add(this.lnk_label);
            this.panel2.Controls.Add(this.cmb_city);
            this.panel2.Controls.Add(this.button_save);
            this.panel2.Controls.Add(this.chk_list_subject);
            this.panel2.Controls.Add(this.dateTimePicker1_dob);
            this.panel2.Controls.Add(this.cmb_state);
            this.panel2.Location = new System.Drawing.Point(197, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 683);
            this.panel2.TabIndex = 15;
            // 
            // checkBox_status
            // 
            this.checkBox_status.AutoSize = true;
            this.checkBox_status.Location = new System.Drawing.Point(33, 104);
            this.checkBox_status.Name = "checkBox_status";
            this.checkBox_status.Size = new System.Drawing.Size(68, 21);
            this.checkBox_status.TabIndex = 12;
            this.checkBox_status.Text = "Active";
            this.checkBox_status.UseVisualStyleBackColor = true;
            // 
            // pnl_display_data
            // 
            this.pnl_display_data.Controls.Add(this.lbl_display_sub);
            this.pnl_display_data.Controls.Add(this.lbl_display_city);
            this.pnl_display_data.Controls.Add(this.rb_male);
            this.pnl_display_data.Controls.Add(this.rd_female);
            this.pnl_display_data.Controls.Add(this.chb_check);
            this.pnl_display_data.Controls.Add(this.lbl_display_gender);
            this.pnl_display_data.Controls.Add(this.lbl_display_status);
            this.pnl_display_data.Controls.Add(this.lbl_display_id);
            this.pnl_display_data.Controls.Add(this.lbl_display_name);
            this.pnl_display_data.Location = new System.Drawing.Point(852, 12);
            this.pnl_display_data.Name = "pnl_display_data";
            this.pnl_display_data.Size = new System.Drawing.Size(252, 446);
            this.pnl_display_data.TabIndex = 16;
            this.pnl_display_data.Visible = false;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(29, 333);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(110, 21);
            this.rb_male.TabIndex = 16;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "radioButton1";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rd_female
            // 
            this.rd_female.AutoSize = true;
            this.rd_female.Location = new System.Drawing.Point(29, 306);
            this.rd_female.Name = "rd_female";
            this.rd_female.Size = new System.Drawing.Size(110, 21);
            this.rd_female.TabIndex = 16;
            this.rd_female.TabStop = true;
            this.rd_female.Text = "radioButton1";
            this.rd_female.UseVisualStyleBackColor = true;
            // 
            // chb_check
            // 
            this.chb_check.AutoSize = true;
            this.chb_check.Location = new System.Drawing.Point(29, 244);
            this.chb_check.Name = "chb_check";
            this.chb_check.Size = new System.Drawing.Size(98, 21);
            this.chb_check.TabIndex = 15;
            this.chb_check.Text = "checkBox1";
            this.chb_check.UseVisualStyleBackColor = true;
            // 
            // lbl_display_gender
            // 
            this.lbl_display_gender.AutoSize = true;
            this.lbl_display_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display_gender.Location = new System.Drawing.Point(17, 172);
            this.lbl_display_gender.Name = "lbl_display_gender";
            this.lbl_display_gender.Size = new System.Drawing.Size(61, 17);
            this.lbl_display_gender.TabIndex = 14;
            this.lbl_display_gender.Text = "label12";
            // 
            // lbl_display_city
            // 
            this.lbl_display_city.AutoSize = true;
            this.lbl_display_city.Location = new System.Drawing.Point(29, 375);
            this.lbl_display_city.Name = "lbl_display_city";
            this.lbl_display_city.Size = new System.Drawing.Size(46, 17);
            this.lbl_display_city.TabIndex = 17;
            this.lbl_display_city.Text = "label9";
            // 
            // lbl_display_sub
            // 
            this.lbl_display_sub.AutoSize = true;
            this.lbl_display_sub.Location = new System.Drawing.Point(93, 409);
            this.lbl_display_sub.Name = "lbl_display_sub";
            this.lbl_display_sub.Size = new System.Drawing.Size(0, 17);
            this.lbl_display_sub.TabIndex = 17;
            // 
            // dgv_details
            // 
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Location = new System.Drawing.Point(887, 484);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.RowHeadersWidth = 51;
            this.dgv_details.RowTemplate.Height = 24;
            this.dgv_details.Size = new System.Drawing.Size(342, 211);
            this.dgv_details.TabIndex = 17;
            // 
            // clb_display_subject
            // 
            this.clb_display_subject.FormattingEnabled = true;
            this.clb_display_subject.Items.AddRange(new object[] {
            "C",
            "C++",
            "Java",
            "Python",
            "php",
            "C#",
            "Ruby",
            "Html",
            "Css",
            "React"});
            this.clb_display_subject.Location = new System.Drawing.Point(1136, 256);
            this.clb_display_subject.Name = "clb_display_subject";
            this.clb_display_subject.Size = new System.Drawing.Size(164, 123);
            this.clb_display_subject.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1331, 714);
            this.Controls.Add(this.dgv_details);
            this.Controls.Add(this.pnl_display_data);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clb_display_subject);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_display_data.ResumeLayout(false);
            this.pnl_display_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RadioButton rdb_f;
        private System.Windows.Forms.RadioButton rdb_m;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.CheckedListBox chk_list_subject;
        private System.Windows.Forms.ComboBox cmb_state;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_dob;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.LinkLabel lnk_label;
        private System.Windows.Forms.Label lbl_display_id;
        private System.Windows.Forms.Label lbl_display_name;
        private System.Windows.Forms.Label lbl_display_status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_display_data;
        private System.Windows.Forms.Label lbl_display_gender;
        private System.Windows.Forms.CheckBox checkBox_status;
        private System.Windows.Forms.CheckBox chb_check;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rd_female;
        private System.Windows.Forms.Label lbl_display_city;
        private System.Windows.Forms.Label lbl_display_sub;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.CheckedListBox clb_display_subject;
    }
}

