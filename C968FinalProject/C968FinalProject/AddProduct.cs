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
        public addProductForm()
        {
            InitializeComponent();

        }

        private void addProductForm_Load(object sender, EventArgs e)
        {
            addProductSaveButton.Enabled = false;
        }

        private void addProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addProductNameTextBox.Text != null)
            {
                addProductSaveButton.Enabled = true;
            }
        }

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
