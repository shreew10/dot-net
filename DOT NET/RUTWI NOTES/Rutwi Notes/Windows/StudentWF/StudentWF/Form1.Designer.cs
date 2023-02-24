
namespace StudentWF
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
            this.pnl_details = new System.Windows.Forms.Panel();
            this.lbl_marks = new System.Windows.Forms.Label();
            this.lbl_subjects = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_rollNo = new System.Windows.Forms.Label();
            this.pnl_input = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.chk_lst_subjects = new System.Windows.Forms.CheckedListBox();
            this.lst_states = new System.Windows.Forms.ListBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.rdb_m = new System.Windows.Forms.RadioButton();
            this.rdb_f = new System.Windows.Forms.RadioButton();
            this.txt_marks = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_rollNo = new System.Windows.Forms.TextBox();
            this.pnl_display_details = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_display_input = new System.Windows.Forms.Panel();
            this.txt_display_subject = new System.Windows.Forms.TextBox();
            this.lbl_display_subjects = new System.Windows.Forms.Label();
            this.txt_rollNo_display = new System.Windows.Forms.TextBox();
            this.txt_city_display = new System.Windows.Forms.TextBox();
            this.rdb_m_display = new System.Windows.Forms.RadioButton();
            this.rdb_f_display = new System.Windows.Forms.RadioButton();
            this.txt_marks_display = new System.Windows.Forms.TextBox();
            this.txt_state_display = new System.Windows.Forms.TextBox();
            this.txt_name_display = new System.Windows.Forms.TextBox();
            this.dgc_details = new System.Windows.Forms.DataGridView();
            this.pnl_details.SuspendLayout();
            this.pnl_input.SuspendLayout();
            this.pnl_display_details.SuspendLayout();
            this.pnl_display_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_details)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_details
            // 
            this.pnl_details.Controls.Add(this.lbl_marks);
            this.pnl_details.Controls.Add(this.lbl_subjects);
            this.pnl_details.Controls.Add(this.lbl_State);
            this.pnl_details.Controls.Add(this.lbl_city);
            this.pnl_details.Controls.Add(this.lbl_gender);
            this.pnl_details.Controls.Add(this.lbl_name);
            this.pnl_details.Controls.Add(this.lbl_rollNo);
            this.pnl_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_details.Location = new System.Drawing.Point(27, 12);
            this.pnl_details.Name = "pnl_details";
            this.pnl_details.Size = new System.Drawing.Size(118, 426);
            this.pnl_details.TabIndex = 7;
            // 
            // lbl_marks
            // 
            this.lbl_marks.AutoSize = true;
            this.lbl_marks.Location = new System.Drawing.Point(24, 343);
            this.lbl_marks.Name = "lbl_marks";
            this.lbl_marks.Size = new System.Drawing.Size(41, 13);
            this.lbl_marks.TabIndex = 13;
            this.lbl_marks.Text = "Marks";
            // 
            // lbl_subjects
            // 
            this.lbl_subjects.AutoSize = true;
            this.lbl_subjects.Location = new System.Drawing.Point(24, 237);
            this.lbl_subjects.Name = "lbl_subjects";
            this.lbl_subjects.Size = new System.Drawing.Size(56, 13);
            this.lbl_subjects.TabIndex = 12;
            this.lbl_subjects.Text = "Subjects";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(24, 195);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(37, 13);
            this.lbl_State.TabIndex = 11;
            this.lbl_State.Text = "State";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(24, 154);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(28, 13);
            this.lbl_city.TabIndex = 10;
            this.lbl_city.Text = "City";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(24, 114);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(48, 13);
            this.lbl_gender.TabIndex = 9;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(24, 67);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(87, 13);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Student Name";
            // 
            // lbl_rollNo
            // 
            this.lbl_rollNo.AutoSize = true;
            this.lbl_rollNo.Location = new System.Drawing.Point(24, 24);
            this.lbl_rollNo.Name = "lbl_rollNo";
            this.lbl_rollNo.Size = new System.Drawing.Size(53, 13);
            this.lbl_rollNo.TabIndex = 7;
            this.lbl_rollNo.Text = "Roll No.";
            // 
            // pnl_input
            // 
            this.pnl_input.Controls.Add(this.btn_save);
            this.pnl_input.Controls.Add(this.chk_lst_subjects);
            this.pnl_input.Controls.Add(this.lst_states);
            this.pnl_input.Controls.Add(this.cmb_city);
            this.pnl_input.Controls.Add(this.rdb_m);
            this.pnl_input.Controls.Add(this.rdb_f);
            this.pnl_input.Controls.Add(this.txt_marks);
            this.pnl_input.Controls.Add(this.txt_name);
            this.pnl_input.Controls.Add(this.txt_rollNo);
            this.pnl_input.Location = new System.Drawing.Point(151, 12);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(193, 426);
            this.pnl_input.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(20, 385);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chk_lst_subjects
            // 
            this.chk_lst_subjects.FormattingEnabled = true;
            this.chk_lst_subjects.Items.AddRange(new object[] {
            "Maths",
            "Science",
            "Marathi",
            "English",
            "Social Science"});
            this.chk_lst_subjects.Location = new System.Drawing.Point(21, 236);
            this.chk_lst_subjects.Name = "chk_lst_subjects";
            this.chk_lst_subjects.Size = new System.Drawing.Size(120, 79);
            this.chk_lst_subjects.TabIndex = 7;
            // 
            // lst_states
            // 
            this.lst_states.FormattingEnabled = true;
            this.lst_states.Items.AddRange(new object[] {
            "Maharashtra",
            "Goa",
            "Punjab",
            "Uttarakhand",
            "Uttar Pradesh",
            "Madhya Pradesh",
            "Karnataka",
            "Tamilnadu",
            "Kerala"});
            this.lst_states.Location = new System.Drawing.Point(20, 190);
            this.lst_states.Name = "lst_states";
            this.lst_states.Size = new System.Drawing.Size(120, 30);
            this.lst_states.TabIndex = 6;
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Items.AddRange(new object[] {
            "Mumbai",
            "Pune",
            "Sangli",
            "Satara",
            "Kolhapur",
            "Ratnagiri",
            "Raigad",
            "Nashik",
            "Nagpur",
            "Jalgaon",
            "Jalana",
            "Aurangabad"});
            this.cmb_city.Location = new System.Drawing.Point(20, 149);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(121, 21);
            this.cmb_city.TabIndex = 5;
            // 
            // rdb_m
            // 
            this.rdb_m.AutoSize = true;
            this.rdb_m.Location = new System.Drawing.Point(71, 109);
            this.rdb_m.Name = "rdb_m";
            this.rdb_m.Size = new System.Drawing.Size(34, 17);
            this.rdb_m.TabIndex = 4;
            this.rdb_m.TabStop = true;
            this.rdb_m.Text = "M";
            this.rdb_m.UseVisualStyleBackColor = true;
            // 
            // rdb_f
            // 
            this.rdb_f.AutoSize = true;
            this.rdb_f.Location = new System.Drawing.Point(20, 109);
            this.rdb_f.Name = "rdb_f";
            this.rdb_f.Size = new System.Drawing.Size(31, 17);
            this.rdb_f.TabIndex = 3;
            this.rdb_f.TabStop = true;
            this.rdb_f.Text = "F";
            this.rdb_f.UseVisualStyleBackColor = true;
            // 
            // txt_marks
            // 
            this.txt_marks.Location = new System.Drawing.Point(21, 340);
            this.txt_marks.Name = "txt_marks";
            this.txt_marks.Size = new System.Drawing.Size(100, 20);
            this.txt_marks.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(20, 62);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_rollNo
            // 
            this.txt_rollNo.Location = new System.Drawing.Point(20, 19);
            this.txt_rollNo.Name = "txt_rollNo";
            this.txt_rollNo.Size = new System.Drawing.Size(100, 20);
            this.txt_rollNo.TabIndex = 0;
            // 
            // pnl_display_details
            // 
            this.pnl_display_details.Controls.Add(this.label1);
            this.pnl_display_details.Controls.Add(this.label2);
            this.pnl_display_details.Controls.Add(this.label3);
            this.pnl_display_details.Controls.Add(this.label4);
            this.pnl_display_details.Controls.Add(this.label5);
            this.pnl_display_details.Controls.Add(this.label6);
            this.pnl_display_details.Controls.Add(this.label7);
            this.pnl_display_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_display_details.Location = new System.Drawing.Point(393, 12);
            this.pnl_display_details.Name = "pnl_display_details";
            this.pnl_display_details.Size = new System.Drawing.Size(118, 426);
            this.pnl_display_details.TabIndex = 9;
            this.pnl_display_details.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Subjects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Student Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Roll No.";
            // 
            // pnl_display_input
            // 
            this.pnl_display_input.Controls.Add(this.txt_display_subject);
            this.pnl_display_input.Controls.Add(this.lbl_display_subjects);
            this.pnl_display_input.Controls.Add(this.txt_rollNo_display);
            this.pnl_display_input.Controls.Add(this.txt_city_display);
            this.pnl_display_input.Controls.Add(this.rdb_m_display);
            this.pnl_display_input.Controls.Add(this.rdb_f_display);
            this.pnl_display_input.Controls.Add(this.txt_marks_display);
            this.pnl_display_input.Controls.Add(this.txt_state_display);
            this.pnl_display_input.Controls.Add(this.txt_name_display);
            this.pnl_display_input.Location = new System.Drawing.Point(517, 12);
            this.pnl_display_input.Name = "pnl_display_input";
            this.pnl_display_input.Size = new System.Drawing.Size(203, 426);
            this.pnl_display_input.TabIndex = 10;
            this.pnl_display_input.Visible = false;
            // 
            // txt_display_subject
            // 
            this.txt_display_subject.Location = new System.Drawing.Point(20, 236);
            this.txt_display_subject.Name = "txt_display_subject";
            this.txt_display_subject.Size = new System.Drawing.Size(169, 20);
            this.txt_display_subject.TabIndex = 11;
            // 
            // lbl_display_subjects
            // 
            this.lbl_display_subjects.AutoSize = true;
            this.lbl_display_subjects.Location = new System.Drawing.Point(21, 237);
            this.lbl_display_subjects.Name = "lbl_display_subjects";
            this.lbl_display_subjects.Size = new System.Drawing.Size(0, 13);
            this.lbl_display_subjects.TabIndex = 10;
            // 
            // txt_rollNo_display
            // 
            this.txt_rollNo_display.Location = new System.Drawing.Point(20, 24);
            this.txt_rollNo_display.Name = "txt_rollNo_display";
            this.txt_rollNo_display.Size = new System.Drawing.Size(100, 20);
            this.txt_rollNo_display.TabIndex = 9;
            // 
            // txt_city_display
            // 
            this.txt_city_display.Location = new System.Drawing.Point(20, 150);
            this.txt_city_display.Name = "txt_city_display";
            this.txt_city_display.Size = new System.Drawing.Size(100, 20);
            this.txt_city_display.TabIndex = 8;
            // 
            // rdb_m_display
            // 
            this.rdb_m_display.AutoSize = true;
            this.rdb_m_display.Location = new System.Drawing.Point(71, 109);
            this.rdb_m_display.Name = "rdb_m_display";
            this.rdb_m_display.Size = new System.Drawing.Size(34, 17);
            this.rdb_m_display.TabIndex = 4;
            this.rdb_m_display.TabStop = true;
            this.rdb_m_display.Text = "M";
            this.rdb_m_display.UseVisualStyleBackColor = true;
            // 
            // rdb_f_display
            // 
            this.rdb_f_display.AutoSize = true;
            this.rdb_f_display.Location = new System.Drawing.Point(20, 109);
            this.rdb_f_display.Name = "rdb_f_display";
            this.rdb_f_display.Size = new System.Drawing.Size(31, 17);
            this.rdb_f_display.TabIndex = 3;
            this.rdb_f_display.TabStop = true;
            this.rdb_f_display.Text = "F";
            this.rdb_f_display.UseVisualStyleBackColor = true;
            // 
            // txt_marks_display
            // 
            this.txt_marks_display.Location = new System.Drawing.Point(21, 340);
            this.txt_marks_display.Name = "txt_marks_display";
            this.txt_marks_display.Size = new System.Drawing.Size(100, 20);
            this.txt_marks_display.TabIndex = 2;
            // 
            // txt_state_display
            // 
            this.txt_state_display.Location = new System.Drawing.Point(20, 188);
            this.txt_state_display.Name = "txt_state_display";
            this.txt_state_display.Size = new System.Drawing.Size(100, 20);
            this.txt_state_display.TabIndex = 1;
            // 
            // txt_name_display
            // 
            this.txt_name_display.Location = new System.Drawing.Point(20, 60);
            this.txt_name_display.Name = "txt_name_display";
            this.txt_name_display.Size = new System.Drawing.Size(100, 20);
            this.txt_name_display.TabIndex = 0;
            // 
            // dgc_details
            // 
            this.dgc_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgc_details.Location = new System.Drawing.Point(222, 560);
            this.dgc_details.Name = "dgc_details";
            this.dgc_details.Size = new System.Drawing.Size(240, 150);
            this.dgc_details.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 749);
            this.Controls.Add(this.dgc_details);
            this.Controls.Add(this.pnl_display_input);
            this.Controls.Add(this.pnl_display_details);
            this.Controls.Add(this.pnl_input);
            this.Controls.Add(this.pnl_details);
            this.Name = "Form1";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_details.ResumeLayout(false);
            this.pnl_details.PerformLayout();
            this.pnl_input.ResumeLayout(false);
            this.pnl_input.PerformLayout();
            this.pnl_display_details.ResumeLayout(false);
            this.pnl_display_details.PerformLayout();
            this.pnl_display_input.ResumeLayout(false);
            this.pnl_display_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_details;
        private System.Windows.Forms.Label lbl_marks;
        private System.Windows.Forms.Label lbl_subjects;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_rollNo;
        private System.Windows.Forms.Panel pnl_input;
        private System.Windows.Forms.CheckedListBox chk_lst_subjects;
        private System.Windows.Forms.ListBox lst_states;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.RadioButton rdb_m;
        private System.Windows.Forms.RadioButton rdb_f;
        private System.Windows.Forms.TextBox txt_marks;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_rollNo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_display_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_display_input;
        private System.Windows.Forms.RadioButton rdb_m_display;
        private System.Windows.Forms.RadioButton rdb_f_display;
        private System.Windows.Forms.TextBox txt_marks_display;
        private System.Windows.Forms.TextBox txt_state_display;
        private System.Windows.Forms.TextBox txt_name_display;
        private System.Windows.Forms.TextBox txt_rollNo_display;
        private System.Windows.Forms.TextBox txt_city_display;
        private System.Windows.Forms.Label lbl_display_subjects;
        private System.Windows.Forms.TextBox txt_display_subject;
        private System.Windows.Forms.DataGridView dgc_details;
    }
}

