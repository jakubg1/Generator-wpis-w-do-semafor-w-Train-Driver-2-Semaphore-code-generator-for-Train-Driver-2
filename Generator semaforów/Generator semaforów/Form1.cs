using System;
using System.Windows.Forms;

namespace Generator_semaforów
{
    public partial class okno : Form
    {

        // wpisywanie wartości
        private String debug;

        public okno()
        {
            InitializeComponent();
        }

        #region sprawdzanie kontrolek (wciskanie/wybieranie czegoś w oknie)

        // typ semafora
        private void typsem_SelectedIndexChanged(object sender, EventArgs e)
        {
            typsemafora = typsem.SelectedIndex;
        }

        // sprawdzanie czy coś jest zaznaczone, radiobuttony
        private void kolpowt1_CheckedChanged(object sender, EventArgs e)
        {
            kolejnoscpowtarzacza = 1;
        }

        private void kolpowt2_CheckedChanged(object sender, EventArgs e)
        {
            kolejnoscpowtarzacza = 2;
        }

        private void kolpowt3_CheckedChanged(object sender, EventArgs e)
        {
            kolejnoscpowtarzacza = 3;
        }

        private void odchsl1_CheckedChanged(object sender, EventArgs e)
        {
            odchylsemafora = -1;
        }

        private void odchsl2_CheckedChanged(object sender, EventArgs e)
        {
            odchylsemafora = 0;
        }

        private void odchsl3_CheckedChanged(object sender, EventArgs e)
        {
            odchylsemafora = 1;
        }


        // sprawdzanie czy coś jest zaznaczone, checkboxy
        private void wskw1_CheckedChanged(object sender, EventArgs e)
        {
            w1 = wskw1.Checked;
        }

        private void wskw18_CheckedChanged(object sender, EventArgs e)
        {
            w18 = wskw18.Checked;
        }

        private void wskw19_CheckedChanged(object sender, EventArgs e)
        {
            w19 = wskw19.Checked;
        }

        private void wskw20_CheckedChanged(object sender, EventArgs e)
        {
            w20 = wskw20.Checked;
        }

        private void wskw24_CheckedChanged(object sender, EventArgs e)
        {
            w24 = wskw24.Checked;
        }

        private void opckarz_CheckedChanged(object sender, EventArgs e)
        {
            karzelk = opckarz.Checked;
        }

        private void opcuniew_CheckedChanged(object sender, EventArgs e)
        {
            uniew = opcuniew.Checked;
        }

        private void paspomaranczowy_CheckedChanged(object sender, EventArgs e)
        {
            ppom = paspomaranczowy.Checked;
        }

        private void paszielony_CheckedChanged(object sender, EventArgs e)
        {
            pziel = paszielony.Checked;
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
        // 1 - ISp
        // 2 - IISp
        // 3 - IIISp
        int kolejnoscpowtarzacza = 1;

        // odchylenie semafora
        // -1 - lewo
        // 0 - prosto
        // 1 - prawo
        int odchylsemafora = -1;

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
            debug = "Debugowanie:\r\ntypsemafora = " + typsemafora + "\r\nkolejnoscpowtarzacza = " + kolejnoscpowtarzacza + "\r\nodchylsemafora = " + odchylsemafora + "\r\nw1 = " + w1 + "\r\nw18 = " + w18 + "\r\nw19 = " + w19 + "\r\nw20 = " + w20 + "\r\nw24 = " + w24 + "\r\nkarzelk = " + karzelk + "\r\nuniew = " + uniew + "\r\nppom = " + ppom + "\r\npziel = " + pziel + "\r\nkomora1 = " + komora1 + "\r\nkomora2 = " + komora2 + "\r\nkomora3 = " + komora3 + "\r\nkomora4 = " + komora4 + "\r\nkomora5 = " + komora5;
            debugger.Text = debug;
        }

        #endregion
    }
}
