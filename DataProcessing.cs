using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalProcessorApp
{
    public partial class DataProcessing : Form
    {
        public DataProcessing()
        {
            InitializeComponent();
        }

        private void txtObservedWavelength_Enter(object sender, EventArgs e)
        {
            if (txtObservedWavelength.Text == "Observed Wavelength:")
            {
                txtObservedWavelength.Text = "";
                txtObservedWavelength.ForeColor = Color.Black;
            }
        }

        private void txtObservedWavelength_Leave(object sender, EventArgs e)
        {
            if (txtObservedWavelength.Text == "")
            {
                txtObservedWavelength.Text = "Observed Wavelength:";
                txtObservedWavelength.ForeColor = Color.Silver;
            }
        }

        private void txtRestWavelength_Enter(object sender, EventArgs e)
        {
            if (txtRestWavelength.Text == "Rest Wavelength:")
            {
                txtRestWavelength.Text = "";
                txtRestWavelength.ForeColor= Color.Black;
            }
        }

        private void txtRestWavelength_Leave(object sender, EventArgs e)
        {
            if (txtRestWavelength.Text == "")
            {
                txtRestWavelength.Text = "Rest Wavelength:";
                txtRestWavelength.ForeColor = Color.Silver;
            }
        }
    }
}
