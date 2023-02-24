
namespace Driving_school_Project
{
    partial class frm_staff_details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear_staff = new System.Windows.Forms.Button();
            this.btn_save_staff = new System.Windows.Forms.Button();
            this.btn_staff_clear = new System.Windows.Forms.Button();
            this.btn_staff_save = new System.Windows.Forms.Button();
            this.cmb_staff_city = new System.Windows.Forms.ComboBox();
            this.rdb_staff_gender_m = new System.Windows.Forms.RadioButton();
            this.rdb_staff_gender_f = new System.Windows.Forms.RadioButton();
            this.rtb_staff_add = new System.Windows.Forms.RichTextBox();
            this.txt_staff_password = new System.Windows.Forms.TextBox();
            this.txt_staff_email = new System.Windows.Forms.TextBox();
            this.txt_staff_pan_no = new System.Windows.Forms.TextBox();
            this.txt_staff_aadhar_no = new System.Windows.Forms.TextBox();
            this.txt_staff_contact = new System.Windows.Forms.TextBox();
            this.txt_staff_area = new System.Windows.Forms.TextBox();
            this.txt_staff_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_staff_details = new System.Windows.Forms.DataGridView();
            this.edit_action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff_details)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAFF DETAILS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_clear_staff);
            this.panel1.Controls.Add(this.btn_save_staff);
            this.panel1.Controls.Add(this.btn_staff_clear);
            this.panel1.Controls.Add(this.btn_staff_save);
            this.panel1.Controls.Add(this.cmb_staff_city);
            this.panel1.Controls.Add(this.rdb_staff_gender_m);
            this.panel1.Controls.Add(this.rdb_staff_gender_f);
            this.panel1.Controls.Add(this.rtb_staff_add);
            this.panel1.Controls.Add(this.txt_staff_password);
            this.panel1.Controls.Add(this.txt_staff_email);
            this.panel1.Controls.Add(this.txt_staff_pan_no);
            this.panel1.Controls.Add(this.txt_staff_aadhar_no);
            this.panel1.Controls.Add(this.txt_staff_contact);
            this.panel1.Controls.Add(this.txt_staff_area);
            this.panel1.Controls.Add(this.txt_staff_name);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 491);
            this.panel1.TabIndex = 20;
            // 
            // btn_clear_staff
            // 
            this.btn_clear_staff.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_clear_staff.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_staff.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_clear_staff.Location = new System.Drawing.Point(289, 439);
            this.btn_clear_staff.Name = "btn_clear_staff";
            this.btn_clear_staff.Size = new System.Drawing.Size(75, 29);
            this.btn_clear_staff.TabIndex = 64;
            this.btn_clear_staff.Text = "Clear";
            this.btn_clear_staff.UseVisualStyleBackColor = false;
            this.btn_clear_staff.Click += new System.EventHandler(this.btn_clear_clear_Click);
            // 
            // btn_save_staff
            // 
            this.btn_save_staff.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_save_staff.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_staff.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_save_staff.Location = new System.Drawing.Point(159, 439);
            this.btn_save_staff.Name = "btn_save_staff";
            this.btn_save_staff.Size = new System.Drawing.Size(75, 29);
            this.btn_save_staff.TabIndex = 63;
            this.btn_save_staff.Text = "Save";
            this.btn_save_staff.UseVisualStyleBackColor = false;
            this.btn_save_staff.Click += new System.EventHandler(this.btn_save_staff_Click);
            // 
            // btn_staff_clear
            // 
            this.btn_staff_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_clear.Location = new System.Drawing.Point(310, 519);
            this.btn_staff_clear.Name = "btn_staff_clear";
            this.btn_staff_clear.Size = new System.Drawing.Size(75, 31);
            this.btn_staff_clear.TabIndex = 62;
            this.btn_staff_clear.Text = "Clear";
            this.btn_staff_clear.UseVisualStyleBackColor = true;
            // 
            // btn_staff_save
            // 
            this.btn_staff_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_save.Location = new System.Drawing.Point(159, 519);
            this.btn_staff_save.Name = "btn_staff_save";
            this.btn_staff_save.Size = new System.Drawing.Size(75, 31);
            this.btn_staff_save.TabIndex = 61;
            this.btn_staff_save.Text = "Save";
            this.btn_staff_save.UseVisualStyleBackColor = true;
            // 
            // cmb_staff_city
            // 
            this.cmb_staff_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_staff_city.FormattingEnabled = true;
            this.cmb_staff_city.Items.AddRange(new object[] {
            "Mumbai",
            "Pune\t",
            "Nagpur\t",
            "Thane\t",
            "Nashik\t",
            "Aurangabad\t",
            "Solapur\t",
            "Jalgaon\t",
            "Amravati\t",
            "Nanded\t",
            "Akola\t",
            "Thane",
            "Sangli\t",
            "Nashik\t",
            "Latur\t",
            "Dhule\t",
            "Ahmednagar\t",
            "Kolhapur\t",
            "Chandrapur\t",
            "Parbhani\t",
            "Jalna\t",
            "Jalgaon\t\t",
            "Raigad\t",
            "Satara\t",
            "Beed\t",
            "Yavatmal\t",
            "Nagpur\t",
            "Gondia\t\t",
            "Amravati\t",
            "Osmanabad\t",
            "Nandurbar\t",
            "Wardha\t\t"});
            this.cmb_staff_city.Location = new System.Drawing.Point(159, 153);
            this.cmb_staff_city.Name = "cmb_staff_city";
            this.cmb_staff_city.Size = new System.Drawing.Size(191, 24);
            this.cmb_staff_city.TabIndex = 60;
            // 
            // rdb_staff_gender_m
            // 
            this.rdb_staff_gender_m.AutoSize = true;
            this.rdb_staff_gender_m.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_staff_gender_m.Location = new System.Drawing.Point(233, 198);
            this.rdb_staff_gender_m.Name = "rdb_staff_gender_m";
            this.rdb_staff_gender_m.Size = new System.Drawing.Size(55, 21);
            this.rdb_staff_gender_m.TabIndex = 59;
            this.rdb_staff_gender_m.TabStop = true;
            this.rdb_staff_gender_m.Text = "Male";
            this.rdb_staff_gender_m.UseVisualStyleBackColor = true;
            // 
            // rdb_staff_gender_f
            // 
            this.rdb_staff_gender_f.AutoSize = true;
            this.rdb_staff_gender_f.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_staff_gender_f.Location = new System.Drawing.Point(159, 198);
            this.rdb_staff_gender_f.Name = "rdb_staff_gender_f";
            this.rdb_staff_gender_f.Size = new System.Drawing.Size(68, 21);
            this.rdb_staff_gender_f.TabIndex = 58;
            this.rdb_staff_gender_f.TabStop = true;
            this.rdb_staff_gender_f.Text = "Female";
            this.rdb_staff_gender_f.UseVisualStyleBackColor = true;
            // 
            // rtb_staff_add
            // 
            this.rtb_staff_add.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_staff_add.Location = new System.Drawing.Point(159, 49);
            this.rtb_staff_add.Name = "rtb_staff_add";
            this.rtb_staff_add.Size = new System.Drawing.Size(226, 53);
            this.rtb_staff_add.TabIndex = 57;
            this.rtb_staff_add.Text = "";
            // 
            // txt_staff_password
            // 
            this.txt_staff_password.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_password.Location = new System.Drawing.Point(159, 397);
            this.txt_staff_password.Name = "txt_staff_password";
            this.txt_staff_password.Size = new System.Drawing.Size(226, 24);
            this.txt_staff_password.TabIndex = 56;
            // 
            // txt_staff_email
            // 
            this.txt_staff_email.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_email.Location = new System.Drawing.Point(159, 355);
            this.txt_staff_email.Name = "txt_staff_email";
            this.txt_staff_email.Size = new System.Drawing.Size(226, 24);
            this.txt_staff_email.TabIndex = 55;
            // 
            // txt_staff_pan_no
            // 
            this.txt_staff_pan_no.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_pan_no.Location = new System.Drawing.Point(159, 315);
            this.txt_staff_pan_no.Name = "txt_staff_pan_no";
            this.txt_staff_pan_no.Size = new System.Drawing.Size(164, 24);
            this.txt_staff_pan_no.TabIndex = 54;
            // 
            // txt_staff_aadhar_no
            // 
            this.txt_staff_aadhar_no.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_aadhar_no.Location = new System.Drawing.Point(159, 274);
            this.txt_staff_aadhar_no.Name = "txt_staff_aadhar_no";
            this.txt_staff_aadhar_no.Size = new System.Drawing.Size(164, 24);
            this.txt_staff_aadhar_no.TabIndex = 53;
            // 
            // txt_staff_contact
            // 
            this.txt_staff_contact.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_contact.Location = new System.Drawing.Point(159, 233);
            this.txt_staff_contact.Name = "txt_staff_contact";
            this.txt_staff_contact.Size = new System.Drawing.Size(164, 24);
            this.txt_staff_contact.TabIndex = 52;
            // 
            // txt_staff_area
            // 
            this.txt_staff_area.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_area.Location = new System.Drawing.Point(159, 113);
            this.txt_staff_area.Name = "txt_staff_area";
            this.txt_staff_area.Size = new System.Drawing.Size(191, 24);
            this.txt_staff_area.TabIndex = 51;
            // 
            // txt_staff_name
            // 
            this.txt_staff_name.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_name.Location = new System.Drawing.Point(159, 12);
            this.txt_staff_name.Name = "txt_staff_name";
            this.txt_staff_name.Size = new System.Drawing.Size(226, 24);
            this.txt_staff_name.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(21, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(21, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(21, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(21, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "PAN Card No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(21, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Aadhar Card No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(21, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(21, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Name:";
            // 
            // dgv_staff_details
            // 
            this.dgv_staff_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit_action,
            this.delete_action});
            this.dgv_staff_details.Location = new System.Drawing.Point(634, 73);
            this.dgv_staff_details.Name = "dgv_staff_details";
            this.dgv_staff_details.Size = new System.Drawing.Size(682, 270);
            this.dgv_staff_details.TabIndex = 21;
            this.dgv_staff_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_details_CellContentClick);
            // 
            // edit_action
            // 
            this.edit_action.HeaderText = "Edit";
            this.edit_action.Name = "edit_action";
            this.edit_action.Text = "Edit";
            this.edit_action.UseColumnTextForButtonValue = true;
            // 
            // delete_action
            // 
            this.delete_action.HeaderText = "Delete";
            this.delete_action.Name = "delete_action";
            this.delete_action.Text = "Delete";
            this.delete_action.UseColumnTextForButtonValue = true;
            // 
            // frm_staff_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1312, 625);
            this.Controls.Add(this.dgv_staff_details);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frm_staff_details";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_staff_clear;
        private System.Windows.Forms.Button btn_staff_save;
        private System.Windows.Forms.ComboBox cmb_staff_city;
        private System.Windows.Forms.RadioButton rdb_staff_gender_m;
        private System.Windows.Forms.RadioButton rdb_staff_gender_f;
        private System.Windows.Forms.RichTextBox rtb_staff_add;
        private System.Windows.Forms.TextBox txt_staff_password;
        private System.Windows.Forms.TextBox txt_staff_email;
        private System.Windows.Forms.TextBox txt_staff_pan_no;
        private System.Windows.Forms.TextBox txt_staff_aadhar_no;
        private System.Windows.Forms.TextBox txt_staff_contact;
        private System.Windows.Forms.TextBox txt_staff_area;
        private System.Windows.Forms.TextBox txt_staff_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_save_staff;
        private System.Windows.Forms.Button btn_clear_staff;
        private System.Windows.Forms.DataGridView dgv_staff_details;
        private System.Windows.Forms.DataGridViewButtonColumn edit_action;
        private System.Windows.Forms.DataGridViewButtonColumn delete_action;
    }
}