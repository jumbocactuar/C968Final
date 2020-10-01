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
        public static List<bool> FieldStateTracker = new List<bool> { false, false, false, false, false, false };

        public addPartForm()
        {
            InitializeComponent();
        }

        private void addPartForm_Load(object sender, EventArgs e)
        {
            addPartCompanyNameLabel.Hide();
            addPartSaveButton.Enabled = false;
            addPartIDTextBox.Text = $"{Counters.PartsIDCounter + 1}";
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

        private void addPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addPartNameTextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void addPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addPartInventoryTextBox.TextLength > 0)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void addPartInventoryTextBox_Leave(object sender, EventArgs e)
        {
            InventoryChecker();
        }

        private void addPartPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addPartPriceTextBox.TextLength > 0)
            {
                FieldStateTracker[2] = true;
            }

            else
            {
                FieldStateTracker[2] = false;
            }

            UpdateSaveButton();
        }

        private void addPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addPartMinTextBox.TextLength > 0)
            {
                FieldStateTracker[3] = true;
            }

            else
            {
                FieldStateTracker[3] = false;
            }

            UpdateSaveButton();
        }

        private void addPartMinTextBox_Leave(object sender, EventArgs e)
        {
            InventoryChecker();
        }

        private void addPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addPartMaxTextBox.TextLength > 0)
            {
                FieldStateTracker[4] = true;
            }

            else
            {
                FieldStateTracker[4] = false;
            }

            UpdateSaveButton();
        }

        private void addPartMaxTextBox_Leave(object sender, EventArgs e)
        {
            InventoryChecker();
        }

        private void addPartSourceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addPartSourceTextBox.TextLength > 0)
            {
                FieldStateTracker[5] = true;
            }

            else
            {
                FieldStateTracker[5] = false;
            }

            UpdateSaveButton();
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            // Convert strings to appropriate types for constructor input
            decimal price = decimal.Parse(addPartPriceTextBox.Text);
            int inventory = int.Parse(addPartInventoryTextBox.Text);
            int min = int.Parse(addPartMinTextBox.Text);
            int max = int.Parse(addPartMaxTextBox.Text);

            // Add the appropriate type part to the AllParts BindingList
            if (addPartInhouseRadioButton.Checked == true)
            {
                Part p = new Inhouse(Counters.PartsIDCounter, addPartNameTextBox.Text, price, inventory, min, max, int.Parse(addPartSourceTextBox.Text));

                Inventory.addPart(p);

                Counters.SelectedPartObject = p;
            }

            else if (addPartOutsourcedRadioButton.Checked == true)
            {
                Part p = new Outsourced(Counters.PartsIDCounter, addPartNameTextBox.Text, price, inventory, min, max, addPartSourceTextBox.Text);

                Inventory.addPart(p);

                Counters.SelectedPartObject = p;
            }

            // Close the Add Part form
            Close();
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                addPartSaveButton.Enabled = false;
            }

            else
            {
                addPartSaveButton.Enabled = true;
            }
        }

        private void InventoryChecker()
        {
            // Check whether Inventory is between Min and Max, Min < Max, and Max > Min
            if ((addPartInventoryTextBox.TextLength > 0) && (addPartMinTextBox.TextLength > 0) && (addPartMaxTextBox.TextLength > 0))
            {
                int inv = int.Parse(addPartInventoryTextBox.Text);
                int min = int.Parse(addPartMinTextBox.Text);
                int max = int.Parse(addPartMaxTextBox.Text);

                if ((inv < min) || (inv > max))
                {
                    MessageBox.Show("Inventory must be greater than Min and less than Max.");

                    addPartInventoryTextBox.Clear();
                }
            }

            if ((addPartMinTextBox.TextLength > 0) && (addPartMaxTextBox.TextLength > 0))
            {
                int min = int.Parse(addPartMinTextBox.Text);
                int max = int.Parse(addPartMaxTextBox.Text);

                if (min > max)
                {
                    MessageBox.Show("Min must be less than Max");

                    addPartMinTextBox.Clear();
                }

                if (max < min)
                {
                    MessageBox.Show("Max must be greater than Min.");

                    addPartMaxTextBox.Clear();
                }
            }
        }
    }
}
