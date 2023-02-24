
namespace EmployeeWF
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_input = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.rdb_gender_m = new System.Windows.Forms.RadioButton();
            this.rdb_gender_f = new System.Windows.Forms.RadioButton();
            this.chk_status = new System.Windows.Forms.CheckBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pnl_display_title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_display_id = new System.Windows.Forms.TextBox();
            this.txt_display_name = new System.Windows.Forms.TextBox();
            this.rdb_display_gen_f = new System.Windows.Forms.RadioButton();
            this.rdb_display_gen_m = new System.Windows.Forms.RadioButton();
            this.pnl_display = new System.Windows.Forms.Panel();
            this.chk_display_status = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.pnl_input.SuspendLayout();
            this.pnl_display_title.SuspendLayout();
            this.pnl_display.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(31, 26);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 17);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(31, 65);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(42, 17);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(31, 107);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(46, 17);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Status";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(31, 147);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(52, 17);
            this.lbl_gender.TabIndex = 3;
            this.lbl_gender.Text = "Gender";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.lbl_gender);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(39, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 249);
            this.panel1.TabIndex = 4;
            // 
            // pnl_input
            // 
            this.pnl_input.Controls.Add(this.btn_save);
            this.pnl_input.Controls.Add(this.rdb_gender_m);
            this.pnl_input.Controls.Add(this.rdb_gender_f);
            this.pnl_input.Controls.Add(this.chk_status);
            this.pnl_input.Controls.Add(this.txt_name);
            this.pnl_input.Controls.Add(this.txt_id);
            this.pnl_input.Location = new System.Drawing.Point(161, 29);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(200, 249);
            this.pnl_input.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(31, 211);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // rdb_gender_m
            // 
            this.rdb_gender_m.AutoSize = true;
            this.rdb_gender_m.Location = new System.Drawing.Point(31, 171);
            this.rdb_gender_m.Name = "rdb_gender_m";
            this.rdb_gender_m.Size = new System.Drawing.Size(34, 17);
            this.rdb_gender_m.TabIndex = 4;
            this.rdb_gender_m.TabStop = true;
            this.rdb_gender_m.Text = "M";
            this.rdb_gender_m.UseVisualStyleBackColor = true;
            // 
            // rdb_gender_f
            // 
            this.rdb_gender_f.AutoSize = true;
            this.rdb_gender_f.Location = new System.Drawing.Point(31, 147);
            this.rdb_gender_f.Name = "rdb_gender_f";
            this.rdb_gender_f.Size = new System.Drawing.Size(31, 17);
            this.rdb_gender_f.TabIndex = 3;
            this.rdb_gender_f.TabStop = true;
            this.rdb_gender_f.Text = "F";
            this.rdb_gender_f.UseVisualStyleBackColor = true;
            // 
            // chk_status
            // 
            this.chk_status.AutoSize = true;
            this.chk_status.Location = new System.Drawing.Point(31, 107);
            this.chk_status.Name = "chk_status";
            this.chk_status.Size = new System.Drawing.Size(56, 17);
            this.chk_status.TabIndex = 2;
            this.chk_status.Text = "Active";
            this.chk_status.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(31, 65);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(31, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 0;
            // 
            // pnl_display_title
            // 
            this.pnl_display_title.Controls.Add(this.label1);
            this.pnl_display_title.Controls.Add(this.label2);
            this.pnl_display_title.Controls.Add(this.label3);
            this.pnl_display_title.Controls.Add(this.label4);
            this.pnl_display_title.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_display_title.Location = new System.Drawing.Point(385, 29);
            this.pnl_display_title.Name = "pnl_display_title";
            this.pnl_display_title.Size = new System.Drawing.Size(107, 209);
            this.pnl_display_title.TabIndex = 6;
            this.pnl_display_title.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status";
            // 
            // txt_display_id
            // 
            this.txt_display_id.Location = new System.Drawing.Point(31, 26);
            this.txt_display_id.Name = "txt_display_id";
            this.txt_display_id.Size = new System.Drawing.Size(100, 20);
            this.txt_display_id.TabIndex = 0;
            // 
            // txt_display_name
            // 
            this.txt_display_name.Location = new System.Drawing.Point(31, 65);
            this.txt_display_name.Name = "txt_display_name";
            this.txt_display_name.Size = new System.Drawing.Size(100, 20);
            this.txt_display_name.TabIndex = 1;
            // 
            // rdb_display_gen_f
            // 
            this.rdb_display_gen_f.AutoSize = true;
            this.rdb_display_gen_f.Location = new System.Drawing.Point(31, 147);
            this.rdb_display_gen_f.Name = "rdb_display_gen_f";
            this.rdb_display_gen_f.Size = new System.Drawing.Size(31, 17);
            this.rdb_display_gen_f.TabIndex = 3;
            this.rdb_display_gen_f.TabStop = true;
            this.rdb_display_gen_f.Text = "F";
            this.rdb_display_gen_f.UseVisualStyleBackColor = true;
            // 
            // rdb_display_gen_m
            // 
            this.rdb_display_gen_m.AutoSize = true;
            this.rdb_display_gen_m.Location = new System.Drawing.Point(31, 171);
            this.rdb_display_gen_m.Name = "rdb_display_gen_m";
            this.rdb_display_gen_m.Size = new System.Drawing.Size(34, 17);
            this.rdb_display_gen_m.TabIndex = 4;
            this.rdb_display_gen_m.TabStop = true;
            this.rdb_display_gen_m.Text = "M";
            this.rdb_display_gen_m.UseVisualStyleBackColor = true;
            // 
            // pnl_display
            // 
            this.pnl_display.Controls.Add(this.chk_display_status);
            this.pnl_display.Controls.Add(this.rdb_display_gen_m);
            this.pnl_display.Controls.Add(this.rdb_display_gen_f);
            this.pnl_display.Controls.Add(this.txt_display_name);
            this.pnl_display.Controls.Add(this.txt_display_id);
            this.pnl_display.Location = new System.Drawing.Point(522, 29);
            this.pnl_display.Name = "pnl_display";
            this.pnl_display.Size = new System.Drawing.Size(200, 209);
            this.pnl_display.TabIndex = 7;
            this.pnl_display.Visible = false;
            // 
            // chk_display_status
            // 
            this.chk_display_status.AutoSize = true;
            this.chk_display_status.Location = new System.Drawing.Point(31, 107);
            this.chk_display_status.Name = "chk_display_status";
            this.chk_display_status.Size = new System.Drawing.Size(56, 17);
            this.chk_display_status.TabIndex = 5;
            this.chk_display_status.Text = "Active";
            this.chk_display_status.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_display);
            this.Controls.Add(this.pnl_display_title);
            this.Controls.Add(this.pnl_input);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Employee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_input.ResumeLayout(false);
            this.pnl_input.PerformLayout();
            this.pnl_display_title.ResumeLayout(false);
            this.pnl_display_title.PerformLayout();
            this.pnl_display.ResumeLayout(false);
            this.pnl_display.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_input;
        private System.Windows.Forms.RadioButton rdb_gender_m;
        private System.Windows.Forms.RadioButton rdb_gender_f;
        private System.Windows.Forms.CheckBox chk_status;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_display_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_display_id;
        private System.Windows.Forms.TextBox txt_display_name;
        private System.Windows.Forms.RadioButton rdb_display_gen_f;
        private System.Windows.Forms.RadioButton rdb_display_gen_m;
        private System.Windows.Forms.Panel pnl_display;
        private System.Windows.Forms.CheckBox chk_display_status;
    }
}

