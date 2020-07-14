namespace ASCIIConversion
{
    partial class fCalculator2
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBtnModulo = new System.Windows.Forms.RadioButton();
            this.RBtnDividedBy = new System.Windows.Forms.RadioButton();
            this.RBtnMultiply = new System.Windows.Forms.RadioButton();
            this.RBtnMinus = new System.Windows.Forms.RadioButton();
            this.RBtnPlus = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.Location = new System.Drawing.Point(10, 259);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(66, 16);
            this.lblResult.TabIndex = 19;
            this.lblResult.Text = "Kết quả:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalculate.Location = new System.Drawing.Point(175, 208);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 40);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Tính";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(250, 53);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(98, 23);
            this.txt2.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(72, 252);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(168, 23);
            this.txtResult.TabIndex = 12;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(72, 53);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(98, 23);
            this.txt1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "CÁC PHÉP TÍNH CƠ BẢN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(184, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số thứ 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số thứ 1:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtnModulo);
            this.groupBox1.Controls.Add(this.RBtnDividedBy);
            this.groupBox1.Controls.Add(this.RBtnMultiply);
            this.groupBox1.Controls.Add(this.RBtnMinus);
            this.groupBox1.Controls.Add(this.RBtnPlus);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(72, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // RBtnModulo
            // 
            this.RBtnModulo.AutoSize = true;
            this.RBtnModulo.Location = new System.Drawing.Point(229, 56);
            this.RBtnModulo.Name = "RBtnModulo";
            this.RBtnModulo.Size = new System.Drawing.Size(39, 20);
            this.RBtnModulo.TabIndex = 0;
            this.RBtnModulo.Text = "%";
            this.RBtnModulo.UseVisualStyleBackColor = true;
            // 
            // RBtnDividedBy
            // 
            this.RBtnDividedBy.AutoSize = true;
            this.RBtnDividedBy.Location = new System.Drawing.Point(161, 56);
            this.RBtnDividedBy.Name = "RBtnDividedBy";
            this.RBtnDividedBy.Size = new System.Drawing.Size(33, 20);
            this.RBtnDividedBy.TabIndex = 0;
            this.RBtnDividedBy.Text = "/";
            this.RBtnDividedBy.UseVisualStyleBackColor = true;
            // 
            // RBtnMultiply
            // 
            this.RBtnMultiply.AutoSize = true;
            this.RBtnMultiply.Location = new System.Drawing.Point(121, 56);
            this.RBtnMultiply.Name = "RBtnMultiply";
            this.RBtnMultiply.Size = new System.Drawing.Size(34, 20);
            this.RBtnMultiply.TabIndex = 0;
            this.RBtnMultiply.Text = "*";
            this.RBtnMultiply.UseVisualStyleBackColor = true;
            // 
            // RBtnMinus
            // 
            this.RBtnMinus.AutoSize = true;
            this.RBtnMinus.Location = new System.Drawing.Point(81, 56);
            this.RBtnMinus.Name = "RBtnMinus";
            this.RBtnMinus.Size = new System.Drawing.Size(34, 20);
            this.RBtnMinus.TabIndex = 0;
            this.RBtnMinus.Text = "-";
            this.RBtnMinus.UseVisualStyleBackColor = true;
            // 
            // RBtnPlus
            // 
            this.RBtnPlus.AutoSize = true;
            this.RBtnPlus.Checked = true;
            this.RBtnPlus.Location = new System.Drawing.Point(21, 56);
            this.RBtnPlus.Name = "RBtnPlus";
            this.RBtnPlus.Size = new System.Drawing.Size(37, 20);
            this.RBtnPlus.TabIndex = 0;
            this.RBtnPlus.TabStop = true;
            this.RBtnPlus.Text = "+";
            this.RBtnPlus.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(273, 208);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fCalculator2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(413, 288);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.Name = "fCalculator2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCalculator2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBtnModulo;
        private System.Windows.Forms.RadioButton RBtnDividedBy;
        private System.Windows.Forms.RadioButton RBtnMultiply;
        private System.Windows.Forms.RadioButton RBtnMinus;
        private System.Windows.Forms.RadioButton RBtnPlus;
        private System.Windows.Forms.Button btnExit;

    }
}