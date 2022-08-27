namespace ArabaOdev
{
    public partial class Form1 : Form
    {
        Araba ArabaOdev = new Araba();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Araba";
            lbSonuc.Text = "";
        }

        private void btKaydet_Click(object sender, EventArgs e)
        {
            ArabaOdev.Id = Convert.ToInt32(nudId.Value);
            ArabaOdev.Marka = tbMarka.Text.Trim();
            ArabaOdev.Model = tbModel.Text.Trim();
            ArabaOdev.KapiSayisi = Convert.ToByte(ddlKapiSayisi.Text.Remove(ddlKapiSayisi.Text.Length - 7));
            ArabaOdev.BeygirGucu = Convert.ToInt16(nudBeygirGucu.Value);
            ArabaOdev.ArabaTuru = ddlArabaTuru.Text;
            ArabaOdev.MaksimumHiz = Convert.ToInt16(nudMaksimumHiz.Value);
            ArabaOdev.Cekis = ddlCekis.Text;
            ArabaOdev.SifirdanYuzeYukselme = Convert.ToByte(nudSifirdanYuzeHizlanma.Value);
            ArabaOdev.Agirlik = Convert.ToInt16(nudAgirlik.Value);
            ArabaOdev.MotorHacmi = Convert.ToDouble(nudMotorHacmi.Value);

            MessageBox.Show("Araba oluþturuldu.");


        }

        private void btGoster_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = "Id:" + ArabaOdev.Id + "\n"
                + "Marka:" + ArabaOdev.Marka + "\n"
                + "Model:" + ArabaOdev.Model + "\n"
                + "Kapý Sayýsý:" + ArabaOdev.KapiSayisi + "\n"
                + "Beygir Gücü:" + ArabaOdev.BeygirGucu + "\n"
                + "Araba Türü:" + ArabaOdev.ArabaTuru + "\n"
                + "Maksimum Hýz:" + ArabaOdev.MaksimumHiz + "\n"
                + "Çekiþ:" + ArabaOdev.Cekis + "\n"
                + "Sýfýrdan Yüze Hýzlanma:" + ArabaOdev.SifirdanYuzeYukselme + "\n"
                + "Aðýrlýk:" + ArabaOdev.Agirlik + "\n"
                + "Motor hacmi:" + ArabaOdev.MotorHacmi;
                


                }
    }
}