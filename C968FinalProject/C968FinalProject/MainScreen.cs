using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace C968FinalProject
{
    public partial class mainScreenForm : Form
    {
        public mainScreenForm()
        {
            InitializeComponent();
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsDataGridView.DataSource = Inventory.AllParts;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.DataSource = Inventory.Products;
        }

        private void partsDataGridView_Load(object sender, EventArgs e)
        {

        }

        private void partsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsDataGridView.ClearSelection();
        }

        private void productsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productsDataGridView.ClearSelection();
        }

        private void partsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Counters.SelectedPartIndex = partsDataGridView.CurrentCell.RowIndex;

            Counters.SelectedPartObject = Inventory.AllParts[Counters.SelectedPartIndex];
        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Counters.SelectedProductIndex = productsDataGridView.CurrentCell.RowIndex;

            Counters.SelectedProductObject = Inventory.Products[Counters.SelectedProductIndex];
        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            addPartForm f = new addPartForm();
            f.Show();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            modifyPartForm f = new modifyPartForm();
            f.Show();
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            string message = "Delete the selected part?";
            string caption = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.OK)
            {
                Inventory.deletePart(Counters.SelectedPartIndex);
            }
        }

        private void productsAddButton_Click(object sender, EventArgs e)
        {
            addProductForm f = new addProductForm();
            f.Show();
        }

        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            modifyProductForm f = new modifyProductForm();
            f.Show();
        }

        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            string message = "Delete the selected product?";
            string caption = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.OK)
            {
                Inventory.removeProduct(Counters.SelectedProductIndex);
            }
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            partsDataGridView.ClearSelection();

            bool found = false;

            if (!int.TryParse(partsSearchTextBox.Text, out int id))
            {
                MessageBox.Show("Part ID must be numeric.");

                partsSearchTextBox.Clear();
            }

            foreach (DataGridViewRow row in partsDataGridView.Rows)
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

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            productsDataGridView.ClearSelection();

            bool found = false;

            if (!int.TryParse(productsSearchTextBox.Text, out int id))
            {
                MessageBox.Show("Product ID must be numeric.");

                productsSearchTextBox.Clear();
            }

            foreach (DataGridViewRow row in productsDataGridView.Rows)
            {
                Product p = (Product)row.DataBoundItem;

                if (p.ProductID == id)
                {
                    row.Selected = true;
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                MessageBox.Show("Product ID not found.");
            }
        }
        private void programExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
