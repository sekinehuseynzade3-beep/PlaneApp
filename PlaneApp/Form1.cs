using System.Media;

namespace PlaneApp
{
    public partial class Form1 : Form
    {
        private SoundPlayer player;
        private bool lightOn = true;
        private int speed = 0;          // GAS basılanda artır
        private const int MaxSpeed = 15;

        private string SesYolu(string fayl) =>
            Path.Combine(Application.StartupPath, "Sesler", fayl);
        private string SekilYolu(string fayl) =>
            Path.Combine(Application.StartupPath, "Sekiller", fayl);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pbPlane.Image = Image.FromFile(SekilYolu("teyyare.png"));
                pbLight.Image = Image.FromFile(SekilYolu("isiq.png"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şəkil tapılmadı: " + ex.Message);
            }
        }

        // Verilən səs faylını çalır (əvvəlki səsi dayandırıb)
        private void SesCal(string fayl)
        {
            try
            {
                player?.Stop();
                player = new SoundPlayer(SesYolu(fayl));
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Səs faylı tapılmadı: " + ex.Message);
            }
        }

        private void btnEnis_Click(object sender, EventArgs e) => SesCal("inishazirliklari.wav");
        private void btnTurbulans_Click(object sender, EventArgs e) => SesCal("turbulans.wav");
        private void btnKemerler_Click(object sender, EventArgs e) => SesCal("kemerler.wav");
        private void btnTesekkur_Click(object sender, EventArgs e) => SesCal("tesekkurler.wav");
        private void btnBeep_Click(object sender, EventArgs e) => SesCal("bip.wav");

        // ON/OFF: işığı yandırıb söndürür və uyğun səsi çalır
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            lightOn = !lightOn;
            pbLight.Visible = lightOn;
            SesCal("isikacmakapamasesi.wav");
        }

        // GAS: təyyarə irəli (yuxarı) hərəkət edir
        private void btnGas_Click(object sender, EventArgs e)
        {
            if (speed < MaxSpeed) speed += 3;
            timerFly.Start();
        }

        // Break: sürət azalır və təyyarə dayanır
        private void btnBreak_Click(object sender, EventArgs e)
        {
            speed = 0;
            timerFly.Stop();
        }

        private void timerFly_Tick(object sender, EventArgs e)
        {
            pbPlane.Top -= speed;
            pbLight.Top -= speed;

            // Ekrandan çıxanda aşağıdan yenidən başlasın
            if (pbPlane.Bottom < 0)
            {
                pbPlane.Top = pnlSky.Height;
                pbLight.Top = pbPlane.Top - 30;
            }
        }
    }
}
