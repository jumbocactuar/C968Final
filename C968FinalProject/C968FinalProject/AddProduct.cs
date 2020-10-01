using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968FinalProject
{
    public partial class addProductForm : Form
    {
        public static List<bool> FieldStateTracker = new List<bool> { false, false, false, false, false };
        public BindingList<Part> associatedParts = new BindingList<Part>();
        // FIXME: Can a value be displayed in a text box that is disabled? Is it preferable to set the field to read only?

        public addProductForm()
        {
            InitializeComponent();
            candidatePartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            candidatePartsDataGridView.DataSource = Inventory.AllParts;
            associatedPartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedPartsDataGridView.DataSource = associatedParts;
        }

        private void addProductForm_Load(object sender, EventArgs e)
        {
            // Disable the Save button until all fields contain values
            addProductSaveButton.Enabled = false;
            addProductIDTextBox.Text = $"{Counters.ProductsIDCounter + 1}";
        }

        private void candidatePartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Counters.SelectedPartIndex = candidatePartsDataGridView.CurrentCell.RowIndex;

            Counters.SelectedPartObject = Inventory.AllParts[Counters.SelectedPartIndex];
        }

        private void addProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addProductNameTextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void addProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addProductInventoryTextBox.TextLength > 0)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void addProductInventoryTextBox_Leave(object sender, EventArgs e)
        {
            InventoryChecker();
        }

        private void addProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addProductPriceTextBox.TextLength > 0)
            {
                FieldStateTracker[2] = true;
            }

            else
            {
                FieldStateTracker[2] = false;
            }

            UpdateSaveButton();
        }

        private void addProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addProductMinTextBox.TextLength > 0)
            {
                FieldStateTracker[3] = true;
            }

            else
            {
                FieldStateTracker[3] = false;
            }

            UpdateSaveButton();
        }

        private void addProductMinTextBox_Leave(object sender, EventArgs e)
        {
            InventoryChecker();
        }

        private void addProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addProductMaxTextBox.TextLength > 0)
            {
                FieldStateTracker[4] = true;
            }

            else
            {
                FieldStateTracker[4] = false;
            }

            UpdateSaveButton();
        }

        private void addProductMaxTextBox_Leave(object sender, EventArgs e)
        {
            InventoryChecker();
        }

        private void candidatePartAddButton_Click(object sender, EventArgs e)
        {
            // Add the candidate part to the associatedParts BindingList
            associatedParts.Add(Counters.SelectedPartObject);
        }

        private void associatedPartDeleteButton_Click(object sender, EventArgs e)
        {
            // Select the appropriate part in associatedParts and remove it
            Counters.SelectedPartIndex = associatedPartsDataGridView.CurrentCell.RowIndex;

            Counters.SelectedPartObject = associatedParts[Counters.SelectedPartIndex];
            
            associatedParts.Remove(Counters.SelectedPartObject);
        }

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            // Convert strings to appropriate types for constructor input
            decimal price = decimal.Parse(addProductPriceTextBox.Text);
            int inventory = int.Parse(addProductInventoryTextBox.Text);
            int min = int.Parse(addProductMinTextBox.Text);
            int max = int.Parse(addProductMaxTextBox.Text);

            // Add the product to the Products BindingList
            Product p = new Product(associatedParts, Counters.ProductsIDCounter, addProductNameTextBox.Text, price, inventory, min, max);

            Inventory.addProduct(p);

            // Close the Add Product form
            Close();
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void candidatePartSearchButton_Click(object sender, EventArgs e)
        {
            // FIXME: Look up a part in the AllParts list
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                addProductSaveButton.Enabled = false;
            }

            else
            {
                addProductSaveButton.Enabled = true;
            }
        }

        private void InventoryChecker()
        {
            // Check whether Inventory is between Min and Max, Min < Max, and Max > Min
            if ((addProductInventoryTextBox.TextLength > 0) && (addProductMinTextBox.TextLength > 0) && (addProductMaxTextBox.TextLength > 0))
            {
                int inv = int.Parse(addProductInventoryTextBox.Text);
                int min = int.Parse(addProductMinTextBox.Text);
                int max = int.Parse(addProductMaxTextBox.Text);

                if ((inv < min) || (inv > max))
                {
                    MessageBox.Show("Inventory must be greater than Min and less than Max.");

                    addProductInventoryTextBox.Clear();
                }
            }

            if ((addProductMinTextBox.TextLength > 0) && (addProductMaxTextBox.TextLength > 0))
            {
                int min = int.Parse(addProductMinTextBox.Text);
                int max = int.Parse(addProductMaxTextBox.Text);

                if (min > max)
                {
                    MessageBox.Show("Min must be less than Max");

                    addProductMinTextBox.Clear();
                }

                if (max < min)
                {
                    MessageBox.Show("Max must be greater than Min.");

                    addProductMaxTextBox.Clear();
                }
            }
        }
    }
}
