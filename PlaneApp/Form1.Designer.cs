namespace PlaneApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlSky = new Panel();
            pbLight = new PictureBox();
            pbPlane = new PictureBox();
            btnEnis = new Button();
            btnTurbulans = new Button();
            btnKemerler = new Button();
            btnTesekkur = new Button();
            btnBeep = new Button();
            btnGas = new Button();
            btnBreak = new Button();
            btnOnOff = new Button();
            timerFly = new System.Windows.Forms.Timer(components);

            pnlSky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlane).BeginInit();
            SuspendLayout();

            // pnlSky
            pnlSky.BackColor = Color.DimGray;
            pnlSky.Location = new Point(0, 0);
            pnlSky.Size = new Size(288, 524);
            pnlSky.Controls.Add(pbLight);
            pnlSky.Controls.Add(pbPlane);

            // pbPlane
            pbPlane.BackColor = Color.Transparent;
            pbPlane.Location = new Point(70, 330);
            pbPlane.Size = new Size(130, 180);
            pbPlane.SizeMode = PictureBoxSizeMode.Zoom;

            // pbLight
            pbLight.BackColor = Color.Transparent;
            pbLight.Location = new Point(110, 300);
            pbLight.Size = new Size(40, 40);
            pbLight.SizeMode = PictureBoxSizeMode.Zoom;

            // Narıncı düymələr
            ConfigOrange(btnEnis, "Eniş hazırlığı", 10, 10);
            ConfigOrange(btnTurbulans, "Turbulans", 10, 80);
            ConfigOrange(btnKemerler, "Kəmərlər", 10, 150);
            ConfigOrange(btnTesekkur, "Təşəkkürlər", 10, 220);
            ConfigOrange(btnBeep, "Beep", 10, 290);
            btnEnis.Click += btnEnis_Click;
            btnTurbulans.Click += btnTurbulans_Click;
            btnKemerler.Click += btnKemerler_Click;
            btnTesekkur.Click += btnTesekkur_Click;
            btnBeep.Click += btnBeep_Click;

            // GAS
            btnGas.Text = "GAS";
            btnGas.BackColor = Color.Green;
            btnGas.ForeColor = Color.White;
            btnGas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGas.Location = new Point(310, 390);
            btnGas.Size = new Size(150, 80);
            btnGas.FlatStyle = FlatStyle.Flat;
            btnGas.Click += btnGas_Click;

            // Break
            btnBreak.Text = "Break";
            btnBreak.BackColor = Color.FromArgb(192, 0, 0);
            btnBreak.ForeColor = Color.White;
            btnBreak.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBreak.Location = new Point(520, 390);
            btnBreak.Size = new Size(150, 80);
            btnBreak.FlatStyle = FlatStyle.Flat;
            btnBreak.Click += btnBreak_Click;

            // ON/OFF
            btnOnOff.Text = "ON/OFF";
            btnOnOff.BackColor = Color.MediumBlue;
            btnOnOff.ForeColor = Color.White;
            btnOnOff.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOnOff.Location = new Point(290, 480);
            btnOnOff.Size = new Size(412, 44);
            btnOnOff.FlatStyle = FlatStyle.Flat;
            btnOnOff.Click += btnOnOff_Click;

            // timerFly
            timerFly.Interval = 30;
            timerFly.Tick += timerFly_Tick;

            // Form1
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(714, 524);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plane";
            Controls.Add(pnlSky);
            Controls.Add(btnEnis);
            Controls.Add(btnTurbulans);
            Controls.Add(btnKemerler);
            Controls.Add(btnTesekkur);
            Controls.Add(btnBeep);
            Controls.Add(btnGas);
            Controls.Add(btnBreak);
            Controls.Add(btnOnOff);
            Load += Form1_Load;

            pnlSky.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPlane).EndInit();
            ResumeLayout(false);
        }

        private void ConfigOrange(Button b, string text, int top, int _)
        {
            b.Text = text;
            b.BackColor = Color.FromArgb(255, 128, 0);
            b.ForeColor = Color.Black;
            b.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            b.Location = new Point(300, top);
            b.Size = new Size(400, 55);
            b.FlatStyle = FlatStyle.Flat;
        }

        private Panel pnlSky;
        private PictureBox pbLight;
        private PictureBox pbPlane;
        private Button btnEnis;
        private Button btnTurbulans;
        private Button btnKemerler;
        private Button btnTesekkur;
        private Button btnBeep;
        private Button btnGas;
        private Button btnBreak;
        private Button btnOnOff;
        private System.Windows.Forms.Timer timerFly;
    }
}
