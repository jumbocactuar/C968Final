namespace C968FinalProject
{
    partial class mainScreen
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
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(229, 20);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Inventory Management System";
            // 
            // programExitButton
            // 
            this.programExitButton.Location = new System.Drawing.Point(1097, 426);
            this.programExitButton.Name = "programExitButton";
            this.programExitButton.Size = new System.Drawing.Size(75, 23);
            this.programExitButton.TabIndex = 1;
            this.programExitButton.Text = "Exit";
            this.programExitButton.UseVisualStyleBackColor = true;
            this.programExitButton.Click += new System.EventHandler(this.programExitButton_Click);
            // 
            // partsAddButton
            // 
            this.partsAddButton.Location = new System.Drawing.Point(290, 370);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(75, 23);
            this.partsAddButton.TabIndex = 2;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            this.partsAddButton.Click += new System.EventHandler(this.partsAddButton_Click);
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.Location = new System.Drawing.Point(371, 370);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(75, 23);
            this.partsModifyButton.TabIndex = 3;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            this.partsModifyButton.Click += new System.EventHandler(this.partsModifyButton_Click);
            // 
            // partsDeleteButton
            // 
            this.partsDeleteButton.Location = new System.Drawing.Point(452, 370);
            this.partsDeleteButton.Name = "partsDeleteButton";
            this.partsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.partsDeleteButton.TabIndex = 4;
            this.partsDeleteButton.Text = "Delete";
            this.partsDeleteButton.UseVisualStyleBackColor = true;
            this.partsDeleteButton.Click += new System.EventHandler(this.partsDeleteButton_Click);
            // 
            // productsAddButton
            // 
            this.productsAddButton.Location = new System.Drawing.Point(906, 370);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(75, 23);
            this.productsAddButton.TabIndex = 5;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            this.productsAddButton.Click += new System.EventHandler(this.productsAddButton_Click);
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Location = new System.Drawing.Point(987, 370);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(75, 23);
            this.productsModifyButton.TabIndex = 6;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            this.productsModifyButton.Click += new System.EventHandler(this.productsModifyButton_Click);
            // 
            // productsDeleteButton
            // 
            this.productsDeleteButton.Location = new System.Drawing.Point(1068, 370);
            this.productsDeleteButton.Name = "productsDeleteButton";
            this.productsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.productsDeleteButton.TabIndex = 7;
            this.productsDeleteButton.Text = "Delete";
            this.productsDeleteButton.UseVisualStyleBackColor = true;
            this.productsDeleteButton.Click += new System.EventHandler(this.productsDeleteButton_Click);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(42, 86);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(46, 20);
            this.partsLabel.TabIndex = 8;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(646, 90);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(72, 20);
            this.productsLabel.TabIndex = 9;
            this.productsLabel.Text = "Products";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(246, 86);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.partsSearchButton.TabIndex = 10;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partsSearchTextBox
            // 
            this.partsSearchTextBox.Location = new System.Drawing.Point(327, 88);
            this.partsSearchTextBox.Name = "partsSearchTextBox";
            this.partsSearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.partsSearchTextBox.TabIndex = 11;
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(862, 88);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productsSearchButton.TabIndex = 12;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            this.productsSearchButton.Click += new System.EventHandler(this.productsSearchButton_Click);
            // 
            // productsSearchTextBox
            // 
            this.productsSearchTextBox.Location = new System.Drawing.Point(943, 90);
            this.productsSearchTextBox.Name = "productsSearchTextBox";
            this.productsSearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.productsSearchTextBox.TabIndex = 13;
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
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
            this.Name = "mainScreen";
            this.Text = "Main Screen";
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
    }
}

