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
            partsDataGridView.DataSource = Inventory.AllParts;
        }

        private void partsDataGridView_Load(object sender, EventArgs e)
        {

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
            //FIXME: Give this button something to do
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
            //FIXME: Give this button something to do
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            //FIXME: Give this button something to do
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            //FIXME: Give this button something to do
        }
        private void programExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //FIXME: Delete this before submission
        private void practiceFormButton_Click(object sender, EventArgs e)
        {
            practiceForm f = new practiceForm();
            f.Show();
        }
    }
}
