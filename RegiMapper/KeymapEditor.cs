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
    public partial class KeymapEditor : Form
    {
        private List<KeymapKey> allKeys = new List<KeymapKey>();
        private List<KeymapKey> selectedKeys = new List<KeymapKey>();

        public KeymapEditor()
        {
            InitializeComponent();
        }

        private void menuExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditorForm_OnLoad(object sender, EventArgs e)
        {
            RenderKeys();
        }

        private void RenderKeys()
        {
            for (int row = 0; row < keysPanel.RowCount; row++)
                for (int col = 0; col < keysPanel.ColumnCount; col++)
                {
                    KeymapKey key = new KeymapKey();
                    allKeys.Add(key);

                    key.KeySelected += new EventHandler(keySelected);
                    key.KeyDeselected += new EventHandler(keyDeselected);

                    keysPanel.Controls.Add(key, col, row);
                }
        }

        private void keySelected(object sender, EventArgs e)
        {
            selectedKeys.Add((KeymapKey)sender);
            editedCountLabel.Text = selectedKeys.Count.ToString();
        }

        private void keyDeselected(object sender, EventArgs e)
        {
            selectedKeys.Remove((KeymapKey)sender);
            editedCountLabel.Text = selectedKeys.Count.ToString();
        }

        protected void OpenKeyEditor(KeymapKey key)
        {
            new KeyEditForm(key).ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            foreach(KeymapKey key in selectedKeys)
            {
                OpenKeyEditor(key);
            }
        }

        private void KeymapEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainAppInstance.AppWelcomeForm.Show();
        }
    }
}
