namespace MyCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNum1 = new NumericUpDown();
            txtNum2 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)txtNum1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNum2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 24);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 0;
            label1.Text = "عدد اول : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 62);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 0;
            label2.Text = "عدد دوم : ";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(12, 22);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(296, 26);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(12, 62);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(296, 26);
            txtNum2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(62, 113);
            button1.Name = "button1";
            button1.Size = new Size(60, 53);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(128, 113);
            button2.Name = "button2";
            button2.Size = new Size(60, 53);
            button2.TabIndex = 2;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(194, 113);
            button3.Name = "button3";
            button3.Size = new Size(60, 53);
            button3.TabIndex = 2;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(260, 113);
            button4.Name = "button4";
            button4.Size = new Size(60, 53);
            button4.TabIndex = 2;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 178);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ماشین حساب";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtNum1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNum2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown txtNum1;
        private NumericUpDown txtNum2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}