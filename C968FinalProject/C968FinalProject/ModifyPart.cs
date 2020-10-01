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
    public partial class modifyPartForm : Form
    {
        public static List<bool> FieldStateTracker = new List<bool> { false, false, false, false, false, false };

        public modifyPartForm()
        {
            InitializeComponent();
        }

        private void modifyPartForm_Load(object sender, EventArgs e)
        {
            modifyPartIDTextBox.Text = $"{Counters.SelectedPartObject.PartID}";
            modifyPartNameTextBox.Text = $"{Counters.SelectedPartObject.Name}";
            modifyPartInventoryTextBox.Text = $"{Counters.SelectedPartObject.InStock}";
            modifyPartPriceTextBox.Text = $"{Counters.SelectedPartObject.Price}";
            modifyPartMinTextBox.Text = $"{Counters.SelectedPartObject.Min}";
            modifyPartMaxTextBox.Text = $"{Counters.SelectedPartObject.Max}";
            modifyPartSourceTextBox.Text = Counters.SelectedPartObject.PartSource();
            
            // Set up the form depending on whether the selected Part is Inhouse or Outsourced
            if (Counters.SelectedPartObject is Inhouse)
            {
                modifyPartInhouseRadioButton.Checked = true;
                modifyPartMachineIDLabel.Show();
                modifyPartCompanyNameLabel.Hide();
            }

            else
            {
                modifyPartOutsourcedRadioButton.Checked = true;
                modifyPartCompanyNameLabel.Show();
                modifyPartMachineIDLabel.Hide();
            }
        }

        private void modifyPartInhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == modifyPartInhouseRadioButton)
            {
                modifyPartMachineIDLabel.Show();
                modifyPartCompanyNameLabel.Hide();
            }
        }

        private void modifyPartOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == modifyPartOutsourcedRadioButton)
            {
                modifyPartCompanyNameLabel.Show();
                modifyPartMachineIDLabel.Hide();
            }
        }

        private void modifyPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyPartNameTextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void modifyPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyPartInventoryTextBox.TextLength > 0)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void modifyPartInventoryTextBox_Leave(object sender, EventArgs e)
        {
            if (modifyPartInventoryTextBox.TextLength > 0)
            {
                if (!int.TryParse(modifyPartInventoryTextBox.Text, out int i))
                {
                    MessageBox.Show("Please enter a numeric value.");

                    modifyPartInventoryTextBox.Clear();
                }
            }

            InventoryChecker();
        }

        private void modifyPartPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyPartPriceTextBox.TextLength > 0)
            {
                FieldStateTracker[2] = true;
            }

            else
            {
                FieldStateTracker[2] = false;
            }

            UpdateSaveButton();
        }

        private void modifyPartPriceTextBox_Leave(object sender, EventArgs e)
        {
            if (modifyPartPriceTextBox.TextLength > 0)
            {
                if (!decimal.TryParse(modifyPartPriceTextBox.Text, out decimal i))
                {
                    MessageBox.Show("Please enter a decimal value.");

                    modifyPartPriceTextBox.Clear();
                }
            }
        }

        private void modifyPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyPartMinTextBox.TextLength > 0)
            {
                FieldStateTracker[3] = true;
            }

            else
            {
                FieldStateTracker[3] = false;
            }

            UpdateSaveButton();
        }

        private void modifyPartMinTextBox_Leave(object sender, EventArgs e)
        {
            if (modifyPartMinTextBox.TextLength > 0)
            {
                if (!int.TryParse(modifyPartMinTextBox.Text, out int i))
                {
                    MessageBox.Show("Please enter a numeric value.");

                    modifyPartMinTextBox.Clear();
                }
            }

            InventoryChecker();
        }

        private void modifyPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyPartMaxTextBox.TextLength > 0)
            {
                FieldStateTracker[4] = true;
            }

            else
            {
                FieldStateTracker[4] = false;
            }

            UpdateSaveButton();
        }

        private void modifyPartMaxTextBox_Leave(object sender, EventArgs e)
        {
            if (modifyPartMaxTextBox.TextLength > 0)
            {
                if (!int.TryParse(modifyPartMaxTextBox.Text, out int i))
                {
                    MessageBox.Show("Please enter a numeric value.");

                    modifyPartMaxTextBox.Clear();
                }
            }

            InventoryChecker();
        }

        private void modifyPartSourceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyPartSourceTextBox.TextLength > 0)
            {
                FieldStateTracker[5] = true;
            }

            else
            {
                FieldStateTracker[5] = false;
            }

            UpdateSaveButton();
        }

        private void modifyPartSourceTextBox_Leave(object sender, EventArgs e)
        {
            if ((modifyPartInhouseRadioButton.Checked == true) && (modifyPartSourceTextBox.TextLength > 0))
            {
                if (!int.TryParse(modifyPartSourceTextBox.Text, out int i))
                {
                    MessageBox.Show("Please enter a numeric value.");

                    modifyPartSourceTextBox.Clear();
                }
            }
        }

        private void modifyPartSaveButton_Click(object sender, EventArgs e)
        {
            // Convert strings to appropriate types for constructor input
            int id = int.Parse(modifyPartIDTextBox.Text);
            decimal price = decimal.Parse(modifyPartPriceTextBox.Text);
            int inventory = int.Parse(modifyPartInventoryTextBox.Text);
            int min = int.Parse(modifyPartMinTextBox.Text);
            int max = int.Parse(modifyPartMaxTextBox.Text);

            // Add the appropriate type part to the AllParts BindingList
            if (modifyPartInhouseRadioButton.Checked == true)
            {
                Part p = new Inhouse(id, modifyPartNameTextBox.Text, price, inventory, min, max, int.Parse(modifyPartSourceTextBox.Text));

                Inventory.updatePart(Counters.SelectedPartIndex, p);

                Counters.SelectedPartObject = p;
            }

            else if (modifyPartOutsourcedRadioButton.Checked == true)
            {
                Part p = new Outsourced(id, modifyPartNameTextBox.Text, price, inventory, min, max, modifyPartSourceTextBox.Text);

                Inventory.updatePart(Counters.SelectedPartIndex, p);

                Counters.SelectedPartObject = p;
            }

            // Close the Modify Part form
            Close();
        }

        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                modifyPartSaveButton.Enabled = false;
            }

            else
            {
                modifyPartSaveButton.Enabled = true;
            }
        }

        private void InventoryChecker()
        {
            // Check whether Inventory is between Min and Max, Min < Max, and Max > Min
            if ((modifyPartInventoryTextBox.TextLength > 0) && (modifyPartMinTextBox.TextLength > 0) && (modifyPartMaxTextBox.TextLength > 0))
            {
                int inv = int.Parse(modifyPartInventoryTextBox.Text);
                int min = int.Parse(modifyPartMinTextBox.Text);
                int max = int.Parse(modifyPartMaxTextBox.Text);

                if ((inv < min) || (inv > max))
                {
                    MessageBox.Show("Inventory must be greater than Min and less than Max.");

                    modifyPartInventoryTextBox.Clear();
                }
            }

            if ((modifyPartMinTextBox.TextLength > 0) && (modifyPartMaxTextBox.TextLength > 0))
            {
                int min = int.Parse(modifyPartMinTextBox.Text);
                int max = int.Parse(modifyPartMaxTextBox.Text);

                if (min > max)
                {
                    MessageBox.Show("Min must be less than Max");

                    modifyPartMinTextBox.Clear();
                }

                if (max < min)
                {
                    MessageBox.Show("Max must be greater than Min.");

                    modifyPartMaxTextBox.Clear();
                }
            }
        }
    }
}
