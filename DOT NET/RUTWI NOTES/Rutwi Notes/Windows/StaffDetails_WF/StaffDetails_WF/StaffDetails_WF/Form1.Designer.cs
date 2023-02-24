
namespace StaffDetails_WF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.chk_lst_subjects = new System.Windows.Forms.CheckedListBox();
            this.cmb_qualification = new System.Windows.Forms.ComboBox();
            this.rdb_gender_m = new System.Windows.Forms.RadioButton();
            this.rdb_gender_f = new System.Windows.Forms.RadioButton();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_deptNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_deptName = new System.Windows.Forms.TextBox();
            this.txt_dptNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.dgv_dept = new System.Windows.Forms.DataGridView();
            this.Edit_action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete_action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dept)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.chk_lst_subjects);
            this.panel1.Controls.Add(this.cmb_qualification);
            this.panel1.Controls.Add(this.rdb_gender_m);
            this.panel1.Controls.Add(this.rdb_gender_f);
            this.panel1.Controls.Add(this.txt_contact);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.txt_deptNo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 504);
            this.panel1.TabIndex = 9;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(266, 454);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(175, 454);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chk_lst_subjects
            // 
            this.chk_lst_subjects.FormattingEnabled = true;
            this.chk_lst_subjects.Items.AddRange(new object[] {
            "DSS",
            "DCS",
            "SOM",
            "BPD",
            "TOS",
            "Survey",
            "Java",
            "C++",
            "C",
            "Python",
            "SQl",
            "DotNet"});
            this.chk_lst_subjects.Location = new System.Drawing.Point(165, 294);
            this.chk_lst_subjects.Name = "chk_lst_subjects";
            this.chk_lst_subjects.Size = new System.Drawing.Size(160, 94);
            this.chk_lst_subjects.TabIndex = 22;
            // 
            // cmb_qualification
            // 
            this.cmb_qualification.FormattingEnabled = true;
            this.cmb_qualification.Items.AddRange(new object[] {
            "B.E Civil",
            "B.E Mechanical",
            "B.E Electrical",
            "B.E Chemical",
            "B.E Computer",
            "B.E Textile"});
            this.cmb_qualification.Location = new System.Drawing.Point(165, 256);
            this.cmb_qualification.Name = "cmb_qualification";
            this.cmb_qualification.Size = new System.Drawing.Size(160, 21);
            this.cmb_qualification.TabIndex = 21;
            // 
            // rdb_gender_m
            // 
            this.rdb_gender_m.AutoSize = true;
            this.rdb_gender_m.Location = new System.Drawing.Point(256, 161);
            this.rdb_gender_m.Name = "rdb_gender_m";
            this.rdb_gender_m.Size = new System.Drawing.Size(34, 17);
            this.rdb_gender_m.TabIndex = 20;
            this.rdb_gender_m.TabStop = true;
            this.rdb_gender_m.Text = "M";
            this.rdb_gender_m.UseVisualStyleBackColor = true;
            // 
            // rdb_gender_f
            // 
            this.rdb_gender_f.AutoSize = true;
            this.rdb_gender_f.Location = new System.Drawing.Point(165, 161);
            this.rdb_gender_f.Name = "rdb_gender_f";
            this.rdb_gender_f.Size = new System.Drawing.Size(31, 17);
            this.rdb_gender_f.TabIndex = 19;
            this.rdb_gender_f.TabStop = true;
            this.rdb_gender_f.Text = "F";
            this.rdb_gender_f.UseVisualStyleBackColor = true;
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(165, 204);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(160, 23);
            this.txt_contact.TabIndex = 18;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(165, 112);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(160, 23);
            this.txt_name.TabIndex = 17;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(165, 65);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(160, 23);
            this.txt_id.TabIndex = 16;
            // 
            // txt_deptNo
            // 
            this.txt_deptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deptNo.Location = new System.Drawing.Point(165, 403);
            this.txt_deptNo.Name = "txt_deptNo";
            this.txt_deptNo.Size = new System.Drawing.Size(160, 23);
            this.txt_deptNo.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(106, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Staff Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Department No.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Subjects:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Qualification:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contact No.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_deptName);
            this.panel2.Controls.Add(this.txt_dptNo);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(28, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 178);
            this.panel2.TabIndex = 10;
            // 
            // txt_deptName
            // 
            this.txt_deptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deptName.Location = new System.Drawing.Point(167, 112);
            this.txt_deptName.Name = "txt_deptName";
            this.txt_deptName.Size = new System.Drawing.Size(167, 23);
            this.txt_deptName.TabIndex = 17;
            // 
            // txt_dptNo
            // 
            this.txt_dptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dptNo.Location = new System.Drawing.Point(167, 74);
            this.txt_dptNo.Name = "txt_dptNo";
            this.txt_dptNo.Size = new System.Drawing.Size(167, 23);
            this.txt_dptNo.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Department Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Department No.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Department:";
            // 
            // dgv_staff
            // 
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit_action,
            this.Delete_action});
            this.dgv_staff.Location = new System.Drawing.Point(418, 12);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.Size = new System.Drawing.Size(843, 336);
            this.dgv_staff.TabIndex = 11;
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            // 
            // dgv_dept
            // 
            this.dgv_dept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dept.Location = new System.Drawing.Point(431, 540);
            this.dgv_dept.Name = "dgv_dept";
            this.dgv_dept.Size = new System.Drawing.Size(514, 178);
            this.dgv_dept.TabIndex = 12;
            // 
            // Edit_action
            // 
            this.Edit_action.HeaderText = "Edit";
            this.Edit_action.Name = "Edit_action";
            this.Edit_action.Text = "Edit";
            this.Edit_action.UseColumnTextForButtonValue = true;
            // 
            // Delete_action
            // 
            this.Delete_action.HeaderText = "Delete";
            this.Delete_action.Name = "Delete_action";
            this.Delete_action.Text = "Delete";
            this.Delete_action.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 749);
            this.Controls.Add(this.dgv_dept);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdb_gender_m;
        private System.Windows.Forms.RadioButton rdb_gender_f;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_deptNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_deptName;
        private System.Windows.Forms.TextBox txt_dptNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox chk_lst_subjects;
        private System.Windows.Forms.ComboBox cmb_qualification;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.DataGridView dgv_dept;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_action;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_action;
    }
}

