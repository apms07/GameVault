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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSell = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToResizeRows = false;
            dgvGames.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGames.BackgroundColor = Color.White;
            dgvGames.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.EnableHeadersVisualStyles = false;
            dgvGames.Location = new Point(20, 190);
            dgvGames.Name = "dgvGames";
            dgvGames.ReadOnly = true;
            dgvGames.RowHeadersVisible = false;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(860, 345);
            dgvGames.TabIndex = 0;
            dgvGames.CellClick += dgvGames_CellClick;
            dgvGames.DataBindingComplete += dgvGames_DataBindingComplete;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(20, 82);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(300, 25);
            txtTitle.TabIndex = 1;
            // 
            // cmbPlatform
            // 
            cmbPlatform.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlatform.FormattingEnabled = true;
            cmbPlatform.Items.AddRange(new object[] { "PS5", "PS4", "Xbox Series", "Xbox One", "Nintendo Switch", "PC" });
            cmbPlatform.Location = new Point(340, 82);
            cmbPlatform.Name = "cmbPlatform";
            cmbPlatform.Size = new Size(150, 25);
            cmbPlatform.TabIndex = 2;
            // 
            // cmbCondition
            // 
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Items.AddRange(new object[] { "New", "Used" });
            cmbCondition.Location = new Point(710, 82);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(170, 25);
            cmbCondition.TabIndex = 4;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(20, 142);
            numPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(150, 25);
            numPrice.TabIndex = 5;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(190, 142);
            numQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 25);
            numQuantity.TabIndex = 6;
            // 
            // numYear
            // 
            numYear.Location = new Point(340, 142);
            numYear.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(150, 25);
            numYear.TabIndex = 7;
            numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(90, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 25);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(510, 82);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(100, 25);
            txtGenre.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(510, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 32);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(780, 140);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 32);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(690, 140);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 32);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(600, 140);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 32);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(20, 545);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(145, 17);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total Inventory Value:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 14;
            label1.Text = "Search:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 15;
            label2.Text = "Title";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 60);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 16;
            label3.Text = "Platform";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 60);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 17;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(710, 60);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 18;
            label5.Text = "Condition:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 120);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 19;
            label6.Text = "Price (€)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(190, 120);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 20;
            label7.Text = "Quantity:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(340, 120);
            label8.Name = "label8";
            label8.Size = new Size(85, 17);
            label8.TabIndex = 21;
            label8.Text = "Release year:";
            label8.Click += label8_Click;
            // 
            // btnSell
            // 
            btnSell.Location = new Point(760, 540);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(100, 27);
            btnSell.TabIndex = 22;
            btnSell.Text = "Sell";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 613);
            Controls.Add(btnSell);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotal);
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
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameVault - Inventory Manager";
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
        private Label lblTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSell;
    }
}
