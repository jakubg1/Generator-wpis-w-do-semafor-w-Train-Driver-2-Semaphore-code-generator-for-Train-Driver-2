namespace Generator_semaforów
{
    partial class okno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(okno));
            this.label1 = new System.Windows.Forms.Label();
            this.typsem = new System.Windows.Forms.ComboBox();
            this.kolpowt1 = new System.Windows.Forms.RadioButton();
            this.kolpowt2 = new System.Windows.Forms.RadioButton();
            this.kolpowt3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kolpowt = new System.Windows.Forms.Panel();
            this.osl = new System.Windows.Forms.Panel();
            this.osl1 = new System.Windows.Forms.RadioButton();
            this.osl2 = new System.Windows.Forms.RadioButton();
            this.osl3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.wskw1 = new System.Windows.Forms.CheckBox();
            this.wskw18 = new System.Windows.Forms.CheckBox();
            this.wskw19 = new System.Windows.Forms.CheckBox();
            this.wskw20 = new System.Windows.Forms.CheckBox();
            this.wskw24 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.opckarz = new System.Windows.Forms.CheckBox();
            this.opcuniew = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.k1 = new System.Windows.Forms.ComboBox();
            this.k2 = new System.Windows.Forms.ComboBox();
            this.k3 = new System.Windows.Forms.ComboBox();
            this.k4 = new System.Windows.Forms.ComboBox();
            this.k5 = new System.Windows.Forms.ComboBox();
            this.debugger = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.paspomaranczowy = new System.Windows.Forms.CheckBox();
            this.paszielony = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wstedyt = new System.Windows.Forms.RadioButton();
            this.wstnot = new System.Windows.Forms.RadioButton();
            this.generuj = new System.Windows.Forms.Button();
            this.polekodu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.sygnalywysw = new System.Windows.Forms.ListBox();
            this.kolpowt.SuspendLayout();
            this.osl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Typ semafora:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // typsem
            // 
            this.typsem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typsem.FormattingEnabled = true;
            this.typsem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.typsem.IntegralHeight = false;
            this.typsem.Items.AddRange(new object[] {
            "Semafor",
            "T. ostrzegawcza",
            "Powtarzacz",
            "T. manewrowa",
            "Semafor SBL"});
            this.typsem.Location = new System.Drawing.Point(12, 32);
            this.typsem.Name = "typsem";
            this.typsem.Size = new System.Drawing.Size(120, 27);
            this.typsem.TabIndex = 1;
            this.typsem.SelectedIndexChanged += new System.EventHandler(this.typsem_SelectedIndexChanged);
            // 
            // kolpowt1
            // 
            this.kolpowt1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolpowt1.Location = new System.Drawing.Point(0, 0);
            this.kolpowt1.Name = "kolpowt1";
            this.kolpowt1.Size = new System.Drawing.Size(120, 25);
            this.kolpowt1.TabIndex = 3;
            this.kolpowt1.Text = "ISp";
            this.kolpowt1.UseVisualStyleBackColor = true;
            this.kolpowt1.CheckedChanged += new System.EventHandler(this.kolpowt1_CheckedChanged);
            // 
            // kolpowt2
            // 
            this.kolpowt2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolpowt2.Location = new System.Drawing.Point(0, 25);
            this.kolpowt2.Name = "kolpowt2";
            this.kolpowt2.Size = new System.Drawing.Size(120, 25);
            this.kolpowt2.TabIndex = 4;
            this.kolpowt2.Text = "IISp";
            this.kolpowt2.UseVisualStyleBackColor = true;
            this.kolpowt2.CheckedChanged += new System.EventHandler(this.kolpowt2_CheckedChanged);
            // 
            // kolpowt3
            // 
            this.kolpowt3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolpowt3.Location = new System.Drawing.Point(0, 50);
            this.kolpowt3.Name = "kolpowt3";
            this.kolpowt3.Size = new System.Drawing.Size(120, 25);
            this.kolpowt3.TabIndex = 5;
            this.kolpowt3.Text = "IIISp";
            this.kolpowt3.UseVisualStyleBackColor = true;
            this.kolpowt3.CheckedChanged += new System.EventHandler(this.kolpowt3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Odchylenie słupa:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kol. powtarzacza:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kolpowt
            // 
            this.kolpowt.Controls.Add(this.kolpowt1);
            this.kolpowt.Controls.Add(this.kolpowt2);
            this.kolpowt.Controls.Add(this.kolpowt3);
            this.kolpowt.Location = new System.Drawing.Point(12, 87);
            this.kolpowt.Name = "kolpowt";
            this.kolpowt.Size = new System.Drawing.Size(120, 75);
            this.kolpowt.TabIndex = 10;
            // 
            // osl
            // 
            this.osl.Controls.Add(this.osl1);
            this.osl.Controls.Add(this.osl2);
            this.osl.Controls.Add(this.osl3);
            this.osl.Location = new System.Drawing.Point(12, 186);
            this.osl.Name = "osl";
            this.osl.Size = new System.Drawing.Size(120, 75);
            this.osl.TabIndex = 11;
            // 
            // osl1
            // 
            this.osl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osl1.Location = new System.Drawing.Point(0, 0);
            this.osl1.Name = "osl1";
            this.osl1.Size = new System.Drawing.Size(120, 25);
            this.osl1.TabIndex = 3;
            this.osl1.Text = "Lewo";
            this.osl1.UseVisualStyleBackColor = true;
            // 
            // osl2
            // 
            this.osl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osl2.Location = new System.Drawing.Point(0, 25);
            this.osl2.Name = "osl2";
            this.osl2.Size = new System.Drawing.Size(120, 25);
            this.osl2.TabIndex = 4;
            this.osl2.Text = "Prosto";
            this.osl2.UseVisualStyleBackColor = true;
            // 
            // osl3
            // 
            this.osl3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osl3.Location = new System.Drawing.Point(0, 50);
            this.osl3.Name = "osl3";
            this.osl3.Size = new System.Drawing.Size(120, 25);
            this.osl3.TabIndex = 5;
            this.osl3.Text = "Prawo";
            this.osl3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(138, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Wskaźniki:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wskw1
            // 
            this.wskw1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wskw1.Location = new System.Drawing.Point(142, 32);
            this.wskw1.Name = "wskw1";
            this.wskw1.Size = new System.Drawing.Size(120, 25);
            this.wskw1.TabIndex = 13;
            this.wskw1.Text = "W1";
            this.wskw1.UseVisualStyleBackColor = true;
            this.wskw1.CheckedChanged += new System.EventHandler(this.wskw1_CheckedChanged);
            // 
            // wskw18
            // 
            this.wskw18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wskw18.Location = new System.Drawing.Point(142, 57);
            this.wskw18.Name = "wskw18";
            this.wskw18.Size = new System.Drawing.Size(120, 25);
            this.wskw18.TabIndex = 14;
            this.wskw18.Text = "W18";
            this.wskw18.UseVisualStyleBackColor = true;
            this.wskw18.CheckedChanged += new System.EventHandler(this.wskw18_CheckedChanged);
            // 
            // wskw19
            // 
            this.wskw19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wskw19.Location = new System.Drawing.Point(142, 82);
            this.wskw19.Name = "wskw19";
            this.wskw19.Size = new System.Drawing.Size(120, 25);
            this.wskw19.TabIndex = 15;
            this.wskw19.Text = "W19";
            this.wskw19.UseVisualStyleBackColor = true;
            this.wskw19.CheckedChanged += new System.EventHandler(this.wskw19_CheckedChanged);
            // 
            // wskw20
            // 
            this.wskw20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wskw20.Location = new System.Drawing.Point(142, 107);
            this.wskw20.Name = "wskw20";
            this.wskw20.Size = new System.Drawing.Size(120, 25);
            this.wskw20.TabIndex = 16;
            this.wskw20.Text = "W20";
            this.wskw20.UseVisualStyleBackColor = true;
            this.wskw20.CheckedChanged += new System.EventHandler(this.wskw20_CheckedChanged);
            // 
            // wskw24
            // 
            this.wskw24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wskw24.Location = new System.Drawing.Point(142, 132);
            this.wskw24.Name = "wskw24";
            this.wskw24.Size = new System.Drawing.Size(120, 25);
            this.wskw24.TabIndex = 17;
            this.wskw24.Text = "W24";
            this.wskw24.UseVisualStyleBackColor = true;
            this.wskw24.CheckedChanged += new System.EventHandler(this.wskw24_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(138, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Opcje dod.:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // opckarz
            // 
            this.opckarz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opckarz.Location = new System.Drawing.Point(142, 183);
            this.opckarz.Name = "opckarz";
            this.opckarz.Size = new System.Drawing.Size(120, 25);
            this.opckarz.TabIndex = 19;
            this.opckarz.Text = "Karzełkowy";
            this.opckarz.UseVisualStyleBackColor = true;
            this.opckarz.CheckedChanged += new System.EventHandler(this.opckarz_CheckedChanged);
            // 
            // opcuniew
            // 
            this.opcuniew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opcuniew.Location = new System.Drawing.Point(142, 208);
            this.opcuniew.Name = "opcuniew";
            this.opcuniew.Size = new System.Drawing.Size(120, 25);
            this.opcuniew.TabIndex = 20;
            this.opcuniew.Text = "Unieważniony";
            this.opcuniew.UseVisualStyleBackColor = true;
            this.opcuniew.CheckedChanged += new System.EventHandler(this.opcuniew_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(264, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Komora 1:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(264, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Komora 2:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(264, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Komora 3:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(264, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Komora 4:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(264, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Komora 5:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // k1
            // 
            this.k1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.k1.FormattingEnabled = true;
            this.k1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.k1.IntegralHeight = false;
            this.k1.Items.AddRange(new object[] {
            "(brak)",
            "Niebieskie",
            "Zielone",
            "Pomarańczowe (odn. do nast. sem.)",
            "Pomarańczowe (ogr. prędkości)",
            "Czerwone",
            "Białe"});
            this.k1.Location = new System.Drawing.Point(359, 7);
            this.k1.Name = "k1";
            this.k1.Size = new System.Drawing.Size(240, 27);
            this.k1.TabIndex = 26;
            this.k1.SelectedIndexChanged += new System.EventHandler(this.k1_SelectedIndexChanged);
            // 
            // k2
            // 
            this.k2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.k2.FormattingEnabled = true;
            this.k2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.k2.IntegralHeight = false;
            this.k2.Items.AddRange(new object[] {
            "(brak)",
            "Niebieskie",
            "Zielone",
            "Pomarańczowe (odn. do nast. sem.)",
            "Pomarańczowe (ogr. prędkości)",
            "Czerwone",
            "Białe"});
            this.k2.Location = new System.Drawing.Point(359, 40);
            this.k2.Name = "k2";
            this.k2.Size = new System.Drawing.Size(240, 27);
            this.k2.TabIndex = 27;
            this.k2.SelectedIndexChanged += new System.EventHandler(this.k2_SelectedIndexChanged);
            // 
            // k3
            // 
            this.k3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.k3.FormattingEnabled = true;
            this.k3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.k3.IntegralHeight = false;
            this.k3.Items.AddRange(new object[] {
            "(brak)",
            "Niebieskie",
            "Zielone",
            "Pomarańczowe (odn. do nast. sem.)",
            "Pomarańczowe (ogr. prędkości)",
            "Czerwone",
            "Białe"});
            this.k3.Location = new System.Drawing.Point(359, 73);
            this.k3.Name = "k3";
            this.k3.Size = new System.Drawing.Size(240, 27);
            this.k3.TabIndex = 28;
            this.k3.SelectedIndexChanged += new System.EventHandler(this.k3_SelectedIndexChanged);
            // 
            // k4
            // 
            this.k4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.k4.FormattingEnabled = true;
            this.k4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.k4.IntegralHeight = false;
            this.k4.Items.AddRange(new object[] {
            "(brak)",
            "Niebieskie",
            "Zielone",
            "Pomarańczowe (odn. do nast. sem.)",
            "Pomarańczowe (ogr. prędkości)",
            "Czerwone",
            "Białe"});
            this.k4.Location = new System.Drawing.Point(359, 106);
            this.k4.Name = "k4";
            this.k4.Size = new System.Drawing.Size(240, 27);
            this.k4.TabIndex = 29;
            this.k4.SelectedIndexChanged += new System.EventHandler(this.k4_SelectedIndexChanged);
            // 
            // k5
            // 
            this.k5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.k5.FormattingEnabled = true;
            this.k5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.k5.IntegralHeight = false;
            this.k5.Items.AddRange(new object[] {
            "(brak)",
            "Niebieskie",
            "Zielone",
            "Pomarańczowe (odn. do nast. sem.)",
            "Pomarańczowe (ogr. prędkości)",
            "Czerwone",
            "Białe"});
            this.k5.Location = new System.Drawing.Point(359, 139);
            this.k5.Name = "k5";
            this.k5.Size = new System.Drawing.Size(240, 27);
            this.k5.TabIndex = 30;
            this.k5.SelectedIndexChanged += new System.EventHandler(this.k5_SelectedIndexChanged);
            // 
            // debugger
            // 
            this.debugger.AutoSize = true;
            this.debugger.Location = new System.Drawing.Point(836, 7);
            this.debugger.Name = "debugger";
            this.debugger.Size = new System.Drawing.Size(41, 13);
            this.debugger.TabIndex = 31;
            this.debugger.Text = "label11";
            this.debugger.Click += new System.EventHandler(this.debugger_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(264, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Pas świetlny:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // paspomaranczowy
            // 
            this.paspomaranczowy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paspomaranczowy.Location = new System.Drawing.Point(359, 173);
            this.paspomaranczowy.Name = "paspomaranczowy";
            this.paspomaranczowy.Size = new System.Drawing.Size(120, 25);
            this.paspomaranczowy.TabIndex = 33;
            this.paspomaranczowy.Text = "Pomarańczow.";
            this.paspomaranczowy.UseVisualStyleBackColor = true;
            this.paspomaranczowy.CheckedChanged += new System.EventHandler(this.paspomaranczowy_CheckedChanged);
            // 
            // paszielony
            // 
            this.paszielony.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paszielony.Location = new System.Drawing.Point(479, 173);
            this.paszielony.Name = "paszielony";
            this.paszielony.Size = new System.Drawing.Size(120, 25);
            this.paszielony.TabIndex = 34;
            this.paszielony.Text = "Zielony";
            this.paszielony.UseVisualStyleBackColor = true;
            this.paszielony.CheckedChanged += new System.EventHandler(this.paszielony_CheckedChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(264, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Miejsce wst.:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wstedyt);
            this.panel1.Controls.Add(this.wstnot);
            this.panel1.Location = new System.Drawing.Point(268, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 50);
            this.panel1.TabIndex = 36;
            // 
            // wstedyt
            // 
            this.wstedyt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wstedyt.Location = new System.Drawing.Point(0, 25);
            this.wstedyt.Name = "wstedyt";
            this.wstedyt.Size = new System.Drawing.Size(82, 25);
            this.wstedyt.TabIndex = 7;
            this.wstedyt.Text = "Edytor";
            this.wstedyt.UseVisualStyleBackColor = true;
            this.wstedyt.CheckedChanged += new System.EventHandler(this.wstedyt_CheckedChanged);
            // 
            // wstnot
            // 
            this.wstnot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wstnot.Location = new System.Drawing.Point(0, 0);
            this.wstnot.Name = "wstnot";
            this.wstnot.Size = new System.Drawing.Size(82, 25);
            this.wstnot.TabIndex = 6;
            this.wstnot.Text = "Notatnik";
            this.wstnot.UseVisualStyleBackColor = true;
            this.wstnot.CheckedChanged += new System.EventHandler(this.wstnot_CheckedChanged);
            // 
            // generuj
            // 
            this.generuj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generuj.Location = new System.Drawing.Point(359, 200);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(240, 52);
            this.generuj.TabIndex = 37;
            this.generuj.Text = "Generuj";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // polekodu
            // 
            this.polekodu.Location = new System.Drawing.Point(359, 262);
            this.polekodu.Multiline = true;
            this.polekodu.Name = "polekodu";
            this.polekodu.Size = new System.Drawing.Size(240, 30);
            this.polekodu.TabIndex = 38;
            this.polekodu.TextChanged += new System.EventHandler(this.polekodu_TextChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(605, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Podgląd:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(700, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 40;
            this.label14.Text = "Sygnały:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // sygnalywysw
            // 
            this.sygnalywysw.FormattingEnabled = true;
            this.sygnalywysw.Location = new System.Drawing.Point(714, 42);
            this.sygnalywysw.Name = "sygnalywysw";
            this.sygnalywysw.Size = new System.Drawing.Size(60, 251);
            this.sygnalywysw.TabIndex = 41;
            this.sygnalywysw.SelectedIndexChanged += new System.EventHandler(this.sygnalywysw_SelectedIndexChanged);
            // 
            // okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1027, 298);
            this.Controls.Add(this.sygnalywysw);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.polekodu);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.paszielony);
            this.Controls.Add(this.paspomaranczowy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.debugger);
            this.Controls.Add(this.k5);
            this.Controls.Add(this.k4);
            this.Controls.Add(this.k3);
            this.Controls.Add(this.k2);
            this.Controls.Add(this.k1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.opcuniew);
            this.Controls.Add(this.opckarz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wskw24);
            this.Controls.Add(this.wskw20);
            this.Controls.Add(this.wskw19);
            this.Controls.Add(this.wskw18);
            this.Controls.Add(this.wskw1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.osl);
            this.Controls.Add(this.kolpowt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typsem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "okno";
            this.Text = "Generator wpisów semaforów do TD2 - wersja 3.0.0";
            this.Load += new System.EventHandler(this.okno_Load);
            this.kolpowt.ResumeLayout(false);
            this.osl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typsem;
        private System.Windows.Forms.Panel kolpowt;
        private System.Windows.Forms.RadioButton kolpowt1;
        private System.Windows.Forms.RadioButton kolpowt2;
        private System.Windows.Forms.RadioButton kolpowt3;
        private System.Windows.Forms.Panel osl;
        private System.Windows.Forms.RadioButton osl1;
        private System.Windows.Forms.RadioButton osl2;
        private System.Windows.Forms.RadioButton osl3;
        private System.Windows.Forms.CheckBox wskw1;
        private System.Windows.Forms.CheckBox wskw18;
        private System.Windows.Forms.CheckBox wskw19;
        private System.Windows.Forms.CheckBox wskw20;
        private System.Windows.Forms.CheckBox wskw24;
        private System.Windows.Forms.CheckBox opckarz;
        private System.Windows.Forms.CheckBox opcuniew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox k1;
        private System.Windows.Forms.ComboBox k2;
        private System.Windows.Forms.ComboBox k3;
        private System.Windows.Forms.ComboBox k4;
        private System.Windows.Forms.ComboBox k5;
        private System.Windows.Forms.Label debugger;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox paspomaranczowy;
        private System.Windows.Forms.CheckBox paszielony;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton wstedyt;
        private System.Windows.Forms.RadioButton wstnot;
        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.TextBox polekodu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox sygnalywysw;
    }
}