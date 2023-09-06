using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AstronomicalProcessorApp
{
    public partial class DataProcessing : Form
    {
        public DataProcessing()
        {
            InitializeComponent();

            // Load events: TextBox_KeyPress(...)
            LoadTxtKeyPress();
            PopulateComboBox();
        }

        #region Textbox Events
        // Create a custom method to populate the ComboBox to read bodies from a simple text file. 
        private void PopulateComboBox()
        {
            string filePath = "bodies.txt";
            try
            {
                string[] bodies = File.ReadAllLines(filePath); // read all lines from file
                cboBody.Items.AddRange(bodies); // add bodies to ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading bodies from file: {ex.Message}");
            }
        }

        // A custom keypress method to ensure all the textboxes can only accept 
        // a double value with one decimal point, and one negative sign in the 1st position.
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as System.Windows.Forms.TextBox;

            // Allow digits, a single decimal point, a negative sign, and control characters
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d.\-\b]"))
            {
                e.Handled = true;
            }

            // Allow a negative sign only in the first position
            if (e.KeyChar == '-' && textBox.SelectionStart != 0)
            {
                e.Handled = true;
            }

            // Ensure only one decimal point is allowed
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        // Load TextBox_KeyPress;
        private void LoadTxtKeyPress()
        {
            txtObservedWavelength.KeyPress += TextBox_KeyPress;
            txtRestWavelength.KeyPress += TextBox_KeyPress;
            txtArcsecondsAngle.KeyPress += TextBox_KeyPress;
            txtMassBase.KeyPress += TextBox_KeyPress;
            txtPow.KeyPress += TextBox_KeyPress;
            txtCelsius.KeyPress += TextBox_KeyPress;
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
                txtRestWavelength.ForeColor = Color.Black;
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

        private void txtArcsecondsAngle_Enter(object sender, EventArgs e)
        {
            if (txtArcsecondsAngle.Text == "Arcseconds angle:")
            {
                txtArcsecondsAngle.Text = "";
                txtArcsecondsAngle.ForeColor = Color.Black;
            }
        }

        private void txtArcsecondsAngle_Leave(object sender, EventArgs e)
        {
            if (txtArcsecondsAngle.Text == "")
            {
                txtArcsecondsAngle.Text = "Arcseconds angle:";
                txtArcsecondsAngle.ForeColor = Color.Silver;
            }
        }

        private void txtMassBase_Enter(object sender, EventArgs e)
        {
            if (txtMassBase.Text == "Blackhole Mass Base:")
            {
                txtMassBase.Text = "";
                txtMassBase.ForeColor = Color.Black;
            }
        }

        private void txtMassBase_Leave(object sender, EventArgs e)
        {
            if (txtMassBase.Text == "")
            {
                txtMassBase.Text = "Blackhole Mass Base:";
                txtMassBase.ForeColor = Color.Silver;
            }
        }

        private void txtPow_Enter(object sender, EventArgs e)
        {
            if (txtPow.Text == "Power:  (x * 10)")
            {
                txtPow.Text = "";
                txtPow.ForeColor = Color.Black;
            }
        }

        private void txtPow_Leave(object sender, EventArgs e)
        {
            if (txtPow.Text == "")
            {
                txtPow.Text = "Power:  (x * 10)";
                txtPow.ForeColor = Color.Silver;
            }
        }

        private void txtCelsius_Enter(object sender, EventArgs e)
        {
            if (txtCelsius.Text == "Celsius:")
            {
                txtCelsius.Text = "";
                txtCelsius.ForeColor = Color.Black;
            }
        }

        private void txtCelsius_Leave(object sender, EventArgs e)
        {
            if (txtCelsius.Text == "")
            {
                txtCelsius.Text = "Celsius:";
                txtCelsius.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void btnStarVelocity_Click(object sender, EventArgs e)
        {
            createInstance();

            stsMsg.Text = "";
            try
            {
                if (double.TryParse(txtObservedWavelength.Text, out double observedWavelength) &&
                    double.TryParse(txtRestWavelength.Text, out double restWavelength))
                {
                    double velocity = calculate.StarVelocity(observedWavelength, restWavelength);
                    stsMsg.Text = $"{velocity}";
                    displayValue($"{velocity}", 1);
                    txtObservedWavelength.Clear();
                    txtRestWavelength.Clear();
                }
                else { stsMsg.Text = "Empty input."; }
            }
            catch { stsMsg.Text = "Something went wrong, is the server running?"; }
        }

        private void btnStarDistance_Click(object sender, EventArgs e)
        {
            createInstance();

            stsMsg.Text = "";
            try
            {
                if (double.TryParse(txtArcsecondsAngle.Text, out double arcsecondsAngle))
                {
                    double parsecs = calculate.StarDistance(arcsecondsAngle);
                    stsMsg.Text = $"{parsecs}";
                    displayValue($"{parsecs}", 2);
                    txtArcsecondsAngle.Clear();
                }
                else { stsMsg.Text = "Empty input."; }
            }
            catch { stsMsg.Text = "Something went wrong, is the server running?"; }
        }

        private void btnBlackholeEventHorizon_Click(object sender, EventArgs e)
        {
            createInstance();

            stsMsg.Text = "";
            try
            {
                if (double.TryParse(txtMassBase.Text, out double massBase) && double.TryParse(txtPow.Text, out double massPow))
                {
                    double blackholeMass = massBase * Math.Pow(10, massPow);
                    double schwarzschildRadius = calculate.BlackholeEventHorizon(blackholeMass);
                    stsMsg.Text = $"{schwarzschildRadius:0.##E+00}";
                    displayValue($"{schwarzschildRadius:0.##E+00}", 4);
                    txtMassBase.Clear();
                    txtPow.Clear();
                }
                else { stsMsg.Text = "Empty input."; }
            }
            catch { stsMsg.Text = "Something went wrong, is the server running?"; }
        }

        private void btnTemperatureConversion_Click(object sender, EventArgs e)
        {
            createInstance();

            stsMsg.Text = "";
            try
            {
                if (double.TryParse(txtCelsius.Text, out double celsius))
                {
                    double kelvin = calculate.TemperatureConversion(celsius);
                    stsMsg.Text = $"{kelvin}";
                    displayValue($"{kelvin}", 3);
                    txtCelsius.Clear();
                }
                else { stsMsg.Text = "Empty input."; }
            }
            catch { stsMsg.Text = "Something went wrong, is the server running?"; }
        }
        #region Custom Methods
        // Connect and create an instance
        private IAstroContract calculate; // Declare a class-level variable        
        private void createInstance()
        {
            string address = "net.pipe://localhost/pipemynumbers";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            calculate = ChannelFactory<IAstroContract>.CreateChannel(binding, ep); // Store the instance in the class-level variable
        }

        // Listview output
        private void displayValue(string value, int column)
        {
            if (!string.IsNullOrEmpty(cboBody.Text))
            {
                // Create a ListViewItem
                ListViewItem lvi = new ListViewItem(cboBody.Text);

                // Add subitems to the ListViewItem, ensuring that the subitems list has enough elements
                while (lvi.SubItems.Count <= column)
                {
                    lvi.SubItems.Add(string.Empty); // Add empty subitems for columns prior to the specified column
                }

                lvi.SubItems[column] = new ListViewItem.ListViewSubItem(lvi, value);

                // Add the ListViewItem to the ListView
                lvOutput.Items.Add(lvi);
            }
            else
            {
                stsMsg.Text = "Please select or enter a body...";
            }
        }
        #endregion
    }
}
