using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968FinalProject
{
    public partial class addPartForm : Form
    {
        public addPartForm()
        {
            InitializeComponent();
        }

        private void addPartForm_Load(object sender, EventArgs e)
        {
            addPartCompanyNameLabel.Hide();
        }

        private void addPartInhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == addPartInhouseRadioButton)
            {
                addPartMachineIDLabel.Show();
                addPartCompanyNameLabel.Hide();
            }
        }

        private void addPartOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == addPartOutsourcedRadioButton)
            {
                addPartCompanyNameLabel.Show();
                addPartMachineIDLabel.Hide();
            }
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            // Convert strings to appropriate types for constructor input
            // FIXME:  can this go in the section for the Price textbox? string temp = $"{addPartPriceTextBox.Text:C2}";
            decimal decPrice = decimal.Parse(addPartPriceTextBox.Text);
            int intInventory = int.Parse(addPartInventoryTextBox.Text);
            int intMin = int.Parse(addPartMinTextBox.Text);
            int intMax = int.Parse(addPartMaxTextBox.Text);
            int intMachineID = int.Parse(addPartSourceTextBox.Text);

            // Add the appropriate type part to the AllParts BindingList
            if (addPartInhouseRadioButton.Checked == true)
            {
                Part p = new Inhouse(Counters.PartsIDCounter, addPartNameTextBox.Text, decPrice, intInventory, intMin, intMax, intMachineID);

                Inventory.addPart(p);
            }

            else if (addPartOutsourcedRadioButton.Checked == true)
            {
                Part p = new Outsourced(Counters.PartsIDCounter, addPartNameTextBox.Text, decPrice, intInventory, intMin, intMax, addPartSourceTextBox.Text);

                Inventory.addPart(p);
            }

            // Close the Add Part form
            DestroyHandle();
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            DestroyHandle();
        }
    }
}
