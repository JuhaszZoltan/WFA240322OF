namespace WFA240322OF
{
    partial class AdapterForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 53);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 32);
            textBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(173, 183);
            numericUpDown1.Maximum = new decimal(new int[] { 1800, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(141, 32);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1800, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(197, 251);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 33);
            comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(127, 346);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 122);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 0;
            label2.Text = "Title:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 32);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 185);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 0;
            label3.Text = "Release Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 248);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 0;
            label4.Text = "Genre:";
            // 
            // AdapterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 431);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "AdapterForm";
            Text = "AdapterForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
    }
}