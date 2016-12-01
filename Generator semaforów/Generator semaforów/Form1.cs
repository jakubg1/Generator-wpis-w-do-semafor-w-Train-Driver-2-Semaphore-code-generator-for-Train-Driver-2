using System;
using System.Windows.Forms;

namespace Generator_semaforów
{
    public partial class Okno : Form
    {

        // wpisywanie wartości
        private String debug;

        public Okno()
        {
            InitializeComponent();
        }

        #region sprawdzanie kontrolek (wciskanie/wybieranie czegoś w oknie)

        // sprawdzanie jaka opcja jest zaznaczona, listy
        private void typsem_SelectedIndexChanged(object sender, EventArgs e)
        {
            typsemafora = TextBoxTypSemafora.SelectedIndex;
        }

        private void k1_SelectedIndexChanged(object sender, EventArgs e)
        {
            komora1 = TextBoxKomora1.SelectedIndex;
        }

        private void k2_SelectedIndexChanged(object sender, EventArgs e)
        {
            komora2 = TextBoxKomora2.SelectedIndex;
        }

        private void k3_SelectedIndexChanged(object sender, EventArgs e)
        {
            komora3 = TextBoxKomora3.SelectedIndex;
        }

        private void k4_SelectedIndexChanged(object sender, EventArgs e)
        {
            komora4 = TextBoxKomora4.SelectedIndex;
        }

        private void k5_SelectedIndexChanged(object sender, EventArgs e)
        {
            komora5 = TextBoxKomora5.SelectedIndex;
        }

        // sprawdzanie czy coś jest zaznaczone, radiobuttony
        private void kolpowt1_CheckedChanged(object sender, EventArgs e)
        {
            if (KolejnoscPowtarzacza1.Checked == true) kolejnoscpowtarzacza = 0;
            else if (KolejnoscPowtarzacza2.Checked == true) kolejnoscpowtarzacza = 1;
            else kolejnoscpowtarzacza = 2;
        }

        private void kolpowt2_CheckedChanged(object sender, EventArgs e)
        {
            if (KolejnoscPowtarzacza1.Checked == true) kolejnoscpowtarzacza = 0;
            else if (KolejnoscPowtarzacza2.Checked == true) kolejnoscpowtarzacza = 1;
            else kolejnoscpowtarzacza = 2;
        }

        private void kolpowt3_CheckedChanged(object sender, EventArgs e)
        {
            if (KolejnoscPowtarzacza1.Checked == true) kolejnoscpowtarzacza = 0;
            else if (KolejnoscPowtarzacza2.Checked == true) kolejnoscpowtarzacza = 1;
            else kolejnoscpowtarzacza = 2;
        }

        private void osl1_CheckedChanged(object sender, EventArgs e)
        {
            if (OdchylenieSlupa1.Checked == true) odchylsemafora = 0;
            else if (OdchylenieSlupa2.Checked == true) odchylsemafora = 1;
            else odchylsemafora = 2;
        }

        private void osl2_CheckedChanged(object sender, EventArgs e)
        {
            if (OdchylenieSlupa1.Checked == true) odchylsemafora = 0;
            else if (OdchylenieSlupa2.Checked == true) odchylsemafora = 1;
            else odchylsemafora = 2;
        }

        private void osl3_CheckedChanged(object sender, EventArgs e)
        {
            if (OdchylenieSlupa1.Checked == true) odchylsemafora = 0;
            else if (OdchylenieSlupa2.Checked == true) odchylsemafora = 1;
            else odchylsemafora = 2;
        }

        private void wstnot_CheckedChanged(object sender, EventArgs e)
        {
            if (WstawianieNotatnik.Checked == true) wst = 0;
            else wst = 1;
        }

        private void wstedyt_CheckedChanged(object sender, EventArgs e)
        {
            if (WstawianieNotatnik.Checked == true) wst = 0;
            else wst = 1;
        }

        // sprawdzanie czy coś jest zaznaczone, checkboxy
        private void wskw1_CheckedChanged(object sender, EventArgs e)
        {
            w1 = WskaznikW1.Checked;
        }

        private void wskw18_CheckedChanged(object sender, EventArgs e)
        {
            w18 = WskaznikW18.Checked;
        }

        private void wskw19_CheckedChanged(object sender, EventArgs e)
        {
            w19 = WskaznikW19.Checked;
        }

        private void wskw20_CheckedChanged(object sender, EventArgs e)
        {
            w20 = WskaznikW20.Checked;
        }

        private void wskw24_CheckedChanged(object sender, EventArgs e)
        {
            w24 = WskaznikW24.Checked;
        }

        private void opckarz_CheckedChanged(object sender, EventArgs e)
        {
            karzelk = OpcjonalnyKarzelkowy.Checked;
        }

        private void opcuniew_CheckedChanged(object sender, EventArgs e)
        {
            uniew = OpcjonalnyUniewazniony.Checked;
        }

        private void paspomaranczowy_CheckedChanged(object sender, EventArgs e)
        {
            ppom = PasPomaranczowy.Checked;
        }

        private void paszielony_CheckedChanged(object sender, EventArgs e)
        {
            pziel = PasZielony.Checked;
        }

        // wyświetlanie możliwych sygnałów przez semafor
        private void sygnalywysw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // nieużywane
        private void okno_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void polekodu_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region liczniki

        // typ semafora
        // 0 - semafor
        // 1 - tarcza ostrzegawcza
        // 2 - powtarzacz
        // 3 - tarcza manewrowa
        // 4 - semafor SBL
        int typsemafora = 0;

        // kolejność powtarzacza
        // 0 - ISp
        // 1 - IISp
        // 2 - IIISp
        int kolejnoscpowtarzacza = 0;

        // odchylenie semafora
        // 0 - lewo
        // 1 - prosto
        // 2 - prawo
        int odchylsemafora = 0;

        // miejsce wstawienia kodu
        // 0 - notatnik
        // 1 - edytor
        int wst = 0;

        // wskaźniki
        bool w1 = false;
        bool w18 = false;
        bool w19 = false;
        bool w20 = false;
        bool w24 = false;

        // opcje dodatkowe
        bool karzelk = false;
        bool uniew = false;

        // pasy
        bool ppom = false;
        bool pziel = false;

        // komory
        // 0 - brak
        // 1 - niebieska
        // 2 - zielona
        // 3 - pomarańczowa - odn. do n. sem.
        // 4 - pomarańczowa - ograniczenie prędkości
        // 5 - czerwona
        // 6 - biała
        int komora1 = 0;
        int komora2 = 0;
        int komora3 = 0;
        int komora4 = 0;
        int komora5 = 0;

        #endregion

        #region debugowanie

        // wyświetlanie
        private void debugger_Click(object sender, EventArgs e)
        {
            debug = "Debugowanie:\r\ntypsemafora = " + typsemafora + "\r\nkolejnoscpowtarzacza = " + kolejnoscpowtarzacza + "\r\nodchylsemafora = " + odchylsemafora + "\r\nwst = " + wst + "\r\nw1 = " + w1 + "\r\nw18 = " + w18 + "\r\nw19 = " + w19 + "\r\nw20 = " + w20 + "\r\nw24 = " + w24 + "\r\nkarzelk = " + karzelk + "\r\nuniew = " + uniew + "\r\nppom = " + ppom + "\r\npziel = " + pziel + "\r\nkomora1 = " + komora1 + "\r\nkomora2 = " + komora2 + "\r\nkomora3 = " + komora3 + "\r\nkomora4 = " + komora4 + "\r\nkomora5 = " + komora5;
            debugger.Text = debug;
        }

        #endregion

    }
}
