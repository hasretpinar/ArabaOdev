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

            MessageBox.Show("Araba olu�turuldu.");


        }

        private void btGoster_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = "Id:" + ArabaOdev.Id + "\n"
                + "Marka:" + ArabaOdev.Marka + "\n"
                + "Model:" + ArabaOdev.Model + "\n"
                + "Kap� Say�s�:" + ArabaOdev.KapiSayisi + "\n"
                + "Beygir G�c�:" + ArabaOdev.BeygirGucu + "\n"
                + "Araba T�r�:" + ArabaOdev.ArabaTuru + "\n"
                + "Maksimum H�z:" + ArabaOdev.MaksimumHiz + "\n"
                + "�eki�:" + ArabaOdev.Cekis + "\n"
                + "S�f�rdan Y�ze H�zlanma:" + ArabaOdev.SifirdanYuzeYukselme + "\n"
                + "A��rl�k:" + ArabaOdev.Agirlik + "\n"
                + "Motor hacmi:" + ArabaOdev.MotorHacmi;
                


                }
    }
}