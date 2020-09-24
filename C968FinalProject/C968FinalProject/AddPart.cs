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
        public addPartForm()
        {
            InitializeComponent();
        }

        private void addPartInhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == addPartInhouseRadioButton)
            {
                addPartMachineIDLabel.Show();
            }
        }

        private void addPartOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == addPartOutsourcedRadioButton)
            {
                addPartCompanyNameLabel.Show();
            }
        }
    }
}
