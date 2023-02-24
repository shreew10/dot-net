
namespace Driving_school_Project
{
    partial class frm_daily_training
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
            this.cmb_student_name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear_training = new System.Windows.Forms.Button();
            this.btn_save_training = new System.Windows.Forms.Button();
            this.dt_training_date = new System.Windows.Forms.DateTimePicker();
            this.txt_stud_aadhar_no = new System.Windows.Forms.TextBox();
            this.txt_daily_km = new System.Windows.Forms.TextBox();
            this.txt_training_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_training_details = new System.Windows.Forms.DataGridView();
            this.edit_action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_training_details)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_student_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_clear_training);
            this.panel1.Controls.Add(this.btn_save_training);
            this.panel1.Controls.Add(this.dt_training_date);
            this.panel1.Controls.Add(this.txt_stud_aadhar_no);
            this.panel1.Controls.Add(this.txt_daily_km);
            this.panel1.Controls.Add(this.txt_training_id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 364);
            this.panel1.TabIndex = 1;
            // 
            // cmb_student_name
            // 
            this.cmb_student_name.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_student_name.FormattingEnabled = true;
            this.cmb_student_name.Location = new System.Drawing.Point(231, 26);
            this.cmb_student_name.Name = "cmb_student_name";
            this.cmb_student_name.Size = new System.Drawing.Size(216, 23);
            this.cmb_student_name.TabIndex = 71;
            this.cmb_student_name.SelectedIndexChanged += new System.EventHandler(this.cmb_student_name_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(15, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Student Name:";
            // 
            // btn_clear_training
            // 
            this.btn_clear_training.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_clear_training.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_training.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_clear_training.Location = new System.Drawing.Point(339, 317);
            this.btn_clear_training.Name = "btn_clear_training";
            this.btn_clear_training.Size = new System.Drawing.Size(75, 32);
            this.btn_clear_training.TabIndex = 9;
            this.btn_clear_training.Text = "Clear";
            this.btn_clear_training.UseVisualStyleBackColor = false;
            this.btn_clear_training.Click += new System.EventHandler(this.btn_clear_training_Click);
            // 
            // btn_save_training
            // 
            this.btn_save_training.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_save_training.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_training.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_save_training.Location = new System.Drawing.Point(231, 317);
            this.btn_save_training.Name = "btn_save_training";
            this.btn_save_training.Size = new System.Drawing.Size(75, 32);
            this.btn_save_training.TabIndex = 8;
            this.btn_save_training.Text = "Save";
            this.btn_save_training.UseVisualStyleBackColor = false;
            this.btn_save_training.Click += new System.EventHandler(this.btn_save_training_Click);
            // 
            // dt_training_date
            // 
            this.dt_training_date.CustomFormat = "dd/MM/yyyy";
            this.dt_training_date.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_training_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_training_date.Location = new System.Drawing.Point(231, 186);
            this.dt_training_date.Name = "dt_training_date";
            this.dt_training_date.Size = new System.Drawing.Size(216, 24);
            this.dt_training_date.TabIndex = 7;
            // 
            // txt_stud_aadhar_no
            // 
            this.txt_stud_aadhar_no.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stud_aadhar_no.Location = new System.Drawing.Point(231, 79);
            this.txt_stud_aadhar_no.Name = "txt_stud_aadhar_no";
            this.txt_stud_aadhar_no.Size = new System.Drawing.Size(216, 24);
            this.txt_stud_aadhar_no.TabIndex = 6;
            // 
            // txt_daily_km
            // 
            this.txt_daily_km.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_daily_km.Location = new System.Drawing.Point(231, 246);
            this.txt_daily_km.Name = "txt_daily_km";
            this.txt_daily_km.Size = new System.Drawing.Size(216, 24);
            this.txt_daily_km.TabIndex = 5;
            // 
            // txt_training_id
            // 
            this.txt_training_id.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_training_id.Location = new System.Drawing.Point(231, 133);
            this.txt_training_id.Name = "txt_training_id";
            this.txt_training_id.Size = new System.Drawing.Size(129, 24);
            this.txt_training_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Aadhar card No.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(15, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Daily Km:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(15, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Training Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(15, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "TRAINING DETAILS";
            // 
            // dgv_training_details
            // 
            this.dgv_training_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_training_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit_action,
            this.delete_action});
            this.dgv_training_details.Location = new System.Drawing.Point(621, 73);
            this.dgv_training_details.Name = "dgv_training_details";
            this.dgv_training_details.Size = new System.Drawing.Size(637, 262);
            this.dgv_training_details.TabIndex = 13;
            this.dgv_training_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_training_details_CellContentClick);
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
            // frm_daily_training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1302, 516);
            this.Controls.Add(this.dgv_training_details);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "frm_daily_training";
            this.Text = "Daily Training";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_training_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear_training;
        private System.Windows.Forms.Button btn_save_training;
        private System.Windows.Forms.DateTimePicker dt_training_date;
        private System.Windows.Forms.TextBox txt_stud_aadhar_no;
        private System.Windows.Forms.TextBox txt_daily_km;
        private System.Windows.Forms.TextBox txt_training_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_training_details;
        private System.Windows.Forms.DataGridViewButtonColumn edit_action;
        private System.Windows.Forms.DataGridViewButtonColumn delete_action;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_student_name;
    }
}