namespace sinemauygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinema salon;

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
                label3.Text = "Salon Oluşturuldu. Koltuk Sayısı " + salon.BosKoLltukOgren();
            }
            catch
            {
                label3.Text = "Salon Oluşturulamadı. Bilgileri kontrol ediniz! ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salon.BiletSat(checkBox1.Checked);
            label3.Text = "Bilet Satıldı. Boş Koltuk Sayısı " + salon.BosKoLltukOgren();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            salon.BiletIpral(checkBox1.Checked);
            label3.Text = "Bilet İptal Edildi " + salon.BosKoLltukOgren();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Şu anki Bakiye ; " + salon.BakiyeOgren();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "ŞU anki Boş Koltuk Sayısı " + salon.BosKoLltukOgren();
        }
    }
}
