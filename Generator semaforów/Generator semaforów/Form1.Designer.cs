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
            this.kolpowt.SuspendLayout();
            this.osl.SuspendLayout();
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
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(264, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Komora 2:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(264, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Komora 3:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(264, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Komora 4:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(264, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Komora 5:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(864, 267);
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
            this.ResumeLayout(false);

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

    }
}