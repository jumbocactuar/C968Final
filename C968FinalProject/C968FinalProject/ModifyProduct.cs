﻿using System;
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
    public partial class modifyProductForm : Form
    {
        public static List<bool> FieldStateTracker = new List<bool> { false, false, false, false, false };
        public BindingList<Part> associatedParts = new BindingList<Part>();

        public modifyProductForm()
        {
            InitializeComponent();
            modifyCandidatePartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyCandidatePartsDataGridView.ReadOnly = true;
            modifyCandidatePartsDataGridView.DataSource = Inventory.AllParts;
            modifyAssociatedPartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyAssociatedPartsDataGridView.DataSource = Counters.SelectedProductObject.AssociatedParts;
        }

        private void modifyProductForm_Load(object sender, EventArgs e)
        {
            modifyProductSaveButton.Enabled = false;
            modifyProductIDTextBox.Text = $"{Counters.SelectedProductObject.ProductID}";
            modifyProductNameTextBox.Text = $"{Counters.SelectedProductObject.Name}";
            modifyProductInventoryTextBox.Text = $"{Counters.SelectedProductObject.InStock}";
            modifyProductPriceTextBox.Text = $"{Counters.SelectedProductObject.Price}";
            modifyProductMinTextBox.Text = $"{Counters.SelectedProductObject.Min}";
            modifyProductMaxTextBox.Text = $"{Counters.SelectedProductObject.Max}";
            associatedParts = Counters.SelectedProductObject.AssociatedParts;
        }

        private void modifyCandidatePartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Counters.SelectedPartIndex = modifyCandidatePartsDataGridView.CurrentCell.RowIndex;

            Counters.SelectedPartObject = Inventory.AllParts[Counters.SelectedPartIndex];
        }

        private void modifyAssociatedPartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Counters.SelectedPartIndex = modifyAssociatedPartsDataGridView.CurrentCell.RowIndex;

            Counters.SelectedPartObject = Inventory.Products[Counters.SelectedProductIndex].AssociatedParts[Counters.SelectedPartIndex];
        }

        private void modifyCandidatePartsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            modifyCandidatePartsDataGridView.ClearSelection();
        }

        private void modifyAssociatedPartsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            modifyAssociatedPartsDataGridView.ClearSelection();
        }

        private void modifyProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyProductNameTextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void modifyProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyProductInventoryTextBox.TextLength > 0)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void modifyProductInventoryTextBox_Leave(object sender, EventArgs e)
        {
            if (modifyProductInventoryTextBox.TextLength > 0)
            {
                if (!int.TryParse(modifyProductInventoryTextBox.Text, out int i))
                {
                    MessageBox.Show("Please enter a numeric value.");

                    modifyProductInventoryTextBox.Clear();
                }
            }

            InventoryChecker();
        }

        private void modifyProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyProductPriceTextBox.TextLength > 0)
            {
                FieldStateTracker[2] = true;
            }

            else
            {
                FieldStateTracker[2] = false;
            }

            UpdateSaveButton();
        }

        private void modifyProductPriceTextBox_Leave(object sender, EventArgs e)
        {
            if (modifyProductPriceTextBox.TextLength > 0)
            {
                if (!decimal.TryParse(modifyProductPriceTextBox.Text, out decimal i))
                {
                    MessageBox.Show("Please enter a decimal value.");

                    modifyProductPriceTextBox.Clear();
                }
            }
        }

        private void modifyProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyProductMinTextBox.TextLength > 0)
            {
                FieldStateTracker[3] = true;
            }

            else
            {
                FieldStateTracker[3] = false;
            }

            UpdateSaveButton();
        }

        private void modifyProductMinTextBox_Leave(object sender, EventArgs e)
        {
            if (modifyProductMinTextBox.TextLength > 0)
            {
                if (!int.TryParse(modifyProductMinTextBox.Text, out int i))
                {
                    MessageBox.Show("Please enter a numeric value.");

                    modifyProductMinTextBox.Clear();
                }
            }

            InventoryChecker();
        }

        private void modifyProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyProductMaxTextBox.TextLength > 0)
            {
                FieldStateTracker[4] = true;
            }

            else
            {
                FieldStateTracker[4] = false;
            }

            UpdateSaveButton();
        }

        private void modifyProductMaxTextBox_Leave(object sender, EventArgs e)
        {
            if (modifyProductMaxTextBox.TextLength > 0)
            {
                if (!int.TryParse(modifyProductMaxTextBox.Text, out int i))
                {
                    MessageBox.Show("Please enter a numeric value.");

                    modifyProductMaxTextBox.Clear();
                }
            }

            InventoryChecker();
        }

        private void modifyCandidatePartAddButton_Click(object sender, EventArgs e)
        {
            // Add the candidate part to the associatedParts BindingList
            associatedParts.Add(Counters.SelectedPartObject);
        }

        private void modifyAssociatedPartDeleteButton_Click(object sender, EventArgs e)
        {
            // Select the appropriate part in associatedParts and remove it
            Counters.SelectedPartIndex = modifyAssociatedPartsDataGridView.CurrentCell.RowIndex;

            Counters.SelectedPartObject = associatedParts[Counters.SelectedPartIndex];

            associatedParts.Remove(Counters.SelectedPartObject);
        }

        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            // Convert strings to appropriate types for constructor input
            int id = int.Parse(modifyProductIDTextBox.Text);
            decimal price = decimal.Parse(modifyProductPriceTextBox.Text);
            int inventory = int.Parse(modifyProductInventoryTextBox.Text);
            int min = int.Parse(modifyProductMinTextBox.Text);
            int max = int.Parse(modifyProductMaxTextBox.Text);

            // Replace the existing Product with the updated Product
            Product p = new Product(associatedParts, id, modifyProductNameTextBox.Text, price, inventory, min, max);

            Inventory.updateProduct(Counters.SelectedProductIndex, p);

            // Close the Modify Product form
            Close();
        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyCandidatePartSearchButton_Click(object sender, EventArgs e)
        {
            modifyCandidatePartsDataGridView.ClearSelection();

            bool found = false;

            if (!int.TryParse(modifyCandidatePartSearchTextBox.Text, out int id))
            {
                MessageBox.Show("Part ID must be numeric.");

                modifyCandidatePartSearchTextBox.Clear();
            }

            foreach (DataGridViewRow row in modifyCandidatePartsDataGridView.Rows)
            {
                Part p = (Part)row.DataBoundItem;

                if (p.PartID == id)
                {
                    row.Selected = true;
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                MessageBox.Show("Part ID not found.");
            }
        }
    

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                modifyProductSaveButton.Enabled = false;
            }

            else
            {
                modifyProductSaveButton.Enabled = true;
            }
        }

        private void InventoryChecker()
        {
            // Check whether Inventory is between Min and Max, Min < Max, and Max > Min
            if ((modifyProductInventoryTextBox.TextLength > 0) && (modifyProductMinTextBox.TextLength > 0) && (modifyProductMaxTextBox.TextLength > 0))
            {
                int inv = int.Parse(modifyProductInventoryTextBox.Text);
                int min = int.Parse(modifyProductMinTextBox.Text);
                int max = int.Parse(modifyProductMaxTextBox.Text);

                if ((inv < min) || (inv > max))
                {
                    MessageBox.Show("Inventory must be greater than Min and less than Max.");

                    modifyProductInventoryTextBox.Clear();
                }
            }

            if ((modifyProductMinTextBox.TextLength > 0) && (modifyProductMaxTextBox.TextLength > 0))
            {
                int min = int.Parse(modifyProductMinTextBox.Text);
                int max = int.Parse(modifyProductMaxTextBox.Text);

                if (min > max)
                {
                    MessageBox.Show("Min must be less than Max");

                    modifyProductMinTextBox.Clear();
                }

                if (max < min)
                {
                    MessageBox.Show("Max must be greater than Min.");

                    modifyProductMaxTextBox.Clear();
                }
            }
        }
    }
}