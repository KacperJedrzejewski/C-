namespace StacjaPaliw
{
    partial class Raport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raport));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Suma = new System.Windows.Forms.TextBox();
            this.Ilosc = new System.Windows.Forms.TextBox();
            this.lblCzasTankowania = new System.Windows.Forms.Label();
            this.txtCzasTankowania = new System.Windows.Forms.TextBox();
            this.lblIloscLitrow = new System.Windows.Forms.Label();
            this.txtIloscLitrow = new System.Windows.Forms.TextBox();
            this.btnPoprzednie = new System.Windows.Forms.Button();
            this.btnNastepny = new System.Windows.Forms.Button();
            this.lblZaplacono = new System.Windows.Forms.Label();
            this.txtZaplacono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRodzaj = new System.Windows.Forms.TextBox();
            this.koniec = new System.Windows.Forms.PictureBox();
            this.NastepnyLabel = new System.Windows.Forms.Label();
            this.PoprzedniLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.koniec)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ilosc tankowan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Łaczna wartosc tankowań";
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(155, 34);
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            this.Suma.Size = new System.Drawing.Size(100, 20);
            this.Suma.TabIndex = 5;
            // 
            // Ilosc
            // 
            this.Ilosc.Location = new System.Drawing.Point(29, 34);
            this.Ilosc.Name = "Ilosc";
            this.Ilosc.ReadOnly = true;
            this.Ilosc.Size = new System.Drawing.Size(100, 20);
            this.Ilosc.TabIndex = 6;
            // 
            // lblCzasTankowania
            // 
            this.lblCzasTankowania.AutoSize = true;
            this.lblCzasTankowania.Location = new System.Drawing.Point(31, 66);
            this.lblCzasTankowania.Name = "lblCzasTankowania";
            this.lblCzasTankowania.Size = new System.Drawing.Size(88, 13);
            this.lblCzasTankowania.TabIndex = 8;
            this.lblCzasTankowania.Text = "Czas tankowania";
            // 
            // txtCzasTankowania
            // 
            this.txtCzasTankowania.Location = new System.Drawing.Point(29, 93);
            this.txtCzasTankowania.Name = "txtCzasTankowania";
            this.txtCzasTankowania.ReadOnly = true;
            this.txtCzasTankowania.Size = new System.Drawing.Size(100, 20);
            this.txtCzasTankowania.TabIndex = 9;
            // 
            // lblIloscLitrow
            // 
            this.lblIloscLitrow.AutoSize = true;
            this.lblIloscLitrow.Location = new System.Drawing.Point(152, 66);
            this.lblIloscLitrow.Name = "lblIloscLitrow";
            this.lblIloscLitrow.Size = new System.Drawing.Size(56, 13);
            this.lblIloscLitrow.TabIndex = 10;
            this.lblIloscLitrow.Text = "Ilość litrów";
            // 
            // txtIloscLitrow
            // 
            this.txtIloscLitrow.Location = new System.Drawing.Point(155, 93);
            this.txtIloscLitrow.Name = "txtIloscLitrow";
            this.txtIloscLitrow.ReadOnly = true;
            this.txtIloscLitrow.Size = new System.Drawing.Size(100, 20);
            this.txtIloscLitrow.TabIndex = 11;
            // 
            // btnPoprzednie
            // 
            this.btnPoprzednie.Location = new System.Drawing.Point(34, 149);
            this.btnPoprzednie.Name = "btnPoprzednie";
            this.btnPoprzednie.Size = new System.Drawing.Size(75, 23);
            this.btnPoprzednie.TabIndex = 12;
            this.btnPoprzednie.Text = "Poprzedni";
            this.btnPoprzednie.UseVisualStyleBackColor = true;
            this.btnPoprzednie.Click += new System.EventHandler(this.btnPoprzednie_Click);
            // 
            // btnNastepny
            // 
            this.btnNastepny.Location = new System.Drawing.Point(155, 149);
            this.btnNastepny.Name = "btnNastepny";
            this.btnNastepny.Size = new System.Drawing.Size(75, 23);
            this.btnNastepny.TabIndex = 13;
            this.btnNastepny.Text = "Następny";
            this.btnNastepny.UseVisualStyleBackColor = true;
            this.btnNastepny.Click += new System.EventHandler(this.btnNastepny_Click);
            // 
            // lblZaplacono
            // 
            this.lblZaplacono.AutoSize = true;
            this.lblZaplacono.Location = new System.Drawing.Point(277, 66);
            this.lblZaplacono.Name = "lblZaplacono";
            this.lblZaplacono.Size = new System.Drawing.Size(60, 13);
            this.lblZaplacono.TabIndex = 14;
            this.lblZaplacono.Text = "Zapłacono";
            // 
            // txtZaplacono
            // 
            this.txtZaplacono.Location = new System.Drawing.Point(280, 93);
            this.txtZaplacono.Name = "txtZaplacono";
            this.txtZaplacono.ReadOnly = true;
            this.txtZaplacono.Size = new System.Drawing.Size(100, 20);
            this.txtZaplacono.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rodzaj";
            // 
            // txtRodzaj
            // 
            this.txtRodzaj.Location = new System.Drawing.Point(280, 34);
            this.txtRodzaj.Name = "txtRodzaj";
            this.txtRodzaj.ReadOnly = true;
            this.txtRodzaj.Size = new System.Drawing.Size(100, 20);
            this.txtRodzaj.TabIndex = 17;
            // 
            // koniec
            // 
            this.koniec.Image = ((System.Drawing.Image)(resources.GetObject("koniec.Image")));
            this.koniec.Location = new System.Drawing.Point(270, 131);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(110, 62);
            this.koniec.TabIndex = 18;
            this.koniec.TabStop = false;
            this.koniec.Visible = false;
            // 
            // NastepnyLabel
            // 
            this.NastepnyLabel.Location = new System.Drawing.Point(155, 149);
            this.NastepnyLabel.Name = "NastepnyLabel";
            this.NastepnyLabel.Size = new System.Drawing.Size(75, 23);
            this.NastepnyLabel.TabIndex = 19;
            this.NastepnyLabel.Text = "Nastepny";
            this.NastepnyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NastepnyLabel.Visible = false;
            this.NastepnyLabel.MouseEnter += new System.EventHandler(this.btnNastepny_MouseEnter);
            this.NastepnyLabel.MouseLeave += new System.EventHandler(this.btnNastepny_MouseLeave);
            // 
            // PoprzedniLabel
            // 
            this.PoprzedniLabel.Location = new System.Drawing.Point(34, 149);
            this.PoprzedniLabel.Name = "PoprzedniLabel";
            this.PoprzedniLabel.Size = new System.Drawing.Size(75, 23);
            this.PoprzedniLabel.TabIndex = 20;
            this.PoprzedniLabel.Text = "Poprzedni";
            this.PoprzedniLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PoprzedniLabel.Visible = false;
            this.PoprzedniLabel.MouseEnter += new System.EventHandler(this.btnNastepny_MouseEnter);
            this.PoprzedniLabel.MouseLeave += new System.EventHandler(this.btnNastepny_MouseLeave);
            // 
            // Raport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 205);
            this.Controls.Add(this.PoprzedniLabel);
            this.Controls.Add(this.NastepnyLabel);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.txtRodzaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZaplacono);
            this.Controls.Add(this.lblZaplacono);
            this.Controls.Add(this.btnNastepny);
            this.Controls.Add(this.btnPoprzednie);
            this.Controls.Add(this.txtIloscLitrow);
            this.Controls.Add(this.lblIloscLitrow);
            this.Controls.Add(this.txtCzasTankowania);
            this.Controls.Add(this.lblCzasTankowania);
            this.Controls.Add(this.Ilosc);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Raport";
            this.Text = "Raport";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.koniec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Suma;
        private System.Windows.Forms.TextBox Ilosc;
        private System.Windows.Forms.Label lblCzasTankowania;
        private System.Windows.Forms.TextBox txtCzasTankowania;
        private System.Windows.Forms.Label lblIloscLitrow;
        private System.Windows.Forms.TextBox txtIloscLitrow;
        private System.Windows.Forms.Button btnPoprzednie;
        private System.Windows.Forms.Button btnNastepny;
        private System.Windows.Forms.Label lblZaplacono;
        private System.Windows.Forms.TextBox txtZaplacono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRodzaj;
        private System.Windows.Forms.PictureBox koniec;
        private System.Windows.Forms.Label NastepnyLabel;
        private System.Windows.Forms.Label PoprzedniLabel;
    }
}