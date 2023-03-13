namespace Activity_4
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
            textBox_Input = new TextBox();
            button_Convert = new Button();
            textBox_Output = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Industry-Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 0;
            label1.Text = "Seconds Elapsed:";
            // 
            // textBox_Input
            // 
            textBox_Input.Location = new Point(226, 66);
            textBox_Input.Name = "textBox_Input";
            textBox_Input.Size = new Size(126, 23);
            textBox_Input.TabIndex = 1;
            // 
            // button_Convert
            // 
            button_Convert.BackColor = SystemColors.InactiveCaption;
            button_Convert.Font = new Font("Industry-Medium", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button_Convert.ForeColor = SystemColors.HotTrack;
            button_Convert.Location = new Point(226, 95);
            button_Convert.Name = "button_Convert";
            button_Convert.Size = new Size(125, 36);
            button_Convert.TabIndex = 2;
            button_Convert.Text = "Convert";
            button_Convert.UseVisualStyleBackColor = false;
            button_Convert.Click += button_Convert_Click;
            // 
            // textBox_Output
            // 
            textBox_Output.Location = new Point(226, 137);
            textBox_Output.Name = "textBox_Output";
            textBox_Output.ReadOnly = true;
            textBox_Output.Size = new Size(125, 23);
            textBox_Output.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Industry-Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(67, 9);
            label5.Name = "label5";
            label5.Size = new Size(257, 42);
            label5.TabIndex = 11;
            label5.Text = "Seconds In Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Industry-Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(122, 129);
            label6.Name = "label6";
            label6.Size = new Size(98, 31);
            label6.TabIndex = 12;
            label6.Text = "Output:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(370, 181);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox_Output);
            Controls.Add(button_Convert);
            Controls.Add(textBox_Input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Seconds In Time";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Input;
        private Button button_Convert;
        private Label label2;
        private TextBox textBox_Seconds;
        private TextBox textBox_Minutes;
        private Label label3;
        private TextBox textBox_Hours;
        private Label label4;
        private TextBox textBox_Output;
        private Label label5;
        private Label label6;
    }
}