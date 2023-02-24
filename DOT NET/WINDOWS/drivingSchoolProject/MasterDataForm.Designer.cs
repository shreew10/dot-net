
namespace drivingSchoolProject
{
    partial class MasterDataForm
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
            this.btn_master_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_master_save = new System.Windows.Forms.Button();
            this.tb_mst_fee = new System.Windows.Forms.TextBox();
            this.cb_mst_veh = new System.Windows.Forms.ComboBox();
            this.cb_mst_category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_master_id = new System.Windows.Forms.TextBox();
            this.dgv_master_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_master_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_master_clear);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_master_save);
            this.panel1.Controls.Add(this.tb_mst_fee);
            this.panel1.Controls.Add(this.cb_mst_veh);
            this.panel1.Controls.Add(this.cb_mst_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_master_id);
            this.panel1.Location = new System.Drawing.Point(45, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 507);
            this.panel1.TabIndex = 0;
            // 
            // btn_master_clear
            // 
            this.btn_master_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_master_clear.Location = new System.Drawing.Point(292, 316);
            this.btn_master_clear.Name = "btn_master_clear";
            this.btn_master_clear.Size = new System.Drawing.Size(75, 32);
            this.btn_master_clear.TabIndex = 65;
            this.btn_master_clear.Text = "Clear";
            this.btn_master_clear.UseVisualStyleBackColor = true;
            this.btn_master_clear.Click += new System.EventHandler(this.btn_master_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "MASTER DATA";
            // 
            // btn_master_save
            // 
            this.btn_master_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_master_save.Location = new System.Drawing.Point(196, 316);
            this.btn_master_save.Name = "btn_master_save";
            this.btn_master_save.Size = new System.Drawing.Size(80, 32);
            this.btn_master_save.TabIndex = 64;
            this.btn_master_save.Text = "Save";
            this.btn_master_save.UseVisualStyleBackColor = true;
            this.btn_master_save.Click += new System.EventHandler(this.btn_master_save_Click);
            // 
            // tb_mst_fee
            // 
            this.tb_mst_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mst_fee.Location = new System.Drawing.Point(196, 266);
            this.tb_mst_fee.Name = "tb_mst_fee";
            this.tb_mst_fee.Size = new System.Drawing.Size(285, 28);
            this.tb_mst_fee.TabIndex = 19;
            // 
            // cb_mst_veh
            // 
            this.cb_mst_veh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mst_veh.FormattingEnabled = true;
            this.cb_mst_veh.Items.AddRange(new object[] {
            "Mercedes Benz",
            "BMW 720D",
            "Audi Q7"});
            this.cb_mst_veh.Location = new System.Drawing.Point(196, 219);
            this.cb_mst_veh.Name = "cb_mst_veh";
            this.cb_mst_veh.Size = new System.Drawing.Size(285, 30);
            this.cb_mst_veh.TabIndex = 18;
            // 
            // cb_mst_category
            // 
            this.cb_mst_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mst_category.FormattingEnabled = true;
            this.cb_mst_category.Items.AddRange(new object[] {
            "Admission",
            "Training",
            "License"});
            this.cb_mst_category.Location = new System.Drawing.Point(196, 167);
            this.cb_mst_category.Name = "cb_mst_category";
            this.cb_mst_category.Size = new System.Drawing.Size(285, 30);
            this.cb_mst_category.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Master ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fee Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vehicle Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Category";
            // 
            // tb_master_id
            // 
            this.tb_master_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_master_id.Location = new System.Drawing.Point(196, 110);
            this.tb_master_id.Name = "tb_master_id";
            this.tb_master_id.Size = new System.Drawing.Size(285, 28);
            this.tb_master_id.TabIndex = 16;
            // 
            // dgv_master_data
            // 
            this.dgv_master_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_master_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_master_data.Location = new System.Drawing.Point(694, 122);
            this.dgv_master_data.Name = "dgv_master_data";
            this.dgv_master_data.RowHeadersWidth = 51;
            this.dgv_master_data.RowTemplate.Height = 24;
            this.dgv_master_data.Size = new System.Drawing.Size(938, 433);
            this.dgv_master_data.TabIndex = 65;
            this.dgv_master_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_master_data_CellContentClick);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(688, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 32);
            this.label6.TabIndex = 66;
            this.label6.Text = "MASTER DATA LIST";
            // 
            // MasterDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 784);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_master_data);
            this.Controls.Add(this.panel1);
            this.Name = "MasterDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterDataForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_master_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mst_fee;
        private System.Windows.Forms.ComboBox cb_mst_veh;
        private System.Windows.Forms.ComboBox cb_mst_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_master_id;
        private System.Windows.Forms.Button btn_master_clear;
        private System.Windows.Forms.Button btn_master_save;
        private System.Windows.Forms.DataGridView dgv_master_data;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Label label6;
    }
}