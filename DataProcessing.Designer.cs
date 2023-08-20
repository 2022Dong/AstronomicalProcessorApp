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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Star Velocity";
            // 
            // txtObservedWavelength
            // 
            this.txtObservedWavelength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservedWavelength.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtObservedWavelength.Location = new System.Drawing.Point(49, 118);
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
            this.txtRestWavelength.Location = new System.Drawing.Point(49, 167);
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
            this.btnStarVelocity.Location = new System.Drawing.Point(49, 221);
            this.btnStarVelocity.Name = "btnStarVelocity";
            this.btnStarVelocity.Size = new System.Drawing.Size(213, 44);
            this.btnStarVelocity.TabIndex = 0;
            this.btnStarVelocity.Text = "Calculate";
            this.btnStarVelocity.UseVisualStyleBackColor = false;
            // 
            // DataProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 644);
            this.Controls.Add(this.btnStarVelocity);
            this.Controls.Add(this.txtRestWavelength);
            this.Controls.Add(this.txtObservedWavelength);
            this.Controls.Add(this.label1);
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
    }
}

