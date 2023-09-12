using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace AstronomicalProcessorApp
{
    public partial class DataProcessing : Form
    {
        public DataProcessing()
        {
            InitializeComponent();
            // Load events: TextBox_KeyPress(...)
            LoadTxtKeyPress();
            PopulateComboBox("English", "bodies.txt");
        }
        private IAstroContract calculate; // Declare a class-level variable
        #region Textbox Events
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

        #endregion

        #region DLL Functions
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
                    displayValue($"{Math.Round(velocity, 4)}", 1);
                    txtObservedWavelength.Clear();
                    txtRestWavelength.Clear();
                    cboBody.Text = "";
                }
                else
                {
                    stsMsg.Text = "Empty input.";
                    string language = Thread.CurrentThread.CurrentUICulture.Name;
                    switch (language)
                    {
                        case "en-GB":
                            stsMsg.Text = "Empty input.";
                            break;
                        case "fr-FR":
                            stsMsg.Text = "Entrée vide.";
                            break;
                        case "de-DE":
                            stsMsg.Text = "Leere Eingabe.";
                            break;
                    }
                }
            }
            catch
            {
                stsMsg.Text = "Something went wrong, is the server running?";
                string language = Thread.CurrentThread.CurrentUICulture.Name;
                switch (language)
                {
                    case "en-GB":
                        stsMsg.Text = "Something went wrong, is the server running?";
                        break;
                    case "fr-FR":
                        stsMsg.Text = "Quelque chose s'est mal passé, le serveur est-il en cours d'exécution ?";
                        break;
                    case "de-DE":
                        stsMsg.Text = "Es ist ein Fehler aufgetreten. Läuft der Server?";
                        break;
                }
            }
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
                    displayValue($"{Math.Round(parsecs, 4)}", 2);
                    txtArcsecondsAngle.Clear();
                    cboBody.Text = "";
                }
                else
                {
                    stsMsg.Text = "Empty input.";
                    string language = Thread.CurrentThread.CurrentUICulture.Name;
                    switch (language)
                    {
                        case "en-GB":
                            stsMsg.Text = "Empty input.";
                            break;
                        case "fr-FR":
                            stsMsg.Text = "Entrée vide.";
                            break;
                        case "de-DE":
                            stsMsg.Text = "Leere Eingabe.";
                            break;
                    }
                }
            }
            catch
            {
                stsMsg.Text = "Something went wrong, is the server running?";
                string language = Thread.CurrentThread.CurrentUICulture.Name;
                switch (language)
                {
                    case "en-GB":
                        stsMsg.Text = "Something went wrong, is the server running?";
                        break;
                    case "fr-FR":
                        stsMsg.Text = "Quelque chose s'est mal passé, le serveur est-il en cours d'exécution ?";
                        break;
                    case "de-DE":
                        stsMsg.Text = "Es ist ein Fehler aufgetreten. Läuft der Server?";
                        break;
                }
            }
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
                    displayValue($"{schwarzschildRadius:0.##E+00}", 4);
                    txtMassBase.Clear();
                    txtPow.Clear();
                    cboBody.Text = "";
                }
                else
                {
                    stsMsg.Text = "Empty input.";
                    string language = Thread.CurrentThread.CurrentUICulture.Name;
                    switch (language)
                    {
                        case "en-GB":
                            stsMsg.Text = "Empty input.";
                            break;
                        case "fr-FR":
                            stsMsg.Text = "Entrée vide.";
                            break;
                        case "de-DE":
                            stsMsg.Text = "Leere Eingabe.";
                            break;
                    }
                }
            }
            catch
            {
                stsMsg.Text = "Something went wrong, is the server running?";
                string language = Thread.CurrentThread.CurrentUICulture.Name;
                switch (language)
                {
                    case "en-GB":
                        stsMsg.Text = "Something went wrong, is the server running?";
                        break;
                    case "fr-FR":
                        stsMsg.Text = "Quelque chose s'est mal passé, le serveur est-il en cours d'exécution ?";
                        break;
                    case "de-DE":
                        stsMsg.Text = "Es ist ein Fehler aufgetreten. Läuft der Server?";
                        break;
                }
            }
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
                    displayValue($"{Math.Round(kelvin, 4)}", 3);
                    txtCelsius.Clear();
                    cboBody.Text = "";
                }
                else
                {
                    stsMsg.Text = "Empty input.";
                    string language = Thread.CurrentThread.CurrentUICulture.Name;
                    switch (language)
                    {
                        case "en-GB":
                            stsMsg.Text = "Empty input.";
                            break;
                        case "fr-FR":
                            stsMsg.Text = "Entrée vide.";
                            break;
                        case "de-DE":
                            stsMsg.Text = "Leere Eingabe.";
                            break;
                    }
                }
            }
            catch
            {
                stsMsg.Text = "Something went wrong, is the server running?";
                string language = Thread.CurrentThread.CurrentUICulture.Name;
                switch (language)
                {
                    case "en-GB":
                        stsMsg.Text = "Something went wrong, is the server running?";
                        break;
                    case "fr-FR":
                        stsMsg.Text = "Quelque chose s'est mal passé, le serveur est-il en cours d'exécution ?";
                        break;
                    case "de-DE":
                        stsMsg.Text = "Es ist ein Fehler aufgetreten. Läuft der Server?";
                        break;
                    default:
                        stsMsg.Text = "Please select or enter a body...";
                        break;
                }
            }
        }
        #endregion

        #region Custom Methods
        // Connect and create an instance              
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
                string language = Thread.CurrentThread.CurrentUICulture.Name;
                switch (language)
                {
                    case "en-GB":
                        stsMsg.Text = "Please select or enter a body...";
                        break;
                    case "fr-FR":
                        stsMsg.Text = "Veuillez sélectionner ou saisir un corps...";
                        break;
                    case "de-DE":
                        stsMsg.Text = "Bitte wählen Sie einen Körper aus oder geben Sie ihn ein...";
                        break;
                    default:
                        stsMsg.Text = "Please select or enter a body...";
                        break;
                }
            }
        }

        // Listview Reset
        private void msClearListview_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to CLEAR all the records?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                lvOutput.Items.Clear();
            }
        }

        // Create a custom method to populate the ComboBox to read bodies from a choosed text file.
        private void PopulateComboBox(string language, string file)
        {
            try
            {
                // You can use the 'language' and 'file' parameters in your method
                string[] items = File.ReadAllLines(file); // Read all lines from the specified file
                cboBody.Items.Clear(); // Clear existing items
                cboBody.Items.AddRange(items); // Add items to ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading data from file: {ex.Message}");
            }
        }
        #endregion

        #region Menu
        //Q7_8 Menu/Button option(s) to change the language and layout for the three different countries.
        private void English_UK_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
            PopulateComboBox("English", "bodies.txt");
        }
        private void French_Click(object sender, EventArgs e)
        {
            ChangeLanguage("French");
            PopulateComboBox("French", "bodies_fr.txt");
        }
        private void German_Click(object sender, EventArgs e)
        {
            ChangeLanguage("German");
            PopulateComboBox("German", "bodies_de.txt");
        }
        private void ChangeLanguage(string language)
        {
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
                    break;
            }
            Controls.Clear();
            InitializeComponent();
        }
        // Q7_9 Menu option to change the form’s style (colours and visual appearance). 
        private void light_Click(object sender, EventArgs e)
        {
            // Background colour
            BackgroundImage = null;
            BackColor = Color.LightGoldenrodYellow;
            lvOutput.BackColor = Color.LightGoldenrodYellow;
            menuStrip1.BackColor = Color.LightGoldenrodYellow;
            statusStrip1.BackColor = Color.LightGoldenrodYellow;

            // Text colour
            ForeColor = Color.Black;
            lvOutput.ForeColor = Color.Black;
            menuStrip1.ForeColor = Color.Black;
            statusStrip1.ForeColor = Color.Black;
            foreach (var GroupBox in Controls.OfType<GroupBox>())
            {
                GroupBox.ForeColor = Color.Black;
            }
        }
        private void dark_Click(object sender, EventArgs e)
        {
            // Background colour
            BackgroundImage = null;
            BackColor = Color.DarkGray;
            lvOutput.BackColor = Color.DarkGray;
            menuStrip1.BackColor = Color.DarkGray;
            statusStrip1.BackColor = Color.DarkGray;

            // Text colour
            ForeColor = Color.White;
            lvOutput.ForeColor = Color.White;
            menuStrip1.ForeColor = Color.White;
            statusStrip1.ForeColor = Color.White;
            foreach (var GroupBox in Controls.OfType<GroupBox>())
            {
                GroupBox.ForeColor = Color.White;
            }
        }

        // Q7_10 Menu/Button option to select a custom background colour from a colour palette (Color Dialogbox) 
        private void msBackground_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = null;
                // Change the background color of the form
                BackColor = colorDlg.Color;
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                // Change the text color of the form
                ForeColor = Color.FromArgb(r, g, b);

                // Change the text color of all TextBox controls
                foreach (var textBox in Controls.OfType<TextBox>())
                {
                    textBox.ForeColor = Color.FromArgb(r, g, b);
                }

                // Change the background color of all GroupBox
                foreach (var GroupBox in Controls.OfType<GroupBox>())
                {
                    GroupBox.ForeColor = Color.FromArgb(r, g, b);
                }

                // Change the background color of all GroupBox
                foreach (var GroupBox in Controls.OfType<GroupBox>())
                {
                    GroupBox.ForeColor = Color.FromArgb(r, g, b);
                }

                // Change the background color of the componments
                lvOutput.BackColor = colorDlg.Color;
                menuStrip1.BackColor = colorDlg.Color;
                statusStrip1.BackColor = colorDlg.Color;

                // Change the font color (text color) of the componments
                lvOutput.ForeColor = Color.FromArgb(r, g, b);
                menuStrip1.ForeColor = Color.FromArgb(r, g, b);
                statusStrip1.ForeColor = Color.FromArgb(r, g, b);

                //// Change the background color of the ListView column headers
                //lvOutput.OwnerDraw = true;
                //lvOutput.DrawColumnHeader += (s, args) =>
                //{
                //    args.DrawBackground();
                //    args.Graphics.FillRectangle(new SolidBrush(colorDlg.Color), args.Bounds);
                //    args.Graphics.DrawString(args.Header.Text, this.Font,
                //        new SolidBrush(Color.FromArgb(r, g, b)), args.Bounds);
                //};

                //// Refresh the ListView to apply the changes
                //lvOutput.Refresh();
            }
        }
        #endregion       

    }
}
