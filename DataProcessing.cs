﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalProcessorApp
{
    public partial class DataProcessing : Form
    {
        public DataProcessing()
        {
            InitializeComponent();

            // Load events: TextBox_KeyPress(...)
            LoadTxtKeyPress();
        }

        #region Textbox Events
        // A custom keypress method to ensure all the textboxes can only accept 
        // a double value with one decimal point, and one negative sign in the 1st position.
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

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
            txtBlackholeMass.KeyPress += TextBox_KeyPress;
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

        private void txtBlackholeMass_Enter(object sender, EventArgs e)
        {
            if (txtBlackholeMass.Text == "Blackhole Mass:")
            {
                txtBlackholeMass.Text = "";
                txtBlackholeMass.ForeColor = Color.Black;
            }
        }

        private void txtBlackholeMass_Leave(object sender, EventArgs e)
        {
            if (txtBlackholeMass.Text == "")
            {
                txtBlackholeMass.Text = "Blackhole Mass:";
                txtBlackholeMass.ForeColor = Color.Silver;
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

        // Create a List<IAstroContract> instance.
        //List<IAstroContract> calculator = new List<IAstroContract>();

        private void btnStarVelocity_Click(object sender, EventArgs e)
        {
            string address = "net.pipe://localhost/pipemynumbers";
            NetNamedPipeBinding binding =
            new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract calculate =
            ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            txtFeedback.Text = "";
            try
            {
                if (double.TryParse(txtObservedWavelength.Text, out double observedWavelength) &&
                    double.TryParse(txtRestWavelength.Text, out double restWavelength))
                {
                    double velocity = calculate.StarVelocity(observedWavelength, restWavelength);
                    txtFeedback.Text = $"{velocity}";
                }
                else { txtFeedback.Text = "Empty input."; }
            }
            catch { txtFeedback.Text = "Something went wrong, is the server running?"; }
        }

        private void btnStarDistance_Click(object sender, EventArgs e)
        {
            string address = "net.pipe://localhost/pipemynumbers";
            NetNamedPipeBinding binding =
            new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract calculate =
            ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            txtFeedback.Text = "";
            try
            {
                if (double.TryParse(txtArcsecondsAngle.Text, out double arcsecondsAngle))
                {
                    double parsecs = calculate.StarDistance(arcsecondsAngle);
                    txtFeedback.Text = $"{parsecs}";
                }
                else { txtFeedback.Text = "Empty input."; }
            }
            catch { txtFeedback.Text = "Something went wrong, is the server running?"; }
        }

        private void btnBlackholeEventHorizon_Click(object sender, EventArgs e)
        {
            //double baseValue = 8.2;
            //int exponent = 36;
            //double result = Math.Pow(baseValue, exponent);

            string address = "net.pipe://localhost/pipemynumbers";
            NetNamedPipeBinding binding =
            new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract calculate =
            ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            txtFeedback.Text = "";
            try
            {
                if (double.TryParse(txtBlackholeMass.Text, out double blackholeMass))
                {
                    double schwarzschildRadius = calculate.BlackholeEventHorizon(blackholeMass);
                    txtFeedback.Text = $"{schwarzschildRadius}";
                }
                else { txtFeedback.Text = "Empty input."; }
            }
            catch { txtFeedback.Text = "Something went wrong, is the server running?"; }
        }

        private void btnTemperatureConversion_Click(object sender, EventArgs e)
        {
            string address = "net.pipe://localhost/pipemynumbers";
            NetNamedPipeBinding binding =
            new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract calculate =
            ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            txtFeedback.Text = "";
            try
            {
                if (double.TryParse(txtCelsius.Text, out double celsius))
                {
                    double kelvin = calculate.TemperatureConversion(celsius);
                    txtFeedback.Text = $"{kelvin}";
                }
                else { txtFeedback.Text = "Empty input."; }
            }
            catch { txtFeedback.Text = "Something went wrong, is the server running?"; }
        }
    }
}
