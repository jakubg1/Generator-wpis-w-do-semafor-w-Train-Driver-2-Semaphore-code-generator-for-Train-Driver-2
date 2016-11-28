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
            if (w1 == false) w1 = true;
            if (w1 == true) w1 = false;
        }

        private void wskw18_CheckedChanged(object sender, EventArgs e)
        {
            if (w18 == false) w18 = true;
            if (w18 == true) w18 = false;
        }

        private void wskw19_CheckedChanged(object sender, EventArgs e)
        {
            if (w19 == false) w19 = true;
            if (w19 == true) w19 = false;
        }

        private void wskw20_CheckedChanged(object sender, EventArgs e)
        {
            if (w20 == false) w20 = true;
            if (w20 == true) w20 = false;
        }

        private void wskw24_CheckedChanged(object sender, EventArgs e)
        {
            if (w24 == false) w24 = true;
            if (w24 == true) w24 = false;
        }

        private void opckarz_CheckedChanged(object sender, EventArgs e)
        {
            if (karzelk == false) karzelk = true;
            if (karzelk == true) karzelk = false;
        }

        private void opcuniew_CheckedChanged(object sender, EventArgs e)
        {
            if (uniew == false) uniew = true;
            if (uniew == true) uniew = false;
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
            debug = "Debugowanie:\r\n" + typsemafora;
            debugger.Text = debug;
        }

        #endregion
    }
}
