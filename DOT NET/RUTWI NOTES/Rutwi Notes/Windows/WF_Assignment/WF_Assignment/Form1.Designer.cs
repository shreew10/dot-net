
namespace WF_Assignment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_equal = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.text_num1 = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.lbl_equal);
            this.panel1.Controls.Add(this.txt_result);
            this.panel1.Controls.Add(this.btn_div);
            this.panel1.Controls.Add(this.btn_mul);
            this.panel1.Controls.Add(this.btn_sub);
            this.panel1.Controls.Add(this.btn_plus);
            this.panel1.Controls.Add(this.txt_num2);
            this.panel1.Controls.Add(this.text_num1);
            this.panel1.Location = new System.Drawing.Point(176, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 212);
            this.panel1.TabIndex = 8;
            // 
            // lbl_equal
            // 
            this.lbl_equal.AutoSize = true;
            this.lbl_equal.Location = new System.Drawing.Point(294, 95);
            this.lbl_equal.Name = "lbl_equal";
            this.lbl_equal.Size = new System.Drawing.Size(13, 13);
            this.lbl_equal.TabIndex = 15;
            this.lbl_equal.Text = "=";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(328, 92);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(94, 20);
            this.txt_result.TabIndex = 14;
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(360, 135);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(91, 40);
            this.btn_div.TabIndex = 13;
            this.btn_div.Text = "Division";
            this.btn_div.UseVisualStyleBackColor = true;
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(248, 135);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(96, 40);
            this.btn_mul.TabIndex = 12;
            this.btn_mul.Text = "Multiplication";
            this.btn_mul.UseVisualStyleBackColor = true;
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(139, 135);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(88, 40);
            this.btn_sub.TabIndex = 11;
            this.btn_sub.Text = "Substraction";
            this.btn_sub.UseVisualStyleBackColor = true;
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(31, 135);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(90, 40);
            this.btn_plus.TabIndex = 10;
            this.btn_plus.Text = "Addition";
            this.btn_plus.UseVisualStyleBackColor = true;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(182, 92);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(92, 20);
            this.txt_num2.TabIndex = 9;
            // 
            // text_num1
            // 
            this.text_num1.Location = new System.Drawing.Point(60, 92);
            this.text_num1.Name = "text_num1";
            this.text_num1.Size = new System.Drawing.Size(94, 20);
            this.text_num1.TabIndex = 8;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(146, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(204, 32);
            this.lbl_title.TabIndex = 16;
            this.lbl_title.Text = "CALCULATOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_equal;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox text_num1;
    }
}

