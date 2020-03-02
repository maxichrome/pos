using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegiMapper
{
    public partial class KeyEditForm : Form
    {
        private KeymapKey key;

        public KeyEditForm(KeymapKey key)
        {
            this.key = key;

            InitializeComponent();
        }

        private void KeyEditForm_Load(object sender, EventArgs e)
        {
            buttonTextBox.BackColor = key.BackColor;
            buttonTextBox.ForeColor = key.ForeColor;
            buttonTextBox.Text = key.KeyText;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            key.KeyText = buttonTextBox.Text;
            MessageBox.Show("KeyText = " + key.KeyText);

            Close();
        }
    }
}
