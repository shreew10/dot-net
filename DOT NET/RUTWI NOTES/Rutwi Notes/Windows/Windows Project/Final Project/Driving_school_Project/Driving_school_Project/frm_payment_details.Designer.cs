
namespace Driving_school_Project
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
            this.cmb_student_name = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_stud_aadhar_no = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_clear_payment = new System.Windows.Forms.Button();
            this.btn_save_payment = new System.Windows.Forms.Button();
            this.cmb_fee_type = new System.Windows.Forms.ComboBox();
            this.rdb_mode_of_payment_online = new System.Windows.Forms.RadioButton();
            this.rdb_mode_of_payment_cheque = new System.Windows.Forms.RadioButton();
            this.rdb_mode_of_payment_cash = new System.Windows.Forms.RadioButton();
            this.txt_receipt_no = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_payment_details = new System.Windows.Forms.DataGridView();
            this.edit_action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_cash_details_payment = new System.Windows.Forms.Panel();
            this.dt_paydate_cash = new System.Windows.Forms.DateTimePicker();
            this.txt_amount_adm_cash = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.pnl_cheque_details_payment = new System.Windows.Forms.Panel();
            this.txt_amount_adm_cheque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.dt_date_cheque = new System.Windows.Forms.DateTimePicker();
            this.dt_paydate_cheque = new System.Windows.Forms.DateTimePicker();
            this.txt_branch_cheque = new System.Windows.Forms.TextBox();
            this.txt_cheque_no = new System.Windows.Forms.TextBox();
            this.cmb_bank_cheque = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.pnl_online_details_payment = new System.Windows.Forms.Panel();
            this.txt_amount_adm_online = new System.Windows.Forms.TextBox();
            this.cmb_bank_online = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txt_id_online = new System.Windows.Forms.TextBox();
            this.dt_paydate_online = new System.Windows.Forms.DateTimePicker();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment_details)).BeginInit();
            this.pnl_cash_details_payment.SuspendLayout();
            this.pnl_cheque_details_payment.SuspendLayout();
            this.pnl_online_details_payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_student_name);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_stud_aadhar_no);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_clear_payment);
            this.panel1.Controls.Add(this.btn_save_payment);
            this.panel1.Controls.Add(this.cmb_fee_type);
            this.panel1.Controls.Add(this.rdb_mode_of_payment_online);
            this.panel1.Controls.Add(this.rdb_mode_of_payment_cheque);
            this.panel1.Controls.Add(this.rdb_mode_of_payment_cash);
            this.panel1.Controls.Add(this.txt_receipt_no);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 601);
            this.panel1.TabIndex = 1;
            // 
            // cmb_student_name
            // 
            this.cmb_student_name.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_student_name.FormattingEnabled = true;
            this.cmb_student_name.Location = new System.Drawing.Point(226, 15);
            this.cmb_student_name.Name = "cmb_student_name";
            this.cmb_student_name.Size = new System.Drawing.Size(216, 23);
            this.cmb_student_name.TabIndex = 70;
            this.cmb_student_name.SelectedIndexChanged += new System.EventHandler(this.cmb_student_name_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(37, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 69;
            this.label10.Text = "Student Name:";
            // 
            // txt_stud_aadhar_no
            // 
            this.txt_stud_aadhar_no.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stud_aadhar_no.Location = new System.Drawing.Point(226, 56);
            this.txt_stud_aadhar_no.Name = "txt_stud_aadhar_no";
            this.txt_stud_aadhar_no.Size = new System.Drawing.Size(216, 24);
            this.txt_stud_aadhar_no.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(37, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 17);
            this.label9.TabIndex = 67;
            this.label9.Text = "Student Aadhar Card No:";
            // 
            // btn_clear_payment
            // 
            this.btn_clear_payment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_clear_payment.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_payment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_clear_payment.Location = new System.Drawing.Point(349, 547);
            this.btn_clear_payment.Name = "btn_clear_payment";
            this.btn_clear_payment.Size = new System.Drawing.Size(75, 29);
            this.btn_clear_payment.TabIndex = 66;
            this.btn_clear_payment.Text = "Clear";
            this.btn_clear_payment.UseVisualStyleBackColor = false;
            this.btn_clear_payment.Click += new System.EventHandler(this.btn_clear_payment_Click);
            // 
            // btn_save_payment
            // 
            this.btn_save_payment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_save_payment.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_payment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_save_payment.Location = new System.Drawing.Point(210, 547);
            this.btn_save_payment.Name = "btn_save_payment";
            this.btn_save_payment.Size = new System.Drawing.Size(75, 29);
            this.btn_save_payment.TabIndex = 65;
            this.btn_save_payment.Text = "Save";
            this.btn_save_payment.UseVisualStyleBackColor = false;
            this.btn_save_payment.Click += new System.EventHandler(this.btn_save_payment_Click);
            // 
            // cmb_fee_type
            // 
            this.cmb_fee_type.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_fee_type.FormattingEnabled = true;
            this.cmb_fee_type.Items.AddRange(new object[] {
            "Admission Fee",
            "Training Fee",
            "License Fee"});
            this.cmb_fee_type.Location = new System.Drawing.Point(226, 146);
            this.cmb_fee_type.Name = "cmb_fee_type";
            this.cmb_fee_type.Size = new System.Drawing.Size(216, 23);
            this.cmb_fee_type.TabIndex = 19;
            // 
            // rdb_mode_of_payment_online
            // 
            this.rdb_mode_of_payment_online.AutoSize = true;
            this.rdb_mode_of_payment_online.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_mode_of_payment_online.Location = new System.Drawing.Point(366, 199);
            this.rdb_mode_of_payment_online.Name = "rdb_mode_of_payment_online";
            this.rdb_mode_of_payment_online.Size = new System.Drawing.Size(65, 21);
            this.rdb_mode_of_payment_online.TabIndex = 16;
            this.rdb_mode_of_payment_online.TabStop = true;
            this.rdb_mode_of_payment_online.Text = "Online";
            this.rdb_mode_of_payment_online.UseVisualStyleBackColor = true;
            this.rdb_mode_of_payment_online.CheckedChanged += new System.EventHandler(this.rdb_mode_of_payment_online_CheckedChanged);
            // 
            // rdb_mode_of_payment_cheque
            // 
            this.rdb_mode_of_payment_cheque.AutoSize = true;
            this.rdb_mode_of_payment_cheque.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_mode_of_payment_cheque.Location = new System.Drawing.Point(289, 199);
            this.rdb_mode_of_payment_cheque.Name = "rdb_mode_of_payment_cheque";
            this.rdb_mode_of_payment_cheque.Size = new System.Drawing.Size(72, 21);
            this.rdb_mode_of_payment_cheque.TabIndex = 15;
            this.rdb_mode_of_payment_cheque.TabStop = true;
            this.rdb_mode_of_payment_cheque.Text = "Cheque";
            this.rdb_mode_of_payment_cheque.UseVisualStyleBackColor = true;
            this.rdb_mode_of_payment_cheque.CheckedChanged += new System.EventHandler(this.rdb_mode_of_payment_cheque_CheckedChanged);
            // 
            // rdb_mode_of_payment_cash
            // 
            this.rdb_mode_of_payment_cash.AutoSize = true;
            this.rdb_mode_of_payment_cash.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_mode_of_payment_cash.Location = new System.Drawing.Point(226, 199);
            this.rdb_mode_of_payment_cash.Name = "rdb_mode_of_payment_cash";
            this.rdb_mode_of_payment_cash.Size = new System.Drawing.Size(55, 21);
            this.rdb_mode_of_payment_cash.TabIndex = 14;
            this.rdb_mode_of_payment_cash.TabStop = true;
            this.rdb_mode_of_payment_cash.Text = "Cash";
            this.rdb_mode_of_payment_cash.UseVisualStyleBackColor = true;
            this.rdb_mode_of_payment_cash.CheckedChanged += new System.EventHandler(this.rdb_mode_of_payment_cash_CheckedChanged);
            // 
            // txt_receipt_no
            // 
            this.txt_receipt_no.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_receipt_no.Location = new System.Drawing.Point(226, 102);
            this.txt_receipt_no.Name = "txt_receipt_no";
            this.txt_receipt_no.Size = new System.Drawing.Size(216, 24);
            this.txt_receipt_no.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(37, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fee Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(37, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Mode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(37, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt No.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(27, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 27);
            this.label11.TabIndex = 21;
            this.label11.Text = "PAYMENT DETAILS";
            // 
            // dgv_payment_details
            // 
            this.dgv_payment_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payment_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit_action,
            this.delete_action});
            this.dgv_payment_details.Location = new System.Drawing.Point(580, 74);
            this.dgv_payment_details.Name = "dgv_payment_details";
            this.dgv_payment_details.Size = new System.Drawing.Size(481, 252);
            this.dgv_payment_details.TabIndex = 22;
            this.dgv_payment_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_payment_details_CellContentClick);
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
            // pnl_cash_details_payment
            // 
            this.pnl_cash_details_payment.Controls.Add(this.dt_paydate_cash);
            this.pnl_cash_details_payment.Controls.Add(this.txt_amount_adm_cash);
            this.pnl_cash_details_payment.Controls.Add(this.label38);
            this.pnl_cash_details_payment.Controls.Add(this.label39);
            this.pnl_cash_details_payment.Location = new System.Drawing.Point(563, 135);
            this.pnl_cash_details_payment.Name = "pnl_cash_details_payment";
            this.pnl_cash_details_payment.Size = new System.Drawing.Size(481, 109);
            this.pnl_cash_details_payment.TabIndex = 31;
            this.pnl_cash_details_payment.Visible = false;
            // 
            // dt_paydate_cash
            // 
            this.dt_paydate_cash.CustomFormat = "dd/MM/yyyy";
            this.dt_paydate_cash.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_paydate_cash.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_paydate_cash.Location = new System.Drawing.Point(222, 66);
            this.dt_paydate_cash.Name = "dt_paydate_cash";
            this.dt_paydate_cash.Size = new System.Drawing.Size(242, 24);
            this.dt_paydate_cash.TabIndex = 72;
            // 
            // txt_amount_adm_cash
            // 
            this.txt_amount_adm_cash.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount_adm_cash.Location = new System.Drawing.Point(226, 16);
            this.txt_amount_adm_cash.Name = "txt_amount_adm_cash";
            this.txt_amount_adm_cash.Size = new System.Drawing.Size(149, 24);
            this.txt_amount_adm_cash.TabIndex = 31;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label38.Location = new System.Drawing.Point(37, 70);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(40, 17);
            this.label38.TabIndex = 71;
            this.label38.Text = "Date:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label39.Location = new System.Drawing.Point(37, 19);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(62, 17);
            this.label39.TabIndex = 30;
            this.label39.Text = "Amount:";
            // 
            // pnl_cheque_details_payment
            // 
            this.pnl_cheque_details_payment.Controls.Add(this.txt_amount_adm_cheque);
            this.pnl_cheque_details_payment.Controls.Add(this.label3);
            this.pnl_cheque_details_payment.Controls.Add(this.label37);
            this.pnl_cheque_details_payment.Controls.Add(this.dt_date_cheque);
            this.pnl_cheque_details_payment.Controls.Add(this.dt_paydate_cheque);
            this.pnl_cheque_details_payment.Controls.Add(this.txt_branch_cheque);
            this.pnl_cheque_details_payment.Controls.Add(this.txt_cheque_no);
            this.pnl_cheque_details_payment.Controls.Add(this.cmb_bank_cheque);
            this.pnl_cheque_details_payment.Controls.Add(this.label36);
            this.pnl_cheque_details_payment.Controls.Add(this.label35);
            this.pnl_cheque_details_payment.Controls.Add(this.label34);
            this.pnl_cheque_details_payment.Controls.Add(this.label33);
            this.pnl_cheque_details_payment.Location = new System.Drawing.Point(563, 260);
            this.pnl_cheque_details_payment.Name = "pnl_cheque_details_payment";
            this.pnl_cheque_details_payment.Size = new System.Drawing.Size(481, 274);
            this.pnl_cheque_details_payment.TabIndex = 31;
            this.pnl_cheque_details_payment.Visible = false;
            // 
            // txt_amount_adm_cheque
            // 
            this.txt_amount_adm_cheque.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount_adm_cheque.Location = new System.Drawing.Point(184, 13);
            this.txt_amount_adm_cheque.Name = "txt_amount_adm_cheque";
            this.txt_amount_adm_cheque.Size = new System.Drawing.Size(100, 23);
            this.txt_amount_adm_cheque.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(31, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Amount:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label37.Location = new System.Drawing.Point(31, 63);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 17);
            this.label37.TabIndex = 27;
            this.label37.Text = "Date:";
            // 
            // dt_date_cheque
            // 
            this.dt_date_cheque.CustomFormat = "dd/MM/yyyy";
            this.dt_date_cheque.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_date_cheque.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_date_cheque.Location = new System.Drawing.Point(184, 147);
            this.dt_date_cheque.Name = "dt_date_cheque";
            this.dt_date_cheque.Size = new System.Drawing.Size(256, 24);
            this.dt_date_cheque.TabIndex = 26;
            // 
            // dt_paydate_cheque
            // 
            this.dt_paydate_cheque.CustomFormat = "dd/MM/yyyy";
            this.dt_paydate_cheque.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_paydate_cheque.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_paydate_cheque.Location = new System.Drawing.Point(184, 58);
            this.dt_paydate_cheque.Name = "dt_paydate_cheque";
            this.dt_paydate_cheque.Size = new System.Drawing.Size(256, 24);
            this.dt_paydate_cheque.TabIndex = 25;
            // 
            // txt_branch_cheque
            // 
            this.txt_branch_cheque.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branch_cheque.Location = new System.Drawing.Point(184, 242);
            this.txt_branch_cheque.Name = "txt_branch_cheque";
            this.txt_branch_cheque.Size = new System.Drawing.Size(256, 23);
            this.txt_branch_cheque.TabIndex = 24;
            // 
            // txt_cheque_no
            // 
            this.txt_cheque_no.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cheque_no.Location = new System.Drawing.Point(184, 105);
            this.txt_cheque_no.Name = "txt_cheque_no";
            this.txt_cheque_no.Size = new System.Drawing.Size(149, 23);
            this.txt_cheque_no.TabIndex = 23;
            // 
            // cmb_bank_cheque
            // 
            this.cmb_bank_cheque.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bank_cheque.FormattingEnabled = true;
            this.cmb_bank_cheque.Items.AddRange(new object[] {
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
            this.cmb_bank_cheque.Location = new System.Drawing.Point(184, 195);
            this.cmb_bank_cheque.Name = "cmb_bank_cheque";
            this.cmb_bank_cheque.Size = new System.Drawing.Size(256, 21);
            this.cmb_bank_cheque.TabIndex = 22;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label36.Location = new System.Drawing.Point(31, 245);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(54, 17);
            this.label36.TabIndex = 21;
            this.label36.Text = "Branch:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label35.Location = new System.Drawing.Point(31, 196);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(42, 17);
            this.label35.TabIndex = 20;
            this.label35.Text = "Bank:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label34.Location = new System.Drawing.Point(31, 152);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(89, 17);
            this.label34.TabIndex = 19;
            this.label34.Text = "Cheque Date:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label33.Location = new System.Drawing.Point(31, 108);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(78, 17);
            this.label33.TabIndex = 18;
            this.label33.Text = "Cheque No:";
            // 
            // pnl_online_details_payment
            // 
            this.pnl_online_details_payment.Controls.Add(this.txt_amount_adm_online);
            this.pnl_online_details_payment.Controls.Add(this.cmb_bank_online);
            this.pnl_online_details_payment.Controls.Add(this.label41);
            this.pnl_online_details_payment.Controls.Add(this.txt_id_online);
            this.pnl_online_details_payment.Controls.Add(this.dt_paydate_online);
            this.pnl_online_details_payment.Controls.Add(this.label43);
            this.pnl_online_details_payment.Controls.Add(this.label42);
            this.pnl_online_details_payment.Controls.Add(this.label40);
            this.pnl_online_details_payment.Location = new System.Drawing.Point(553, 540);
            this.pnl_online_details_payment.Name = "pnl_online_details_payment";
            this.pnl_online_details_payment.Size = new System.Drawing.Size(481, 206);
            this.pnl_online_details_payment.TabIndex = 30;
            this.pnl_online_details_payment.Visible = false;
            // 
            // txt_amount_adm_online
            // 
            this.txt_amount_adm_online.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount_adm_online.Location = new System.Drawing.Point(184, 15);
            this.txt_amount_adm_online.Name = "txt_amount_adm_online";
            this.txt_amount_adm_online.Size = new System.Drawing.Size(149, 24);
            this.txt_amount_adm_online.TabIndex = 35;
            // 
            // cmb_bank_online
            // 
            this.cmb_bank_online.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bank_online.FormattingEnabled = true;
            this.cmb_bank_online.Items.AddRange(new object[] {
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
            this.cmb_bank_online.Location = new System.Drawing.Point(184, 161);
            this.cmb_bank_online.Name = "cmb_bank_online";
            this.cmb_bank_online.Size = new System.Drawing.Size(256, 21);
            this.cmb_bank_online.TabIndex = 35;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label41.Location = new System.Drawing.Point(31, 18);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(62, 17);
            this.label41.TabIndex = 34;
            this.label41.Text = "Amount:";
            // 
            // txt_id_online
            // 
            this.txt_id_online.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_online.Location = new System.Drawing.Point(184, 113);
            this.txt_id_online.Name = "txt_id_online";
            this.txt_id_online.Size = new System.Drawing.Size(175, 24);
            this.txt_id_online.TabIndex = 34;
            // 
            // dt_paydate_online
            // 
            this.dt_paydate_online.CustomFormat = "dd/MM/yyyy";
            this.dt_paydate_online.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_paydate_online.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_paydate_online.Location = new System.Drawing.Point(184, 62);
            this.dt_paydate_online.Name = "dt_paydate_online";
            this.dt_paydate_online.Size = new System.Drawing.Size(256, 24);
            this.dt_paydate_online.TabIndex = 32;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label43.Location = new System.Drawing.Point(31, 162);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(42, 17);
            this.label43.TabIndex = 31;
            this.label43.Text = "Bank:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label42.Location = new System.Drawing.Point(31, 116);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(97, 17);
            this.label42.TabIndex = 30;
            this.label42.Text = "Transaction ID:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label40.Location = new System.Drawing.Point(31, 67);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(40, 17);
            this.label40.TabIndex = 28;
            this.label40.Text = "Date:";
            // 
            // frm_payment_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1235, 749);
            this.Controls.Add(this.pnl_cash_details_payment);
            this.Controls.Add(this.pnl_online_details_payment);
            this.Controls.Add(this.pnl_cheque_details_payment);
            this.Controls.Add(this.dgv_payment_details);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Name = "frm_payment_details";
            this.Text = "Payment Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment_details)).EndInit();
            this.pnl_cash_details_payment.ResumeLayout(false);
            this.pnl_cash_details_payment.PerformLayout();
            this.pnl_cheque_details_payment.ResumeLayout(false);
            this.pnl_cheque_details_payment.PerformLayout();
            this.pnl_online_details_payment.ResumeLayout(false);
            this.pnl_online_details_payment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_fee_type;
        private System.Windows.Forms.RadioButton rdb_mode_of_payment_online;
        private System.Windows.Forms.RadioButton rdb_mode_of_payment_cheque;
        private System.Windows.Forms.RadioButton rdb_mode_of_payment_cash;
        private System.Windows.Forms.TextBox txt_receipt_no;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_save_payment;
        private System.Windows.Forms.Button btn_clear_payment;
        private System.Windows.Forms.DataGridView dgv_payment_details;
        private System.Windows.Forms.DataGridViewButtonColumn edit_action;
        private System.Windows.Forms.DataGridViewButtonColumn delete_action;
        private System.Windows.Forms.TextBox txt_stud_aadhar_no;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_student_name;
        private System.Windows.Forms.Panel pnl_cash_details_payment;
        private System.Windows.Forms.Panel pnl_cheque_details_payment;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DateTimePicker dt_date_cheque;
        private System.Windows.Forms.DateTimePicker dt_paydate_cheque;
        private System.Windows.Forms.TextBox txt_branch_cheque;
        private System.Windows.Forms.TextBox txt_cheque_no;
        private System.Windows.Forms.ComboBox cmb_bank_cheque;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txt_amount_adm_cash;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txt_amount_adm_cheque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_paydate_cash;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel pnl_online_details_payment;
        private System.Windows.Forms.TextBox txt_amount_adm_online;
        private System.Windows.Forms.ComboBox cmb_bank_online;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txt_id_online;
        private System.Windows.Forms.DateTimePicker dt_paydate_online;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label40;
    }
}