
namespace drivingSchoolProject
{
    partial class StaffForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_staff_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_staff_clear = new System.Windows.Forms.Button();
            this.btn_staff_save = new System.Windows.Forms.Button();
            this.tb_staff_password = new System.Windows.Forms.TextBox();
            this.tb_staff_email = new System.Windows.Forms.TextBox();
            this.tb_staff_contact = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_staff_area = new System.Windows.Forms.TextBox();
            this.cb_staff_city = new System.Windows.Forms.ComboBox();
            this.tb_staff_pan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_staff_aadhar_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_female_staff = new System.Windows.Forms.RadioButton();
            this.rb_male_staff = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_staff_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_staff_address = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgv_staff_data);
            this.panel1.Controls.Add(this.btn_staff_clear);
            this.panel1.Controls.Add(this.btn_staff_save);
            this.panel1.Controls.Add(this.tb_staff_password);
            this.panel1.Controls.Add(this.tb_staff_email);
            this.panel1.Controls.Add(this.tb_staff_contact);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_staff_area);
            this.panel1.Controls.Add(this.cb_staff_city);
            this.panel1.Controls.Add(this.tb_staff_pan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_staff_aadhar_no);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rb_female_staff);
            this.panel1.Controls.Add(this.rb_male_staff);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_staff_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rtb_staff_address);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1759, 780);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(697, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 32);
            this.label8.TabIndex = 66;
            this.label8.Text = "Staff Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 32);
            this.label5.TabIndex = 65;
            this.label5.Text = "Staff Information";
            // 
            // dgv_staff_data
            // 
            this.dgv_staff_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_staff_data.Location = new System.Drawing.Point(703, 99);
            this.dgv_staff_data.Name = "dgv_staff_data";
            this.dgv_staff_data.RowHeadersWidth = 51;
            this.dgv_staff_data.RowTemplate.Height = 24;
            this.dgv_staff_data.Size = new System.Drawing.Size(908, 433);
            this.dgv_staff_data.TabIndex = 64;
            this.dgv_staff_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_data_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit Action";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete Action";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Text = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 125;
            // 
            // btn_staff_clear
            // 
            this.btn_staff_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_clear.Location = new System.Drawing.Point(294, 711);
            this.btn_staff_clear.Name = "btn_staff_clear";
            this.btn_staff_clear.Size = new System.Drawing.Size(75, 32);
            this.btn_staff_clear.TabIndex = 63;
            this.btn_staff_clear.Text = "Clear";
            this.btn_staff_clear.UseVisualStyleBackColor = true;
            this.btn_staff_clear.Click += new System.EventHandler(this.btn_staff_clear_Click);
            // 
            // btn_staff_save
            // 
            this.btn_staff_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_save.Location = new System.Drawing.Point(198, 711);
            this.btn_staff_save.Name = "btn_staff_save";
            this.btn_staff_save.Size = new System.Drawing.Size(80, 32);
            this.btn_staff_save.TabIndex = 62;
            this.btn_staff_save.Text = "Save";
            this.btn_staff_save.UseVisualStyleBackColor = true;
            this.btn_staff_save.Click += new System.EventHandler(this.btn_staff_save_Click);
            // 
            // tb_staff_password
            // 
            this.tb_staff_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_staff_password.Location = new System.Drawing.Point(198, 644);
            this.tb_staff_password.Name = "tb_staff_password";
            this.tb_staff_password.Size = new System.Drawing.Size(285, 28);
            this.tb_staff_password.TabIndex = 61;
            // 
            // tb_staff_email
            // 
            this.tb_staff_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_staff_email.Location = new System.Drawing.Point(198, 588);
            this.tb_staff_email.Name = "tb_staff_email";
            this.tb_staff_email.Size = new System.Drawing.Size(285, 28);
            this.tb_staff_email.TabIndex = 60;
            // 
            // tb_staff_contact
            // 
            this.tb_staff_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_staff_contact.Location = new System.Drawing.Point(198, 253);
            this.tb_staff_contact.Name = "tb_staff_contact";
            this.tb_staff_contact.Size = new System.Drawing.Size(285, 28);
            this.tb_staff_contact.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 57;
            this.label12.Text = "Contact";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 644);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 24);
            this.label11.TabIndex = 56;
            this.label11.Text = "Staff Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 588);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "Staff Email";
            // 
            // tb_staff_area
            // 
            this.tb_staff_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_staff_area.Location = new System.Drawing.Point(198, 407);
            this.tb_staff_area.Name = "tb_staff_area";
            this.tb_staff_area.Size = new System.Drawing.Size(285, 28);
            this.tb_staff_area.TabIndex = 54;
            // 
            // cb_staff_city
            // 
            this.cb_staff_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_staff_city.FormattingEnabled = true;
            this.cb_staff_city.Items.AddRange(new object[] {
            "pune",
            "satara",
            "sangli",
            "jalna",
            "mumbai",
            "beed",
            "latur",
            "parbhani",
            "nanded"});
            this.cb_staff_city.Location = new System.Drawing.Point(198, 461);
            this.cb_staff_city.Name = "cb_staff_city";
            this.cb_staff_city.Size = new System.Drawing.Size(285, 30);
            this.cb_staff_city.TabIndex = 53;
            // 
            // tb_staff_pan
            // 
            this.tb_staff_pan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_staff_pan.Location = new System.Drawing.Point(198, 523);
            this.tb_staff_pan.Name = "tb_staff_pan";
            this.tb_staff_pan.Size = new System.Drawing.Size(285, 28);
            this.tb_staff_pan.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Pancard";
            // 
            // tb_staff_aadhar_no
            // 
            this.tb_staff_aadhar_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_staff_aadhar_no.Location = new System.Drawing.Point(198, 191);
            this.tb_staff_aadhar_no.Name = "tb_staff_aadhar_no";
            this.tb_staff_aadhar_no.Size = new System.Drawing.Size(285, 28);
            this.tb_staff_aadhar_no.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Aadhar No";
            // 
            // rb_female_staff
            // 
            this.rb_female_staff.AutoSize = true;
            this.rb_female_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_female_staff.Location = new System.Drawing.Point(276, 142);
            this.rb_female_staff.Name = "rb_female_staff";
            this.rb_female_staff.Size = new System.Drawing.Size(95, 28);
            this.rb_female_staff.TabIndex = 45;
            this.rb_female_staff.TabStop = true;
            this.rb_female_staff.Text = "Female";
            this.rb_female_staff.UseVisualStyleBackColor = true;
            // 
            // rb_male_staff
            // 
            this.rb_male_staff.AutoSize = true;
            this.rb_male_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male_staff.Location = new System.Drawing.Point(198, 142);
            this.rb_male_staff.Name = "rb_male_staff";
            this.rb_male_staff.Size = new System.Drawing.Size(72, 28);
            this.rb_male_staff.TabIndex = 44;
            this.rb_male_staff.TabStop = true;
            this.rb_male_staff.Text = "Male";
            this.rb_male_staff.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Gender";
            // 
            // tb_staff_name
            // 
            this.tb_staff_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_staff_name.Location = new System.Drawing.Point(198, 99);
            this.tb_staff_name.Name = "tb_staff_name";
            this.tb_staff_name.Size = new System.Drawing.Size(285, 28);
            this.tb_staff_name.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "City";
            // 
            // rtb_staff_address
            // 
            this.rtb_staff_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_staff_address.Location = new System.Drawing.Point(198, 305);
            this.rtb_staff_address.Name = "rtb_staff_address";
            this.rtb_staff_address.Size = new System.Drawing.Size(285, 96);
            this.rtb_staff_address.TabIndex = 42;
            this.rtb_staff_address.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Area";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1759, 780);
            this.Controls.Add(this.panel1);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_staff_area;
        private System.Windows.Forms.ComboBox cb_staff_city;
        private System.Windows.Forms.TextBox tb_staff_pan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_staff_aadhar_no;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_female_staff;
        private System.Windows.Forms.RadioButton rb_male_staff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_staff_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_staff_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_staff_contact;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_staff_password;
        private System.Windows.Forms.TextBox tb_staff_email;
        private System.Windows.Forms.Button btn_staff_clear;
        private System.Windows.Forms.Button btn_staff_save;
        private System.Windows.Forms.DataGridView dgv_staff_data;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}