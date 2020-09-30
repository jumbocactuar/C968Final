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

            if (Counters.SelectedPartObject is Inhouse)
            {
                modifyPartInhouseRadioButton.Checked = true;
                modifyPartMachineIDLabel.Show();
                modifyPartCompanyNameLabel.Hide();
                //modifyPartSourceTextBox.Text = $"{Counters.SelectedPartObject.MachineID}";
            }

            else
            {
                modifyPartOutsourcedRadioButton.Checked = true;
                modifyPartCompanyNameLabel.Show();
                modifyPartMachineIDLabel.Hide();
                //modifyPartSourceTextBox.Text = $"{Counters.SelectedPartObject.CompanyName}";
            }
        }
    }
}

// TODO: Do I need two new trackers: SelectedInhouse and SelectedOutsourced?
