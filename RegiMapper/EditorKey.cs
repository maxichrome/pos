using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegiMapper
{
    public partial class KeymapKey : UserControl 
    {
        private bool keyEnable = false;
        private string keyText = "";
        private bool selected = false;
        private string itemPlu = "";

        public event EventHandler KeyPressed;
        public event EventHandler KeySelected;
        public event EventHandler KeyDeselected;

        public KeymapKey()
        {
            InitializeComponent();
            RenderKey();
        }

        public bool KeyEnabled {
            get { return keyEnable; }
            set { keyEnable = value; RenderKey(); }
        }

        public string KeyText {
            get { return keyText; }
            set { keyText = value; RenderKey(); }
        }

        public bool Selected {
            get { return selected; }
            set {
                selected = value;

                if (value == true)
                    KeySelected?.Invoke(this, new EventArgs());
                else
                    KeyDeselected?.Invoke(this, new EventArgs());

                RenderKey();
            }
        }
        
        public string KeyPLU {
            get { return itemPlu; }
            set { itemPlu = value; }
        }

        private void RenderKey()
        {
            // selected key
            if(Selected) { baseKey.FlatAppearance.BorderColor = Color.Lime; }
            else { baseKey.FlatAppearance.BorderColor = SystemColors.Control; }

            // disabled key
            if (!keyEnable)
            {
                BackColor = Color.Yellow;
                ForeColor = Color.Red;
                baseKey.Text = "Key Enable False";
            }
            else
            {
                baseKey.Text = keyText;
            }
        }

        private void baseKey_Click(object sender, EventArgs e)
        {
            Selected = !Selected;
            KeyPressed?.Invoke(sender, e);
        }
    }
}
