namespace WindowsFormsApp1
{
    partial class Form1
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
            this.PensjaBox = new System.Windows.Forms.GroupBox();
            this.NETTO = new System.Windows.Forms.RadioButton();
            this.BRUTTO = new System.Windows.Forms.RadioButton();
            this.Pensja = new System.Windows.Forms.TextBox();
            this.Emerytalne = new System.Windows.Forms.TextBox();
            this.Rentowe = new System.Windows.Forms.TextBox();
            this.Chorobowe = new System.Windows.Forms.TextBox();
            this.Zdrowotna = new System.Windows.Forms.TextBox();
            this.Koszty = new System.Windows.Forms.TextBox();
            this.Pit = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Poprzedni = new System.Windows.Forms.Button();
            this.Zamknij = new System.Windows.Forms.Button();
            this.Nowy = new System.Windows.Forms.Button();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.Nastepny = new System.Windows.Forms.Button();
            this.Usun = new System.Windows.Forms.Button();
            this.happy = new System.Windows.Forms.PictureBox();
            this.Neutral = new System.Windows.Forms.PictureBox();
            this.Sad = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PensjaBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Neutral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sad)).BeginInit();
            this.SuspendLayout();
            // 
            // PensjaBox
            // 
            this.PensjaBox.Controls.Add(this.NETTO);
            this.PensjaBox.Controls.Add(this.BRUTTO);
            this.PensjaBox.Controls.Add(this.Pensja);
            this.PensjaBox.Location = new System.Drawing.Point(12, 12);
            this.PensjaBox.Name = "PensjaBox";
            this.PensjaBox.Size = new System.Drawing.Size(277, 73);
            this.PensjaBox.TabIndex = 0;
            this.PensjaBox.TabStop = false;
            this.PensjaBox.Text = "Pensja";
            // 
            // NETTO
            // 
            this.NETTO.AutoSize = true;
            this.NETTO.Location = new System.Drawing.Point(162, 40);
            this.NETTO.Name = "NETTO";
            this.NETTO.Size = new System.Drawing.Size(62, 17);
            this.NETTO.TabIndex = 1;
            this.NETTO.TabStop = true;
            this.NETTO.Text = "NETTO";
            this.NETTO.UseVisualStyleBackColor = true;
            this.NETTO.CheckedChanged += new System.EventHandler(this.NETTO_CheckedChanged);
            // 
            // BRUTTO
            // 
            this.BRUTTO.AutoSize = true;
            this.BRUTTO.Location = new System.Drawing.Point(162, 17);
            this.BRUTTO.Name = "BRUTTO";
            this.BRUTTO.Size = new System.Drawing.Size(70, 17);
            this.BRUTTO.TabIndex = 0;
            this.BRUTTO.TabStop = true;
            this.BRUTTO.Text = "BRUTTO";
            this.BRUTTO.UseVisualStyleBackColor = true;
            // 
            // Pensja
            // 
            this.Pensja.Location = new System.Drawing.Point(0, 19);
            this.Pensja.Name = "Pensja";
            this.Pensja.ReadOnly = true;
            this.Pensja.Size = new System.Drawing.Size(148, 20);
            this.Pensja.TabIndex = 1;
            // 
            // Emerytalne
            // 
            this.Emerytalne.Location = new System.Drawing.Point(12, 126);
            this.Emerytalne.Name = "Emerytalne";
            this.Emerytalne.ReadOnly = true;
            this.Emerytalne.Size = new System.Drawing.Size(148, 20);
            this.Emerytalne.TabIndex = 2;
            // 
            // Rentowe
            // 
            this.Rentowe.Location = new System.Drawing.Point(12, 152);
            this.Rentowe.Name = "Rentowe";
            this.Rentowe.ReadOnly = true;
            this.Rentowe.Size = new System.Drawing.Size(148, 20);
            this.Rentowe.TabIndex = 3;
            // 
            // Chorobowe
            // 
            this.Chorobowe.Location = new System.Drawing.Point(12, 178);
            this.Chorobowe.Name = "Chorobowe";
            this.Chorobowe.ReadOnly = true;
            this.Chorobowe.Size = new System.Drawing.Size(148, 20);
            this.Chorobowe.TabIndex = 4;
            // 
            // Zdrowotna
            // 
            this.Zdrowotna.Location = new System.Drawing.Point(12, 204);
            this.Zdrowotna.Name = "Zdrowotna";
            this.Zdrowotna.ReadOnly = true;
            this.Zdrowotna.Size = new System.Drawing.Size(148, 20);
            this.Zdrowotna.TabIndex = 5;
            // 
            // Koszty
            // 
            this.Koszty.Location = new System.Drawing.Point(12, 230);
            this.Koszty.Name = "Koszty";
            this.Koszty.ReadOnly = true;
            this.Koszty.Size = new System.Drawing.Size(148, 20);
            this.Koszty.TabIndex = 6;
            // 
            // Pit
            // 
            this.Pit.Location = new System.Drawing.Point(12, 256);
            this.Pit.Name = "Pit";
            this.Pit.ReadOnly = true;
            this.Pit.Size = new System.Drawing.Size(148, 20);
            this.Pit.TabIndex = 7;
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(12, 282);
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            this.Suma.Size = new System.Drawing.Size(195, 20);
            this.Suma.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(171, 132);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(132, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Ubezpieczenie Emerytalne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ubezpieczenie Rentowe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ubezpieczenie Chorobowe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Składka zdrowotna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Koszty uzyskania przychodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Zaliczka na PIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Suma";
            // 
            // Poprzedni
            // 
            this.Poprzedni.Location = new System.Drawing.Point(12, 324);
            this.Poprzedni.Name = "Poprzedni";
            this.Poprzedni.Size = new System.Drawing.Size(62, 23);
            this.Poprzedni.TabIndex = 16;
            this.Poprzedni.Text = "Poprzedni";
            this.Poprzedni.UseVisualStyleBackColor = true;
            this.Poprzedni.Click += new System.EventHandler(this.Poprzedni_Click);
            // 
            // Zamknij
            // 
            this.Zamknij.Location = new System.Drawing.Point(352, 324);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(62, 23);
            this.Zamknij.TabIndex = 17;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // Nowy
            // 
            this.Nowy.Location = new System.Drawing.Point(148, 324);
            this.Nowy.Name = "Nowy";
            this.Nowy.Size = new System.Drawing.Size(62, 23);
            this.Nowy.TabIndex = 18;
            this.Nowy.Text = "Nowy";
            this.Nowy.UseVisualStyleBackColor = true;
            this.Nowy.Click += new System.EventHandler(this.Nowy_Click);
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(13, 92);
            this.Imie.Name = "Imie";
            this.Imie.ReadOnly = true;
            this.Imie.Size = new System.Drawing.Size(100, 20);
            this.Imie.TabIndex = 19;
            this.Imie.Text = "Imie";
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(136, 92);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            this.Nazwisko.Size = new System.Drawing.Size(100, 20);
            this.Nazwisko.TabIndex = 20;
            this.Nazwisko.Text = "Nazwisko";
            // 
            // Nastepny
            // 
            this.Nastepny.Location = new System.Drawing.Point(80, 324);
            this.Nastepny.Name = "Nastepny";
            this.Nastepny.Size = new System.Drawing.Size(62, 23);
            this.Nastepny.TabIndex = 22;
            this.Nastepny.Text = "Nastepny";
            this.Nastepny.UseVisualStyleBackColor = true;
            this.Nastepny.Click += new System.EventHandler(this.Nastepny_Click);
            // 
            // Usun
            // 
            this.Usun.Location = new System.Drawing.Point(216, 324);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(62, 23);
            this.Usun.TabIndex = 23;
            this.Usun.Text = "Usuń";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // happy
            // 
            this.happy.Image = global::WindowsFormsApp1.Properties.Resources.happy;
            this.happy.Location = new System.Drawing.Point(312, 12);
            this.happy.Name = "happy";
            this.happy.Size = new System.Drawing.Size(122, 123);
            this.happy.TabIndex = 24;
            this.happy.TabStop = false;
            // 
            // Neutral
            // 
            this.Neutral.Image = global::WindowsFormsApp1.Properties.Resources.neurtal;
            this.Neutral.Location = new System.Drawing.Point(312, 12);
            this.Neutral.Name = "Neutral";
            this.Neutral.Size = new System.Drawing.Size(122, 123);
            this.Neutral.TabIndex = 25;
            this.Neutral.TabStop = false;
            // 
            // Sad
            // 
            this.Sad.Image = global::WindowsFormsApp1.Properties.Resources.sad;
            this.Sad.Location = new System.Drawing.Point(312, 12);
            this.Sad.Name = "Sad";
            this.Sad.Size = new System.Drawing.Size(122, 123);
            this.Sad.TabIndex = 26;
            this.Sad.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Edytuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Edytuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sad);
            this.Controls.Add(this.Neutral);
            this.Controls.Add(this.happy);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.Nastepny);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.Nowy);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.Poprzedni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Pit);
            this.Controls.Add(this.Koszty);
            this.Controls.Add(this.Zdrowotna);
            this.Controls.Add(this.Chorobowe);
            this.Controls.Add(this.Rentowe);
            this.Controls.Add(this.Emerytalne);
            this.Controls.Add(this.PensjaBox);
            this.Name = "Form1";
            this.Text = "Pensje";
            this.PensjaBox.ResumeLayout(false);
            this.PensjaBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Neutral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PensjaBox;
        private System.Windows.Forms.RadioButton NETTO;
        private System.Windows.Forms.RadioButton BRUTTO;
        private System.Windows.Forms.TextBox Pensja;
        private System.Windows.Forms.TextBox Emerytalne;
        private System.Windows.Forms.TextBox Rentowe;
        private System.Windows.Forms.TextBox Chorobowe;
        private System.Windows.Forms.TextBox Zdrowotna;
        private System.Windows.Forms.TextBox Koszty;
        private System.Windows.Forms.TextBox Pit;
        private System.Windows.Forms.TextBox Suma;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Poprzedni;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.Button Nowy;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.Button Nastepny;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.PictureBox happy;
        private System.Windows.Forms.PictureBox Neutral;
        private System.Windows.Forms.PictureBox Sad;
        private System.Windows.Forms.Button button1;
    }
}

