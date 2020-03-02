using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterAppCS {
    public partial class overlayForm : Form {
        public overlayForm() {
            InitializeComponent();
        }

        private void overlayForm_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Overlay_DebugClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                Application.Exit();
            }
        }

        private void overlayForm_Load(object sender, EventArgs e) {

        }
    }
}
