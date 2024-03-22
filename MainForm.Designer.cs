namespace WFA240322OF
{
    partial class MainForm
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
            dgvMain = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvMain.Location = new Point(12, 12);
            dgvMain.MultiSelect = false;
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersVisible = false;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(848, 318);
            dgvMain.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 5F;
            Column2.HeaderText = "Title";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 2F;
            Column3.HeaderText = "Release";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 2F;
            Column4.HeaderText = "Genre";
            Column4.Name = "Column4";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDelete.Location = new Point(12, 336);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(315, 48);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "DELETE SELECTED";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.Location = new Point(12, 390);
            button2.Name = "button2";
            button2.Size = new Size(315, 48);
            button2.TabIndex = 1;
            button2.Text = "MODIFIES SELECTED";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.Location = new Point(12, 444);
            button3.Name = "button3";
            button3.Size = new Size(315, 48);
            button3.TabIndex = 1;
            button3.Text = "ADD NEW";
            button3.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 507);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnDelete);
            Controls.Add(dgvMain);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "WinForms Összefoglaló";
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnDelete;
        private Button button2;
        private Button button3;
    }
}
