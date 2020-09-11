namespace C968FinalProject
{
    partial class mainScreenForm
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.programExitButton = new System.Windows.Forms.Button();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.partsModifyButton = new System.Windows.Forms.Button();
            this.partsDeleteButton = new System.Windows.Forms.Button();
            this.productsAddButton = new System.Windows.Forms.Button();
            this.productsModifyButton = new System.Windows.Forms.Button();
            this.productsDeleteButton = new System.Windows.Forms.Button();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsSearchTextBox = new System.Windows.Forms.TextBox();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.productsSearchTextBox = new System.Windows.Forms.TextBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(16, 11);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(283, 25);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Inventory Management System";
            // 
            // programExitButton
            // 
            this.programExitButton.Location = new System.Drawing.Point(1596, 647);
            this.programExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.programExitButton.Name = "programExitButton";
            this.programExitButton.Size = new System.Drawing.Size(100, 28);
            this.programExitButton.TabIndex = 1;
            this.programExitButton.Text = "Exit";
            this.programExitButton.UseVisualStyleBackColor = true;
            this.programExitButton.Click += new System.EventHandler(this.programExitButton_Click);
            // 
            // partsAddButton
            // 
            this.partsAddButton.Location = new System.Drawing.Point(500, 561);
            this.partsAddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(100, 28);
            this.partsAddButton.TabIndex = 2;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            this.partsAddButton.Click += new System.EventHandler(this.partsAddButton_Click);
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.Location = new System.Drawing.Point(608, 561);
            this.partsModifyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(100, 28);
            this.partsModifyButton.TabIndex = 3;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            this.partsModifyButton.Click += new System.EventHandler(this.partsModifyButton_Click);
            // 
            // partsDeleteButton
            // 
            this.partsDeleteButton.Location = new System.Drawing.Point(716, 561);
            this.partsDeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partsDeleteButton.Name = "partsDeleteButton";
            this.partsDeleteButton.Size = new System.Drawing.Size(100, 28);
            this.partsDeleteButton.TabIndex = 4;
            this.partsDeleteButton.Text = "Delete";
            this.partsDeleteButton.UseVisualStyleBackColor = true;
            this.partsDeleteButton.Click += new System.EventHandler(this.partsDeleteButton_Click);
            // 
            // productsAddButton
            // 
            this.productsAddButton.Location = new System.Drawing.Point(1380, 561);
            this.productsAddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(100, 28);
            this.productsAddButton.TabIndex = 5;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            this.productsAddButton.Click += new System.EventHandler(this.productsAddButton_Click);
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Location = new System.Drawing.Point(1488, 561);
            this.productsModifyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(100, 28);
            this.productsModifyButton.TabIndex = 6;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            this.productsModifyButton.Click += new System.EventHandler(this.productsModifyButton_Click);
            // 
            // productsDeleteButton
            // 
            this.productsDeleteButton.Location = new System.Drawing.Point(1596, 561);
            this.productsDeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsDeleteButton.Name = "productsDeleteButton";
            this.productsDeleteButton.Size = new System.Drawing.Size(100, 28);
            this.productsDeleteButton.TabIndex = 7;
            this.productsDeleteButton.Text = "Delete";
            this.productsDeleteButton.UseVisualStyleBackColor = true;
            this.productsDeleteButton.Click += new System.EventHandler(this.productsDeleteButton_Click);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(16, 112);
            this.partsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(57, 25);
            this.partsLabel.TabIndex = 8;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(891, 112);
            this.productsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(89, 25);
            this.productsLabel.TabIndex = 9;
            this.productsLabel.Text = "Products";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(333, 110);
            this.partsSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(100, 28);
            this.partsSearchButton.TabIndex = 10;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partsSearchTextBox
            // 
            this.partsSearchTextBox.Location = new System.Drawing.Point(441, 112);
            this.partsSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partsSearchTextBox.Name = "partsSearchTextBox";
            this.partsSearchTextBox.Size = new System.Drawing.Size(265, 22);
            this.partsSearchTextBox.TabIndex = 11;
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(1213, 110);
            this.productsSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(100, 28);
            this.productsSearchButton.TabIndex = 12;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            this.productsSearchButton.Click += new System.EventHandler(this.productsSearchButton_Click);
            // 
            // productsSearchTextBox
            // 
            this.productsSearchTextBox.Location = new System.Drawing.Point(1321, 112);
            this.productsSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsSearchTextBox.Name = "productsSearchTextBox";
            this.productsSearchTextBox.Size = new System.Drawing.Size(265, 22);
            this.productsSearchTextBox.TabIndex = 13;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productInventory,
            this.productPrice,
            this.productMin,
            this.productMax});
            this.productsDataGridView.Location = new System.Drawing.Point(896, 185);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.Size = new System.Drawing.Size(800, 369);
            this.productsDataGridView.TabIndex = 14;
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.partInventory,
            this.partPrice,
            this.partMin,
            this.partMax});
            this.partsDataGridView.Location = new System.Drawing.Point(16, 185);
            this.partsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowHeadersWidth = 51;
            this.partsDataGridView.Size = new System.Drawing.Size(800, 369);
            this.partsDataGridView.TabIndex = 15;
            // 
            // productID
            // 
            this.productID.HeaderText = "Product ID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.Width = 125;
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Width = 125;
            // 
            // productInventory
            // 
            this.productInventory.HeaderText = "Inventory";
            this.productInventory.MinimumWidth = 6;
            this.productInventory.Name = "productInventory";
            this.productInventory.Width = 125;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            this.productPrice.Width = 125;
            // 
            // productMin
            // 
            this.productMin.HeaderText = "Min";
            this.productMin.MinimumWidth = 6;
            this.productMin.Name = "productMin";
            this.productMin.Width = 125;
            // 
            // productMax
            // 
            this.productMax.HeaderText = "Max";
            this.productMax.MinimumWidth = 6;
            this.productMax.Name = "productMax";
            this.productMax.Width = 125;
            // 
            // partID
            // 
            this.partID.HeaderText = "Part ID";
            this.partID.MinimumWidth = 6;
            this.partID.Name = "partID";
            this.partID.Width = 125;
            // 
            // partName
            // 
            this.partName.HeaderText = "Name";
            this.partName.MinimumWidth = 6;
            this.partName.Name = "partName";
            this.partName.Width = 125;
            // 
            // partInventory
            // 
            this.partInventory.HeaderText = "Inventory";
            this.partInventory.MinimumWidth = 6;
            this.partInventory.Name = "partInventory";
            this.partInventory.Width = 125;
            // 
            // partPrice
            // 
            this.partPrice.HeaderText = "Price";
            this.partPrice.MinimumWidth = 6;
            this.partPrice.Name = "partPrice";
            this.partPrice.Width = 125;
            // 
            // partMin
            // 
            this.partMin.HeaderText = "Min";
            this.partMin.MinimumWidth = 6;
            this.partMin.Name = "partMin";
            this.partMin.Width = 125;
            // 
            // partMax
            // 
            this.partMax.HeaderText = "Max";
            this.partMax.MinimumWidth = 6;
            this.partMax.Name = "partMax";
            this.partMax.Width = 125;
            // 
            // mainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 690);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.productsSearchTextBox);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.partsSearchTextBox);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.productsDeleteButton);
            this.Controls.Add(this.productsModifyButton);
            this.Controls.Add(this.productsAddButton);
            this.Controls.Add(this.partsDeleteButton);
            this.Controls.Add(this.partsModifyButton);
            this.Controls.Add(this.partsAddButton);
            this.Controls.Add(this.programExitButton);
            this.Controls.Add(this.mainLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainScreenForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button programExitButton;
        private System.Windows.Forms.Button partsAddButton;
        private System.Windows.Forms.Button partsModifyButton;
        private System.Windows.Forms.Button partsDeleteButton;
        private System.Windows.Forms.Button productsAddButton;
        private System.Windows.Forms.Button productsModifyButton;
        private System.Windows.Forms.Button productsDeleteButton;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.TextBox partsSearchTextBox;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.TextBox productsSearchTextBox;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMax;
    }
}

