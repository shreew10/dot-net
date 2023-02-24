
namespace drivingSchoolProject
{
    partial class PaymentDetailsForm
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
            this.tb_payment_aadhar = new System.Windows.Forms.TextBox();
            this.dtp_paydate = new System.Windows.Forms.DateTimePicker();
            this.lbl_paydate = new System.Windows.Forms.Label();
            this.rb_cheq_pay = new System.Windows.Forms.RadioButton();
            this.rb_online_pay = new System.Windows.Forms.RadioButton();
            this.rb_cash_pay = new System.Windows.Forms.RadioButton();
            this.cb_stuname_paydet = new System.Windows.Forms.ComboBox();
            this.tblstudentdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_drving_schoolDataSet = new drivingSchoolProject.db_drving_schoolDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_payment_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_payment_details_clear = new System.Windows.Forms.Button();
            this.btn_payment_details_save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_stud_bank = new System.Windows.Forms.ComboBox();
            this.cb_stud_fee_type = new System.Windows.Forms.ComboBox();
            this.tb_stud_bank_branch = new System.Windows.Forms.TextBox();
            this.dtp_stud_cheq_date = new System.Windows.Forms.DateTimePicker();
            this.tb_stud_cheque_no = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_cheqno = new System.Windows.Forms.Label();
            this.tb_stud_amount = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_stud_recpt_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cheqdate = new System.Windows.Forms.Label();
            this.lbl_branchname = new System.Windows.Forms.Label();
            this.lbl_bnkname = new System.Windows.Forms.Label();
            this.tbl_student_detailsTableAdapter = new drivingSchoolProject.db_drving_schoolDataSetTableAdapters.tbl_student_detailsTableAdapter();
            this.pnl_cash_amount = new System.Windows.Forms.Panel();
            this.pnl_online_data = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_cheque_data = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_drving_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment_data)).BeginInit();
            this.pnl_cash_amount.SuspendLayout();
            this.pnl_online_data.SuspendLayout();
            this.pnl_cheque_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_cheque_data);
            this.panel1.Controls.Add(this.pnl_online_data);
            this.panel1.Controls.Add(this.pnl_cash_amount);
            this.panel1.Controls.Add(this.tb_payment_aadhar);
            this.panel1.Controls.Add(this.dtp_paydate);
            this.panel1.Controls.Add(this.lbl_paydate);
            this.panel1.Controls.Add(this.rb_cheq_pay);
            this.panel1.Controls.Add(this.rb_online_pay);
            this.panel1.Controls.Add(this.rb_cash_pay);
            this.panel1.Controls.Add(this.cb_stuname_paydet);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dgv_payment_data);
            this.panel1.Controls.Add(this.btn_payment_details_clear);
            this.panel1.Controls.Add(this.btn_payment_details_save);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cb_stud_fee_type);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_stud_recpt_no);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1773, 1029);
            this.panel1.TabIndex = 0;
            // 
            // tb_payment_aadhar
            // 
            this.tb_payment_aadhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_payment_aadhar.Location = new System.Drawing.Point(344, 108);
            this.tb_payment_aadhar.Name = "tb_payment_aadhar";
            this.tb_payment_aadhar.Size = new System.Drawing.Size(285, 28);
            this.tb_payment_aadhar.TabIndex = 76;
            // 
            // dtp_paydate
            // 
            this.dtp_paydate.CustomFormat = "dd/MM/yyyy";
            this.dtp_paydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_paydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_paydate.Location = new System.Drawing.Point(344, 214);
            this.dtp_paydate.Name = "dtp_paydate";
            this.dtp_paydate.Size = new System.Drawing.Size(285, 28);
            this.dtp_paydate.TabIndex = 75;
            // 
            // lbl_paydate
            // 
            this.lbl_paydate.AutoSize = true;
            this.lbl_paydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paydate.Location = new System.Drawing.Point(40, 214);
            this.lbl_paydate.Name = "lbl_paydate";
            this.lbl_paydate.Size = new System.Drawing.Size(92, 24);
            this.lbl_paydate.TabIndex = 74;
            this.lbl_paydate.Text = "Pay Date";
            // 
            // rb_cheq_pay
            // 
            this.rb_cheq_pay.AutoSize = true;
            this.rb_cheq_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cheq_pay.Location = new System.Drawing.Point(522, 325);
            this.rb_cheq_pay.Name = "rb_cheq_pay";
            this.rb_cheq_pay.Size = new System.Drawing.Size(99, 28);
            this.rb_cheq_pay.TabIndex = 73;
            this.rb_cheq_pay.TabStop = true;
            this.rb_cheq_pay.Text = "Cheque";
            this.rb_cheq_pay.UseVisualStyleBackColor = true;
            this.rb_cheq_pay.CheckedChanged += new System.EventHandler(this.rb_cheq_pay_CheckedChanged);
            // 
            // rb_online_pay
            // 
            this.rb_online_pay.AutoSize = true;
            this.rb_online_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_online_pay.Location = new System.Drawing.Point(421, 325);
            this.rb_online_pay.Name = "rb_online_pay";
            this.rb_online_pay.Size = new System.Drawing.Size(87, 28);
            this.rb_online_pay.TabIndex = 72;
            this.rb_online_pay.TabStop = true;
            this.rb_online_pay.Text = "Online";
            this.rb_online_pay.UseVisualStyleBackColor = true;
            this.rb_online_pay.CheckedChanged += new System.EventHandler(this.rb_online_pay_CheckedChanged);
            // 
            // rb_cash_pay
            // 
            this.rb_cash_pay.AutoSize = true;
            this.rb_cash_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cash_pay.Location = new System.Drawing.Point(343, 325);
            this.rb_cash_pay.Name = "rb_cash_pay";
            this.rb_cash_pay.Size = new System.Drawing.Size(74, 28);
            this.rb_cash_pay.TabIndex = 71;
            this.rb_cash_pay.TabStop = true;
            this.rb_cash_pay.Text = "Cash";
            this.rb_cash_pay.UseVisualStyleBackColor = true;
            this.rb_cash_pay.CheckedChanged += new System.EventHandler(this.rb_cash_pay_CheckedChanged);
            // 
            // cb_stuname_paydet
            // 
            this.cb_stuname_paydet.DataSource = this.tblstudentdetailsBindingSource;
            this.cb_stuname_paydet.DisplayMember = "stud_name";
            this.cb_stuname_paydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_stuname_paydet.FormattingEnabled = true;
            this.cb_stuname_paydet.Location = new System.Drawing.Point(343, 60);
            this.cb_stuname_paydet.Name = "cb_stuname_paydet";
            this.cb_stuname_paydet.Size = new System.Drawing.Size(285, 30);
            this.cb_stuname_paydet.TabIndex = 70;
            this.cb_stuname_paydet.SelectedIndexChanged += new System.EventHandler(this.cb_stuname_paydet_SelectedIndexChanged);
            // 
            // tblstudentdetailsBindingSource
            // 
            this.tblstudentdetailsBindingSource.DataMember = "tbl_student_details";
            this.tblstudentdetailsBindingSource.DataSource = this.db_drving_schoolDataSet;
            // 
            // db_drving_schoolDataSet
            // 
            this.db_drving_schoolDataSet.DataSetName = "db_drving_schoolDataSet";
            this.db_drving_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 24);
            this.label12.TabIndex = 69;
            this.label12.Text = "Student Name";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(791, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 32);
            this.label11.TabIndex = 67;
            this.label11.Text = "Payment List";
            // 
            // dgv_payment_data
            // 
            this.dgv_payment_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payment_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_payment_data.Location = new System.Drawing.Point(797, 149);
            this.dgv_payment_data.Name = "dgv_payment_data";
            this.dgv_payment_data.RowHeadersWidth = 51;
            this.dgv_payment_data.RowTemplate.Height = 24;
            this.dgv_payment_data.Size = new System.Drawing.Size(814, 433);
            this.dgv_payment_data.TabIndex = 66;
            this.dgv_payment_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_payment_data_CellContentClick);
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
            // btn_payment_details_clear
            // 
            this.btn_payment_details_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment_details_clear.Location = new System.Drawing.Point(439, 626);
            this.btn_payment_details_clear.Name = "btn_payment_details_clear";
            this.btn_payment_details_clear.Size = new System.Drawing.Size(75, 32);
            this.btn_payment_details_clear.TabIndex = 65;
            this.btn_payment_details_clear.Text = "Clear";
            this.btn_payment_details_clear.UseVisualStyleBackColor = true;
            this.btn_payment_details_clear.Click += new System.EventHandler(this.btn_payment_details_clear_Click);
            // 
            // btn_payment_details_save
            // 
            this.btn_payment_details_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment_details_save.Location = new System.Drawing.Point(343, 626);
            this.btn_payment_details_save.Name = "btn_payment_details_save";
            this.btn_payment_details_save.Size = new System.Drawing.Size(80, 32);
            this.btn_payment_details_save.TabIndex = 64;
            this.btn_payment_details_save.Text = "Save";
            this.btn_payment_details_save.UseVisualStyleBackColor = true;
            this.btn_payment_details_save.Click += new System.EventHandler(this.btn_payment_details_save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 32);
            this.label10.TabIndex = 62;
            this.label10.Text = "Payment Details";
            // 
            // cb_stud_bank
            // 
            this.cb_stud_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_stud_bank.FormattingEnabled = true;
            this.cb_stud_bank.Items.AddRange(new object[] {
            "SBI",
            "ICICI",
            "YES BANK",
            "IDBI BANK",
            "BOB",
            "BANK OF INDIA",
            "HDFC BANK",
            "CANARA BANK",
            "AU FINANCE BANK"});
            this.cb_stud_bank.Location = new System.Drawing.Point(317, 105);
            this.cb_stud_bank.Name = "cb_stud_bank";
            this.cb_stud_bank.Size = new System.Drawing.Size(285, 30);
            this.cb_stud_bank.TabIndex = 61;
            // 
            // cb_stud_fee_type
            // 
            this.cb_stud_fee_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_stud_fee_type.FormattingEnabled = true;
            this.cb_stud_fee_type.Items.AddRange(new object[] {
            "Admission",
            "Training",
            "License"});
            this.cb_stud_fee_type.Location = new System.Drawing.Point(344, 269);
            this.cb_stud_fee_type.Name = "cb_stud_fee_type";
            this.cb_stud_fee_type.Size = new System.Drawing.Size(285, 30);
            this.cb_stud_fee_type.TabIndex = 60;
            // 
            // tb_stud_bank_branch
            // 
            this.tb_stud_bank_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stud_bank_branch.Location = new System.Drawing.Point(317, 151);
            this.tb_stud_bank_branch.Name = "tb_stud_bank_branch";
            this.tb_stud_bank_branch.Size = new System.Drawing.Size(285, 28);
            this.tb_stud_bank_branch.TabIndex = 59;
            // 
            // dtp_stud_cheq_date
            // 
            this.dtp_stud_cheq_date.CustomFormat = "dd/MM/yyyy";
            this.dtp_stud_cheq_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_stud_cheq_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_stud_cheq_date.Location = new System.Drawing.Point(316, 195);
            this.dtp_stud_cheq_date.Name = "dtp_stud_cheq_date";
            this.dtp_stud_cheq_date.Size = new System.Drawing.Size(285, 28);
            this.dtp_stud_cheq_date.TabIndex = 57;
            // 
            // tb_stud_cheque_no
            // 
            this.tb_stud_cheque_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stud_cheque_no.Location = new System.Drawing.Point(317, 63);
            this.tb_stud_cheque_no.Name = "tb_stud_cheque_no";
            this.tb_stud_cheque_no.Size = new System.Drawing.Size(285, 28);
            this.tb_stud_cheque_no.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Student Adhar Card";
            // 
            // lbl_cheqno
            // 
            this.lbl_cheqno.AutoSize = true;
            this.lbl_cheqno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cheqno.Location = new System.Drawing.Point(12, 63);
            this.lbl_cheqno.Name = "lbl_cheqno";
            this.lbl_cheqno.Size = new System.Drawing.Size(255, 24);
            this.lbl_cheqno.TabIndex = 48;
            this.lbl_cheqno.Text = "Cheque No/Transaction Id";
            // 
            // tb_stud_amount
            // 
            this.tb_stud_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stud_amount.Location = new System.Drawing.Point(317, 11);
            this.tb_stud_amount.Name = "tb_stud_amount";
            this.tb_stud_amount.Size = new System.Drawing.Size(285, 28);
            this.tb_stud_amount.TabIndex = 47;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(13, 15);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(82, 24);
            this.lbl_amount.TabIndex = 46;
            this.lbl_amount.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Mode Of Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Fee Type";
            // 
            // tb_stud_recpt_no
            // 
            this.tb_stud_recpt_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stud_recpt_no.Location = new System.Drawing.Point(343, 152);
            this.tb_stud_recpt_no.Name = "tb_stud_recpt_no";
            this.tb_stud_recpt_no.Size = new System.Drawing.Size(285, 28);
            this.tb_stud_recpt_no.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Reciept Number";
            // 
            // lbl_cheqdate
            // 
            this.lbl_cheqdate.AutoSize = true;
            this.lbl_cheqdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cheqdate.Location = new System.Drawing.Point(12, 195);
            this.lbl_cheqdate.Name = "lbl_cheqdate";
            this.lbl_cheqdate.Size = new System.Drawing.Size(132, 24);
            this.lbl_cheqdate.TabIndex = 39;
            this.lbl_cheqdate.Text = "Cheque Date";
            // 
            // lbl_branchname
            // 
            this.lbl_branchname.AutoSize = true;
            this.lbl_branchname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_branchname.Location = new System.Drawing.Point(13, 151);
            this.lbl_branchname.Name = "lbl_branchname";
            this.lbl_branchname.Size = new System.Drawing.Size(137, 24);
            this.lbl_branchname.TabIndex = 37;
            this.lbl_branchname.Text = "Branch Name";
            // 
            // lbl_bnkname
            // 
            this.lbl_bnkname.AutoSize = true;
            this.lbl_bnkname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bnkname.Location = new System.Drawing.Point(13, 105);
            this.lbl_bnkname.Name = "lbl_bnkname";
            this.lbl_bnkname.Size = new System.Drawing.Size(117, 24);
            this.lbl_bnkname.TabIndex = 38;
            this.lbl_bnkname.Text = "Bank Name";
            this.lbl_bnkname.Click += new System.EventHandler(this.lbl_bnkname_Click);
            // 
            // tbl_student_detailsTableAdapter
            // 
            this.tbl_student_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_cash_amount
            // 
            this.pnl_cash_amount.Controls.Add(this.lbl_amount);
            this.pnl_cash_amount.Controls.Add(this.tb_stud_amount);
            this.pnl_cash_amount.Location = new System.Drawing.Point(27, 367);
            this.pnl_cash_amount.Name = "pnl_cash_amount";
            this.pnl_cash_amount.Size = new System.Drawing.Size(629, 50);
            this.pnl_cash_amount.TabIndex = 77;
            // 
            // pnl_online_data
            // 
            this.pnl_online_data.Controls.Add(this.label2);
            this.pnl_online_data.Controls.Add(this.textBox1);
            this.pnl_online_data.Controls.Add(this.lbl_cheqno);
            this.pnl_online_data.Controls.Add(this.tb_stud_cheque_no);
            this.pnl_online_data.Controls.Add(this.lbl_bnkname);
            this.pnl_online_data.Controls.Add(this.cb_stud_bank);
            this.pnl_online_data.Location = new System.Drawing.Point(27, 367);
            this.pnl_online_data.Name = "pnl_online_data";
            this.pnl_online_data.Size = new System.Drawing.Size(629, 152);
            this.pnl_online_data.TabIndex = 78;
            this.pnl_online_data.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(317, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 28);
            this.textBox1.TabIndex = 47;
            // 
            // pnl_cheque_data
            // 
            this.pnl_cheque_data.Controls.Add(this.label3);
            this.pnl_cheque_data.Controls.Add(this.textBox2);
            this.pnl_cheque_data.Controls.Add(this.label4);
            this.pnl_cheque_data.Controls.Add(this.textBox3);
            this.pnl_cheque_data.Controls.Add(this.label7);
            this.pnl_cheque_data.Controls.Add(this.comboBox1);
            this.pnl_cheque_data.Controls.Add(this.lbl_branchname);
            this.pnl_cheque_data.Controls.Add(this.tb_stud_bank_branch);
            this.pnl_cheque_data.Controls.Add(this.lbl_cheqdate);
            this.pnl_cheque_data.Controls.Add(this.dtp_stud_cheq_date);
            this.pnl_cheque_data.Location = new System.Drawing.Point(27, 367);
            this.pnl_cheque_data.Name = "pnl_cheque_data";
            this.pnl_cheque_data.Size = new System.Drawing.Size(629, 244);
            this.pnl_cheque_data.TabIndex = 79;
            this.pnl_cheque_data.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Amount";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(317, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 28);
            this.textBox2.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cheque No/Transaction Id";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(317, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 28);
            this.textBox3.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Bank Name";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SBI",
            "ICICI",
            "YES BANK",
            "IDBI BANK",
            "BOB",
            "BANK OF INDIA",
            "HDFC BANK",
            "CANARA BANK",
            "AU FINANCE BANK"});
            this.comboBox1.Location = new System.Drawing.Point(317, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 30);
            this.comboBox1.TabIndex = 61;
            // 
            // PaymentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1773, 1029);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentDetailsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaymentDetailsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_drving_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment_data)).EndInit();
            this.pnl_cash_amount.ResumeLayout(false);
            this.pnl_cash_amount.PerformLayout();
            this.pnl_online_data.ResumeLayout(false);
            this.pnl_online_data.PerformLayout();
            this.pnl_cheque_data.ResumeLayout(false);
            this.pnl_cheque_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_cheqno;
        private System.Windows.Forms.TextBox tb_stud_amount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_stud_recpt_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cheqdate;
        private System.Windows.Forms.Label lbl_branchname;
        private System.Windows.Forms.Label lbl_bnkname;
        private System.Windows.Forms.DateTimePicker dtp_stud_cheq_date;
        private System.Windows.Forms.TextBox tb_stud_cheque_no;
        private System.Windows.Forms.TextBox tb_stud_bank_branch;
        private System.Windows.Forms.ComboBox cb_stud_fee_type;
        private System.Windows.Forms.ComboBox cb_stud_bank;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_payment_details_clear;
        private System.Windows.Forms.Button btn_payment_details_save;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_payment_data;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.ComboBox cb_stuname_paydet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rb_cheq_pay;
        private System.Windows.Forms.RadioButton rb_online_pay;
        private System.Windows.Forms.RadioButton rb_cash_pay;
        private System.Windows.Forms.DateTimePicker dtp_paydate;
        private System.Windows.Forms.Label lbl_paydate;
        private System.Windows.Forms.TextBox tb_payment_aadhar;
        private db_drving_schoolDataSet db_drving_schoolDataSet;
        private System.Windows.Forms.BindingSource tblstudentdetailsBindingSource;
        private db_drving_schoolDataSetTableAdapters.tbl_student_detailsTableAdapter tbl_student_detailsTableAdapter;
        private System.Windows.Forms.Panel pnl_cash_amount;
        private System.Windows.Forms.Panel pnl_online_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnl_cheque_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}