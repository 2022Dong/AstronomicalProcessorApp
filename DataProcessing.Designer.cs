namespace AstronomicalProcessorApp
{
    partial class DataProcessing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataProcessing));
            this.txtObservedWavelength = new System.Windows.Forms.TextBox();
            this.txtRestWavelength = new System.Windows.Forms.TextBox();
            this.btnStarVelocity = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnTemperatureConversion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtArcsecondsAngle = new System.Windows.Forms.TextBox();
            this.btnStarDistance = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMassBase = new System.Windows.Forms.TextBox();
            this.txtPow = new System.Windows.Forms.TextBox();
            this.btnBlackholeEventHorizon = new System.Windows.Forms.Button();
            this.lvOutput = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cboBody = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.English_UK = new System.Windows.Forms.ToolStripMenuItem();
            this.French = new System.Windows.Forms.ToolStripMenuItem();
            this.German = new System.Windows.Forms.ToolStripMenuItem();
            this.msStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.light = new System.Windows.Forms.ToolStripMenuItem();
            this.dark = new System.Windows.Forms.ToolStripMenuItem();
            this.msBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.msClearListview = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtObservedWavelength
            // 
            this.txtObservedWavelength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservedWavelength.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtObservedWavelength.Location = new System.Drawing.Point(24, 58);
            this.txtObservedWavelength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservedWavelength.Name = "txtObservedWavelength";
            this.txtObservedWavelength.Size = new System.Drawing.Size(213, 28);
            this.txtObservedWavelength.TabIndex = 1;
            this.txtObservedWavelength.Text = "Observed Wavelength:";
            this.txtObservedWavelength.Enter += new System.EventHandler(this.txtObservedWavelength_Enter);
            this.txtObservedWavelength.Leave += new System.EventHandler(this.txtObservedWavelength_Leave);
            // 
            // txtRestWavelength
            // 
            this.txtRestWavelength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestWavelength.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRestWavelength.Location = new System.Drawing.Point(24, 107);
            this.txtRestWavelength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRestWavelength.Name = "txtRestWavelength";
            this.txtRestWavelength.Size = new System.Drawing.Size(213, 28);
            this.txtRestWavelength.TabIndex = 0;
            this.txtRestWavelength.Text = "Rest Wavelength:";
            this.txtRestWavelength.Enter += new System.EventHandler(this.txtRestWavelength_Enter);
            this.txtRestWavelength.Leave += new System.EventHandler(this.txtRestWavelength_Leave);
            // 
            // btnStarVelocity
            // 
            this.btnStarVelocity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStarVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarVelocity.Location = new System.Drawing.Point(24, 161);
            this.btnStarVelocity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStarVelocity.Name = "btnStarVelocity";
            this.btnStarVelocity.Size = new System.Drawing.Size(213, 44);
            this.btnStarVelocity.TabIndex = 0;
            this.btnStarVelocity.Text = "Calculate";
            this.btnStarVelocity.UseVisualStyleBackColor = false;
            this.btnStarVelocity.Click += new System.EventHandler(this.btnStarVelocity_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservedWavelength);
            this.groupBox1.Controls.Add(this.txtRestWavelength);
            this.groupBox1.Controls.Add(this.btnStarVelocity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 234);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Star Velocity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCelsius);
            this.groupBox2.Controls.Add(this.btnTemperatureConversion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1001, 421);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Celsius -> Kelvin";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsius.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCelsius.Location = new System.Drawing.Point(24, 66);
            this.txtCelsius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(213, 28);
            this.txtCelsius.TabIndex = 1;
            this.txtCelsius.Text = "Celsius:";
            this.txtCelsius.Enter += new System.EventHandler(this.txtCelsius_Enter);
            this.txtCelsius.Leave += new System.EventHandler(this.txtCelsius_Leave);
            // 
            // btnTemperatureConversion
            // 
            this.btnTemperatureConversion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemperatureConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemperatureConversion.Location = new System.Drawing.Point(24, 132);
            this.btnTemperatureConversion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTemperatureConversion.Name = "btnTemperatureConversion";
            this.btnTemperatureConversion.Size = new System.Drawing.Size(213, 44);
            this.btnTemperatureConversion.TabIndex = 0;
            this.btnTemperatureConversion.Text = "Calculate";
            this.btnTemperatureConversion.UseVisualStyleBackColor = false;
            this.btnTemperatureConversion.Click += new System.EventHandler(this.btnTemperatureConversion_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtArcsecondsAngle);
            this.groupBox3.Controls.Add(this.btnStarDistance);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 421);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 207);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Star Distance";
            // 
            // txtArcsecondsAngle
            // 
            this.txtArcsecondsAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArcsecondsAngle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtArcsecondsAngle.Location = new System.Drawing.Point(24, 66);
            this.txtArcsecondsAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArcsecondsAngle.Name = "txtArcsecondsAngle";
            this.txtArcsecondsAngle.Size = new System.Drawing.Size(213, 28);
            this.txtArcsecondsAngle.TabIndex = 1;
            this.txtArcsecondsAngle.Text = "Arcseconds angle:";
            this.txtArcsecondsAngle.Enter += new System.EventHandler(this.txtArcsecondsAngle_Enter);
            this.txtArcsecondsAngle.Leave += new System.EventHandler(this.txtArcsecondsAngle_Leave);
            // 
            // btnStarDistance
            // 
            this.btnStarDistance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarDistance.Location = new System.Drawing.Point(24, 132);
            this.btnStarDistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStarDistance.Name = "btnStarDistance";
            this.btnStarDistance.Size = new System.Drawing.Size(213, 44);
            this.btnStarDistance.TabIndex = 0;
            this.btnStarDistance.Text = "Calculate";
            this.btnStarDistance.UseVisualStyleBackColor = false;
            this.btnStarDistance.Click += new System.EventHandler(this.btnStarDistance_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox4.Controls.Add(this.txtMassBase);
            this.groupBox4.Controls.Add(this.txtPow);
            this.groupBox4.Controls.Add(this.btnBlackholeEventHorizon);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1001, 114);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(267, 234);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Event Horizon";
            // 
            // txtMassBase
            // 
            this.txtMassBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMassBase.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMassBase.Location = new System.Drawing.Point(24, 58);
            this.txtMassBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMassBase.Name = "txtMassBase";
            this.txtMassBase.Size = new System.Drawing.Size(213, 28);
            this.txtMassBase.TabIndex = 1;
            this.txtMassBase.Text = "Blackhole Mass Base:";
            this.txtMassBase.Enter += new System.EventHandler(this.txtMassBase_Enter);
            this.txtMassBase.Leave += new System.EventHandler(this.txtMassBase_Leave);
            // 
            // txtPow
            // 
            this.txtPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPow.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPow.Location = new System.Drawing.Point(24, 107);
            this.txtPow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPow.Name = "txtPow";
            this.txtPow.Size = new System.Drawing.Size(213, 28);
            this.txtPow.TabIndex = 0;
            this.txtPow.Text = "Power:  (x * 10)";
            this.txtPow.Enter += new System.EventHandler(this.txtPow_Enter);
            this.txtPow.Leave += new System.EventHandler(this.txtPow_Leave);
            // 
            // btnBlackholeEventHorizon
            // 
            this.btnBlackholeEventHorizon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBlackholeEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlackholeEventHorizon.Location = new System.Drawing.Point(24, 161);
            this.btnBlackholeEventHorizon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBlackholeEventHorizon.Name = "btnBlackholeEventHorizon";
            this.btnBlackholeEventHorizon.Size = new System.Drawing.Size(213, 44);
            this.btnBlackholeEventHorizon.TabIndex = 0;
            this.btnBlackholeEventHorizon.Text = "Calculate";
            this.btnBlackholeEventHorizon.UseVisualStyleBackColor = false;
            this.btnBlackholeEventHorizon.Click += new System.EventHandler(this.btnBlackholeEventHorizon_Click);
            // 
            // lvOutput
            // 
            this.lvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvOutput.HideSelection = false;
            this.lvOutput.Location = new System.Drawing.Point(309, 116);
            this.lvOutput.Margin = new System.Windows.Forms.Padding(4);
            this.lvOutput.Name = "lvOutput";
            this.lvOutput.Size = new System.Drawing.Size(683, 496);
            this.lvOutput.TabIndex = 3;
            this.lvOutput.UseCompatibleStateImageBehavior = false;
            this.lvOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Celestial Body";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Star Velocity";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Star Distance";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kelvin Temp.";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SchwarzschildRadius";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Celestial Body";
            // 
            // cboBody
            // 
            this.cboBody.FormattingEnabled = true;
            this.cboBody.Location = new System.Drawing.Point(667, 64);
            this.cboBody.Margin = new System.Windows.Forms.Padding(4);
            this.cboBody.Name = "cboBody";
            this.cboBody.Size = new System.Drawing.Size(213, 24);
            this.cboBody.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1296, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsMsg
            // 
            this.stsMsg.Name = "stsMsg";
            this.stsMsg.Size = new System.Drawing.Size(42, 20);
            this.stsMsg.Text = "Info: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msLanguage,
            this.msStyle,
            this.msBackground,
            this.msClearListview});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1296, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msLanguage
            // 
            this.msLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.English_UK,
            this.French,
            this.German});
            this.msLanguage.Name = "msLanguage";
            this.msLanguage.Size = new System.Drawing.Size(88, 24);
            this.msLanguage.Text = "Language";
            // 
            // English_UK
            // 
            this.English_UK.Image = ((System.Drawing.Image)(resources.GetObject("English_UK.Image")));
            this.English_UK.Name = "English_UK";
            this.English_UK.Size = new System.Drawing.Size(172, 26);
            this.English_UK.Text = "English (UK)";
            // 
            // French
            // 
            this.French.Image = ((System.Drawing.Image)(resources.GetObject("French.Image")));
            this.French.Name = "French";
            this.French.Size = new System.Drawing.Size(172, 26);
            this.French.Text = "French";
            // 
            // German
            // 
            this.German.Image = ((System.Drawing.Image)(resources.GetObject("German.Image")));
            this.German.Name = "German";
            this.German.Size = new System.Drawing.Size(172, 26);
            this.German.Text = "German";
            // 
            // msStyle
            // 
            this.msStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.light,
            this.dark});
            this.msStyle.Name = "msStyle";
            this.msStyle.Size = new System.Drawing.Size(55, 24);
            this.msStyle.Text = "Style";
            // 
            // light
            // 
            this.light.Image = ((System.Drawing.Image)(resources.GetObject("light.Image")));
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(125, 26);
            this.light.Text = "Light";
            this.light.Click += new System.EventHandler(this.light_Click);
            // 
            // dark
            // 
            this.dark.Image = ((System.Drawing.Image)(resources.GetObject("dark.Image")));
            this.dark.Name = "dark";
            this.dark.Size = new System.Drawing.Size(125, 26);
            this.dark.Text = "Dark";
            this.dark.Click += new System.EventHandler(this.dark_Click);
            // 
            // msBackground
            // 
            this.msBackground.Name = "msBackground";
            this.msBackground.Size = new System.Drawing.Size(150, 24);
            this.msBackground.Text = "Background Colour";
            this.msBackground.Click += new System.EventHandler(this.msBackground_Click);
            // 
            // msClearListview
            // 
            this.msClearListview.Name = "msClearListview";
            this.msClearListview.Size = new System.Drawing.Size(59, 26);
            this.msClearListview.Text = "Reset";
            this.msClearListview.Click += new System.EventHandler(this.msClearListview_Click);
            // 
            // DataProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 683);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cboBody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvOutput);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Processing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtObservedWavelength;
        private System.Windows.Forms.TextBox txtRestWavelength;
        private System.Windows.Forms.Button btnStarVelocity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnTemperatureConversion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtArcsecondsAngle;
        private System.Windows.Forms.Button btnStarDistance;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMassBase;
        private System.Windows.Forms.TextBox txtPow;
        private System.Windows.Forms.Button btnBlackholeEventHorizon;
        private System.Windows.Forms.ListView lvOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBody;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msLanguage;
        private System.Windows.Forms.ToolStripMenuItem msStyle;
        private System.Windows.Forms.ToolStripMenuItem English_UK;
        private System.Windows.Forms.ToolStripMenuItem French;
        private System.Windows.Forms.ToolStripMenuItem German;
        private System.Windows.Forms.ToolStripMenuItem msBackground;
        private System.Windows.Forms.ToolStripMenuItem light;
        private System.Windows.Forms.ToolStripMenuItem dark;
        private System.Windows.Forms.ToolStripMenuItem msClearListview;
    }
}

