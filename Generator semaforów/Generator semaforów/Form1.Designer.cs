namespace Generator_semaforów
{
    partial class Okno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno));
            this.labelTypSemafora = new System.Windows.Forms.Label();
            this.TextBoxTypSemafora = new System.Windows.Forms.ComboBox();
            this.KolejnoscPowtarzacza1 = new System.Windows.Forms.RadioButton();
            this.KolejnoscPowtarzacza2 = new System.Windows.Forms.RadioButton();
            this.KolejnoscPowtarzacza3 = new System.Windows.Forms.RadioButton();
            this.labelOdchylenieSlupa = new System.Windows.Forms.Label();
            this.labelKolejnoscPowtarzacza = new System.Windows.Forms.Label();
            this.RadioGroupKolejnoscPowtarzacza = new System.Windows.Forms.Panel();
            this.RadioGroupOdchylenieSlupa = new System.Windows.Forms.Panel();
            this.OdchylenieSlupa1 = new System.Windows.Forms.RadioButton();
            this.OdchylenieSlupa2 = new System.Windows.Forms.RadioButton();
            this.OdchylenieSlupa3 = new System.Windows.Forms.RadioButton();
            this.labelWskazniki = new System.Windows.Forms.Label();
            this.WskaznikW1 = new System.Windows.Forms.CheckBox();
            this.WskaznikW18 = new System.Windows.Forms.CheckBox();
            this.WskaznikW19 = new System.Windows.Forms.CheckBox();
            this.WskaznikW20 = new System.Windows.Forms.CheckBox();
            this.WskaznikW24 = new System.Windows.Forms.CheckBox();
            this.labelOpcjeDodatkowe = new System.Windows.Forms.Label();
            this.OpcjonalnyKarzelkowy = new System.Windows.Forms.CheckBox();
            this.OpcjonalnyUniewazniony = new System.Windows.Forms.CheckBox();
            this.labelKomora1 = new System.Windows.Forms.Label();
            this.labelKomora2 = new System.Windows.Forms.Label();
            this.labelKomora3 = new System.Windows.Forms.Label();
            this.labelKomora4 = new System.Windows.Forms.Label();
            this.labelKomora5 = new System.Windows.Forms.Label();
            this.TextBoxKomora1 = new System.Windows.Forms.ComboBox();
            this.TextBoxKomora2 = new System.Windows.Forms.ComboBox();
            this.TextBoxKomora3 = new System.Windows.Forms.ComboBox();
            this.TextBoxKomora4 = new System.Windows.Forms.ComboBox();
            this.TextBoxKomora5 = new System.Windows.Forms.ComboBox();
            this.debugger = new System.Windows.Forms.Label();
            this.labelPasSwietlny = new System.Windows.Forms.Label();
            this.PasPomaranczowy = new System.Windows.Forms.CheckBox();
            this.PasZielony = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RadioGroupMiejsceWstawiania = new System.Windows.Forms.Panel();
            this.WstawianieEdytor = new System.Windows.Forms.RadioButton();
            this.WstawianieNotatnik = new System.Windows.Forms.RadioButton();
            this.Generuj = new System.Windows.Forms.Button();
            this.PoleKodu = new System.Windows.Forms.TextBox();
            this.labelPodglad = new System.Windows.Forms.Label();
            this.labelSygnaly = new System.Windows.Forms.Label();
            this.SygnalyWyswietlane = new System.Windows.Forms.ListBox();
            this.labelKomoraWedlugPredkosci = new System.Windows.Forms.Label();
            this.labelPredkoscNaTymSemaforze = new System.Windows.Forms.Label();
            this.Predkosc40 = new System.Windows.Forms.CheckBox();
            this.Predkosc100 = new System.Windows.Forms.CheckBox();
            this.Predkosc60 = new System.Windows.Forms.CheckBox();
            this.labelPredkoscNaNastepnymSemaforze = new System.Windows.Forms.Label();
            this.Predkosc40Lub60 = new System.Windows.Forms.CheckBox();
            this.Predkosc100LubMax = new System.Windows.Forms.CheckBox();
            this.KomoraBiala = new System.Windows.Forms.CheckBox();
            this.Konfiguruj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RadioGroupKolejnoscPowtarzacza.SuspendLayout();
            this.RadioGroupOdchylenieSlupa.SuspendLayout();
            this.RadioGroupMiejsceWstawiania.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTypSemafora
            // 
            this.labelTypSemafora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypSemafora.Location = new System.Drawing.Point(12, 14);
            this.labelTypSemafora.Name = "labelTypSemafora";
            this.labelTypSemafora.Size = new System.Drawing.Size(131, 20);
            this.labelTypSemafora.TabIndex = 0;
            this.labelTypSemafora.Text = "Typ semafora:";
            this.labelTypSemafora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxTypSemafora
            // 
            this.TextBoxTypSemafora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxTypSemafora.FormattingEnabled = true;
            this.TextBoxTypSemafora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxTypSemafora.IntegralHeight = false;
            this.TextBoxTypSemafora.Items.AddRange(new object[] {
            "Semafor",
            "T. ostrzegawcza",
            "Powtarzacz",
            "T. manewrowa",
            "Semafor SBL"});
            this.TextBoxTypSemafora.Location = new System.Drawing.Point(16, 37);
            this.TextBoxTypSemafora.Name = "TextBoxTypSemafora";
            this.TextBoxTypSemafora.Size = new System.Drawing.Size(127, 27);
            this.TextBoxTypSemafora.TabIndex = 1;
            this.TextBoxTypSemafora.SelectedIndexChanged += new System.EventHandler(this.TypSemafora_SelectedIndexChanged);
            // 
            // KolejnoscPowtarzacza1
            // 
            this.KolejnoscPowtarzacza1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KolejnoscPowtarzacza1.Location = new System.Drawing.Point(6, 3);
            this.KolejnoscPowtarzacza1.Name = "KolejnoscPowtarzacza1";
            this.KolejnoscPowtarzacza1.Size = new System.Drawing.Size(128, 25);
            this.KolejnoscPowtarzacza1.TabIndex = 3;
            this.KolejnoscPowtarzacza1.Text = "ISp";
            this.KolejnoscPowtarzacza1.UseVisualStyleBackColor = true;
            this.KolejnoscPowtarzacza1.CheckedChanged += new System.EventHandler(this.KolejnoscPowtarzacza1_CheckedChanged);
            // 
            // KolejnoscPowtarzacza2
            // 
            this.KolejnoscPowtarzacza2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KolejnoscPowtarzacza2.Location = new System.Drawing.Point(6, 34);
            this.KolejnoscPowtarzacza2.Name = "KolejnoscPowtarzacza2";
            this.KolejnoscPowtarzacza2.Size = new System.Drawing.Size(131, 25);
            this.KolejnoscPowtarzacza2.TabIndex = 4;
            this.KolejnoscPowtarzacza2.Text = "IISp";
            this.KolejnoscPowtarzacza2.UseVisualStyleBackColor = true;
            this.KolejnoscPowtarzacza2.CheckedChanged += new System.EventHandler(this.KolejnoscPowtarzacza2_CheckedChanged);
            // 
            // KolejnoscPowtarzacza3
            // 
            this.KolejnoscPowtarzacza3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KolejnoscPowtarzacza3.Location = new System.Drawing.Point(6, 65);
            this.KolejnoscPowtarzacza3.Name = "KolejnoscPowtarzacza3";
            this.KolejnoscPowtarzacza3.Size = new System.Drawing.Size(131, 25);
            this.KolejnoscPowtarzacza3.TabIndex = 5;
            this.KolejnoscPowtarzacza3.Text = "IIISp";
            this.KolejnoscPowtarzacza3.UseVisualStyleBackColor = true;
            this.KolejnoscPowtarzacza3.CheckedChanged += new System.EventHandler(this.KolejnoscPowtarzacza3_CheckedChanged);
            // 
            // labelOdchylenieSlupa
            // 
            this.labelOdchylenieSlupa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdchylenieSlupa.Location = new System.Drawing.Point(12, 189);
            this.labelOdchylenieSlupa.Name = "labelOdchylenieSlupa";
            this.labelOdchylenieSlupa.Size = new System.Drawing.Size(131, 20);
            this.labelOdchylenieSlupa.TabIndex = 6;
            this.labelOdchylenieSlupa.Text = "Odchylenie słupa:";
            this.labelOdchylenieSlupa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKolejnoscPowtarzacza
            // 
            this.labelKolejnoscPowtarzacza.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKolejnoscPowtarzacza.Location = new System.Drawing.Point(14, 70);
            this.labelKolejnoscPowtarzacza.Name = "labelKolejnoscPowtarzacza";
            this.labelKolejnoscPowtarzacza.Size = new System.Drawing.Size(129, 20);
            this.labelKolejnoscPowtarzacza.TabIndex = 2;
            this.labelKolejnoscPowtarzacza.Text = "Kol. powtarzacza:";
            this.labelKolejnoscPowtarzacza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioGroupKolejnoscPowtarzacza
            // 
            this.RadioGroupKolejnoscPowtarzacza.Controls.Add(this.KolejnoscPowtarzacza1);
            this.RadioGroupKolejnoscPowtarzacza.Controls.Add(this.KolejnoscPowtarzacza2);
            this.RadioGroupKolejnoscPowtarzacza.Controls.Add(this.KolejnoscPowtarzacza3);
            this.RadioGroupKolejnoscPowtarzacza.Location = new System.Drawing.Point(16, 93);
            this.RadioGroupKolejnoscPowtarzacza.Name = "RadioGroupKolejnoscPowtarzacza";
            this.RadioGroupKolejnoscPowtarzacza.Size = new System.Drawing.Size(131, 93);
            this.RadioGroupKolejnoscPowtarzacza.TabIndex = 10;
            // 
            // RadioGroupOdchylenieSlupa
            // 
            this.RadioGroupOdchylenieSlupa.Controls.Add(this.OdchylenieSlupa1);
            this.RadioGroupOdchylenieSlupa.Controls.Add(this.OdchylenieSlupa2);
            this.RadioGroupOdchylenieSlupa.Controls.Add(this.OdchylenieSlupa3);
            this.RadioGroupOdchylenieSlupa.Location = new System.Drawing.Point(16, 213);
            this.RadioGroupOdchylenieSlupa.Name = "RadioGroupOdchylenieSlupa";
            this.RadioGroupOdchylenieSlupa.Size = new System.Drawing.Size(131, 102);
            this.RadioGroupOdchylenieSlupa.TabIndex = 11;
            // 
            // OdchylenieSlupa1
            // 
            this.OdchylenieSlupa1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdchylenieSlupa1.Location = new System.Drawing.Point(6, 6);
            this.OdchylenieSlupa1.Name = "OdchylenieSlupa1";
            this.OdchylenieSlupa1.Size = new System.Drawing.Size(125, 25);
            this.OdchylenieSlupa1.TabIndex = 3;
            this.OdchylenieSlupa1.Text = "Lewo";
            this.OdchylenieSlupa1.UseVisualStyleBackColor = true;
            this.OdchylenieSlupa1.CheckedChanged += new System.EventHandler(this.OdchylenieSlupa1_CheckedChanged);
            // 
            // OdchylenieSlupa2
            // 
            this.OdchylenieSlupa2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdchylenieSlupa2.Location = new System.Drawing.Point(6, 37);
            this.OdchylenieSlupa2.Name = "OdchylenieSlupa2";
            this.OdchylenieSlupa2.Size = new System.Drawing.Size(125, 25);
            this.OdchylenieSlupa2.TabIndex = 4;
            this.OdchylenieSlupa2.Text = "Prosto";
            this.OdchylenieSlupa2.UseVisualStyleBackColor = true;
            this.OdchylenieSlupa2.CheckedChanged += new System.EventHandler(this.OdchylenieSlupa2_CheckedChanged);
            // 
            // OdchylenieSlupa3
            // 
            this.OdchylenieSlupa3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdchylenieSlupa3.Location = new System.Drawing.Point(6, 68);
            this.OdchylenieSlupa3.Name = "OdchylenieSlupa3";
            this.OdchylenieSlupa3.Size = new System.Drawing.Size(125, 25);
            this.OdchylenieSlupa3.TabIndex = 5;
            this.OdchylenieSlupa3.Text = "Prawo";
            this.OdchylenieSlupa3.UseVisualStyleBackColor = true;
            this.OdchylenieSlupa3.CheckedChanged += new System.EventHandler(this.OdchylenieSlupa3_CheckedChanged);
            // 
            // labelWskazniki
            // 
            this.labelWskazniki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWskazniki.Location = new System.Drawing.Point(149, 14);
            this.labelWskazniki.Name = "labelWskazniki";
            this.labelWskazniki.Size = new System.Drawing.Size(129, 20);
            this.labelWskazniki.TabIndex = 12;
            this.labelWskazniki.Text = "Wskaźniki:";
            this.labelWskazniki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WskaznikW1
            // 
            this.WskaznikW1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WskaznikW1.Location = new System.Drawing.Point(153, 37);
            this.WskaznikW1.Name = "WskaznikW1";
            this.WskaznikW1.Size = new System.Drawing.Size(125, 25);
            this.WskaznikW1.TabIndex = 13;
            this.WskaznikW1.Text = "W1";
            this.WskaznikW1.UseVisualStyleBackColor = true;
            this.WskaznikW1.CheckedChanged += new System.EventHandler(this.WskaznikW1_CheckedChanged);
            // 
            // WskaznikW18
            // 
            this.WskaznikW18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WskaznikW18.Location = new System.Drawing.Point(153, 68);
            this.WskaznikW18.Name = "WskaznikW18";
            this.WskaznikW18.Size = new System.Drawing.Size(125, 25);
            this.WskaznikW18.TabIndex = 14;
            this.WskaznikW18.Text = "W18";
            this.WskaznikW18.UseVisualStyleBackColor = true;
            this.WskaznikW18.CheckedChanged += new System.EventHandler(this.WskaznikW18_CheckedChanged);
            // 
            // WskaznikW19
            // 
            this.WskaznikW19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WskaznikW19.Location = new System.Drawing.Point(153, 99);
            this.WskaznikW19.Name = "WskaznikW19";
            this.WskaznikW19.Size = new System.Drawing.Size(125, 25);
            this.WskaznikW19.TabIndex = 15;
            this.WskaznikW19.Text = "W19";
            this.WskaznikW19.UseVisualStyleBackColor = true;
            this.WskaznikW19.CheckedChanged += new System.EventHandler(this.WskaznikW19_CheckedChanged);
            // 
            // WskaznikW20
            // 
            this.WskaznikW20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WskaznikW20.Location = new System.Drawing.Point(153, 130);
            this.WskaznikW20.Name = "WskaznikW20";
            this.WskaznikW20.Size = new System.Drawing.Size(125, 25);
            this.WskaznikW20.TabIndex = 16;
            this.WskaznikW20.Text = "W20";
            this.WskaznikW20.UseVisualStyleBackColor = true;
            this.WskaznikW20.CheckedChanged += new System.EventHandler(this.WskaznikW20_CheckedChanged);
            // 
            // WskaznikW24
            // 
            this.WskaznikW24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WskaznikW24.Location = new System.Drawing.Point(153, 161);
            this.WskaznikW24.Name = "WskaznikW24";
            this.WskaznikW24.Size = new System.Drawing.Size(125, 25);
            this.WskaznikW24.TabIndex = 17;
            this.WskaznikW24.Text = "W24";
            this.WskaznikW24.UseVisualStyleBackColor = true;
            this.WskaznikW24.CheckedChanged += new System.EventHandler(this.WskaznikW24_CheckedChanged);
            // 
            // labelOpcjeDodatkowe
            // 
            this.labelOpcjeDodatkowe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpcjeDodatkowe.Location = new System.Drawing.Point(149, 189);
            this.labelOpcjeDodatkowe.Name = "labelOpcjeDodatkowe";
            this.labelOpcjeDodatkowe.Size = new System.Drawing.Size(129, 20);
            this.labelOpcjeDodatkowe.TabIndex = 18;
            this.labelOpcjeDodatkowe.Text = "Opcje dodatkowe:";
            this.labelOpcjeDodatkowe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpcjonalnyKarzelkowy
            // 
            this.OpcjonalnyKarzelkowy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpcjonalnyKarzelkowy.Location = new System.Drawing.Point(153, 212);
            this.OpcjonalnyKarzelkowy.Name = "OpcjonalnyKarzelkowy";
            this.OpcjonalnyKarzelkowy.Size = new System.Drawing.Size(125, 25);
            this.OpcjonalnyKarzelkowy.TabIndex = 19;
            this.OpcjonalnyKarzelkowy.Text = "Karzełkowy";
            this.OpcjonalnyKarzelkowy.UseVisualStyleBackColor = true;
            this.OpcjonalnyKarzelkowy.CheckedChanged += new System.EventHandler(this.OpcjonalnyKarzeklowy_CheckedChanged);
            // 
            // OpcjonalnyUniewazniony
            // 
            this.OpcjonalnyUniewazniony.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpcjonalnyUniewazniony.Location = new System.Drawing.Point(153, 243);
            this.OpcjonalnyUniewazniony.Name = "OpcjonalnyUniewazniony";
            this.OpcjonalnyUniewazniony.Size = new System.Drawing.Size(125, 25);
            this.OpcjonalnyUniewazniony.TabIndex = 20;
            this.OpcjonalnyUniewazniony.Text = "Unieważniony";
            this.OpcjonalnyUniewazniony.UseVisualStyleBackColor = true;
            this.OpcjonalnyUniewazniony.CheckedChanged += new System.EventHandler(this.OpcjonalnyUniewazniony_CheckedChanged);
            // 
            // labelKomora1
            // 
            this.labelKomora1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKomora1.Location = new System.Drawing.Point(284, 14);
            this.labelKomora1.Name = "labelKomora1";
            this.labelKomora1.Size = new System.Drawing.Size(80, 20);
            this.labelKomora1.TabIndex = 21;
            this.labelKomora1.Text = "Komora 1:";
            this.labelKomora1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKomora2
            // 
            this.labelKomora2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKomora2.Location = new System.Drawing.Point(284, 39);
            this.labelKomora2.Name = "labelKomora2";
            this.labelKomora2.Size = new System.Drawing.Size(80, 20);
            this.labelKomora2.TabIndex = 22;
            this.labelKomora2.Text = "Komora 2:";
            this.labelKomora2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKomora3
            // 
            this.labelKomora3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKomora3.Location = new System.Drawing.Point(284, 65);
            this.labelKomora3.Name = "labelKomora3";
            this.labelKomora3.Size = new System.Drawing.Size(80, 20);
            this.labelKomora3.TabIndex = 23;
            this.labelKomora3.Text = "Komora 3:";
            this.labelKomora3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKomora4
            // 
            this.labelKomora4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKomora4.Location = new System.Drawing.Point(284, 90);
            this.labelKomora4.Name = "labelKomora4";
            this.labelKomora4.Size = new System.Drawing.Size(80, 20);
            this.labelKomora4.TabIndex = 24;
            this.labelKomora4.Text = "Komora 4:";
            this.labelKomora4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKomora5
            // 
            this.labelKomora5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKomora5.Location = new System.Drawing.Point(284, 115);
            this.labelKomora5.Name = "labelKomora5";
            this.labelKomora5.Size = new System.Drawing.Size(80, 20);
            this.labelKomora5.TabIndex = 25;
            this.labelKomora5.Text = "Komora 5:";
            this.labelKomora5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxKomora1
            // 
            this.TextBoxKomora1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxKomora1.FormattingEnabled = true;
            this.TextBoxKomora1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxKomora1.IntegralHeight = false;
            this.TextBoxKomora1.Items.AddRange(new object[] {
            "(brak)",
            "Niebieskie",
            "Zielone",
            "Pomarańczowe (odn. do nast. sem.)",
            "Pomarańczowe (ogr. prędkości)",
            "Czerwone",
            "Białe"});
            this.TextBoxKomora1.Location = new System.Drawing.Point(370, 12);
            this.TextBoxKomora1.Name = "TextBoxKomora1";
            this.TextBoxKomora1.Size = new System.Drawing.Size(240, 27);
            this.TextBoxKomora1.TabIndex = 26;
            this.TextBoxKomora1.SelectedIndexChanged += new System.EventHandler(this.Komora1_SelectedIndexChanged);
            // 
            // TextBoxKomora2
            // 
            this.TextBoxKomora2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxKomora2.FormattingEnabled = true;
            this.TextBoxKomora2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxKomora2.IntegralHeight = false;
            this.TextBoxKomora2.Items.AddRange(new object[] {
            "(brak)",
            "Niebieskie",
            "Zielone",
            "Pomarańczowe (odn. do nast. sem.)",
            "Pomarańczowe (ogr. prędkości)",
            "Czerwone",
            "Białe"});
            this.TextBoxKomora2.Location = new System.Drawing.Point(370, 37);
            this.TextBoxKomora2.Name = "TextBoxKomora2";
            this.TextBoxKomora2.Size = new System.Drawing.Size(240, 27);
            this.TextBoxKomora2.TabIndex = 27;
            this.TextBoxKomora2.SelectedIndexChanged += new System.EventHandler(this.Komora2_SelectedIndexChanged);
            // 
            // TextBoxKomora3
            // 
            this.TextBoxKomora3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxKomora3.FormattingEnabled = true;
            this.TextBoxKomora3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxKomora3.IntegralHeight = false;
            this.TextBoxKomora3.Items.AddRange(new object[] {
            "(brak)",
            "Niebieskie",
            "Zielone",
            "Pomarańczowe (odn. do nast. sem.)",
            "Pomarańczowe (ogr. prędkości)",
            "Czerwone",
            "Białe"});
            this.TextBoxKomora3.Location = new System.Drawing.Point(370, 63);
            this.TextBoxKomora3.Name = "TextBoxKomora3";
            this.TextBoxKomora3.Size = new System.Drawing.Size(240, 27);
            this.TextBoxKomora3.TabIndex = 28;
            this.TextBoxKomora3.SelectedIndexChanged += new System.EventHandler(this.Komora3_SelectedIndexChanged);
            // 
            // TextBoxKomora4
            // 
            this.TextBoxKomora4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxKomora4.FormattingEnabled = true;
            this.TextBoxKomora4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxKomora4.IntegralHeight = false;
            this.TextBoxKomora4.Items.AddRange(new object[] {
            "(brak)",
            "Niebieskie",
            "Zielone",
            "Pomarańczowe (odn. do nast. sem.)",
            "Pomarańczowe (ogr. prędkości)",
            "Czerwone",
            "Białe"});
            this.TextBoxKomora4.Location = new System.Drawing.Point(370, 88);
            this.TextBoxKomora4.Name = "TextBoxKomora4";
            this.TextBoxKomora4.Size = new System.Drawing.Size(240, 27);
            this.TextBoxKomora4.TabIndex = 29;
            this.TextBoxKomora4.SelectedIndexChanged += new System.EventHandler(this.Komora4_SelectedIndexChanged);
            // 
            // TextBoxKomora5
            // 
            this.TextBoxKomora5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxKomora5.FormattingEnabled = true;
            this.TextBoxKomora5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxKomora5.IntegralHeight = false;
            this.TextBoxKomora5.Items.AddRange(new object[] {
            "(brak)",
            "Niebieskie",
            "Zielone",
            "Pomarańczowe (odn. do nast. sem.)",
            "Pomarańczowe (ogr. prędkości)",
            "Czerwone",
            "Białe"});
            this.TextBoxKomora5.Location = new System.Drawing.Point(370, 113);
            this.TextBoxKomora5.Name = "TextBoxKomora5";
            this.TextBoxKomora5.Size = new System.Drawing.Size(240, 27);
            this.TextBoxKomora5.TabIndex = 30;
            this.TextBoxKomora5.SelectedIndexChanged += new System.EventHandler(this.Komora5_SelectedIndexChanged);
            // 
            // debugger
            // 
            this.debugger.AutoSize = true;
            this.debugger.Location = new System.Drawing.Point(617, 37);
            this.debugger.Name = "debugger";
            this.debugger.Size = new System.Drawing.Size(41, 13);
            this.debugger.TabIndex = 31;
            this.debugger.Text = "label11";
            this.debugger.Click += new System.EventHandler(this.debugger_Click);
            // 
            // labelPasSwietlny
            // 
            this.labelPasSwietlny.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasSwietlny.Location = new System.Drawing.Point(284, 147);
            this.labelPasSwietlny.Name = "labelPasSwietlny";
            this.labelPasSwietlny.Size = new System.Drawing.Size(89, 20);
            this.labelPasSwietlny.TabIndex = 32;
            this.labelPasSwietlny.Text = "Pas świetlny:";
            this.labelPasSwietlny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasPomaranczowy
            // 
            this.PasPomaranczowy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasPomaranczowy.Location = new System.Drawing.Point(370, 146);
            this.PasPomaranczowy.Name = "PasPomaranczowy";
            this.PasPomaranczowy.Size = new System.Drawing.Size(132, 25);
            this.PasPomaranczowy.TabIndex = 33;
            this.PasPomaranczowy.Text = "Pomarańczowy";
            this.PasPomaranczowy.UseVisualStyleBackColor = true;
            this.PasPomaranczowy.CheckedChanged += new System.EventHandler(this.PasPomaranczowy_CheckedChanged);
            // 
            // PasZielony
            // 
            this.PasZielony.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasZielony.Location = new System.Drawing.Point(508, 146);
            this.PasZielony.Name = "PasZielony";
            this.PasZielony.Size = new System.Drawing.Size(102, 25);
            this.PasZielony.TabIndex = 34;
            this.PasZielony.Text = "Zielony";
            this.PasZielony.UseVisualStyleBackColor = true;
            this.PasZielony.CheckedChanged += new System.EventHandler(this.PasZielony_CheckedChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(284, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Miejsce wst.:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioGroupMiejsceWstawiania
            // 
            this.RadioGroupMiejsceWstawiania.Controls.Add(this.WstawianieEdytor);
            this.RadioGroupMiejsceWstawiania.Controls.Add(this.WstawianieNotatnik);
            this.RadioGroupMiejsceWstawiania.Location = new System.Drawing.Point(284, 214);
            this.RadioGroupMiejsceWstawiania.Name = "RadioGroupMiejsceWstawiania";
            this.RadioGroupMiejsceWstawiania.Size = new System.Drawing.Size(96, 63);
            this.RadioGroupMiejsceWstawiania.TabIndex = 36;
            // 
            // WstawianieEdytor
            // 
            this.WstawianieEdytor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WstawianieEdytor.Location = new System.Drawing.Point(4, 30);
            this.WstawianieEdytor.Name = "WstawianieEdytor";
            this.WstawianieEdytor.Size = new System.Drawing.Size(82, 25);
            this.WstawianieEdytor.TabIndex = 7;
            this.WstawianieEdytor.Text = "Edytor";
            this.WstawianieEdytor.UseVisualStyleBackColor = true;
            this.WstawianieEdytor.CheckedChanged += new System.EventHandler(this.WstawianieEdytor_CheckedChanged);
            // 
            // WstawianieNotatnik
            // 
            this.WstawianieNotatnik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WstawianieNotatnik.Location = new System.Drawing.Point(4, -1);
            this.WstawianieNotatnik.Name = "WstawianieNotatnik";
            this.WstawianieNotatnik.Size = new System.Drawing.Size(82, 25);
            this.WstawianieNotatnik.TabIndex = 6;
            this.WstawianieNotatnik.Text = "Notatnik";
            this.WstawianieNotatnik.UseVisualStyleBackColor = true;
            this.WstawianieNotatnik.CheckedChanged += new System.EventHandler(this.WstawianieNotatnik_CheckedChanged);
            // 
            // Generuj
            // 
            this.Generuj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Generuj.Location = new System.Drawing.Point(370, 199);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(240, 52);
            this.Generuj.TabIndex = 37;
            this.Generuj.Text = "Generuj";
            this.Generuj.UseVisualStyleBackColor = true;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // PoleKodu
            // 
            this.PoleKodu.Location = new System.Drawing.Point(370, 287);
            this.PoleKodu.Name = "PoleKodu";
            this.PoleKodu.Size = new System.Drawing.Size(240, 20);
            this.PoleKodu.TabIndex = 38;
            this.PoleKodu.TextChanged += new System.EventHandler(this.PoleKodu_TextChanged);
            // 
            // labelPodglad
            // 
            this.labelPodglad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPodglad.Location = new System.Drawing.Point(616, 14);
            this.labelPodglad.Name = "labelPodglad";
            this.labelPodglad.Size = new System.Drawing.Size(89, 20);
            this.labelPodglad.TabIndex = 39;
            this.labelPodglad.Text = "Podgląd:";
            this.labelPodglad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSygnaly
            // 
            this.labelSygnaly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSygnaly.Location = new System.Drawing.Point(711, 14);
            this.labelSygnaly.Name = "labelSygnaly";
            this.labelSygnaly.Size = new System.Drawing.Size(89, 20);
            this.labelSygnaly.TabIndex = 40;
            this.labelSygnaly.Text = "Sygnały:";
            this.labelSygnaly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SygnalyWyswietlane
            // 
            this.SygnalyWyswietlane.FormattingEnabled = true;
            this.SygnalyWyswietlane.Location = new System.Drawing.Point(715, 37);
            this.SygnalyWyswietlane.Name = "SygnalyWyswietlane";
            this.SygnalyWyswietlane.Size = new System.Drawing.Size(85, 277);
            this.SygnalyWyswietlane.TabIndex = 41;
            this.SygnalyWyswietlane.SelectedIndexChanged += new System.EventHandler(this.SygnalyWyswietlane_SelectedIndexChanged);
            // 
            // labelKomoraWedlugPredkosci
            // 
            this.labelKomoraWedlugPredkosci.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKomoraWedlugPredkosci.Location = new System.Drawing.Point(833, 14);
            this.labelKomoraWedlugPredkosci.Name = "labelKomoraWedlugPredkosci";
            this.labelKomoraWedlugPredkosci.Size = new System.Drawing.Size(220, 20);
            this.labelKomoraWedlugPredkosci.TabIndex = 42;
            this.labelKomoraWedlugPredkosci.Text = "Komory wg prędkości";
            this.labelKomoraWedlugPredkosci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPredkoscNaTymSemaforze
            // 
            this.labelPredkoscNaTymSemaforze.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPredkoscNaTymSemaforze.Location = new System.Drawing.Point(833, 38);
            this.labelPredkoscNaTymSemaforze.Name = "labelPredkoscNaTymSemaforze";
            this.labelPredkoscNaTymSemaforze.Size = new System.Drawing.Size(220, 20);
            this.labelPredkoscNaTymSemaforze.TabIndex = 43;
            this.labelPredkoscNaTymSemaforze.Text = "Prędkość na tym semaforze";
            this.labelPredkoscNaTymSemaforze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Predkosc40
            // 
            this.Predkosc40.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Predkosc40.Location = new System.Drawing.Point(837, 64);
            this.Predkosc40.Name = "Predkosc40";
            this.Predkosc40.Size = new System.Drawing.Size(50, 25);
            this.Predkosc40.TabIndex = 44;
            this.Predkosc40.Text = "40";
            this.Predkosc40.UseVisualStyleBackColor = true;
            this.Predkosc40.CheckedChanged += new System.EventHandler(this.Predkosc40_CheckedChanged);
            // 
            // Predkosc100
            // 
            this.Predkosc100.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Predkosc100.Location = new System.Drawing.Point(949, 64);
            this.Predkosc100.Name = "Predkosc100";
            this.Predkosc100.Size = new System.Drawing.Size(59, 25);
            this.Predkosc100.TabIndex = 45;
            this.Predkosc100.Text = "100";
            this.Predkosc100.UseVisualStyleBackColor = true;
            this.Predkosc100.CheckedChanged += new System.EventHandler(this.Predkosc100_CheckedChanged);
            // 
            // Predkosc60
            // 
            this.Predkosc60.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Predkosc60.Location = new System.Drawing.Point(893, 64);
            this.Predkosc60.Name = "Predkosc60";
            this.Predkosc60.Size = new System.Drawing.Size(50, 25);
            this.Predkosc60.TabIndex = 46;
            this.Predkosc60.Text = "60";
            this.Predkosc60.UseVisualStyleBackColor = true;
            this.Predkosc60.CheckedChanged += new System.EventHandler(this.Predkosc60_CheckedChanged);
            // 
            // labelPredkoscNaNastepnymSemaforze
            // 
            this.labelPredkoscNaNastepnymSemaforze.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPredkoscNaNastepnymSemaforze.Location = new System.Drawing.Point(833, 92);
            this.labelPredkoscNaNastepnymSemaforze.Name = "labelPredkoscNaNastepnymSemaforze";
            this.labelPredkoscNaNastepnymSemaforze.Size = new System.Drawing.Size(220, 20);
            this.labelPredkoscNaNastepnymSemaforze.TabIndex = 47;
            this.labelPredkoscNaNastepnymSemaforze.Text = "Prędkość na następnym semaforze";
            this.labelPredkoscNaNastepnymSemaforze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Predkosc40Lub60
            // 
            this.Predkosc40Lub60.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Predkosc40Lub60.Location = new System.Drawing.Point(837, 115);
            this.Predkosc40Lub60.Name = "Predkosc40Lub60";
            this.Predkosc40Lub60.Size = new System.Drawing.Size(87, 25);
            this.Predkosc40Lub60.TabIndex = 48;
            this.Predkosc40Lub60.Text = "40/60";
            this.Predkosc40Lub60.UseVisualStyleBackColor = true;
            this.Predkosc40Lub60.CheckedChanged += new System.EventHandler(this.Predkosc40Lub60_CheckedChanged);
            // 
            // Predkosc100LubMax
            // 
            this.Predkosc100LubMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Predkosc100LubMax.Location = new System.Drawing.Point(927, 115);
            this.Predkosc100LubMax.Name = "Predkosc100LubMax";
            this.Predkosc100LubMax.Size = new System.Drawing.Size(92, 25);
            this.Predkosc100LubMax.TabIndex = 49;
            this.Predkosc100LubMax.Text = "100/Vmax";
            this.Predkosc100LubMax.UseVisualStyleBackColor = true;
            this.Predkosc100LubMax.CheckedChanged += new System.EventHandler(this.Predkosc100LubMax_CheckedChanged);
            // 
            // KomoraBiala
            // 
            this.KomoraBiala.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KomoraBiala.Location = new System.Drawing.Point(837, 146);
            this.KomoraBiala.Name = "KomoraBiala";
            this.KomoraBiala.Size = new System.Drawing.Size(120, 25);
            this.KomoraBiala.TabIndex = 50;
            this.KomoraBiala.Text = "Komora biała";
            this.KomoraBiala.UseVisualStyleBackColor = true;
            this.KomoraBiala.CheckedChanged += new System.EventHandler(this.KomoraBiala_CheckedChanged);
            // 
            // Konfiguruj
            // 
            this.Konfiguruj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Konfiguruj.Location = new System.Drawing.Point(837, 177);
            this.Konfiguruj.Name = "Konfiguruj";
            this.Konfiguruj.Size = new System.Drawing.Size(216, 52);
            this.Konfiguruj.TabIndex = 51;
            this.Konfiguruj.Text = "Konfiguruj";
            this.Konfiguruj.UseVisualStyleBackColor = true;
            this.Konfiguruj.Click += new System.EventHandler(this.Konfiguruj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 28);
            this.button1.TabIndex = 52;
            this.button1.Text = "testujRysowanie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1073, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Konfiguruj);
            this.Controls.Add(this.KomoraBiala);
            this.Controls.Add(this.Predkosc100LubMax);
            this.Controls.Add(this.Predkosc40Lub60);
            this.Controls.Add(this.labelPredkoscNaNastepnymSemaforze);
            this.Controls.Add(this.Predkosc60);
            this.Controls.Add(this.Predkosc100);
            this.Controls.Add(this.Predkosc40);
            this.Controls.Add(this.labelPredkoscNaTymSemaforze);
            this.Controls.Add(this.labelKomoraWedlugPredkosci);
            this.Controls.Add(this.SygnalyWyswietlane);
            this.Controls.Add(this.labelSygnaly);
            this.Controls.Add(this.labelPodglad);
            this.Controls.Add(this.PoleKodu);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.RadioGroupMiejsceWstawiania);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PasZielony);
            this.Controls.Add(this.PasPomaranczowy);
            this.Controls.Add(this.labelPasSwietlny);
            this.Controls.Add(this.debugger);
            this.Controls.Add(this.TextBoxKomora5);
            this.Controls.Add(this.TextBoxKomora4);
            this.Controls.Add(this.TextBoxKomora3);
            this.Controls.Add(this.TextBoxKomora2);
            this.Controls.Add(this.TextBoxKomora1);
            this.Controls.Add(this.labelKomora5);
            this.Controls.Add(this.labelKomora4);
            this.Controls.Add(this.labelKomora3);
            this.Controls.Add(this.labelKomora2);
            this.Controls.Add(this.labelKomora1);
            this.Controls.Add(this.OpcjonalnyUniewazniony);
            this.Controls.Add(this.OpcjonalnyKarzelkowy);
            this.Controls.Add(this.labelOpcjeDodatkowe);
            this.Controls.Add(this.WskaznikW24);
            this.Controls.Add(this.WskaznikW20);
            this.Controls.Add(this.WskaznikW19);
            this.Controls.Add(this.WskaznikW18);
            this.Controls.Add(this.WskaznikW1);
            this.Controls.Add(this.labelWskazniki);
            this.Controls.Add(this.RadioGroupOdchylenieSlupa);
            this.Controls.Add(this.RadioGroupKolejnoscPowtarzacza);
            this.Controls.Add(this.labelOdchylenieSlupa);
            this.Controls.Add(this.labelKolejnoscPowtarzacza);
            this.Controls.Add(this.TextBoxTypSemafora);
            this.Controls.Add(this.labelTypSemafora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Okno";
            this.Text = "Generator wpisów semaforów do TD2 - wersja 3.0.0";
            this.RadioGroupKolejnoscPowtarzacza.ResumeLayout(false);
            this.RadioGroupOdchylenieSlupa.ResumeLayout(false);
            this.RadioGroupMiejsceWstawiania.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypSemafora;
        private System.Windows.Forms.Label labelKolejnoscPowtarzacza;
        private System.Windows.Forms.Label labelOdchylenieSlupa;
        private System.Windows.Forms.Label labelWskazniki;
        private System.Windows.Forms.Label labelOpcjeDodatkowe;
        private System.Windows.Forms.ComboBox TextBoxTypSemafora;
        private System.Windows.Forms.Panel RadioGroupKolejnoscPowtarzacza;
        private System.Windows.Forms.RadioButton KolejnoscPowtarzacza1;
        private System.Windows.Forms.RadioButton KolejnoscPowtarzacza2;
        private System.Windows.Forms.RadioButton KolejnoscPowtarzacza3;
        private System.Windows.Forms.Panel RadioGroupOdchylenieSlupa;
        private System.Windows.Forms.RadioButton OdchylenieSlupa1;
        private System.Windows.Forms.RadioButton OdchylenieSlupa2;
        private System.Windows.Forms.RadioButton OdchylenieSlupa3;
        private System.Windows.Forms.CheckBox WskaznikW1;
        private System.Windows.Forms.CheckBox WskaznikW18;
        private System.Windows.Forms.CheckBox WskaznikW19;
        private System.Windows.Forms.CheckBox WskaznikW20;
        private System.Windows.Forms.CheckBox WskaznikW24;
        private System.Windows.Forms.CheckBox OpcjonalnyKarzelkowy;
        private System.Windows.Forms.CheckBox OpcjonalnyUniewazniony;
        private System.Windows.Forms.Label labelKomora1;
        private System.Windows.Forms.Label labelKomora2;
        private System.Windows.Forms.Label labelKomora3;
        private System.Windows.Forms.Label labelKomora4;
        private System.Windows.Forms.Label labelKomora5;
        private System.Windows.Forms.ComboBox TextBoxKomora1;
        private System.Windows.Forms.ComboBox TextBoxKomora2;
        private System.Windows.Forms.ComboBox TextBoxKomora3;
        private System.Windows.Forms.ComboBox TextBoxKomora4;
        private System.Windows.Forms.ComboBox TextBoxKomora5;
        private System.Windows.Forms.Label debugger;
        private System.Windows.Forms.Label labelPasSwietlny;
        private System.Windows.Forms.CheckBox PasPomaranczowy;
        private System.Windows.Forms.CheckBox PasZielony;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel RadioGroupMiejsceWstawiania;
        private System.Windows.Forms.RadioButton WstawianieEdytor;
        private System.Windows.Forms.RadioButton WstawianieNotatnik;
        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.TextBox PoleKodu;
        private System.Windows.Forms.Label labelPodglad;
        private System.Windows.Forms.Label labelSygnaly;
        private System.Windows.Forms.ListBox SygnalyWyswietlane;
        private System.Windows.Forms.Label labelKomoraWedlugPredkosci;
        private System.Windows.Forms.Label labelPredkoscNaTymSemaforze;
        private System.Windows.Forms.CheckBox Predkosc40;
        private System.Windows.Forms.CheckBox Predkosc100;
        private System.Windows.Forms.CheckBox Predkosc60;
        private System.Windows.Forms.Label labelPredkoscNaNastepnymSemaforze;
        private System.Windows.Forms.CheckBox Predkosc40Lub60;
        private System.Windows.Forms.CheckBox Predkosc100LubMax;
        private System.Windows.Forms.CheckBox KomoraBiala;
        private System.Windows.Forms.Button Konfiguruj;
        private System.Windows.Forms.Button button1;
    }
}