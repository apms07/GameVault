namespace GameVault
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
            dgvGames = new DataGridView();
            txtTitle = new TextBox();
            cmbPlatform = new ComboBox();
            cmbCondition = new ComboBox();
            numPrice = new NumericUpDown();
            numQuantity = new NumericUpDown();
            numYear = new NumericUpDown();
            txtSearch = new TextBox();
            txtGenre = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.AllowUserToAddRows = false;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Dock = DockStyle.Bottom;
            dgvGames.Location = new Point(0, 356);
            dgvGames.Name = "dgvGames";
            dgvGames.ReadOnly = true;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(938, 150);
            dgvGames.TabIndex = 0;
            dgvGames.CellClick += dgvGames_CellClick;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(170, 43);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 1;
            // 
            // cmbPlatform
            // 
            cmbPlatform.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlatform.FormattingEnabled = true;
            cmbPlatform.Items.AddRange(new object[] { "PS5", "PS4", "Xbox Series", "Xbox One", "Nintendo Switch", "PC" });
            cmbPlatform.Location = new Point(457, 43);
            cmbPlatform.Name = "cmbPlatform";
            cmbPlatform.Size = new Size(121, 23);
            cmbPlatform.TabIndex = 2;
            // 
            // cmbCondition
            // 
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Items.AddRange(new object[] { "New", "Used" });
            cmbCondition.Location = new Point(319, 96);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(121, 23);
            cmbCondition.TabIndex = 3;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(766, 44);
            numPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 4;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(170, 96);
            numQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 23);
            numQuantity.TabIndex = 5;
            // 
            // numYear
            // 
            numYear.Location = new Point(623, 43);
            numYear.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(120, 23);
            numYear.TabIndex = 6;
            numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(623, 314);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(319, 43);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(100, 23);
            txtGenre.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(487, 96);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(811, 314);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(374, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(558, 190);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 506);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtGenre);
            Controls.Add(txtSearch);
            Controls.Add(numYear);
            Controls.Add(numQuantity);
            Controls.Add(numPrice);
            Controls.Add(cmbCondition);
            Controls.Add(cmbPlatform);
            Controls.Add(txtTitle);
            Controls.Add(dgvGames);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGames;
        private TextBox txtTitle;
        private ComboBox cmbPlatform;
        private ComboBox cmbCondition;
        private NumericUpDown numPrice;
        private NumericUpDown numQuantity;
        private NumericUpDown numYear;
        private TextBox txtSearch;
        private TextBox txtGenre;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
