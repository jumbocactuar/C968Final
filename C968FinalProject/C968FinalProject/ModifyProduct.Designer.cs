namespace C968FinalProject
{
    partial class modifyProductForm
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
            this.modifyCandidatePartAddButton = new System.Windows.Forms.Button();
            this.modifyCandidatePartSearchTextBox = new System.Windows.Forms.TextBox();
            this.modifyCandidatePartSearchButton = new System.Windows.Forms.Button();
            this.modifyAssociatedPartsLabel = new System.Windows.Forms.Label();
            this.modifyCandidatePartsLabel = new System.Windows.Forms.Label();
            this.modifyProductFormLabel = new System.Windows.Forms.Label();
            this.modifyAssociatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.modifyCandidatePartsDataGridView = new System.Windows.Forms.DataGridView();
            this.modifyProductMaxLabel = new System.Windows.Forms.Label();
            this.modifyProductMinLabel = new System.Windows.Forms.Label();
            this.modifyProductPriceLabel = new System.Windows.Forms.Label();
            this.modifyProductInventoryLabel = new System.Windows.Forms.Label();
            this.modifyProductNameLabel = new System.Windows.Forms.Label();
            this.modifyProductIDLabel = new System.Windows.Forms.Label();
            this.modifyProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductMinTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyAssociatedPartDeleteButton = new System.Windows.Forms.Button();
            this.modifyProductSaveButton = new System.Windows.Forms.Button();
            this.modifyProductCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modifyAssociatedPartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyCandidatePartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyCandidatePartAddButton
            // 
            this.modifyCandidatePartAddButton.Location = new System.Drawing.Point(856, 333);
            this.modifyCandidatePartAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyCandidatePartAddButton.Name = "modifyCandidatePartAddButton";
            this.modifyCandidatePartAddButton.Size = new System.Drawing.Size(75, 23);
            this.modifyCandidatePartAddButton.TabIndex = 55;
            this.modifyCandidatePartAddButton.Text = "Add";
            this.modifyCandidatePartAddButton.UseVisualStyleBackColor = true;
            this.modifyCandidatePartAddButton.Click += new System.EventHandler(this.modifyCandidatePartAddButton_Click);
            // 
            // modifyCandidatePartSearchTextBox
            // 
            this.modifyCandidatePartSearchTextBox.Location = new System.Drawing.Point(680, 41);
            this.modifyCandidatePartSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modifyCandidatePartSearchTextBox.Name = "modifyCandidatePartSearchTextBox";
            this.modifyCandidatePartSearchTextBox.Size = new System.Drawing.Size(216, 20);
            this.modifyCandidatePartSearchTextBox.TabIndex = 54;
            // 
            // modifyCandidatePartSearchButton
            // 
            this.modifyCandidatePartSearchButton.Location = new System.Drawing.Point(584, 38);
            this.modifyCandidatePartSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyCandidatePartSearchButton.Name = "modifyCandidatePartSearchButton";
            this.modifyCandidatePartSearchButton.Size = new System.Drawing.Size(75, 23);
            this.modifyCandidatePartSearchButton.TabIndex = 53;
            this.modifyCandidatePartSearchButton.Text = "Search";
            this.modifyCandidatePartSearchButton.UseVisualStyleBackColor = true;
            this.modifyCandidatePartSearchButton.Click += new System.EventHandler(this.modifyCandidatePartSearchButton_Click);
            // 
            // modifyAssociatedPartsLabel
            // 
            this.modifyAssociatedPartsLabel.AutoSize = true;
            this.modifyAssociatedPartsLabel.Location = new System.Drawing.Point(331, 406);
            this.modifyAssociatedPartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modifyAssociatedPartsLabel.Name = "modifyAssociatedPartsLabel";
            this.modifyAssociatedPartsLabel.Size = new System.Drawing.Size(166, 13);
            this.modifyAssociatedPartsLabel.TabIndex = 52;
            this.modifyAssociatedPartsLabel.Text = "Parts associated with this Product";
            // 
            // modifyCandidatePartsLabel
            // 
            this.modifyCandidatePartsLabel.AutoSize = true;
            this.modifyCandidatePartsLabel.Location = new System.Drawing.Point(331, 65);
            this.modifyCandidatePartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modifyCandidatePartsLabel.Name = "modifyCandidatePartsLabel";
            this.modifyCandidatePartsLabel.Size = new System.Drawing.Size(95, 13);
            this.modifyCandidatePartsLabel.TabIndex = 51;
            this.modifyCandidatePartsLabel.Text = "All candidate Parts";
            // 
            // modifyProductFormLabel
            // 
            this.modifyProductFormLabel.AutoSize = true;
            this.modifyProductFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductFormLabel.Location = new System.Drawing.Point(10, 12);
            this.modifyProductFormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modifyProductFormLabel.Name = "modifyProductFormLabel";
            this.modifyProductFormLabel.Size = new System.Drawing.Size(114, 20);
            this.modifyProductFormLabel.TabIndex = 50;
            this.modifyProductFormLabel.Text = "Modify Product";
            // 
            // modifyAssociatedPartsDataGridView
            // 
            this.modifyAssociatedPartsDataGridView.AllowUserToAddRows = false;
            this.modifyAssociatedPartsDataGridView.AllowUserToDeleteRows = false;
            this.modifyAssociatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyAssociatedPartsDataGridView.Location = new System.Drawing.Point(331, 427);
            this.modifyAssociatedPartsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.modifyAssociatedPartsDataGridView.Name = "modifyAssociatedPartsDataGridView";
            this.modifyAssociatedPartsDataGridView.ReadOnly = true;
            this.modifyAssociatedPartsDataGridView.RowHeadersVisible = false;
            this.modifyAssociatedPartsDataGridView.RowHeadersWidth = 51;
            this.modifyAssociatedPartsDataGridView.RowTemplate.Height = 24;
            this.modifyAssociatedPartsDataGridView.Size = new System.Drawing.Size(600, 244);
            this.modifyAssociatedPartsDataGridView.TabIndex = 49;
            this.modifyAssociatedPartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modifyAssociatedPartsDataGridView_CellClick);
            // 
            // modifyCandidatePartsDataGridView
            // 
            this.modifyCandidatePartsDataGridView.AllowUserToAddRows = false;
            this.modifyCandidatePartsDataGridView.AllowUserToDeleteRows = false;
            this.modifyCandidatePartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyCandidatePartsDataGridView.Location = new System.Drawing.Point(331, 84);
            this.modifyCandidatePartsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.modifyCandidatePartsDataGridView.Name = "modifyCandidatePartsDataGridView";
            this.modifyCandidatePartsDataGridView.ReadOnly = true;
            this.modifyCandidatePartsDataGridView.RowHeadersVisible = false;
            this.modifyCandidatePartsDataGridView.RowHeadersWidth = 51;
            this.modifyCandidatePartsDataGridView.RowTemplate.Height = 24;
            this.modifyCandidatePartsDataGridView.Size = new System.Drawing.Size(600, 244);
            this.modifyCandidatePartsDataGridView.TabIndex = 48;
            this.modifyCandidatePartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modifyCandidatePartsDataGridView_CellClick);
            // 
            // modifyProductMaxLabel
            // 
            this.modifyProductMaxLabel.AutoSize = true;
            this.modifyProductMaxLabel.Location = new System.Drawing.Point(204, 448);
            this.modifyProductMaxLabel.Name = "modifyProductMaxLabel";
            this.modifyProductMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.modifyProductMaxLabel.TabIndex = 47;
            this.modifyProductMaxLabel.Text = "Max";
            // 
            // modifyProductMinLabel
            // 
            this.modifyProductMinLabel.AutoSize = true;
            this.modifyProductMinLabel.Location = new System.Drawing.Point(72, 448);
            this.modifyProductMinLabel.Name = "modifyProductMinLabel";
            this.modifyProductMinLabel.Size = new System.Drawing.Size(24, 13);
            this.modifyProductMinLabel.TabIndex = 46;
            this.modifyProductMinLabel.Text = "Min";
            // 
            // modifyProductPriceLabel
            // 
            this.modifyProductPriceLabel.AutoSize = true;
            this.modifyProductPriceLabel.Location = new System.Drawing.Point(33, 406);
            this.modifyProductPriceLabel.Name = "modifyProductPriceLabel";
            this.modifyProductPriceLabel.Size = new System.Drawing.Size(63, 13);
            this.modifyProductPriceLabel.TabIndex = 45;
            this.modifyProductPriceLabel.Text = "Price / Cost";
            // 
            // modifyProductInventoryLabel
            // 
            this.modifyProductInventoryLabel.AutoSize = true;
            this.modifyProductInventoryLabel.Location = new System.Drawing.Point(45, 366);
            this.modifyProductInventoryLabel.Name = "modifyProductInventoryLabel";
            this.modifyProductInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.modifyProductInventoryLabel.TabIndex = 44;
            this.modifyProductInventoryLabel.Text = "Inventory";
            // 
            // modifyProductNameLabel
            // 
            this.modifyProductNameLabel.AutoSize = true;
            this.modifyProductNameLabel.Location = new System.Drawing.Point(62, 326);
            this.modifyProductNameLabel.Name = "modifyProductNameLabel";
            this.modifyProductNameLabel.Size = new System.Drawing.Size(35, 13);
            this.modifyProductNameLabel.TabIndex = 43;
            this.modifyProductNameLabel.Text = "Name";
            // 
            // modifyProductIDLabel
            // 
            this.modifyProductIDLabel.AutoSize = true;
            this.modifyProductIDLabel.Location = new System.Drawing.Point(78, 285);
            this.modifyProductIDLabel.Name = "modifyProductIDLabel";
            this.modifyProductIDLabel.Size = new System.Drawing.Size(18, 13);
            this.modifyProductIDLabel.TabIndex = 42;
            this.modifyProductIDLabel.Text = "ID";
            // 
            // modifyProductMaxTextBox
            // 
            this.modifyProductMaxTextBox.Location = new System.Drawing.Point(237, 445);
            this.modifyProductMaxTextBox.Name = "modifyProductMaxTextBox";
            this.modifyProductMaxTextBox.Size = new System.Drawing.Size(60, 20);
            this.modifyProductMaxTextBox.TabIndex = 41;
            this.modifyProductMaxTextBox.TextChanged += new System.EventHandler(this.modifyProductMaxTextBox_TextChanged);
            this.modifyProductMaxTextBox.Leave += new System.EventHandler(this.modifyProductMaxTextBox_Leave);
            // 
            // modifyProductMinTextBox
            // 
            this.modifyProductMinTextBox.Location = new System.Drawing.Point(102, 445);
            this.modifyProductMinTextBox.Name = "modifyProductMinTextBox";
            this.modifyProductMinTextBox.Size = new System.Drawing.Size(60, 20);
            this.modifyProductMinTextBox.TabIndex = 40;
            this.modifyProductMinTextBox.TextChanged += new System.EventHandler(this.modifyProductMinTextBox_TextChanged);
            this.modifyProductMinTextBox.Leave += new System.EventHandler(this.modifyProductMinTextBox_Leave);
            // 
            // modifyProductPriceTextBox
            // 
            this.modifyProductPriceTextBox.Location = new System.Drawing.Point(102, 403);
            this.modifyProductPriceTextBox.Name = "modifyProductPriceTextBox";
            this.modifyProductPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyProductPriceTextBox.TabIndex = 39;
            this.modifyProductPriceTextBox.TextChanged += new System.EventHandler(this.modifyProductPriceTextBox_TextChanged);
            // 
            // modifyProductInventoryTextBox
            // 
            this.modifyProductInventoryTextBox.Location = new System.Drawing.Point(102, 363);
            this.modifyProductInventoryTextBox.Name = "modifyProductInventoryTextBox";
            this.modifyProductInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyProductInventoryTextBox.TabIndex = 38;
            this.modifyProductInventoryTextBox.TextChanged += new System.EventHandler(this.modifyProductInventoryTextBox_TextChanged);
            this.modifyProductInventoryTextBox.Leave += new System.EventHandler(this.modifyProductInventoryTextBox_Leave);
            // 
            // modifyProductNameTextBox
            // 
            this.modifyProductNameTextBox.Location = new System.Drawing.Point(102, 323);
            this.modifyProductNameTextBox.Name = "modifyProductNameTextBox";
            this.modifyProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyProductNameTextBox.TabIndex = 37;
            this.modifyProductNameTextBox.TextChanged += new System.EventHandler(this.modifyProductNameTextBox_TextChanged);
            // 
            // modifyProductIDTextBox
            // 
            this.modifyProductIDTextBox.Enabled = false;
            this.modifyProductIDTextBox.Location = new System.Drawing.Point(102, 282);
            this.modifyProductIDTextBox.Name = "modifyProductIDTextBox";
            this.modifyProductIDTextBox.ReadOnly = true;
            this.modifyProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyProductIDTextBox.TabIndex = 36;
            // 
            // modifyAssociatedPartDeleteButton
            // 
            this.modifyAssociatedPartDeleteButton.Location = new System.Drawing.Point(856, 675);
            this.modifyAssociatedPartDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyAssociatedPartDeleteButton.Name = "modifyAssociatedPartDeleteButton";
            this.modifyAssociatedPartDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.modifyAssociatedPartDeleteButton.TabIndex = 56;
            this.modifyAssociatedPartDeleteButton.Text = "Delete";
            this.modifyAssociatedPartDeleteButton.UseVisualStyleBackColor = true;
            this.modifyAssociatedPartDeleteButton.Click += new System.EventHandler(this.modifyAssociatedPartDeleteButton_Click);
            // 
            // modifyProductSaveButton
            // 
            this.modifyProductSaveButton.Location = new System.Drawing.Point(752, 760);
            this.modifyProductSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyProductSaveButton.Name = "modifyProductSaveButton";
            this.modifyProductSaveButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductSaveButton.TabIndex = 58;
            this.modifyProductSaveButton.Text = "Save";
            this.modifyProductSaveButton.UseVisualStyleBackColor = true;
            this.modifyProductSaveButton.Click += new System.EventHandler(this.modifyProductSaveButton_Click);
            // 
            // modifyProductCancelButton
            // 
            this.modifyProductCancelButton.Location = new System.Drawing.Point(856, 760);
            this.modifyProductCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyProductCancelButton.Name = "modifyProductCancelButton";
            this.modifyProductCancelButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductCancelButton.TabIndex = 57;
            this.modifyProductCancelButton.Text = "Cancel";
            this.modifyProductCancelButton.UseVisualStyleBackColor = true;
            this.modifyProductCancelButton.Click += new System.EventHandler(this.modifyProductCancelButton_Click);
            // 
            // modifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 815);
            this.Controls.Add(this.modifyProductSaveButton);
            this.Controls.Add(this.modifyProductCancelButton);
            this.Controls.Add(this.modifyAssociatedPartDeleteButton);
            this.Controls.Add(this.modifyCandidatePartAddButton);
            this.Controls.Add(this.modifyCandidatePartSearchTextBox);
            this.Controls.Add(this.modifyCandidatePartSearchButton);
            this.Controls.Add(this.modifyAssociatedPartsLabel);
            this.Controls.Add(this.modifyCandidatePartsLabel);
            this.Controls.Add(this.modifyProductFormLabel);
            this.Controls.Add(this.modifyAssociatedPartsDataGridView);
            this.Controls.Add(this.modifyCandidatePartsDataGridView);
            this.Controls.Add(this.modifyProductMaxLabel);
            this.Controls.Add(this.modifyProductMinLabel);
            this.Controls.Add(this.modifyProductPriceLabel);
            this.Controls.Add(this.modifyProductInventoryLabel);
            this.Controls.Add(this.modifyProductNameLabel);
            this.Controls.Add(this.modifyProductIDLabel);
            this.Controls.Add(this.modifyProductMaxTextBox);
            this.Controls.Add(this.modifyProductMinTextBox);
            this.Controls.Add(this.modifyProductPriceTextBox);
            this.Controls.Add(this.modifyProductInventoryTextBox);
            this.Controls.Add(this.modifyProductNameTextBox);
            this.Controls.Add(this.modifyProductIDTextBox);
            this.Name = "modifyProductForm";
            this.Text = "Modify Product";
            this.Load += new System.EventHandler(this.modifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modifyAssociatedPartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyCandidatePartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyCandidatePartAddButton;
        private System.Windows.Forms.TextBox modifyCandidatePartSearchTextBox;
        private System.Windows.Forms.Button modifyCandidatePartSearchButton;
        private System.Windows.Forms.Label modifyAssociatedPartsLabel;
        private System.Windows.Forms.Label modifyCandidatePartsLabel;
        private System.Windows.Forms.Label modifyProductFormLabel;
        private System.Windows.Forms.DataGridView modifyAssociatedPartsDataGridView;
        private System.Windows.Forms.DataGridView modifyCandidatePartsDataGridView;
        private System.Windows.Forms.Label modifyProductMaxLabel;
        private System.Windows.Forms.Label modifyProductMinLabel;
        private System.Windows.Forms.Label modifyProductPriceLabel;
        private System.Windows.Forms.Label modifyProductInventoryLabel;
        private System.Windows.Forms.Label modifyProductNameLabel;
        private System.Windows.Forms.Label modifyProductIDLabel;
        private System.Windows.Forms.TextBox modifyProductMaxTextBox;
        private System.Windows.Forms.TextBox modifyProductMinTextBox;
        private System.Windows.Forms.TextBox modifyProductPriceTextBox;
        private System.Windows.Forms.TextBox modifyProductInventoryTextBox;
        private System.Windows.Forms.TextBox modifyProductNameTextBox;
        private System.Windows.Forms.TextBox modifyProductIDTextBox;
        private System.Windows.Forms.Button modifyAssociatedPartDeleteButton;
        private System.Windows.Forms.Button modifyProductSaveButton;
        private System.Windows.Forms.Button modifyProductCancelButton;
    }
}