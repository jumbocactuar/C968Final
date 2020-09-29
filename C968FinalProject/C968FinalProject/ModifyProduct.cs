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
    public partial class modifyProductForm : Form
    {
        public static List<bool> FieldStateTracker = new List<bool> { false, false, false, false, false };

        public modifyProductForm()
        {
            InitializeComponent();
            modifyCandidatePartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyCandidatePartsDataGridView.ReadOnly = true;
            // FIXME: After enabling the Add button, make sure the above read only thing doesn't mess anything up
            modifyCandidatePartsDataGridView.DataSource = Inventory.AllParts;
            modifyAssociatedPartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Counters.SelectedProductObject = Inventory.Products[Counters.SelectedProductIndex];
            modifyAssociatedPartsDataGridView.DataSource = Counters.SelectedProductObject.AssociatedParts;
        }

        private void modifyProductForm_Load(object sender, EventArgs e)
        {
            modifyProductSaveButton.Enabled = false;
            modifyProductIDTextBox.Text = $"{Counters.SelectedProductObject.ProductID}";
        }
    }
}


// TODO: Fully implement separate parts and products indices, add cell click events on the Main Screen to set the indices,
// Maybe zero out the indices upon load so it doesn't carry over the wrong value?