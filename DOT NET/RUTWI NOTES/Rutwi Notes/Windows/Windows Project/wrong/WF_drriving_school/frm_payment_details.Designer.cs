
namespace WF_drriving_school
{
    partial class frm_payment_details
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_fee_type = new System.Windows.Forms.ComboBox();
            this.cmb_bank_name = new System.Windows.Forms.ComboBox();
            this.dt_cheque_date = new System.Windows.Forms.DateTimePicker();
            this.rdb_mode_of_payment_online = new System.Windows.Forms.RadioButton();
            this.rdb_mode_of_payment_cheque = new System.Windows.Forms.RadioButton();
            this.rdb_mode_of_payment_cash = new System.Windows.Forms.RadioButton();
            this.txt_stud_aadhar_no = new System.Windows.Forms.TextBox();
            this.txt_branch = new System.Windows.Forms.TextBox();
            this.txt_cheque_no = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_receipt_no = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmb_fee_type);
            this.panel1.Controls.Add(this.cmb_bank_name);
            this.panel1.Controls.Add(this.dt_cheque_date);
            this.panel1.Controls.Add(this.rdb_mode_of_payment_online);
            this.panel1.Controls.Add(this.rdb_mode_of_payment_cheque);
            this.panel1.Controls.Add(this.rdb_mode_of_payment_cash);
            this.panel1.Controls.Add(this.txt_stud_aadhar_no);
            this.panel1.Controls.Add(this.txt_branch);
            this.panel1.Controls.Add(this.txt_cheque_no);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.txt_receipt_no);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 555);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(181, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "PAYMENT DETAILS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Bank Details:";
            // 
            // cmb_fee_type
            // 
            this.cmb_fee_type.FormattingEnabled = true;
            this.cmb_fee_type.Location = new System.Drawing.Point(221, 446);
            this.cmb_fee_type.Name = "cmb_fee_type";
            this.cmb_fee_type.Size = new System.Drawing.Size(216, 21);
            this.cmb_fee_type.TabIndex = 19;
            // 
            // cmb_bank_name
            // 
            this.cmb_bank_name.FormattingEnabled = true;
            this.cmb_bank_name.Items.AddRange(new object[] {
            "Allahabad Bank",
            "Andhra Bank",
            "Axis Bank",
            "Bank of Bahrain and Kuwait",
            "Bank of Baroda - Corporate Banking",
            "Bank of Baroda - Retail Banking",
            "Bank of India",
            "Bank of Maharashtra",
            "Canara Bank",
            "Central Bank of India",
            "City Union Bank",
            "Corporation Bank",
            "Deutsche Bank",
            "Development Credit Bank",
            "Dhanlaxmi Bank",
            "Federal Bank",
            "ICICI Bank",
            "IDBI Bank",
            "Indian Bank",
            "Indian Overseas Bank",
            "IndusInd Bank",
            "ING Vysya Bank",
            "Jammu and Kashmir Bank",
            "Karnataka Bank Ltd",
            "Karur Vysya Bank",
            "Kotak Bank",
            "Laxmi Vilas Bank",
            "Oriental Bank of Commerce",
            "Punjab National Bank - Corporate Banking",
            "Punjab National Bank - Retail Banking",
            "Punjab & Sind Bank",
            "Shamrao Vitthal Co-operative Bank",
            "South Indian Bank",
            "State Bank of Bikaner & Jaipur",
            "State Bank of Hyderabad",
            "State Bank of India",
            "State Bank of Mysore",
            "State Bank of Patiala",
            "State Bank of Travancore",
            "Syndicate Bank",
            "Tamilnad Mercantile Bank Ltd.",
            "UCO Bank",
            "Union Bank of India",
            "United Bank of India",
            "Vijaya Bank",
            "Yes Bank Ltd"});
            this.cmb_bank_name.Location = new System.Drawing.Point(239, 337);
            this.cmb_bank_name.Name = "cmb_bank_name";
            this.cmb_bank_name.Size = new System.Drawing.Size(216, 21);
            this.cmb_bank_name.TabIndex = 18;
            // 
            // dt_cheque_date
            // 
            this.dt_cheque_date.Location = new System.Drawing.Point(237, 273);
            this.dt_cheque_date.Name = "dt_cheque_date";
            this.dt_cheque_date.Size = new System.Drawing.Size(200, 20);
            this.dt_cheque_date.TabIndex = 17;
            // 
            // rdb_mode_of_payment_online
            // 
            this.rdb_mode_of_payment_online.AutoSize = true;
            this.rdb_mode_of_payment_online.Location = new System.Drawing.Point(400, 136);
            this.rdb_mode_of_payment_online.Name = "rdb_mode_of_payment_online";
            this.rdb_mode_of_payment_online.Size = new System.Drawing.Size(55, 17);
            this.rdb_mode_of_payment_online.TabIndex = 16;
            this.rdb_mode_of_payment_online.TabStop = true;
            this.rdb_mode_of_payment_online.Text = "Online";
            this.rdb_mode_of_payment_online.UseVisualStyleBackColor = true;
            // 
            // rdb_mode_of_payment_cheque
            // 
            this.rdb_mode_of_payment_cheque.AutoSize = true;
            this.rdb_mode_of_payment_cheque.Location = new System.Drawing.Point(320, 136);
            this.rdb_mode_of_payment_cheque.Name = "rdb_mode_of_payment_cheque";
            this.rdb_mode_of_payment_cheque.Size = new System.Drawing.Size(62, 17);
            this.rdb_mode_of_payment_cheque.TabIndex = 15;
            this.rdb_mode_of_payment_cheque.TabStop = true;
            this.rdb_mode_of_payment_cheque.Text = "Cheque";
            this.rdb_mode_of_payment_cheque.UseVisualStyleBackColor = true;
            // 
            // rdb_mode_of_payment_cash
            // 
            this.rdb_mode_of_payment_cash.AutoSize = true;
            this.rdb_mode_of_payment_cash.Location = new System.Drawing.Point(248, 136);
            this.rdb_mode_of_payment_cash.Name = "rdb_mode_of_payment_cash";
            this.rdb_mode_of_payment_cash.Size = new System.Drawing.Size(49, 17);
            this.rdb_mode_of_payment_cash.TabIndex = 14;
            this.rdb_mode_of_payment_cash.TabStop = true;
            this.rdb_mode_of_payment_cash.Text = "Cash";
            this.rdb_mode_of_payment_cash.UseVisualStyleBackColor = true;
            // 
            // txt_stud_aadhar_no
            // 
            this.txt_stud_aadhar_no.Location = new System.Drawing.Point(248, 486);
            this.txt_stud_aadhar_no.Name = "txt_stud_aadhar_no";
            this.txt_stud_aadhar_no.Size = new System.Drawing.Size(216, 20);
            this.txt_stud_aadhar_no.TabIndex = 13;
            // 
            // txt_branch
            // 
            this.txt_branch.Location = new System.Drawing.Point(237, 397);
            this.txt_branch.Name = "txt_branch";
            this.txt_branch.Size = new System.Drawing.Size(216, 20);
            this.txt_branch.TabIndex = 12;
            // 
            // txt_cheque_no
            // 
            this.txt_cheque_no.Location = new System.Drawing.Point(237, 228);
            this.txt_cheque_no.Name = "txt_cheque_no";
            this.txt_cheque_no.Size = new System.Drawing.Size(152, 20);
            this.txt_cheque_no.TabIndex = 11;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(237, 184);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_amount.TabIndex = 10;
            // 
            // txt_receipt_no
            // 
            this.txt_receipt_no.Location = new System.Drawing.Point(248, 81);
            this.txt_receipt_no.Name = "txt_receipt_no";
            this.txt_receipt_no.Size = new System.Drawing.Size(216, 20);
            this.txt_receipt_no.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Student Aadhar Card No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fee Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Branch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bank Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cheque Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cheque No.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Mode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt No.:";
            // 
            // frm_payment_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Name = "frm_payment_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_stud_aadhar_no;
        private System.Windows.Forms.TextBox txt_branch;
        private System.Windows.Forms.TextBox txt_cheque_no;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_receipt_no;
        private System.Windows.Forms.RadioButton rdb_mode_of_payment_cash;
        private System.Windows.Forms.RadioButton rdb_mode_of_payment_online;
        private System.Windows.Forms.RadioButton rdb_mode_of_payment_cheque;
        private System.Windows.Forms.DateTimePicker dt_cheque_date;
        private System.Windows.Forms.ComboBox cmb_bank_name;
        private System.Windows.Forms.ComboBox cmb_fee_type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}