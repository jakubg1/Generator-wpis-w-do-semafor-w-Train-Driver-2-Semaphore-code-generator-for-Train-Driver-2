﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Generator_semaforów
{
    public partial class Okno : Form
    {

        #region liczniki i zmienne

        // wpisywanie wartości
        private string debug;

        // typ semafora
        // 0 - semafor
        // 1 - tarcza ostrzegawcza
        // 2 - powtarzacz
        // 3 - tarcza manewrowa
        // 4 - semafor SBL
        private int typsemafora;

        // kolejność powtarzacza
        // 0 - ISp
        // 1 - IISp
        // 2 - IIISp
        private int kolejnoscpowtarzacza;

        // odchylenie semafora
        // 0 - lewo
        // 1 - prosto
        // 2 - prawo
        private int odchylsemafora;

        // miejsce wstawienia kodu
        // 0 - notatnik
        // 1 - edytor
        private int wst;

        // wskaźniki
        private bool w1;
        private bool w18;
        private bool w19;
        private bool w20;
        private bool w24;

        // opcje dodatkowe
        private bool karzelk;
        private bool uniew;

        // pasy
        private bool ppom;
        private bool pziel;

        // komory
        // 0 - brak
        // 1 - niebieska
        // 2 - zielona
        // 3 - pomarańczowa - odn. do n. sem.
        // 4 - pomarańczowa - ograniczenie prędkości
        // 5 - czerwona
        // 6 - biała
        private int komora1;
        private int komora2;
        private int komora3;
        private int komora4;
        private int komora5;

        //predkosci na semaforach
        private bool predkosc40;
        private bool predkosc60;
        private bool predkosc100;
        private bool predkosc40na60;
        private bool predkosc100naVmax;
        private bool komoraBiala;

        #endregion

        #region konstruktor - przypisanie startowych wartosci licznikom i zmiennym
        public Okno()
        {

            typsemafora = 0;
            kolejnoscpowtarzacza = 0;
            odchylsemafora = 0;
            wst = 0;
            w1 = false;
            w18 = false;
            w19 = false;
            w20 = false;
            w24 = false;
            karzelk = false;
            uniew = false;
            ppom = false;
            pziel = false;
            komora1 = 0;
            komora2 = 0;
            komora3 = 0;
            komora4 = 0;
            komora5 = 0;
            predkosc40 = false;
            predkosc60 = false;
            predkosc100 = false;
            predkosc40na60 = false;
            predkosc100naVmax = false;
            komoraBiala = false;
           
            InitializeComponent();

            TextBoxTypSemafora.SelectedIndex = TextBoxTypSemafora.FindStringExact("Semafor");
            TextBoxKomora1.SelectedIndex = TextBoxKomora1.FindStringExact("(brak)");
            TextBoxKomora2.SelectedIndex = TextBoxKomora2.FindStringExact("(brak)");
            TextBoxKomora3.SelectedIndex = TextBoxKomora3.FindStringExact("(brak)");
            TextBoxKomora4.SelectedIndex = TextBoxKomora4.FindStringExact("(brak)");
            TextBoxKomora5.SelectedIndex = TextBoxKomora5.FindStringExact("(brak)");

            
        }
        #endregion

        #region sprawdzanie kontrolek (wciskanie/wybieranie czegoś w oknie)

        // sprawdzanie jaka opcja jest zaznaczona, listy
        private void TypSemafora_SelectedIndexChanged(object sender, EventArgs e)
        {
            typsemafora = TextBoxTypSemafora.SelectedIndex;
        }

        private void Komora1_SelectedIndexChanged(object sender, EventArgs e)
        {
            komora1 = TextBoxKomora1.SelectedIndex;
        }

        private void Komora2_SelectedIndexChanged(object sender, EventArgs e)
        {
            komora2 = TextBoxKomora2.SelectedIndex;
        }

        private void Komora3_SelectedIndexChanged(object sender, EventArgs e)
        {
            komora3 = TextBoxKomora3.SelectedIndex;
        }

        private void Komora4_SelectedIndexChanged(object sender, EventArgs e)
        {
            komora4 = TextBoxKomora4.SelectedIndex;
        }

        private void Komora5_SelectedIndexChanged(object sender, EventArgs e)
        {
            komora5 = TextBoxKomora5.SelectedIndex;
        }

        // sprawdzanie czy coś jest zaznaczone, radiobuttony
        private void KolejnoscPowtarzacza1_CheckedChanged(object sender, EventArgs e)
        {
            if (KolejnoscPowtarzacza1.Checked == true) kolejnoscpowtarzacza = 0;
            else if (KolejnoscPowtarzacza2.Checked == true) kolejnoscpowtarzacza = 1;
            else kolejnoscpowtarzacza = 2;
        }

        private void KolejnoscPowtarzacza2_CheckedChanged(object sender, EventArgs e)
        {
            if (KolejnoscPowtarzacza1.Checked == true) kolejnoscpowtarzacza = 0;
            else if (KolejnoscPowtarzacza2.Checked == true) kolejnoscpowtarzacza = 1;
            else kolejnoscpowtarzacza = 2;
        }

        private void KolejnoscPowtarzacza3_CheckedChanged(object sender, EventArgs e)
        {
            if (KolejnoscPowtarzacza1.Checked == true) kolejnoscpowtarzacza = 0;
            else if (KolejnoscPowtarzacza2.Checked == true) kolejnoscpowtarzacza = 1;
            else kolejnoscpowtarzacza = 2;
        }

        private void OdchylenieSlupa1_CheckedChanged(object sender, EventArgs e)
        {
            if (OdchylenieSlupa1.Checked == true) odchylsemafora = 0;
            else if (OdchylenieSlupa2.Checked == true) odchylsemafora = 1;
            else odchylsemafora = 2;
        }

        private void OdchylenieSlupa2_CheckedChanged(object sender, EventArgs e)
        {
            if (OdchylenieSlupa1.Checked == true) odchylsemafora = 0;
            else if (OdchylenieSlupa2.Checked == true) odchylsemafora = 1;
            else odchylsemafora = 2;
        }

        private void OdchylenieSlupa3_CheckedChanged(object sender, EventArgs e)
        {
            if (OdchylenieSlupa1.Checked == true) odchylsemafora = 0;
            else if (OdchylenieSlupa2.Checked == true) odchylsemafora = 1;
            else odchylsemafora = 2;
        }

        private void WstawianieNotatnik_CheckedChanged(object sender, EventArgs e)
        {
            if (WstawianieNotatnik.Checked == true) wst = 0;
            else wst = 1;
        }

        private void WstawianieEdytor_CheckedChanged(object sender, EventArgs e)
        {
            if (WstawianieNotatnik.Checked == true) wst = 0;
            else wst = 1;
        }

        // sprawdzanie czy coś jest zaznaczone, checkboxy
        private void WskaznikW1_CheckedChanged(object sender, EventArgs e)
        {
            w1 = WskaznikW1.Checked;
        }

        private void WskaznikW18_CheckedChanged(object sender, EventArgs e)
        {
            w18 = WskaznikW18.Checked;
        }

        private void WskaznikW19_CheckedChanged(object sender, EventArgs e)
        {
            w19 = WskaznikW19.Checked;
        }

        private void WskaznikW20_CheckedChanged(object sender, EventArgs e)
        {
            w20 = WskaznikW20.Checked;
        }

        private void WskaznikW24_CheckedChanged(object sender, EventArgs e)
        {
            w24 = WskaznikW24.Checked;
        }

        private void OpcjonalnyKarzeklowy_CheckedChanged(object sender, EventArgs e)
        {
            karzelk = OpcjonalnyKarzelkowy.Checked;
        }

        private void OpcjonalnyUniewazniony_CheckedChanged(object sender, EventArgs e)
        {
            uniew = OpcjonalnyUniewazniony.Checked;
        }

        private void PasPomaranczowy_CheckedChanged(object sender, EventArgs e)
        {
            ppom = PasPomaranczowy.Checked;
        }

        private void PasZielony_CheckedChanged(object sender, EventArgs e)
        {
            pziel = PasZielony.Checked;
        }

        // wyświetlanie możliwych sygnałów przez semafor
        private void SygnalyWyswietlane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Predkosc40_CheckedChanged(object sender, EventArgs e)
        {
            predkosc40 = Predkosc40.Checked;
        }

        private void Predkosc60_CheckedChanged(object sender, EventArgs e)
        {
            predkosc60 = Predkosc60.Checked;
        }

        private void Predkosc100_CheckedChanged(object sender, EventArgs e)
        {
            predkosc100 = Predkosc100.Checked;
        }

        private void Predkosc40Lub60_CheckedChanged(object sender, EventArgs e)
        {
            predkosc40na60 = Predkosc40Lub60.Checked;
        }

        private void Predkosc100LubMax_CheckedChanged(object sender, EventArgs e)
        {
            predkosc100naVmax = Predkosc100LubMax.Checked;
        }

        private void KomoraBiala_CheckedChanged(object sender, EventArgs e)
        {
            komoraBiala = KomoraBiala.Checked;
        }

        // nieużywane
        private void PoleKodu_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region generowanie kodu

        private void Generuj_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region automatyczne konfigurowanie komór

        private void Konfiguruj_Click(object sender, EventArgs e)
        {
            if (predkosc40 == false) if (predkosc60 == false) if (predkosc100 == false) if (predkosc40na60 == false) if (predkosc100naVmax == false) if (komoraBiala == false) ;
        }

        #endregion

        #region debugowanie

        // wyświetlanie
        private void debugger_Click(object sender, EventArgs e)
        {
            debug = "Debugowanie:\r\ntypsemafora = " + typsemafora +
                    "\r\nkolejnoscpowtarzacza = " + kolejnoscpowtarzacza +
                    "\r\nodchylsemafora = " + odchylsemafora +
                    "\r\nwst = " + wst +
                    "\r\nw1 = " + w1 +
                    "\r\nw18 = " + w18 +
                    "\r\nw19 = " + w19 +
                    "\r\nw20 = " + w20 +
                    "\r\nw24 = " + w24 +
                    "\r\nkarzelk = " + karzelk +
                    "\r\nuniew = " + uniew +
                    "\r\nppom = " + ppom +
                    "\r\npziel = " + pziel +
                    "\r\nkomora1 = " + komora1 +
                    "\r\nkomora2 = " + komora2 +
                    "\r\nkomora3 = " + komora3 +
                    "\r\nkomora4 = " + komora4 +
                    "\r\nkomora5 = " + komora5 +
                    "\r\npredkosc40 = " + predkosc40 +
                    "\r\npredkosc60 = " + predkosc60 +
                    "\r\npredkosc100 = " + predkosc100 +
                    "\r\npredkosc40na60 = " + predkosc40na60 +
                    "\r\npredkosc100naVmax = " + predkosc100naVmax +
                    "\r\nkomoraBiala = " + komoraBiala;
            debugger.Text = debug;
            
        }

        #endregion

        #region rysowanie semaforu

        private void rysujSemafor(byte typ, byte komora1, byte komora2, byte komora3, byte komora4, byte komora5)
        {
            int startX = 25,
                startY = 325,
                width = 100,
                height = 200;


            Graphics kartka = CreateGraphics();
            SolidBrush pedzel = new SolidBrush(Color.White);
            Pen kredka = new Pen(Color.DarkBlue);

            //rysowanie bialego pola
            kartka.DrawRectangle(kredka, startX, startY, width, height);
            kartka.FillRectangle(pedzel, startX, startY, width, height);
            //rysowanie słupa
            int steps = 10;
            int widthScale = 4;
            int heightScale = height/(steps + 1);

            kredka = new Pen(Color.Black);
            for (int i = 1; i <= steps; i++)
            {
                if (i%2 == 1)
                {
                    pedzel = new SolidBrush(Color.White);
                }
                else
                {
                    pedzel = new SolidBrush(Color.Red);
                }
                kartka.DrawRectangle(kredka, width /2 , startY + (i * heightScale), widthScale, heightScale);
                kartka.FillRectangle(pedzel, width / 2 + 1, startY + (i * heightScale) - 1, widthScale, heightScale);
            }

            //generowanie losowego koloru dla testow, potem zmienimy na te z parametrow przekazanych do metody
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);

            kredka = new Pen(Color.Black);
            pedzel = new SolidBrush(Color.Black);

            //obudowa komór
            kartka.DrawRectangle(kredka, width / 2 + 5, startY  +  heightScale, 20, 75);
            kartka.FillRectangle(pedzel, width / 2 + 5, startY + heightScale, 20, 75);

            //rysowanie komór :)
            for (int i = 1; i < 5; i++)
            {
                randomGen.Next();
                randomColorName = names[randomGen.Next(names.Length)];
                randomColor = Color.FromKnownColor(randomColorName);

                pedzel = new SolidBrush(randomColor);

                kartka.DrawEllipse(kredka, width / 2 + 8, startY + (i * heightScale) + 2, 15, 15);
                kartka.FillEllipse(pedzel, width / 2 + 8, startY + (i * heightScale) + 2, 15, 15);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rysujSemafor(0, 0, 0, 0, 0, 0);
        }

        #endregion


    }
}