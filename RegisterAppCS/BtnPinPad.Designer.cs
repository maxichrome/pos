namespace RegisterAppCS
{
    partial class BtnPinPad
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button baseButton;
        private System.Windows.Forms.Label statusLabel;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baseButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baseButton
            // 
            this.baseButton.BackColor = System.Drawing.Color.Black;
            this.baseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseButton.ForeColor = System.Drawing.Color.White;
            this.baseButton.Image = global::RegisterAppCS.Properties.Resources.SendLeft;
            this.baseButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.baseButton.Location = new System.Drawing.Point(0, 0);
            this.baseButton.Margin = new System.Windows.Forms.Padding(0);
            this.baseButton.Name = "baseButton";
            this.baseButton.Padding = new System.Windows.Forms.Padding(3);
            this.baseButton.Size = new System.Drawing.Size(369, 89);
            this.baseButton.TabIndex = 0;
            this.baseButton.Text = "PIN Pad";
            this.baseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.baseButton.UseVisualStyleBackColor = false;
            this.baseButton.BackColorChanged += new System.EventHandler(this.BaseBackgroundChanged);
            // 
            // label1
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = this.baseButton.BackColor;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.statusLabel.ForeColor = System.Drawing.Color.Yellow;
            this.statusLabel.Location = new System.Drawing.Point(6, 65);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "label1";
            this.statusLabel.Size = new System.Drawing.Size(45, 16);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status";
            // 
            // BtnPinPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.baseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BtnPinPad";
            this.Size = new System.Drawing.Size(369, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
