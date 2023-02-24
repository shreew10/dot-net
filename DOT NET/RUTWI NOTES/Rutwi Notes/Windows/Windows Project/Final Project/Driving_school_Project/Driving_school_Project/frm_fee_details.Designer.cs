
namespace Driving_school_Project
{
    partial class frm_fee_details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_clear_fee = new System.Windows.Forms.Button();
            this.btn_save_fee = new System.Windows.Forms.Button();
            this.cmb_vehicle_type = new System.Windows.Forms.ComboBox();
            this.txt_fee_amount = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_fee_details = new System.Windows.Forms.DataGridView();
            this.edit_action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fee_details)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.btn_clear_fee);
            this.panel1.Controls.Add(this.btn_save_fee);
            this.panel1.Controls.Add(this.cmb_vehicle_type);
            this.panel1.Controls.Add(this.txt_fee_amount);
            this.panel1.Controls.Add(this.txt_category);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 272);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(25, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID:";
            this.label5.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(155, 34);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(166, 23);
            this.txt_id.TabIndex = 16;
            this.txt_id.Visible = false;
            // 
            // btn_clear_fee
            // 
            this.btn_clear_fee.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_clear_fee.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_fee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_clear_fee.Location = new System.Drawing.Point(246, 209);
            this.btn_clear_fee.Name = "btn_clear_fee";
            this.btn_clear_fee.Size = new System.Drawing.Size(75, 32);
            this.btn_clear_fee.TabIndex = 15;
            this.btn_clear_fee.Text = "Clear";
            this.btn_clear_fee.UseVisualStyleBackColor = false;
            this.btn_clear_fee.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save_fee
            // 
            this.btn_save_fee.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_save_fee.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_fee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_save_fee.Location = new System.Drawing.Point(155, 209);
            this.btn_save_fee.Name = "btn_save_fee";
            this.btn_save_fee.Size = new System.Drawing.Size(75, 32);
            this.btn_save_fee.TabIndex = 14;
            this.btn_save_fee.Text = "Save";
            this.btn_save_fee.UseVisualStyleBackColor = false;
            this.btn_save_fee.Click += new System.EventHandler(this.btn_save_fee_Click);
            // 
            // cmb_vehicle_type
            // 
            this.cmb_vehicle_type.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vehicle_type.FormattingEnabled = true;
            this.cmb_vehicle_type.Items.AddRange(new object[] {
            "LMV",
            "HMV"});
            this.cmb_vehicle_type.Location = new System.Drawing.Point(155, 117);
            this.cmb_vehicle_type.Name = "cmb_vehicle_type";
            this.cmb_vehicle_type.Size = new System.Drawing.Size(166, 23);
            this.cmb_vehicle_type.TabIndex = 6;
            // 
            // txt_fee_amount
            // 
            this.txt_fee_amount.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fee_amount.Location = new System.Drawing.Point(155, 159);
            this.txt_fee_amount.Name = "txt_fee_amount";
            this.txt_fee_amount.Size = new System.Drawing.Size(166, 23);
            this.txt_fee_amount.TabIndex = 5;
            // 
            // txt_category
            // 
            this.txt_category.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category.Location = new System.Drawing.Point(155, 74);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(166, 23);
            this.txt_category.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(25, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fee Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicle Type:";
            // 
            // dgv_fee_details
            // 
            this.dgv_fee_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fee_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit_action,
            this.delete_action});
            this.dgv_fee_details.Location = new System.Drawing.Point(570, 89);
            this.dgv_fee_details.Name = "dgv_fee_details";
            this.dgv_fee_details.Size = new System.Drawing.Size(479, 241);
            this.dgv_fee_details.TabIndex = 13;
            this.dgv_fee_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fee_details_CellContentClick);
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
            // frm_fee_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1092, 496);
            this.Controls.Add(this.dgv_fee_details);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frm_fee_details";
            this.Text = "Fee Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fee_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fee_amount;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.ComboBox cmb_vehicle_type;
        private System.Windows.Forms.DataGridView dgv_fee_details;
        private System.Windows.Forms.DataGridViewButtonColumn edit_action;
        private System.Windows.Forms.DataGridViewButtonColumn delete_action;
        private System.Windows.Forms.Button btn_save_fee;
        private System.Windows.Forms.Button btn_clear_fee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
    }
}