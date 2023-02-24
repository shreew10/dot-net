
namespace Calculator_assignmentWF
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
            this.pnl_calculator = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_calculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_calculator
            // 
            this.pnl_calculator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_calculator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_calculator.Controls.Add(this.label2);
            this.pnl_calculator.Controls.Add(this.label1);
            this.pnl_calculator.Controls.Add(this.btn_div);
            this.pnl_calculator.Controls.Add(this.btn_mul);
            this.pnl_calculator.Controls.Add(this.btn_sub);
            this.pnl_calculator.Controls.Add(this.btn_add);
            this.pnl_calculator.Controls.Add(this.txt_result);
            this.pnl_calculator.Controls.Add(this.txt_num2);
            this.pnl_calculator.Controls.Add(this.txt_num1);
            this.pnl_calculator.Location = new System.Drawing.Point(185, 132);
            this.pnl_calculator.Name = "pnl_calculator";
            this.pnl_calculator.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_calculator.Size = new System.Drawing.Size(393, 206);
            this.pnl_calculator.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "=";
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(298, 122);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(65, 42);
            this.btn_div.TabIndex = 14;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mul.Location = new System.Drawing.Point(207, 122);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(65, 42);
            this.btn_mul.TabIndex = 13;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(120, 122);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(65, 42);
            this.btn_sub.TabIndex = 12;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(30, 122);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(65, 42);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(263, 77);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 10;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(140, 77);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(90, 20);
            this.txt_num2.TabIndex = 9;
            this.txt_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(30, 77);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(94, 20);
            this.txt_num1.TabIndex = 8;
            this.txt_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "CALCULATOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_calculator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_calculator.ResumeLayout(false);
            this.pnl_calculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_calculator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num1;
    }
}

