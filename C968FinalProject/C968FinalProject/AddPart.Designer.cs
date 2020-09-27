namespace C968FinalProject
{
    partial class addPartForm
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
            this.addPartFormLabel = new System.Windows.Forms.Label();
            this.addPartInhouseRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartSourceTextBox = new System.Windows.Forms.TextBox();
            this.addPartIDLabel = new System.Windows.Forms.Label();
            this.addPartNameLabel = new System.Windows.Forms.Label();
            this.addPartInventoryLabel = new System.Windows.Forms.Label();
            this.addPartPriceLabel = new System.Windows.Forms.Label();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.addPartMaxLabel = new System.Windows.Forms.Label();
            this.addPartMachineIDLabel = new System.Windows.Forms.Label();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.addPartCompanyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPartFormLabel
            // 
            this.addPartFormLabel.AutoSize = true;
            this.addPartFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartFormLabel.Location = new System.Drawing.Point(17, 16);
            this.addPartFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartFormLabel.Name = "addPartFormLabel";
            this.addPartFormLabel.Size = new System.Drawing.Size(88, 25);
            this.addPartFormLabel.TabIndex = 0;
            this.addPartFormLabel.Text = "Add Part";
            // 
            // addPartInhouseRadioButton
            // 
            this.addPartInhouseRadioButton.AutoSize = true;
            this.addPartInhouseRadioButton.Checked = true;
            this.addPartInhouseRadioButton.Location = new System.Drawing.Point(165, 16);
            this.addPartInhouseRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartInhouseRadioButton.Name = "addPartInhouseRadioButton";
            this.addPartInhouseRadioButton.Size = new System.Drawing.Size(86, 21);
            this.addPartInhouseRadioButton.TabIndex = 1;
            this.addPartInhouseRadioButton.TabStop = true;
            this.addPartInhouseRadioButton.Text = "In-House";
            this.addPartInhouseRadioButton.UseVisualStyleBackColor = true;
            this.addPartInhouseRadioButton.CheckedChanged += new System.EventHandler(this.addPartInhouseRadioButton_CheckedChanged);
            // 
            // addPartOutsourcedRadioButton
            // 
            this.addPartOutsourcedRadioButton.AutoSize = true;
            this.addPartOutsourcedRadioButton.Location = new System.Drawing.Point(305, 16);
            this.addPartOutsourcedRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartOutsourcedRadioButton.Name = "addPartOutsourcedRadioButton";
            this.addPartOutsourcedRadioButton.Size = new System.Drawing.Size(103, 21);
            this.addPartOutsourcedRadioButton.TabIndex = 2;
            this.addPartOutsourcedRadioButton.Text = "Outsourced";
            this.addPartOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.addPartOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.addPartOutsourcedRadioButton_CheckedChanged);
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.Location = new System.Drawing.Point(165, 85);
            this.addPartIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.ReadOnly = true;
            this.addPartIDTextBox.Size = new System.Drawing.Size(132, 22);
            this.addPartIDTextBox.TabIndex = 3;
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.Location = new System.Drawing.Point(165, 135);
            this.addPartNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.addPartNameTextBox.TabIndex = 4;
            // 
            // addPartInventoryTextBox
            // 
            this.addPartInventoryTextBox.Location = new System.Drawing.Point(165, 185);
            this.addPartInventoryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartInventoryTextBox.Name = "addPartInventoryTextBox";
            this.addPartInventoryTextBox.Size = new System.Drawing.Size(132, 22);
            this.addPartInventoryTextBox.TabIndex = 5;
            // 
            // addPartPriceTextBox
            // 
            this.addPartPriceTextBox.Location = new System.Drawing.Point(165, 234);
            this.addPartPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartPriceTextBox.Name = "addPartPriceTextBox";
            this.addPartPriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.addPartPriceTextBox.TabIndex = 6;
            // 
            // addPartMinTextBox
            // 
            this.addPartMinTextBox.Location = new System.Drawing.Point(165, 286);
            this.addPartMinTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartMinTextBox.Name = "addPartMinTextBox";
            this.addPartMinTextBox.Size = new System.Drawing.Size(79, 22);
            this.addPartMinTextBox.TabIndex = 7;
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.Location = new System.Drawing.Point(345, 286);
            this.addPartMaxTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(79, 22);
            this.addPartMaxTextBox.TabIndex = 8;
            // 
            // addPartSourceTextBox
            // 
            this.addPartSourceTextBox.Location = new System.Drawing.Point(165, 340);
            this.addPartSourceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartSourceTextBox.Name = "addPartSourceTextBox";
            this.addPartSourceTextBox.Size = new System.Drawing.Size(132, 22);
            this.addPartSourceTextBox.TabIndex = 9;
            // 
            // addPartIDLabel
            // 
            this.addPartIDLabel.AutoSize = true;
            this.addPartIDLabel.Location = new System.Drawing.Point(133, 89);
            this.addPartIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartIDLabel.Name = "addPartIDLabel";
            this.addPartIDLabel.Size = new System.Drawing.Size(21, 17);
            this.addPartIDLabel.TabIndex = 10;
            this.addPartIDLabel.Text = "ID";
            // 
            // addPartNameLabel
            // 
            this.addPartNameLabel.AutoSize = true;
            this.addPartNameLabel.Location = new System.Drawing.Point(111, 139);
            this.addPartNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartNameLabel.Name = "addPartNameLabel";
            this.addPartNameLabel.Size = new System.Drawing.Size(45, 17);
            this.addPartNameLabel.TabIndex = 11;
            this.addPartNameLabel.Text = "Name";
            // 
            // addPartInventoryLabel
            // 
            this.addPartInventoryLabel.AutoSize = true;
            this.addPartInventoryLabel.Location = new System.Drawing.Point(89, 188);
            this.addPartInventoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartInventoryLabel.Name = "addPartInventoryLabel";
            this.addPartInventoryLabel.Size = new System.Drawing.Size(66, 17);
            this.addPartInventoryLabel.TabIndex = 12;
            this.addPartInventoryLabel.Text = "Inventory";
            // 
            // addPartPriceLabel
            // 
            this.addPartPriceLabel.AutoSize = true;
            this.addPartPriceLabel.Location = new System.Drawing.Point(73, 238);
            this.addPartPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartPriceLabel.Name = "addPartPriceLabel";
            this.addPartPriceLabel.Size = new System.Drawing.Size(80, 17);
            this.addPartPriceLabel.TabIndex = 13;
            this.addPartPriceLabel.Text = "Price / Cost";
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Location = new System.Drawing.Point(125, 289);
            this.addPartMinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(30, 17);
            this.addPartMinLabel.TabIndex = 14;
            this.addPartMinLabel.Text = "Min";
            // 
            // addPartMaxLabel
            // 
            this.addPartMaxLabel.AutoSize = true;
            this.addPartMaxLabel.Location = new System.Drawing.Point(301, 289);
            this.addPartMaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartMaxLabel.Name = "addPartMaxLabel";
            this.addPartMaxLabel.Size = new System.Drawing.Size(33, 17);
            this.addPartMaxLabel.TabIndex = 15;
            this.addPartMaxLabel.Text = "Max";
            // 
            // addPartMachineIDLabel
            // 
            this.addPartMachineIDLabel.AutoSize = true;
            this.addPartMachineIDLabel.Location = new System.Drawing.Point(75, 343);
            this.addPartMachineIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartMachineIDLabel.Name = "addPartMachineIDLabel";
            this.addPartMachineIDLabel.Size = new System.Drawing.Size(78, 17);
            this.addPartMachineIDLabel.TabIndex = 16;
            this.addPartMachineIDLabel.Text = "Machine ID";
            // 
            // addPartSaveButton
            // 
            this.addPartSaveButton.Location = new System.Drawing.Point(237, 439);
            this.addPartSaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartSaveButton.Name = "addPartSaveButton";
            this.addPartSaveButton.Size = new System.Drawing.Size(100, 28);
            this.addPartSaveButton.TabIndex = 17;
            this.addPartSaveButton.Text = "Save";
            this.addPartSaveButton.UseVisualStyleBackColor = true;
            this.addPartSaveButton.Click += new System.EventHandler(this.addPartSaveButton_Click);
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.Location = new System.Drawing.Point(369, 439);
            this.addPartCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(100, 28);
            this.addPartCancelButton.TabIndex = 18;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.addPartCancelButton_Click);
            // 
            // addPartCompanyNameLabel
            // 
            this.addPartCompanyNameLabel.AutoSize = true;
            this.addPartCompanyNameLabel.Location = new System.Drawing.Point(48, 343);
            this.addPartCompanyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartCompanyNameLabel.Name = "addPartCompanyNameLabel";
            this.addPartCompanyNameLabel.Size = new System.Drawing.Size(108, 17);
            this.addPartCompanyNameLabel.TabIndex = 20;
            this.addPartCompanyNameLabel.Text = "Company Name";
            // 
            // addPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 506);
            this.Controls.Add(this.addPartCompanyNameLabel);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.addPartMachineIDLabel);
            this.Controls.Add(this.addPartMaxLabel);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.addPartPriceLabel);
            this.Controls.Add(this.addPartInventoryLabel);
            this.Controls.Add(this.addPartNameLabel);
            this.Controls.Add(this.addPartIDLabel);
            this.Controls.Add(this.addPartSourceTextBox);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.addPartPriceTextBox);
            this.Controls.Add(this.addPartInventoryTextBox);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.addPartOutsourcedRadioButton);
            this.Controls.Add(this.addPartInhouseRadioButton);
            this.Controls.Add(this.addPartFormLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addPartForm";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.addPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartFormLabel;
        private System.Windows.Forms.RadioButton addPartInhouseRadioButton;
        private System.Windows.Forms.RadioButton addPartOutsourcedRadioButton;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.TextBox addPartInventoryTextBox;
        private System.Windows.Forms.TextBox addPartPriceTextBox;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.TextBox addPartSourceTextBox;
        private System.Windows.Forms.Label addPartIDLabel;
        private System.Windows.Forms.Label addPartNameLabel;
        private System.Windows.Forms.Label addPartInventoryLabel;
        private System.Windows.Forms.Label addPartPriceLabel;
        private System.Windows.Forms.Label addPartMinLabel;
        private System.Windows.Forms.Label addPartMaxLabel;
        private System.Windows.Forms.Label addPartMachineIDLabel;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.Button addPartCancelButton;
        private System.Windows.Forms.Label addPartCompanyNameLabel;
    }
}