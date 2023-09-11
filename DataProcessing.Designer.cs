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
            this.components = new System.ComponentModel.Container();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            resources.ApplyResources(this.txtObservedWavelength, "txtObservedWavelength");
            this.txtObservedWavelength.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtObservedWavelength.Name = "txtObservedWavelength";
            this.toolTip1.SetToolTip(this.txtObservedWavelength, resources.GetString("txtObservedWavelength.ToolTip"));
            this.txtObservedWavelength.Enter += new System.EventHandler(this.txtObservedWavelength_Enter);
            this.txtObservedWavelength.Leave += new System.EventHandler(this.txtObservedWavelength_Leave);
            // 
            // txtRestWavelength
            // 
            resources.ApplyResources(this.txtRestWavelength, "txtRestWavelength");
            this.txtRestWavelength.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRestWavelength.Name = "txtRestWavelength";
            this.toolTip1.SetToolTip(this.txtRestWavelength, resources.GetString("txtRestWavelength.ToolTip"));
            this.txtRestWavelength.Enter += new System.EventHandler(this.txtRestWavelength_Enter);
            this.txtRestWavelength.Leave += new System.EventHandler(this.txtRestWavelength_Leave);
            // 
            // btnStarVelocity
            // 
            resources.ApplyResources(this.btnStarVelocity, "btnStarVelocity");
            this.btnStarVelocity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStarVelocity.Name = "btnStarVelocity";
            this.toolTip1.SetToolTip(this.btnStarVelocity, resources.GetString("btnStarVelocity.ToolTip"));
            this.btnStarVelocity.UseVisualStyleBackColor = false;
            this.btnStarVelocity.Click += new System.EventHandler(this.btnStarVelocity_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.txtObservedWavelength);
            this.groupBox1.Controls.Add(this.txtRestWavelength);
            this.groupBox1.Controls.Add(this.btnStarVelocity);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.txtCelsius);
            this.groupBox2.Controls.Add(this.btnTemperatureConversion);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // txtCelsius
            // 
            resources.ApplyResources(this.txtCelsius, "txtCelsius");
            this.txtCelsius.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCelsius.Name = "txtCelsius";
            this.toolTip1.SetToolTip(this.txtCelsius, resources.GetString("txtCelsius.ToolTip"));
            this.txtCelsius.Enter += new System.EventHandler(this.txtCelsius_Enter);
            this.txtCelsius.Leave += new System.EventHandler(this.txtCelsius_Leave);
            // 
            // btnTemperatureConversion
            // 
            resources.ApplyResources(this.btnTemperatureConversion, "btnTemperatureConversion");
            this.btnTemperatureConversion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemperatureConversion.Name = "btnTemperatureConversion";
            this.toolTip1.SetToolTip(this.btnTemperatureConversion, resources.GetString("btnTemperatureConversion.ToolTip"));
            this.btnTemperatureConversion.UseVisualStyleBackColor = false;
            this.btnTemperatureConversion.Click += new System.EventHandler(this.btnTemperatureConversion_Click);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.txtArcsecondsAngle);
            this.groupBox3.Controls.Add(this.btnStarDistance);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // txtArcsecondsAngle
            // 
            resources.ApplyResources(this.txtArcsecondsAngle, "txtArcsecondsAngle");
            this.txtArcsecondsAngle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtArcsecondsAngle.Name = "txtArcsecondsAngle";
            this.toolTip1.SetToolTip(this.txtArcsecondsAngle, resources.GetString("txtArcsecondsAngle.ToolTip"));
            this.txtArcsecondsAngle.Enter += new System.EventHandler(this.txtArcsecondsAngle_Enter);
            this.txtArcsecondsAngle.Leave += new System.EventHandler(this.txtArcsecondsAngle_Leave);
            // 
            // btnStarDistance
            // 
            resources.ApplyResources(this.btnStarDistance, "btnStarDistance");
            this.btnStarDistance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStarDistance.Name = "btnStarDistance";
            this.toolTip1.SetToolTip(this.btnStarDistance, resources.GetString("btnStarDistance.ToolTip"));
            this.btnStarDistance.UseVisualStyleBackColor = false;
            this.btnStarDistance.Click += new System.EventHandler(this.btnStarDistance_Click);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.txtMassBase);
            this.groupBox4.Controls.Add(this.txtPow);
            this.groupBox4.Controls.Add(this.btnBlackholeEventHorizon);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // txtMassBase
            // 
            resources.ApplyResources(this.txtMassBase, "txtMassBase");
            this.txtMassBase.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMassBase.Name = "txtMassBase";
            this.toolTip1.SetToolTip(this.txtMassBase, resources.GetString("txtMassBase.ToolTip"));
            this.txtMassBase.Enter += new System.EventHandler(this.txtMassBase_Enter);
            this.txtMassBase.Leave += new System.EventHandler(this.txtMassBase_Leave);
            // 
            // txtPow
            // 
            resources.ApplyResources(this.txtPow, "txtPow");
            this.txtPow.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPow.Name = "txtPow";
            this.toolTip1.SetToolTip(this.txtPow, resources.GetString("txtPow.ToolTip"));
            this.txtPow.Enter += new System.EventHandler(this.txtPow_Enter);
            this.txtPow.Leave += new System.EventHandler(this.txtPow_Leave);
            // 
            // btnBlackholeEventHorizon
            // 
            resources.ApplyResources(this.btnBlackholeEventHorizon, "btnBlackholeEventHorizon");
            this.btnBlackholeEventHorizon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBlackholeEventHorizon.Name = "btnBlackholeEventHorizon";
            this.toolTip1.SetToolTip(this.btnBlackholeEventHorizon, resources.GetString("btnBlackholeEventHorizon.ToolTip"));
            this.btnBlackholeEventHorizon.UseVisualStyleBackColor = false;
            this.btnBlackholeEventHorizon.Click += new System.EventHandler(this.btnBlackholeEventHorizon_Click);
            // 
            // lvOutput
            // 
            resources.ApplyResources(this.lvOutput, "lvOutput");
            this.lvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvOutput.HideSelection = false;
            this.lvOutput.Name = "lvOutput";
            this.toolTip1.SetToolTip(this.lvOutput, resources.GetString("lvOutput.ToolTip"));
            this.lvOutput.UseCompatibleStateImageBehavior = false;
            this.lvOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // cboBody
            // 
            resources.ApplyResources(this.cboBody, "cboBody");
            this.cboBody.FormattingEnabled = true;
            this.cboBody.Name = "cboBody";
            this.toolTip1.SetToolTip(this.cboBody, resources.GetString("cboBody.ToolTip"));
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsMsg});
            this.statusStrip1.Name = "statusStrip1";
            this.toolTip1.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // stsMsg
            // 
            resources.ApplyResources(this.stsMsg, "stsMsg");
            this.stsMsg.Name = "stsMsg";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msLanguage,
            this.msStyle,
            this.msBackground,
            this.msClearListview});
            this.menuStrip1.Name = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // msLanguage
            // 
            resources.ApplyResources(this.msLanguage, "msLanguage");
            this.msLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.English_UK,
            this.French,
            this.German});
            this.msLanguage.Name = "msLanguage";
            // 
            // English_UK
            // 
            resources.ApplyResources(this.English_UK, "English_UK");
            this.English_UK.Name = "English_UK";
            this.English_UK.Click += new System.EventHandler(this.English_UK_Click);
            // 
            // French
            // 
            resources.ApplyResources(this.French, "French");
            this.French.Name = "French";
            this.French.Click += new System.EventHandler(this.French_Click);
            // 
            // German
            // 
            resources.ApplyResources(this.German, "German");
            this.German.Name = "German";
            this.German.Click += new System.EventHandler(this.German_Click);
            // 
            // msStyle
            // 
            resources.ApplyResources(this.msStyle, "msStyle");
            this.msStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.light,
            this.dark});
            this.msStyle.Name = "msStyle";
            // 
            // light
            // 
            resources.ApplyResources(this.light, "light");
            this.light.Name = "light";
            this.light.Click += new System.EventHandler(this.light_Click);
            // 
            // dark
            // 
            resources.ApplyResources(this.dark, "dark");
            this.dark.Name = "dark";
            this.dark.Click += new System.EventHandler(this.dark_Click);
            // 
            // msBackground
            // 
            resources.ApplyResources(this.msBackground, "msBackground");
            this.msBackground.Name = "msBackground";
            this.msBackground.Click += new System.EventHandler(this.msBackground_Click);
            // 
            // msClearListview
            // 
            resources.ApplyResources(this.msClearListview, "msClearListview");
            this.msClearListview.Name = "msClearListview";
            this.msClearListview.Click += new System.EventHandler(this.msClearListview_Click);
            // 
            // DataProcessing
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "DataProcessing";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

