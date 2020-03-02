using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterAppCS {
    public partial class BtnPinPad : UserControl {
        private PinPadLayout layout;

        public PinPadLayout ButtonLayout
        {
            get { return layout; }
            set {
                layout = value;
                ApplyLayout();
            }
        }

        public BtnPinPad()
        {
            InitializeComponent();
            ApplyLayout();
        }

        private void ApplyLayout()
        {
            switch (layout)
            {
                case PinPadLayout.LeftPad:
                    baseButton.TextAlign = ContentAlignment.TopRight;
                    baseButton.ImageAlign = ContentAlignment.TopLeft;
                    baseButton.Image = Properties.Resources.SendLeft;
                    // TODO: more logic
                    break;
                case PinPadLayout.RightPad:
                    baseButton.TextAlign = ContentAlignment.TopLeft;
                    baseButton.ImageAlign = ContentAlignment.TopRight;
                    baseButton.Image = Properties.Resources.SendRight;
                    // TODO: more logic
                    break;
                default:
                    layout = PinPadLayout.LeftPad;
                    break;
            }

            return;
        }

        private void BaseBackgroundChanged(object sender, EventArgs e)
        {
            statusLabel.BackColor = baseButton.BackColor;
        }
    }

    public enum PinPadLayout {
        LeftPad,
        RightPad
    }
}
