
namespace EventsExample
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
            this.cb_sub = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb1_value = new System.Windows.Forms.TextBox();
            this.tb2_value = new System.Windows.Forms.TextBox();
            this.lbl_display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_sub
            // 
            this.cb_sub.FormattingEnabled = true;
            this.cb_sub.Items.AddRange(new object[] {
            "c",
            "c++",
            "java",
            "python",
            "react"});
            this.cb_sub.Location = new System.Drawing.Point(243, 231);
            this.cb_sub.Name = "cb_sub";
            this.cb_sub.Size = new System.Drawing.Size(121, 24);
            this.cb_sub.TabIndex = 1;
            this.cb_sub.SelectedIndexChanged += new System.EventHandler(this.cb_sub_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject";
            // 
            // tb1_value
            // 
            this.tb1_value.Location = new System.Drawing.Point(640, 101);
            this.tb1_value.Name = "tb1_value";
            this.tb1_value.Size = new System.Drawing.Size(100, 22);
            this.tb1_value.TabIndex = 3;
            this.tb1_value.TextChanged += new System.EventHandler(this.tb1_value_TextChanged);
            // 
            // tb2_value
            // 
            this.tb2_value.Location = new System.Drawing.Point(640, 159);
            this.tb2_value.Name = "tb2_value";
            this.tb2_value.Size = new System.Drawing.Size(100, 22);
            this.tb2_value.TabIndex = 4;
            this.tb2_value.TextChanged += new System.EventHandler(this.tb2_value_TextChanged);
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.Location = new System.Drawing.Point(640, 237);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(52, 17);
            this.lbl_display.TabIndex = 5;
            this.lbl_display.Text = "display";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.tb2_value);
            this.Controls.Add(this.tb1_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_sub);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_sub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb1_value;
        private System.Windows.Forms.TextBox tb2_value;
        private System.Windows.Forms.Label lbl_display;
    }
}

