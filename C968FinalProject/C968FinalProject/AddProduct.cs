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
    public partial class addProductForm : Form
    {
        public static List<bool> FieldStateTracker = new List<bool> { false, false, false, false, false };
        // FIXME: Can a value be displayed in a text box that is disabled? Is it preferable to set the field to read only?

        public addProductForm()
        {
            InitializeComponent();
            candidatePartsDataGridView.DataSource = Inventory.AllParts;
            //FIXME: associatedPartsDataGridView.DataSource = 
        }

        private void addProductForm_Load(object sender, EventArgs e)
        {
            addProductSaveButton.Enabled = false;
        }

        private void candidatePartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = candidatePartsDataGridView.CurrentCell.RowIndex;
            //selectedIndex = e.RowIndex;
            selectedObject = Inventory.AllParts[selectedIndex];
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

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            // FIXME: Convert strings to appropriate types for constructor input


            // FIXME: Add the product to the Products BindingList


            // Close the Add Product form
            Close();
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
