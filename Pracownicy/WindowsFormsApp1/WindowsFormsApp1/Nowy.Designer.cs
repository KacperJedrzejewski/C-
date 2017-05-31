namespace WindowsFormsApp1
{
    partial class Nowy
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
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.Miejski = new System.Windows.Forms.RadioButton();
            this.Wiejski = new System.Windows.Forms.RadioButton();
            this.Zapisz = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.Pensja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(28, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Imie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko:";
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(21, 29);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(100, 20);
            this.Imie.TabIndex = 2;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(127, 29);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(127, 20);
            this.Nazwisko.TabIndex = 3;
            // 
            // Miejski
            // 
            this.Miejski.AutoSize = true;
            this.Miejski.Location = new System.Drawing.Point(21, 115);
            this.Miejski.Name = "Miejski";
            this.Miejski.Size = new System.Drawing.Size(168, 17);
            this.Miejski.TabIndex = 5;
            this.Miejski.TabStop = true;
            this.Miejski.Text = "Praca w miejscu zamieszkania";
            this.Miejski.UseVisualStyleBackColor = true;
            // 
            // Wiejski
            // 
            this.Wiejski.AutoSize = true;
            this.Wiejski.Location = new System.Drawing.Point(21, 138);
            this.Wiejski.Name = "Wiejski";
            this.Wiejski.Size = new System.Drawing.Size(186, 17);
            this.Wiejski.TabIndex = 6;
            this.Wiejski.TabStop = true;
            this.Wiejski.Text = "Praca poza terenem zamieszkania";
            this.Wiejski.UseVisualStyleBackColor = true;
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(21, 176);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(75, 23);
            this.Zapisz.TabIndex = 7;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(114, 176);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 23);
            this.Anuluj.TabIndex = 8;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // Pensja
            // 
            this.Pensja.Location = new System.Drawing.Point(21, 78);
            this.Pensja.Name = "Pensja";
            this.Pensja.Size = new System.Drawing.Size(148, 20);
            this.Pensja.TabIndex = 4;
            this.Pensja.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pensja:";
            // 
            // Nowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pensja);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.Wiejski);
            this.Controls.Add(this.Miejski);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Name = "Nowy";
            this.Text = "Nowy pracownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.RadioButton Miejski;
        private System.Windows.Forms.RadioButton Wiejski;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.TextBox Pensja;
        private System.Windows.Forms.Label label1;
    }
}