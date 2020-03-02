using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RegisterAppCS;

namespace RegisterHost {
    public partial class RegiHostForm : Form {
        protected overlayForm overlay;

        private FormWindowState lastWinState;

        private Timer timeDateTimer;
        private TableLayoutPanel layoutMaster;
        private TableLayoutPanel layoutGasPump;
        private TableLayoutPanel layoutControlArea;
        private ListBox boxSummaryList;
        private ListBox boxItemsList;
        private Button btnTotal;
        private Button button25;
        private Button button24;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label posIdLabel;
        private Button button34;
        private Button button32;
        private Button button31;
        private Button button30;
        private Button button29;
        private Button button28;
        private Button button27;
        private Button button26;
        private Button button23;
        private Button button21;
        private Button button17;
        private Button button16;
        private Button button15;
        private Label posVerLabel;
        private Label timeDateLabel;
        private Button button82;
        private Button button81;
        private Button button80;
        private Button button79;
        private Button button78;
        private Button button77;
        private Button button76;
        private Button button75;
        private Button button74;
        private Button button73;
        private Button button72;
        private Button button71;
        private Button button70;
        private Button button69;
        private Button button68;
        private Button button67;
        private Button button66;
        private Button button65;
        private Button button64;
        private Button button63;
        private Button button62;
        private Button button61;
        private Button button60;
        private Button button59;
        private Button button58;
        private Button button57;
        private Button button51;
        private Button button50;
        private Button button49;
        private Button button48;
        private Button button47;
        private Button button46;
        private Button button45;
        private Button button44;
        private Button button43;
        private Button button42;
        private Button button41;
        private Button button40;
        private Button button38;
        private Button button37;
        private Button button36;
        private Button button35;
        private Button button52;
        private Button button53;
        private Button button54;
        private Button button55;
        private Button button56;
        private Label PumpLabel1;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label PumpLabel3;
        private Label PumpLabel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button90;
        private Button button89;
        private Button button88;
        private Button button87;
        private Button button86;
        private Button button85;
        private Button button84;
        private Button button83;
        private Button button39;
        private IContainer components = null;

        public RegiHostForm() {
            InitializeComponent();

            timeDateTimer.Interval = 1000;
            timeDateTimer.Start();
            timeDateTimer.Tick += new EventHandler(TimeTick);

            TimeTick();
        }

        private void TimeTick()
        {
            DateTime currentTime = DateTime.Now;

            timeDateLabel.Text = currentTime.ToString();
        }

        private void TimeTick(object sender, EventArgs e) { TimeTick(); }

        private void TestBtnClick(object sender, EventArgs e)
        {
            ShowOverlay();
        }

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void DeselectList(object sender, EventArgs e) {
            ((ListControl) sender).SelectedIndex = -1;
        }

        private void ShowOverlay() {
            if (overlay != null)
                return;

            overlay = new overlayForm();
            overlay.FormClosed += new FormClosedEventHandler(this.resetOverlay);
            overlay.Show();
        }

        public void resetOverlay(object sender, FormClosedEventArgs e) {
            overlay.Dispose();
            overlay = null;
        }

        protected override void OnClientSizeChanged(EventArgs e) {
            if(this.WindowState != lastWinState) {
                lastWinState = this.WindowState;
                OnWindowStateChanged(e);
            }

            base.OnClientSizeChanged(e);
        }

