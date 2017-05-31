namespace WindowsFormsApp1
{
    partial class Edytuj
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pensja = new System.Windows.Forms.TextBox();
            this.Anuluj = new System.Windows.Forms.Button();
            this.Zapisz = new System.Windows.Forms.Button();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pensja:";
            // 
            // Pensja
            // 
            this.Pensja.Location = new System.Drawing.Point(41, 64);
            this.Pensja.Name = "Pensja";
            this.Pensja.Size = new System.Drawing.Size(159, 20);
            this.Pensja.TabIndex = 14;
            this.Pensja.Text = "0";
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(139, 99);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(116, 23);
            this.Anuluj.TabIndex = 18;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(12, 99);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(115, 23);
            this.Zapisz.TabIndex = 17;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(138, 25);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(130, 20);
            this.Nazwisko.TabIndex = 13;
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(2, 25);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(130, 20);
            this.Imie.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nazwisko:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Imie:";
            // 
            // Edytuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pensja);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Name = "Edytuj";
            this.Text = "Edytuj pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pensja;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
    }
}