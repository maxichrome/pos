namespace RegiMapper
{
    partial class KeymapKey
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baseKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baseKey
            // 
            this.baseKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseKey.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.baseKey.FlatAppearance.BorderSize = 3;
            this.baseKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseKey.Location = new System.Drawing.Point(0, 0);
            this.baseKey.Margin = new System.Windows.Forms.Padding(0);
            this.baseKey.Name = "baseKey";
            this.baseKey.Size = new System.Drawing.Size(75, 75);
            this.baseKey.TabIndex = 0;
            this.baseKey.Text = "IceCup Small-Large";
            this.baseKey.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.baseKey.UseVisualStyleBackColor = false;
            this.baseKey.Click += new System.EventHandler(this.baseKey_Click);
            // 
            // KeymapKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseKey);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "KeymapKey";
            this.Size = new System.Drawing.Size(75, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button baseKey;
    }
}
