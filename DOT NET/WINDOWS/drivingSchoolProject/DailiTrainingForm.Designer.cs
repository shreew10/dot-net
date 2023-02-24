
namespace drivingSchoolProject
{
    partial class DailiTrainingForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_training_aadhar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_training_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_training_clear = new System.Windows.Forms.Button();
            this.btn_training_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_stud_Training_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_stud_daily_kms = new System.Windows.Forms.TextBox();
            this.tb_stud_training_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblstudentdetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.db_drving_schoolDataSet3 = new drivingSchoolProject.db_drving_schoolDataSet3();
            this.tblstudentdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_drving_schoolDataSet1 = new drivingSchoolProject.db_drving_schoolDataSet1();
            this.tbl_student_detailsTableAdapter = new drivingSchoolProject.db_drving_schoolDataSet1TableAdapters.tbl_student_detailsTableAdapter();
            this.db_drving_schoolDataSet2 = new drivingSchoolProject.db_drving_schoolDataSet2();
            this.tblstudentdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_student_detailsTableAdapter1 = new drivingSchoolProject.db_drving_schoolDataSet2TableAdapters.tbl_student_detailsTableAdapter();
            this.tbl_student_detailsTableAdapter2 = new drivingSchoolProject.db_drving_schoolDataSet3TableAdapters.tbl_student_detailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_training_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentdetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_drving_schoolDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_drving_schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_drving_schoolDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentdetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_training_aadhar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgv_training_data);
            this.panel1.Controls.Add(this.btn_training_clear);
            this.panel1.Controls.Add(this.btn_training_save);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtp_stud_Training_date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_stud_daily_kms);
            this.panel1.Controls.Add(this.tb_stud_training_id);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1765, 896);
            this.panel1.TabIndex = 0;
            // 
            // cb_training_aadhar
            // 
            this.cb_training_aadhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_training_aadhar.FormattingEnabled = true;
            this.cb_training_aadhar.Location = new System.Drawing.Point(292, 221);
            this.cb_training_aadhar.Name = "cb_training_aadhar";
            this.cb_training_aadhar.Size = new System.Drawing.Size(285, 30);
            this.cb_training_aadhar.TabIndex = 69;
            this.cb_training_aadhar.SelectedIndexChanged += new System.EventHandler(this.cb_training_aadhar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(808, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 32);
            this.label4.TabIndex = 68;
            this.label4.Text = "Daily Training List";
            // 
            // dgv_training_data
            // 
            this.dgv_training_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_training_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_training_data.Location = new System.Drawing.Point(814, 108);
            this.dgv_training_data.Name = "dgv_training_data";
            this.dgv_training_data.RowHeadersWidth = 51;
            this.dgv_training_data.RowTemplate.Height = 24;
            this.dgv_training_data.Size = new System.Drawing.Size(832, 433);
            this.dgv_training_data.TabIndex = 67;
            this.dgv_training_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_training_data_CellContentClick);
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
            // btn_training_clear
            // 
            this.btn_training_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_training_clear.Location = new System.Drawing.Point(388, 323);
            this.btn_training_clear.Name = "btn_training_clear";
            this.btn_training_clear.Size = new System.Drawing.Size(75, 32);
            this.btn_training_clear.TabIndex = 66;
            this.btn_training_clear.Text = "Clear";
            this.btn_training_clear.UseVisualStyleBackColor = true;
            this.btn_training_clear.Click += new System.EventHandler(this.btn_training_clear_Click);
            // 
            // btn_training_save
            // 
            this.btn_training_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_training_save.Location = new System.Drawing.Point(292, 323);
            this.btn_training_save.Name = "btn_training_save";
            this.btn_training_save.Size = new System.Drawing.Size(80, 32);
            this.btn_training_save.TabIndex = 65;
            this.btn_training_save.Text = "Save";
            this.btn_training_save.UseVisualStyleBackColor = true;
            this.btn_training_save.Click += new System.EventHandler(this.btn_training_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 32);
            this.label3.TabIndex = 56;
            this.label3.Text = "Daily Training Information";
            // 
            // dtp_stud_Training_date
            // 
            this.dtp_stud_Training_date.CustomFormat = "dd/MM/yyyy";
            this.dtp_stud_Training_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_stud_Training_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_stud_Training_date.Location = new System.Drawing.Point(292, 164);
            this.dtp_stud_Training_date.Name = "dtp_stud_Training_date";
            this.dtp_stud_Training_date.Size = new System.Drawing.Size(285, 28);
            this.dtp_stud_Training_date.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Student Adhar Card";
            // 
            // tb_stud_daily_kms
            // 
            this.tb_stud_daily_kms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stud_daily_kms.Location = new System.Drawing.Point(292, 278);
            this.tb_stud_daily_kms.Name = "tb_stud_daily_kms";
            this.tb_stud_daily_kms.Size = new System.Drawing.Size(285, 28);
            this.tb_stud_daily_kms.TabIndex = 39;
            // 
            // tb_stud_training_id
            // 
            this.tb_stud_training_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stud_training_id.Location = new System.Drawing.Point(292, 110);
            this.tb_stud_training_id.Name = "tb_stud_training_id";
            this.tb_stud_training_id.Size = new System.Drawing.Size(285, 28);
            this.tb_stud_training_id.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "Student Daily Kms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Training Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Training Id";
            // 
            // tblstudentdetailsBindingSource2
            // 
            this.tblstudentdetailsBindingSource2.DataMember = "tbl_student_details";
            this.tblstudentdetailsBindingSource2.DataSource = this.db_drving_schoolDataSet3;
            // 
            // db_drving_schoolDataSet3
            // 
            this.db_drving_schoolDataSet3.DataSetName = "db_drving_schoolDataSet3";
            this.db_drving_schoolDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblstudentdetailsBindingSource
            // 
            this.tblstudentdetailsBindingSource.DataMember = "tbl_student_details";
            this.tblstudentdetailsBindingSource.DataSource = this.db_drving_schoolDataSet1;
            // 
            // db_drving_schoolDataSet1
            // 
            this.db_drving_schoolDataSet1.DataSetName = "db_drving_schoolDataSet1";
            this.db_drving_schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_student_detailsTableAdapter
            // 
            this.tbl_student_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // db_drving_schoolDataSet2
            // 
            this.db_drving_schoolDataSet2.DataSetName = "db_drving_schoolDataSet2";
            this.db_drving_schoolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblstudentdetailsBindingSource1
            // 
            this.tblstudentdetailsBindingSource1.DataMember = "tbl_student_details";
            this.tblstudentdetailsBindingSource1.DataSource = this.db_drving_schoolDataSet2;
            // 
            // tbl_student_detailsTableAdapter1
            // 
            this.tbl_student_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_student_detailsTableAdapter2
            // 
            this.tbl_student_detailsTableAdapter2.ClearBeforeFill = true;
            // 
            // DailiTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1765, 896);
            this.Controls.Add(this.panel1);
            this.Name = "DailiTrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailiTrainingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DailiTrainingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_training_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentdetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_drving_schoolDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_drving_schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_drving_schoolDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentdetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_stud_daily_kms;
        private System.Windows.Forms.TextBox tb_stud_training_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_stud_Training_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_training_data;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button btn_training_clear;
        private System.Windows.Forms.Button btn_training_save;
        private System.Windows.Forms.Label label4;
        private db_drving_schoolDataSet1 db_drving_schoolDataSet1;
        private System.Windows.Forms.BindingSource tblstudentdetailsBindingSource;
        private db_drving_schoolDataSet1TableAdapters.tbl_student_detailsTableAdapter tbl_student_detailsTableAdapter;
        private db_drving_schoolDataSet2 db_drving_schoolDataSet2;
        private System.Windows.Forms.BindingSource tblstudentdetailsBindingSource1;
        private db_drving_schoolDataSet2TableAdapters.tbl_student_detailsTableAdapter tbl_student_detailsTableAdapter1;
        private System.Windows.Forms.ComboBox cb_training_aadhar;
        private db_drving_schoolDataSet3 db_drving_schoolDataSet3;
        private System.Windows.Forms.BindingSource tblstudentdetailsBindingSource2;
        private db_drving_schoolDataSet3TableAdapters.tbl_student_detailsTableAdapter tbl_student_detailsTableAdapter2;
    }
}