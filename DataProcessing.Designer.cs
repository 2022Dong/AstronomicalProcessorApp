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
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservedWavelength = new System.Windows.Forms.TextBox();
            this.txtRestWavelength = new System.Windows.Forms.TextBox();
            this.btnStarVelocity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Star Velocity";
            // 
            // txtObservedWavelength
            // 
            this.txtObservedWavelength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservedWavelength.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtObservedWavelength.Location = new System.Drawing.Point(37, 96);
            this.txtObservedWavelength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObservedWavelength.Name = "txtObservedWavelength";
            this.txtObservedWavelength.Size = new System.Drawing.Size(161, 24);
            this.txtObservedWavelength.TabIndex = 1;
            this.txtObservedWavelength.Text = "Observed Wavelength:";
            this.txtObservedWavelength.Enter += new System.EventHandler(this.txtObservedWavelength_Enter);
            this.txtObservedWavelength.Leave += new System.EventHandler(this.txtObservedWavelength_Leave);
            // 
            // txtRestWavelength
            // 
            this.txtRestWavelength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestWavelength.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRestWavelength.Location = new System.Drawing.Point(37, 136);
            this.txtRestWavelength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRestWavelength.Name = "txtRestWavelength";
            this.txtRestWavelength.Size = new System.Drawing.Size(161, 24);
            this.txtRestWavelength.TabIndex = 0;
            this.txtRestWavelength.Text = "Rest Wavelength:";
            this.txtRestWavelength.Enter += new System.EventHandler(this.txtRestWavelength_Enter);
            this.txtRestWavelength.Leave += new System.EventHandler(this.txtRestWavelength_Leave);
            // 
            // btnStarVelocity
            // 
            this.btnStarVelocity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStarVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarVelocity.Location = new System.Drawing.Point(37, 180);
            this.btnStarVelocity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStarVelocity.Name = "btnStarVelocity";
            this.btnStarVelocity.Size = new System.Drawing.Size(160, 36);
            this.btnStarVelocity.TabIndex = 0;
            this.btnStarVelocity.Text = "Calculate";
            this.btnStarVelocity.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Star Velocity";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(37, 344);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 24);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Observed Wavelength:";
            this.textBox1.Enter += new System.EventHandler(this.txtObservedWavelength_Enter);
            this.textBox1.Leave += new System.EventHandler(this.txtObservedWavelength_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(37, 384);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 24);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Rest Wavelength:";
            this.textBox2.Enter += new System.EventHandler(this.txtRestWavelength_Enter);
            this.textBox2.Leave += new System.EventHandler(this.txtRestWavelength_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DataProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStarVelocity);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtRestWavelength);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtObservedWavelength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DataProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservedWavelength;
        private System.Windows.Forms.TextBox txtRestWavelength;
        private System.Windows.Forms.Button btnStarVelocity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