        protected void OnWindowStateChanged(EventArgs e) {
            MessageBox.Show("window state changed!");
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeDateTimer = new System.Windows.Forms.Timer(this.components);
            this.layoutMaster = new System.Windows.Forms.TableLayoutPanel();
            this.layoutGasPump = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PumpLabel3 = new System.Windows.Forms.Label();
            this.PumpLabel2 = new System.Windows.Forms.Label();
            this.button82 = new System.Windows.Forms.Button();
            this.button81 = new System.Windows.Forms.Button();
            this.button80 = new System.Windows.Forms.Button();
            this.button79 = new System.Windows.Forms.Button();
            this.button78 = new System.Windows.Forms.Button();
            this.button77 = new System.Windows.Forms.Button();
            this.button76 = new System.Windows.Forms.Button();
            this.button75 = new System.Windows.Forms.Button();
            this.button74 = new System.Windows.Forms.Button();
            this.button73 = new System.Windows.Forms.Button();
            this.button72 = new System.Windows.Forms.Button();
            this.button71 = new System.Windows.Forms.Button();
            this.button70 = new System.Windows.Forms.Button();
            this.button69 = new System.Windows.Forms.Button();
            this.button68 = new System.Windows.Forms.Button();
            this.button67 = new System.Windows.Forms.Button();
            this.button66 = new System.Windows.Forms.Button();
            this.button65 = new System.Windows.Forms.Button();
            this.button64 = new System.Windows.Forms.Button();
            this.button63 = new System.Windows.Forms.Button();
            this.button62 = new System.Windows.Forms.Button();
            this.button61 = new System.Windows.Forms.Button();
            this.button60 = new System.Windows.Forms.Button();
            this.button59 = new System.Windows.Forms.Button();
            this.button58 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.PumpLabel1 = new System.Windows.Forms.Label();
            this.layoutControlArea = new System.Windows.Forms.TableLayoutPanel();
            this.posIdLabel = new System.Windows.Forms.Label();
            this.button34 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.boxSummaryList = new System.Windows.Forms.ListBox();
            this.boxItemsList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.posVerLabel = new System.Windows.Forms.Label();
            this.timeDateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button90 = new System.Windows.Forms.Button();
            this.button89 = new System.Windows.Forms.Button();
            this.button88 = new System.Windows.Forms.Button();
            this.button87 = new System.Windows.Forms.Button();
            this.button86 = new System.Windows.Forms.Button();
            this.button85 = new System.Windows.Forms.Button();
            this.button84 = new System.Windows.Forms.Button();
            this.button83 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutMaster.SuspendLayout();
            this.layoutGasPump.SuspendLayout();
            this.layoutControlArea.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMaster
            // 
            this.layoutMaster.ColumnCount = 2;
            this.layoutMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.layoutMaster.Controls.Add(this.layoutGasPump, 0, 0);
            this.layoutMaster.Controls.Add(this.layoutControlArea, 1, 1);
            this.layoutMaster.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.layoutMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMaster.Location = new System.Drawing.Point(0, 0);
            this.layoutMaster.Margin = new System.Windows.Forms.Padding(0);
            this.layoutMaster.Name = "layoutMaster";
            this.layoutMaster.RowCount = 2;
            this.layoutMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layoutMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMaster.Size = new System.Drawing.Size(1152, 768);
            this.layoutMaster.TabIndex = 0;
            // 
            // layoutGasPump
            // 
            this.layoutGasPump.ColumnCount = 16;
            this.layoutMaster.SetColumnSpan(this.layoutGasPump, 2);
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.layoutGasPump.Controls.Add(this.label19, 15, 0);
            this.layoutGasPump.Controls.Add(this.label18, 14, 0);
            this.layoutGasPump.Controls.Add(this.label17, 13, 0);
            this.layoutGasPump.Controls.Add(this.label16, 12, 0);
            this.layoutGasPump.Controls.Add(this.label15, 11, 0);
            this.layoutGasPump.Controls.Add(this.label14, 10, 0);
            this.layoutGasPump.Controls.Add(this.label13, 9, 0);
            this.layoutGasPump.Controls.Add(this.label12, 8, 0);
            this.layoutGasPump.Controls.Add(this.label11, 7, 0);
            this.layoutGasPump.Controls.Add(this.label10, 6, 0);
            this.layoutGasPump.Controls.Add(this.label9, 5, 0);
            this.layoutGasPump.Controls.Add(this.label8, 4, 0);
            this.layoutGasPump.Controls.Add(this.label7, 3, 0);
            this.layoutGasPump.Controls.Add(this.PumpLabel3, 2, 0);
            this.layoutGasPump.Controls.Add(this.PumpLabel2, 1, 0);
            this.layoutGasPump.Controls.Add(this.button82, 15, 2);
            this.layoutGasPump.Controls.Add(this.button81, 14, 2);
            this.layoutGasPump.Controls.Add(this.button80, 13, 2);
            this.layoutGasPump.Controls.Add(this.button79, 12, 2);
            this.layoutGasPump.Controls.Add(this.button78, 11, 2);
            this.layoutGasPump.Controls.Add(this.button77, 10, 2);
            this.layoutGasPump.Controls.Add(this.button76, 9, 2);
            this.layoutGasPump.Controls.Add(this.button75, 8, 2);
            this.layoutGasPump.Controls.Add(this.button74, 7, 2);
            this.layoutGasPump.Controls.Add(this.button73, 6, 2);
            this.layoutGasPump.Controls.Add(this.button72, 5, 2);
            this.layoutGasPump.Controls.Add(this.button71, 4, 2);
            this.layoutGasPump.Controls.Add(this.button70, 3, 2);
            this.layoutGasPump.Controls.Add(this.button69, 2, 2);
            this.layoutGasPump.Controls.Add(this.button68, 1, 2);
            this.layoutGasPump.Controls.Add(this.button67, 0, 2);
            this.layoutGasPump.Controls.Add(this.button66, 15, 1);
            this.layoutGasPump.Controls.Add(this.button65, 14, 1);
            this.layoutGasPump.Controls.Add(this.button64, 13, 1);
            this.layoutGasPump.Controls.Add(this.button63, 12, 1);
            this.layoutGasPump.Controls.Add(this.button62, 11, 1);
            this.layoutGasPump.Controls.Add(this.button61, 10, 1);
            this.layoutGasPump.Controls.Add(this.button60, 9, 1);
            this.layoutGasPump.Controls.Add(this.button59, 8, 1);
            this.layoutGasPump.Controls.Add(this.button58, 7, 1);
            this.layoutGasPump.Controls.Add(this.button57, 6, 1);
            this.layoutGasPump.Controls.Add(this.button51, 0, 3);
            this.layoutGasPump.Controls.Add(this.button50, 0, 3);
            this.layoutGasPump.Controls.Add(this.button49, 0, 3);
            this.layoutGasPump.Controls.Add(this.button48, 0, 3);
            this.layoutGasPump.Controls.Add(this.button47, 0, 3);
            this.layoutGasPump.Controls.Add(this.button46, 0, 3);
            this.layoutGasPump.Controls.Add(this.button45, 0, 3);
            this.layoutGasPump.Controls.Add(this.button44, 0, 3);
            this.layoutGasPump.Controls.Add(this.button43, 0, 3);
            this.layoutGasPump.Controls.Add(this.button42, 0, 3);
            this.layoutGasPump.Controls.Add(this.button41, 0, 3);
            this.layoutGasPump.Controls.Add(this.button40, 0, 3);
            this.layoutGasPump.Controls.Add(this.button39, 0, 3);
            this.layoutGasPump.Controls.Add(this.button38, 0, 3);
            this.layoutGasPump.Controls.Add(this.button37, 0, 3);
            this.layoutGasPump.Controls.Add(this.button36, 0, 3);
            this.layoutGasPump.Controls.Add(this.button35, 0, 1);
            this.layoutGasPump.Controls.Add(this.button52, 1, 1);
            this.layoutGasPump.Controls.Add(this.button53, 2, 1);
            this.layoutGasPump.Controls.Add(this.button54, 3, 1);
            this.layoutGasPump.Controls.Add(this.button55, 4, 1);
            this.layoutGasPump.Controls.Add(this.button56, 5, 1);
            this.layoutGasPump.Controls.Add(this.PumpLabel1, 0, 0);
            this.layoutGasPump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutGasPump.ForeColor = System.Drawing.Color.Red;
            this.layoutGasPump.Location = new System.Drawing.Point(0, 0);
            this.layoutGasPump.Margin = new System.Windows.Forms.Padding(0);
            this.layoutGasPump.Name = "layoutGasPump";
            this.layoutGasPump.RowCount = 4;
            this.layoutGasPump.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.layoutGasPump.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutGasPump.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutGasPump.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutGasPump.Size = new System.Drawing.Size(1152, 150);
            this.layoutGasPump.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(1080, 0);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 22);
            this.label19.TabIndex = 97;
            this.label19.Text = "16";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1008, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 22);
            this.label18.TabIndex = 96;
            this.label18.Text = "15";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(936, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 22);
            this.label17.TabIndex = 95;
            this.label17.Text = "14";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(864, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 22);
            this.label16.TabIndex = 94;
            this.label16.Text = "13";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(792, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 22);
            this.label15.TabIndex = 93;
            this.label15.Text = "12";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(720, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 22);
            this.label14.TabIndex = 92;
            this.label14.Text = "11";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(648, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 22);
            this.label13.TabIndex = 91;
            this.label13.Text = "10";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(576, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 22);
            this.label12.TabIndex = 90;
            this.label12.Text = "9";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(504, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 89;
            this.label11.Text = "8";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(432, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 22);
            this.label10.TabIndex = 88;
            this.label10.Text = "7";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(360, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 87;
            this.label9.Text = "6";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(288, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 86;
            this.label8.Text = "5";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(216, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 85;
            this.label7.Text = "4";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PumpLabel3
            // 
            this.PumpLabel3.AutoSize = true;
            this.PumpLabel3.BackColor = System.Drawing.Color.Black;
            this.PumpLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PumpLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PumpLabel3.ForeColor = System.Drawing.Color.White;
            this.PumpLabel3.Location = new System.Drawing.Point(144, 0);
            this.PumpLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.PumpLabel3.Name = "PumpLabel3";
            this.PumpLabel3.Size = new System.Drawing.Size(72, 22);
            this.PumpLabel3.TabIndex = 84;
            this.PumpLabel3.Text = "3";
            this.PumpLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PumpLabel2
            // 
            this.PumpLabel2.AutoSize = true;
            this.PumpLabel2.BackColor = System.Drawing.Color.Black;
            this.PumpLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PumpLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PumpLabel2.ForeColor = System.Drawing.Color.White;
            this.PumpLabel2.Location = new System.Drawing.Point(72, 0);
            this.PumpLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.PumpLabel2.Name = "PumpLabel2";
            this.PumpLabel2.Size = new System.Drawing.Size(72, 22);
            this.PumpLabel2.TabIndex = 83;
            this.PumpLabel2.Text = "2";
            this.PumpLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button82
            // 
            this.button82.BackColor = System.Drawing.SystemColors.Info;
            this.button82.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button82.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button82.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button82.ForeColor = System.Drawing.Color.Red;
            this.button82.Location = new System.Drawing.Point(1080, 64);
            this.button82.Margin = new System.Windows.Forms.Padding(0);
            this.button82.Name = "button82";
            this.button82.Size = new System.Drawing.Size(72, 42);
            this.button82.TabIndex = 81;
            this.button82.UseVisualStyleBackColor = false;
            // 
            // button81
            // 
            this.button81.BackColor = System.Drawing.SystemColors.Info;
            this.button81.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button81.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button81.ForeColor = System.Drawing.Color.Red;
            this.button81.Location = new System.Drawing.Point(1008, 64);
            this.button81.Margin = new System.Windows.Forms.Padding(0);
            this.button81.Name = "button81";
            this.button81.Size = new System.Drawing.Size(72, 42);
            this.button81.TabIndex = 80;
            this.button81.UseVisualStyleBackColor = false;
            // 
            // button80
            // 
            this.button80.BackColor = System.Drawing.SystemColors.Info;
            this.button80.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button80.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button80.ForeColor = System.Drawing.Color.Red;
            this.button80.Location = new System.Drawing.Point(936, 64);
            this.button80.Margin = new System.Windows.Forms.Padding(0);
            this.button80.Name = "button80";
            this.button80.Size = new System.Drawing.Size(72, 42);
            this.button80.TabIndex = 79;
            this.button80.UseVisualStyleBackColor = false;
            // 
            // button79
            // 
            this.button79.BackColor = System.Drawing.SystemColors.Info;
            this.button79.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button79.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button79.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button79.ForeColor = System.Drawing.Color.Red;
            this.button79.Location = new System.Drawing.Point(864, 64);
            this.button79.Margin = new System.Windows.Forms.Padding(0);
            this.button79.Name = "button79";
            this.button79.Size = new System.Drawing.Size(72, 42);
            this.button79.TabIndex = 78;
            this.button79.UseVisualStyleBackColor = false;
            // 
            // button78
            // 
            this.button78.BackColor = System.Drawing.SystemColors.Info;
            this.button78.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button78.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button78.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button78.ForeColor = System.Drawing.Color.Red;
            this.button78.Location = new System.Drawing.Point(792, 64);
            this.button78.Margin = new System.Windows.Forms.Padding(0);
            this.button78.Name = "button78";
            this.button78.Size = new System.Drawing.Size(72, 42);
            this.button78.TabIndex = 77;
            this.button78.UseVisualStyleBackColor = false;
            // 
            // button77
            // 
            this.button77.BackColor = System.Drawing.SystemColors.Info;
            this.button77.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button77.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button77.ForeColor = System.Drawing.Color.Red;
            this.button77.Location = new System.Drawing.Point(720, 64);
            this.button77.Margin = new System.Windows.Forms.Padding(0);
            this.button77.Name = "button77";
            this.button77.Size = new System.Drawing.Size(72, 42);
            this.button77.TabIndex = 76;
            this.button77.UseVisualStyleBackColor = false;
            // 
            // button76
            // 
            this.button76.BackColor = System.Drawing.SystemColors.Info;
            this.button76.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button76.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button76.ForeColor = System.Drawing.Color.Red;
            this.button76.Location = new System.Drawing.Point(648, 64);
            this.button76.Margin = new System.Windows.Forms.Padding(0);
            this.button76.Name = "button76";
            this.button76.Size = new System.Drawing.Size(72, 42);
            this.button76.TabIndex = 75;
            this.button76.UseVisualStyleBackColor = false;
            // 
            // button75
            // 
            this.button75.BackColor = System.Drawing.SystemColors.Info;
            this.button75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button75.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button75.ForeColor = System.Drawing.Color.Red;
            this.button75.Location = new System.Drawing.Point(576, 64);
            this.button75.Margin = new System.Windows.Forms.Padding(0);
            this.button75.Name = "button75";
            this.button75.Size = new System.Drawing.Size(72, 42);
            this.button75.TabIndex = 74;
            this.button75.UseVisualStyleBackColor = false;
            // 
            // button74
            // 
            this.button74.BackColor = System.Drawing.SystemColors.Info;
            this.button74.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button74.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button74.ForeColor = System.Drawing.Color.Red;
            this.button74.Location = new System.Drawing.Point(504, 64);
            this.button74.Margin = new System.Windows.Forms.Padding(0);
            this.button74.Name = "button74";
            this.button74.Size = new System.Drawing.Size(72, 42);
            this.button74.TabIndex = 73;
            this.button74.UseVisualStyleBackColor = false;
            // 
            // button73
            // 
            this.button73.BackColor = System.Drawing.SystemColors.Info;
            this.button73.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button73.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button73.ForeColor = System.Drawing.Color.Red;
            this.button73.Location = new System.Drawing.Point(432, 64);
            this.button73.Margin = new System.Windows.Forms.Padding(0);
            this.button73.Name = "button73";
            this.button73.Size = new System.Drawing.Size(72, 42);
            this.button73.TabIndex = 72;
            this.button73.UseVisualStyleBackColor = false;
            // 
            // button72
            // 
            this.button72.BackColor = System.Drawing.SystemColors.Info;
            this.button72.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button72.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button72.ForeColor = System.Drawing.Color.Red;
            this.button72.Location = new System.Drawing.Point(360, 64);
            this.button72.Margin = new System.Windows.Forms.Padding(0);
            this.button72.Name = "button72";
            this.button72.Size = new System.Drawing.Size(72, 42);
            this.button72.TabIndex = 71;
            this.button72.UseVisualStyleBackColor = false;
            // 
            // button71
            // 
            this.button71.BackColor = System.Drawing.SystemColors.Info;
            this.button71.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button71.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button71.ForeColor = System.Drawing.Color.Red;
            this.button71.Location = new System.Drawing.Point(288, 64);
            this.button71.Margin = new System.Windows.Forms.Padding(0);
            this.button71.Name = "button71";
            this.button71.Size = new System.Drawing.Size(72, 42);
            this.button71.TabIndex = 70;
            this.button71.UseVisualStyleBackColor = false;
            // 
            // button70
            // 
            this.button70.BackColor = System.Drawing.SystemColors.Info;
            this.button70.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button70.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button70.ForeColor = System.Drawing.Color.Red;
            this.button70.Location = new System.Drawing.Point(216, 64);
            this.button70.Margin = new System.Windows.Forms.Padding(0);
            this.button70.Name = "button70";
            this.button70.Size = new System.Drawing.Size(72, 42);
            this.button70.TabIndex = 69;
            this.button70.UseVisualStyleBackColor = false;
            // 
            // button69
            // 
            this.button69.BackColor = System.Drawing.SystemColors.Info;
            this.button69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button69.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button69.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button69.ForeColor = System.Drawing.Color.Red;
            this.button69.Location = new System.Drawing.Point(144, 64);
            this.button69.Margin = new System.Windows.Forms.Padding(0);
            this.button69.Name = "button69";
            this.button69.Size = new System.Drawing.Size(72, 42);
            this.button69.TabIndex = 68;
            this.button69.UseVisualStyleBackColor = false;
            // 
            // button68
            // 
            this.button68.BackColor = System.Drawing.SystemColors.Info;
            this.button68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button68.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button68.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button68.ForeColor = System.Drawing.Color.Red;
            this.button68.Location = new System.Drawing.Point(72, 64);
            this.button68.Margin = new System.Windows.Forms.Padding(0);
            this.button68.Name = "button68";
            this.button68.Size = new System.Drawing.Size(72, 42);
            this.button68.TabIndex = 67;
            this.button68.UseVisualStyleBackColor = false;
            // 
            // button67
            // 
            this.button67.BackColor = System.Drawing.SystemColors.Info;
            this.button67.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button67.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button67.ForeColor = System.Drawing.Color.Red;
            this.button67.Location = new System.Drawing.Point(0, 64);
            this.button67.Margin = new System.Windows.Forms.Padding(0);
            this.button67.Name = "button67";
            this.button67.Size = new System.Drawing.Size(72, 42);
            this.button67.TabIndex = 66;
            this.button67.UseVisualStyleBackColor = false;
            // 
            // button66
            // 
            this.button66.BackColor = System.Drawing.SystemColors.Info;
            this.button66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button66.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button66.ForeColor = System.Drawing.Color.Red;
            this.button66.Location = new System.Drawing.Point(1080, 22);
            this.button66.Margin = new System.Windows.Forms.Padding(0);
            this.button66.Name = "button66";
            this.button66.Size = new System.Drawing.Size(72, 42);
            this.button66.TabIndex = 65;
            this.button66.UseVisualStyleBackColor = false;
            // 
            // button65
            // 
            this.button65.BackColor = System.Drawing.SystemColors.Info;
            this.button65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button65.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button65.ForeColor = System.Drawing.Color.Red;
            this.button65.Location = new System.Drawing.Point(1008, 22);
            this.button65.Margin = new System.Windows.Forms.Padding(0);
            this.button65.Name = "button65";
            this.button65.Size = new System.Drawing.Size(72, 42);
            this.button65.TabIndex = 64;
            this.button65.UseVisualStyleBackColor = false;
            // 
            // button64
            // 
            this.button64.BackColor = System.Drawing.SystemColors.Info;
            this.button64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button64.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button64.ForeColor = System.Drawing.Color.Red;
            this.button64.Location = new System.Drawing.Point(936, 22);
            this.button64.Margin = new System.Windows.Forms.Padding(0);
            this.button64.Name = "button64";
            this.button64.Size = new System.Drawing.Size(72, 42);
            this.button64.TabIndex = 63;
            this.button64.UseVisualStyleBackColor = false;
            // 
            // button63
            // 
            this.button63.BackColor = System.Drawing.SystemColors.Info;
            this.button63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button63.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button63.ForeColor = System.Drawing.Color.Red;
            this.button63.Location = new System.Drawing.Point(864, 22);
            this.button63.Margin = new System.Windows.Forms.Padding(0);
            this.button63.Name = "button63";
            this.button63.Size = new System.Drawing.Size(72, 42);
            this.button63.TabIndex = 62;
            this.button63.UseVisualStyleBackColor = false;
            // 
            // button62
            // 
            this.button62.BackColor = System.Drawing.SystemColors.Info;
            this.button62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button62.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button62.ForeColor = System.Drawing.Color.Red;
            this.button62.Location = new System.Drawing.Point(792, 22);
            this.button62.Margin = new System.Windows.Forms.Padding(0);
            this.button62.Name = "button62";
            this.button62.Size = new System.Drawing.Size(72, 42);
            this.button62.TabIndex = 61;
            this.button62.UseVisualStyleBackColor = false;
            // 
            // button61
            // 
            this.button61.BackColor = System.Drawing.SystemColors.Info;
            this.button61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button61.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button61.ForeColor = System.Drawing.Color.Red;
            this.button61.Location = new System.Drawing.Point(720, 22);
            this.button61.Margin = new System.Windows.Forms.Padding(0);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(72, 42);
            this.button61.TabIndex = 60;
            this.button61.UseVisualStyleBackColor = false;
            // 
            // button60
            // 
            this.button60.BackColor = System.Drawing.SystemColors.Info;
            this.button60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button60.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button60.ForeColor = System.Drawing.Color.Red;
            this.button60.Location = new System.Drawing.Point(648, 22);
            this.button60.Margin = new System.Windows.Forms.Padding(0);
            this.button60.Name = "button60";
            this.button60.Size = new System.Drawing.Size(72, 42);
            this.button60.TabIndex = 59;
            this.button60.UseVisualStyleBackColor = false;
            // 
            // button59
            // 
            this.button59.BackColor = System.Drawing.SystemColors.Info;
            this.button59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button59.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button59.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button59.ForeColor = System.Drawing.Color.Red;
            this.button59.Location = new System.Drawing.Point(576, 22);
            this.button59.Margin = new System.Windows.Forms.Padding(0);
            this.button59.Name = "button59";
            this.button59.Size = new System.Drawing.Size(72, 42);
            this.button59.TabIndex = 58;
            this.button59.UseVisualStyleBackColor = false;
            // 
            // button58
            // 
            this.button58.BackColor = System.Drawing.SystemColors.Info;
            this.button58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button58.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button58.ForeColor = System.Drawing.Color.Red;
            this.button58.Location = new System.Drawing.Point(504, 22);
            this.button58.Margin = new System.Windows.Forms.Padding(0);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(72, 42);
            this.button58.TabIndex = 57;
            this.button58.UseVisualStyleBackColor = false;
            // 
            // button57
            // 
            this.button57.BackColor = System.Drawing.SystemColors.Info;
            this.button57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button57.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button57.ForeColor = System.Drawing.Color.Red;
            this.button57.Location = new System.Drawing.Point(432, 22);
            this.button57.Margin = new System.Windows.Forms.Padding(0);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(72, 42);
            this.button57.TabIndex = 56;
            this.button57.UseVisualStyleBackColor = false;
            // 
            // button51
            // 
            this.button51.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button51.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button51.ForeColor = System.Drawing.Color.White;
            this.button51.Location = new System.Drawing.Point(288, 106);
            this.button51.Margin = new System.Windows.Forms.Padding(0);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(72, 44);
            this.button51.TabIndex = 54;
            this.button51.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button51.UseVisualStyleBackColor = false;
            // 
            // button50
            // 
            this.button50.BackColor = System.Drawing.Color.Black;
            this.button50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button50.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button50.ForeColor = System.Drawing.Color.White;
            this.button50.Location = new System.Drawing.Point(504, 106);
            this.button50.Margin = new System.Windows.Forms.Padding(0);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(72, 44);
            this.button50.TabIndex = 53;
            this.button50.Text = "Paper\r\nOut";
            this.button50.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button50.UseVisualStyleBackColor = false;
            // 
            // button49
            // 
            this.button49.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button49.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button49.ForeColor = System.Drawing.Color.White;
            this.button49.Location = new System.Drawing.Point(432, 106);
            this.button49.Margin = new System.Windows.Forms.Padding(0);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(72, 44);
            this.button49.TabIndex = 52;
            this.button49.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button49.UseVisualStyleBackColor = false;
            // 
            // button48
            // 
            this.button48.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button48.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button48.ForeColor = System.Drawing.Color.White;
            this.button48.Location = new System.Drawing.Point(72, 106);
            this.button48.Margin = new System.Windows.Forms.Padding(0);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(72, 44);
            this.button48.TabIndex = 51;
            this.button48.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button48.UseVisualStyleBackColor = false;
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button47.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button47.ForeColor = System.Drawing.Color.White;
            this.button47.Location = new System.Drawing.Point(0, 106);
            this.button47.Margin = new System.Windows.Forms.Padding(0);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(72, 44);
            this.button47.TabIndex = 50;
            this.button47.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button47.UseVisualStyleBackColor = false;
            // 
            // button46
            // 
            this.button46.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button46.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button46.ForeColor = System.Drawing.Color.White;
            this.button46.Location = new System.Drawing.Point(216, 106);
            this.button46.Margin = new System.Windows.Forms.Padding(0);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(72, 44);
            this.button46.TabIndex = 49;
            this.button46.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button46.UseVisualStyleBackColor = false;
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button45.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button45.ForeColor = System.Drawing.Color.White;
            this.button45.Location = new System.Drawing.Point(360, 106);
            this.button45.Margin = new System.Windows.Forms.Padding(0);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(72, 44);
            this.button45.TabIndex = 48;
            this.button45.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button45.UseVisualStyleBackColor = false;
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button44.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.ForeColor = System.Drawing.Color.White;
            this.button44.Location = new System.Drawing.Point(720, 106);
            this.button44.Margin = new System.Windows.Forms.Padding(0);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(72, 44);
            this.button44.TabIndex = 47;
            this.button44.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button44.UseVisualStyleBackColor = false;
            // 
            // button43
            // 
            this.button43.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button43.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button43.ForeColor = System.Drawing.Color.White;
            this.button43.Location = new System.Drawing.Point(792, 106);
            this.button43.Margin = new System.Windows.Forms.Padding(0);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(72, 44);
            this.button43.TabIndex = 46;
            this.button43.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button43.UseVisualStyleBackColor = false;
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button42.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button42.ForeColor = System.Drawing.Color.White;
            this.button42.Location = new System.Drawing.Point(576, 106);
            this.button42.Margin = new System.Windows.Forms.Padding(0);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(72, 44);
            this.button42.TabIndex = 45;
            this.button42.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button42.UseVisualStyleBackColor = false;
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button41.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.ForeColor = System.Drawing.Color.White;
            this.button41.Location = new System.Drawing.Point(648, 106);
            this.button41.Margin = new System.Windows.Forms.Padding(0);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(72, 44);
            this.button41.TabIndex = 44;
            this.button41.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button41.UseVisualStyleBackColor = false;
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button40.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.ForeColor = System.Drawing.Color.White;
            this.button40.Location = new System.Drawing.Point(1008, 106);
            this.button40.Margin = new System.Windows.Forms.Padding(0);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(72, 44);
            this.button40.TabIndex = 43;
            this.button40.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button40.UseVisualStyleBackColor = false;
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button39.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.ForeColor = System.Drawing.Color.White;
            this.button39.Location = new System.Drawing.Point(1080, 106);
            this.button39.Margin = new System.Windows.Forms.Padding(0);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(72, 44);
            this.button39.TabIndex = 42;
            this.button39.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button39.UseVisualStyleBackColor = false;
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button38.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.ForeColor = System.Drawing.Color.White;
            this.button38.Location = new System.Drawing.Point(864, 106);
            this.button38.Margin = new System.Windows.Forms.Padding(0);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(72, 44);
            this.button38.TabIndex = 41;
            this.button38.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button38.UseVisualStyleBackColor = false;
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button37.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.ForeColor = System.Drawing.Color.White;
            this.button37.Location = new System.Drawing.Point(936, 106);
            this.button37.Margin = new System.Windows.Forms.Padding(0);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(72, 44);
            this.button37.TabIndex = 40;
            this.button37.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button37.UseVisualStyleBackColor = false;
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button36.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.ForeColor = System.Drawing.Color.White;
            this.button36.Location = new System.Drawing.Point(144, 106);
            this.button36.Margin = new System.Windows.Forms.Padding(0);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(72, 44);
            this.button36.TabIndex = 39;
            this.button36.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.SystemColors.Info;
            this.button35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.ForeColor = System.Drawing.Color.Red;
            this.button35.Location = new System.Drawing.Point(0, 22);
            this.button35.Margin = new System.Windows.Forms.Padding(0);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(72, 42);
            this.button35.TabIndex = 38;
            this.button35.UseVisualStyleBackColor = false;
            // 
            // button52
            // 
            this.button52.BackColor = System.Drawing.SystemColors.Info;
            this.button52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button52.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button52.ForeColor = System.Drawing.Color.Red;
            this.button52.Location = new System.Drawing.Point(72, 22);
            this.button52.Margin = new System.Windows.Forms.Padding(0);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(72, 42);
            this.button52.TabIndex = 55;
            this.button52.UseVisualStyleBackColor = false;
            // 
            // button53
            // 
            this.button53.BackColor = System.Drawing.SystemColors.Info;
            this.button53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button53.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button53.ForeColor = System.Drawing.Color.Red;
            this.button53.Location = new System.Drawing.Point(144, 22);
            this.button53.Margin = new System.Windows.Forms.Padding(0);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(72, 42);
            this.button53.TabIndex = 55;
            this.button53.UseVisualStyleBackColor = false;
            // 
            // button54
            // 
            this.button54.BackColor = System.Drawing.SystemColors.Info;
            this.button54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button54.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button54.ForeColor = System.Drawing.Color.Red;
            this.button54.Location = new System.Drawing.Point(216, 22);
            this.button54.Margin = new System.Windows.Forms.Padding(0);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(72, 42);
            this.button54.TabIndex = 55;
            this.button54.UseVisualStyleBackColor = false;
            // 
            // button55
            // 
            this.button55.BackColor = System.Drawing.SystemColors.Info;
            this.button55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button55.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button55.ForeColor = System.Drawing.Color.Red;
            this.button55.Location = new System.Drawing.Point(288, 22);
            this.button55.Margin = new System.Windows.Forms.Padding(0);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(72, 42);
            this.button55.TabIndex = 55;
            this.button55.UseVisualStyleBackColor = false;
            // 
            // button56
            // 
            this.button56.BackColor = System.Drawing.SystemColors.Info;
            this.button56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button56.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button56.ForeColor = System.Drawing.Color.Red;
            this.button56.Location = new System.Drawing.Point(360, 22);
            this.button56.Margin = new System.Windows.Forms.Padding(0);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(72, 42);
            this.button56.TabIndex = 55;
            this.button56.UseVisualStyleBackColor = false;
            // 
            // PumpLabel1
            // 
            this.PumpLabel1.AutoSize = true;
            this.PumpLabel1.BackColor = System.Drawing.Color.Black;
            this.PumpLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PumpLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PumpLabel1.ForeColor = System.Drawing.Color.White;
            this.PumpLabel1.Location = new System.Drawing.Point(0, 0);
            this.PumpLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.PumpLabel1.Name = "PumpLabel1";
            this.PumpLabel1.Size = new System.Drawing.Size(72, 22);
            this.PumpLabel1.TabIndex = 82;
            this.PumpLabel1.Text = "1";
            this.PumpLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutControlArea
            // 
            this.layoutControlArea.ColumnCount = 6;
            this.layoutControlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutControlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutControlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutControlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutControlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutControlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutControlArea.Controls.Add(this.posIdLabel, 5, 10);
            this.layoutControlArea.Controls.Add(this.button34, 1, 10);
            this.layoutControlArea.Controls.Add(this.button32, 0, 10);
            this.layoutControlArea.Controls.Add(this.button31, 2, 9);
            this.layoutControlArea.Controls.Add(this.button30, 1, 9);
            this.layoutControlArea.Controls.Add(this.button29, 0, 9);
            this.layoutControlArea.Controls.Add(this.button28, 5, 8);
            this.layoutControlArea.Controls.Add(this.button27, 4, 8);
            this.layoutControlArea.Controls.Add(this.button26, 3, 8);
            this.layoutControlArea.Controls.Add(this.button23, 2, 8);
            this.layoutControlArea.Controls.Add(this.button21, 3, 7);
            this.layoutControlArea.Controls.Add(this.button17, 5, 6);
            this.layoutControlArea.Controls.Add(this.button16, 4, 6);
            this.layoutControlArea.Controls.Add(this.button15, 3, 6);
            this.layoutControlArea.Controls.Add(this.btnTotal, 3, 9);
            this.layoutControlArea.Controls.Add(this.button25, 1, 8);
            this.layoutControlArea.Controls.Add(this.button24, 0, 8);
            this.layoutControlArea.Controls.Add(this.button20, 2, 7);
            this.layoutControlArea.Controls.Add(this.button19, 1, 7);
            this.layoutControlArea.Controls.Add(this.button18, 0, 7);
            this.layoutControlArea.Controls.Add(this.button14, 2, 6);
            this.layoutControlArea.Controls.Add(this.button13, 1, 6);
            this.layoutControlArea.Controls.Add(this.button12, 0, 6);
            this.layoutControlArea.Controls.Add(this.button10, 3, 5);
            this.layoutControlArea.Controls.Add(this.button9, 2, 5);
            this.layoutControlArea.Controls.Add(this.button8, 1, 5);
            this.layoutControlArea.Controls.Add(this.button7, 0, 5);
            this.layoutControlArea.Controls.Add(this.button6, 5, 4);
            this.layoutControlArea.Controls.Add(this.button5, 4, 4);
            this.layoutControlArea.Controls.Add(this.button4, 3, 4);
            this.layoutControlArea.Controls.Add(this.button3, 2, 4);
            this.layoutControlArea.Controls.Add(this.button2, 1, 4);
            this.layoutControlArea.Controls.Add(this.boxSummaryList, 0, 3);
            this.layoutControlArea.Controls.Add(this.boxItemsList, 0, 1);
            this.layoutControlArea.Controls.Add(this.button1, 0, 4);
            this.layoutControlArea.Controls.Add(this.posVerLabel, 0, 0);
            this.layoutControlArea.Controls.Add(this.timeDateLabel, 2, 10);
            this.layoutControlArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlArea.Location = new System.Drawing.Point(755, 153);
            this.layoutControlArea.Name = "layoutControlArea";
            this.layoutControlArea.RowCount = 11;
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutControlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutControlArea.Size = new System.Drawing.Size(394, 612);
            this.layoutControlArea.TabIndex = 1;
            // 
            // posIdLabel
            // 
            this.posIdLabel.BackColor = System.Drawing.Color.Yellow;
            this.posIdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posIdLabel.ForeColor = System.Drawing.Color.Red;
            this.posIdLabel.Location = new System.Drawing.Point(328, 586);
            this.posIdLabel.Margin = new System.Windows.Forms.Padding(3);
            this.posIdLabel.Name = "posIdLabel";
            this.posIdLabel.Size = new System.Drawing.Size(63, 23);
            this.posIdLabel.TabIndex = 51;
            this.posIdLabel.Text = "0";
            this.posIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button34
            // 
            this.button34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button34.Location = new System.Drawing.Point(68, 586);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(59, 23);
            this.button34.TabIndex = 49;
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Visible = false;
            // 
            // button32
            // 
            this.button32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button32.Location = new System.Drawing.Point(3, 586);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(59, 23);
            this.button32.TabIndex = 48;
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Visible = false;
            // 
            // button31
            // 
            this.button31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button31.Location = new System.Drawing.Point(133, 523);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(59, 57);
            this.button31.TabIndex = 47;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Visible = false;
            // 
            // button30
            // 
            this.button30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button30.Location = new System.Drawing.Point(68, 523);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(59, 57);
            this.button30.TabIndex = 46;
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Visible = false;
            // 
            // button29
            // 
            this.button29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button29.Location = new System.Drawing.Point(3, 523);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(59, 57);
            this.button29.TabIndex = 45;
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Visible = false;
            // 
            // button28
            // 
            this.button28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button28.Location = new System.Drawing.Point(328, 460);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(63, 57);
            this.button28.TabIndex = 44;
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Visible = false;
            // 
            // button27
            // 
            this.button27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button27.Location = new System.Drawing.Point(263, 460);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(59, 57);
            this.button27.TabIndex = 43;
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Visible = false;
            // 
            // button26
            // 
            this.button26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button26.Location = new System.Drawing.Point(198, 460);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(59, 57);
            this.button26.TabIndex = 42;
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Visible = false;
            // 
            // button23
            // 
            this.button23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(133, 460);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(59, 57);
            this.button23.TabIndex = 41;
            this.button23.Text = "&.";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Visible = false;
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.Location = new System.Drawing.Point(198, 397);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(59, 57);
            this.button21.TabIndex = 40;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Visible = false;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Location = new System.Drawing.Point(328, 334);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(63, 57);
            this.button17.TabIndex = 39;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Visible = false;
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Location = new System.Drawing.Point(263, 334);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(59, 57);
            this.button16.TabIndex = 38;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Visible = false;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Location = new System.Drawing.Point(198, 334);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(59, 57);
            this.button15.TabIndex = 37;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Visible = false;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Green;
            this.layoutControlArea.SetColumnSpan(this.btnTotal, 3);
            this.btnTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.Location = new System.Drawing.Point(198, 523);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(193, 57);
            this.btnTotal.TabIndex = 34;
            this.btnTotal.Text = "TOTAL";
            this.btnTotal.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(68, 460);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(59, 57);
            this.button25.TabIndex = 26;
            this.button25.Text = "00";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(3, 460);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(59, 57);
            this.button24.TabIndex = 25;
            this.button24.Text = "&0";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(133, 397);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(59, 57);
            this.button20.TabIndex = 21;
            this.button20.Text = "&3";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(68, 397);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(59, 57);
            this.button19.TabIndex = 20;
            this.button19.Text = "&2";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(3, 397);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(59, 57);
            this.button18.TabIndex = 19;
            this.button18.Text = "&1";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(133, 334);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(59, 57);
            this.button14.TabIndex = 15;
            this.button14.Text = "&6";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(68, 334);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(59, 57);
            this.button13.TabIndex = 14;
            this.button13.Text = "&5";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(3, 334);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(59, 57);
            this.button12.TabIndex = 13;
            this.button12.Text = "&4";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(198, 271);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(59, 57);
            this.button10.TabIndex = 11;
            this.button10.Text = "Void";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(133, 271);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 57);
            this.button9.TabIndex = 10;
            this.button9.Text = "&9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(68, 271);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 57);
            this.button8.TabIndex = 9;
            this.button8.Text = "&8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 271);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 57);
            this.button7.TabIndex = 8;
            this.button7.Text = "&7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(328, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 57);
            this.button6.TabIndex = 7;
            this.button6.Text = "Un Suspend";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(263, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 57);
            this.button5.TabIndex = 6;
            this.button5.Text = "Suspend";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(198, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 57);
            this.button4.TabIndex = 5;
            this.button4.Text = "Refund";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(133, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 57);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back Space";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(68, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "@";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // boxSummaryList
            // 
            this.layoutControlArea.SetColumnSpan(this.boxSummaryList, 6);
            this.boxSummaryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxSummaryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSummaryList.ForeColor = System.Drawing.Color.Green;
            this.boxSummaryList.ItemHeight = 16;
            this.boxSummaryList.Items.AddRange(new object[] {
            "Subtotal",
            "Tax",
            "Total",
            "Balance"});
            this.boxSummaryList.Location = new System.Drawing.Point(0, 142);
            this.boxSummaryList.Margin = new System.Windows.Forms.Padding(0);
            this.boxSummaryList.Name = "boxSummaryList";
            this.boxSummaryList.Size = new System.Drawing.Size(394, 63);
            this.boxSummaryList.TabIndex = 1;
            this.boxSummaryList.SelectedIndexChanged += new System.EventHandler(this.DeselectList);
            // 
            // boxItemsList
            // 
            this.layoutControlArea.SetColumnSpan(this.boxItemsList, 6);
            this.boxItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxItemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxItemsList.ForeColor = System.Drawing.Color.Green;
            this.boxItemsList.FormattingEnabled = true;
            this.boxItemsList.ItemHeight = 16;
            this.boxItemsList.Location = new System.Drawing.Point(0, 16);
            this.boxItemsList.Margin = new System.Windows.Forms.Padding(0);
            this.boxItemsList.Name = "boxItemsList";
            this.layoutControlArea.SetRowSpan(this.boxItemsList, 2);
            this.boxItemsList.Size = new System.Drawing.Size(394, 126);
            this.boxItemsList.TabIndex = 0;
            this.boxItemsList.SelectedIndexChanged += new System.EventHandler(this.DeselectList);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // posVerLabel
            // 
            this.posVerLabel.AutoSize = true;
            this.layoutControlArea.SetColumnSpan(this.posVerLabel, 6);
            this.posVerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posVerLabel.Location = new System.Drawing.Point(0, 0);
            this.posVerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.posVerLabel.Name = "posVerLabel";
            this.posVerLabel.Size = new System.Drawing.Size(394, 16);
            this.posVerLabel.TabIndex = 35;
            this.posVerLabel.Text = "POS Version Info";
            // 
            // timeDateLabel
            // 
            this.timeDateLabel.BackColor = System.Drawing.Color.Black;
            this.layoutControlArea.SetColumnSpan(this.timeDateLabel, 3);
            this.timeDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDateLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.timeDateLabel.Location = new System.Drawing.Point(133, 586);
            this.timeDateLabel.Margin = new System.Windows.Forms.Padding(3);
            this.timeDateLabel.Name = "timeDateLabel";
            this.timeDateLabel.Size = new System.Drawing.Size(189, 23);
            this.timeDateLabel.TabIndex = 36;
            this.timeDateLabel.Text = "Time and Date";
            this.timeDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.Controls.Add(this.button90, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.button89, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.button88, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.button87, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.button86, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.button85, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.button84, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button83, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(746, 612);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // button90
            // 
            this.button90.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button90.Location = new System.Drawing.Point(647, 5);
            this.button90.Margin = new System.Windows.Forms.Padding(0);
            this.button90.Name = "button90";
            this.button90.Size = new System.Drawing.Size(96, 45);
            this.button90.TabIndex = 45;
            this.button90.Text = "Keymap";
            this.button90.UseVisualStyleBackColor = true;
            this.button90.Visible = false;
            // 
            // button89
            // 
            this.button89.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button89.Location = new System.Drawing.Point(555, 5);
            this.button89.Margin = new System.Windows.Forms.Padding(0);
            this.button89.Name = "button89";
            this.button89.Size = new System.Drawing.Size(92, 45);
            this.button89.TabIndex = 44;
            this.button89.Text = "Payment Methods";
            this.button89.UseVisualStyleBackColor = true;
            // 
            // button88
            // 
            this.button88.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button88.Location = new System.Drawing.Point(463, 5);
            this.button88.Margin = new System.Windows.Forms.Padding(0);
            this.button88.Name = "button88";
            this.button88.Size = new System.Drawing.Size(92, 45);
            this.button88.TabIndex = 43;
            this.button88.Text = "FSC Journal";
            this.button88.UseVisualStyleBackColor = true;
            // 
            // button87
            // 
            this.button87.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button87.Location = new System.Drawing.Point(371, 5);
            this.button87.Margin = new System.Windows.Forms.Padding(0);
            this.button87.Name = "button87";
            this.button87.Size = new System.Drawing.Size(92, 45);
            this.button87.TabIndex = 42;
            this.button87.Text = "Calculator";
            this.button87.UseVisualStyleBackColor = true;
            // 
            // button86
            // 
            this.button86.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button86.Location = new System.Drawing.Point(279, 5);
            this.button86.Margin = new System.Windows.Forms.Padding(0);
            this.button86.Name = "button86";
            this.button86.Size = new System.Drawing.Size(92, 45);
            this.button86.TabIndex = 41;
            this.button86.Text = "Tax Shift";
            this.button86.UseVisualStyleBackColor = true;
            // 
            // button85
            // 
            this.button85.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button85.Location = new System.Drawing.Point(187, 5);
            this.button85.Margin = new System.Windows.Forms.Padding(0);
            this.button85.Name = "button85";
            this.button85.Size = new System.Drawing.Size(92, 45);
            this.button85.TabIndex = 40;
            this.button85.Text = "Date of Birth";
            this.button85.UseVisualStyleBackColor = true;
            // 
            // button84
            // 
            this.button84.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button84.Location = new System.Drawing.Point(95, 5);
            this.button84.Margin = new System.Windows.Forms.Padding(0);
            this.button84.Name = "button84";
            this.button84.Size = new System.Drawing.Size(92, 45);
            this.button84.TabIndex = 39;
            this.button84.Text = "Gas Menu";
            this.button84.UseVisualStyleBackColor = true;
            // 
            // button83
            // 
            this.button83.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button83.Location = new System.Drawing.Point(3, 5);
            this.button83.Margin = new System.Windows.Forms.Padding(0);
            this.button83.Name = "button83";
            this.button83.Size = new System.Drawing.Size(92, 45);
            this.button83.TabIndex = 38;
            this.button83.Text = "Main Menu";
            this.button83.UseVisualStyleBackColor = true;
            this.button83.Click += new System.EventHandler(this.TestBtnClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 11;
            this.tableLayoutPanel4.SetColumnSpan(this.tableLayoutPanel5, 8);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 53);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel5.RowCount = 9;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(734, 551);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // RegiHostForm
            // 
            this.ClientSize = new System.Drawing.Size(1152, 768);
            this.ControlBox = false;
            this.Controls.Add(this.layoutMaster);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegiHostForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.layoutMaster.ResumeLayout(false);
            this.layoutGasPump.ResumeLayout(false);
            this.layoutGasPump.PerformLayout();
            this.layoutControlArea.ResumeLayout(false);
            this.layoutControlArea.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button186_Click(object sender, EventArgs e)
        {

        }

        private void button178_Click(object sender, EventArgs e)
        {

        }

        private void button188_Click(object sender, EventArgs e)
        {

        }

        private void button177_Click(object sender, EventArgs e)
        {

        }

        private void button166_Click(object sender, EventArgs e)
        {

        }

        private void button167_Click(object sender, EventArgs e)
        {

        }

        private void button156_Click(object sender, EventArgs e)
        {

        }

        private void button145_Click(object sender, EventArgs e)
        {

        }

        private void button134_Click(object sender, EventArgs e)
        {

        }

        private void button123_Click(object sender, EventArgs e)
        {

        }

        private void button112_Click(object sender, EventArgs e)
        {

        }

        private void button101_Click(object sender, EventArgs e)
        {

        }

        private void button100_Click(object sender, EventArgs e)
        {

        }

        private void button111_Click(object sender, EventArgs e)
        {

        }

        private void button122_Click(object sender, EventArgs e)
        {

        }

        private void button133_Click(object sender, EventArgs e)
        {

        }

        private void button144_Click(object sender, EventArgs e)
        {

        }

        private void button155_Click(object sender, EventArgs e)
        {

        }

        private void button187_Click(object sender, EventArgs e)
        {

        }

        private void button176_Click(object sender, EventArgs e)
        {

        }

        private void button165_Click(object sender, EventArgs e)
        {

        }

        private void button154_Click(object sender, EventArgs e)
        {

        }

        private void button143_Click(object sender, EventArgs e)
        {

        }

        private void button132_Click(object sender, EventArgs e)
        {

        }

        private void button121_Click(object sender, EventArgs e)
        {

        }

        private void button110_Click(object sender, EventArgs e)
        {

        }

        private void button99_Click(object sender, EventArgs e)
        {

        }

        private void button98_Click(object sender, EventArgs e)
        {

        }

        private void button109_Click(object sender, EventArgs e)
        {

        }

        private void button120_Click(object sender, EventArgs e)
        {

        }

        private void button131_Click(object sender, EventArgs e)
        {

        }

        private void button142_Click(object sender, EventArgs e)
        {

        }

        private void button175_Click(object sender, EventArgs e)
        {

        }

        private void button164_Click(object sender, EventArgs e)
        {

        }

        private void button153_Click(object sender, EventArgs e)
        {

        }

        private void button189_Click(object sender, EventArgs e)
        {

        }

        private void button185_Click(object sender, EventArgs e)
        {

        }

        private void button174_Click(object sender, EventArgs e)
        {

        }

        private void button163_Click(object sender, EventArgs e)
        {

        }

        private void button152_Click(object sender, EventArgs e)
        {

        }

        private void button141_Click(object sender, EventArgs e)
        {

        }

        private void button130_Click(object sender, EventArgs e)
        {

        }

        private void button119_Click(object sender, EventArgs e)
        {

        }

        private void button108_Click(object sender, EventArgs e)
        {

        }

        private void button97_Click(object sender, EventArgs e)
        {

        }

        private void button96_Click(object sender, EventArgs e)
        {

        }

        private void button95_Click(object sender, EventArgs e)
        {

        }

        private void button94_Click(object sender, EventArgs e)
        {

        }

        private void button93_Click(object sender, EventArgs e)
        {

        }

        private void button92_Click(object sender, EventArgs e)
        {

        }

        private void button91_Click(object sender, EventArgs e)
        {

        }

        private void button103_Click(object sender, EventArgs e)
        {

        }

        private void button104_Click(object sender, EventArgs e)
        {

        }

        private void button105_Click(object sender, EventArgs e)
        {

        }

        private void button106_Click(object sender, EventArgs e)
        {

        }

        private void button117_Click(object sender, EventArgs e)
        {

        }

        private void button128_Click(object sender, EventArgs e)
        {

        }

        private void button139_Click(object sender, EventArgs e)
        {

        }

        private void button150_Click(object sender, EventArgs e)
        {

        }

        private void button161_Click(object sender, EventArgs e)
        {

        }

        private void button172_Click(object sender, EventArgs e)
        {

        }

        private void button183_Click(object sender, EventArgs e)
        {

        }

        private void button182_Click(object sender, EventArgs e)
        {

        }

        private void button181_Click(object sender, EventArgs e)
        {

        }

        private void button180_Click(object sender, EventArgs e)
        {

        }

        private void button179_Click(object sender, EventArgs e)
        {

        }

        private void button168_Click(object sender, EventArgs e)
        {

        }

        private void button157_Click(object sender, EventArgs e)
        {

        }

        private void button146_Click(object sender, EventArgs e)
        {

        }

        private void button135_Click(object sender, EventArgs e)
        {

        }

        private void button124_Click(object sender, EventArgs e)
        {

        }

        private void button113_Click(object sender, EventArgs e)
        {

        }
    }
}
