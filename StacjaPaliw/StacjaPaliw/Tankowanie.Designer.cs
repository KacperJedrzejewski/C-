namespace StacjaPaliw
{
    partial class Tankowanie
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
            this.lblZaIleTankujesz = new System.Windows.Forms.Label();
            this.lblTankIleL = new System.Windows.Forms.Label();
            this.lblTankDoZaplaty = new System.Windows.Forms.Label();
            this.txtTankIleL = new System.Windows.Forms.TextBox();
            this.txtTankDoZaplaty = new System.Windows.Forms.TextBox();
            this.BtnTankuj = new System.Windows.Forms.Button();
            this.txtZaKwote = new System.Windows.Forms.TextBox();
            this.rbtZaKwote = new System.Windows.Forms.RadioButton();
            this.rbt200 = new System.Windows.Forms.RadioButton();
            this.rbt150 = new System.Windows.Forms.RadioButton();
            this.rbt100 = new System.Windows.Forms.RadioButton();
            this.rbt050 = new System.Windows.Forms.RadioButton();
            this.rbt20 = new System.Windows.Forms.RadioButton();
            this.zaplac = new System.Windows.Forms.Button();
            this.ladowanie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ladowanie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZaIleTankujesz
            // 
            this.lblZaIleTankujesz.AutoSize = true;
            this.lblZaIleTankujesz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaIleTankujesz.Location = new System.Drawing.Point(15, 15);
            this.lblZaIleTankujesz.Name = "lblZaIleTankujesz";
            this.lblZaIleTankujesz.Size = new System.Drawing.Size(296, 25);
            this.lblZaIleTankujesz.TabIndex = 1;
            this.lblZaIleTankujesz.Text = "Za ile chcesz zatankować?";
            // 
            // lblTankIleL
            // 
            this.lblTankIleL.AutoSize = true;
            this.lblTankIleL.Location = new System.Drawing.Point(245, 232);
            this.lblTankIleL.Name = "lblTankIleL";
            this.lblTankIleL.Size = new System.Drawing.Size(45, 13);
            this.lblTankIleL.TabIndex = 5;
            this.lblTankIleL.Text = "Ile litrów";
            // 
            // lblTankDoZaplaty
            // 
            this.lblTankDoZaplaty.AutoSize = true;
            this.lblTankDoZaplaty.Location = new System.Drawing.Point(245, 173);
            this.lblTankDoZaplaty.Name = "lblTankDoZaplaty";
            this.lblTankDoZaplaty.Size = new System.Drawing.Size(59, 13);
            this.lblTankDoZaplaty.TabIndex = 6;
            this.lblTankDoZaplaty.Text = "Do zapłaty";
            // 
            // txtTankIleL
            // 
            this.txtTankIleL.Location = new System.Drawing.Point(248, 195);
            this.txtTankIleL.Name = "txtTankIleL";
            this.txtTankIleL.ReadOnly = true;
            this.txtTankIleL.Size = new System.Drawing.Size(100, 20);
            this.txtTankIleL.TabIndex = 7;
            this.txtTankIleL.Text = "0";
            // 
            // txtTankDoZaplaty
            // 
            this.txtTankDoZaplaty.Location = new System.Drawing.Point(248, 248);
            this.txtTankDoZaplaty.Name = "txtTankDoZaplaty";
            this.txtTankDoZaplaty.ReadOnly = true;
            this.txtTankDoZaplaty.Size = new System.Drawing.Size(100, 20);
            this.txtTankDoZaplaty.TabIndex = 8;
            // 
            // BtnTankuj
            // 
            this.BtnTankuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnTankuj.Location = new System.Drawing.Point(113, 74);
            this.BtnTankuj.Name = "BtnTankuj";
            this.BtnTankuj.Size = new System.Drawing.Size(93, 66);
            this.BtnTankuj.TabIndex = 18;
            this.BtnTankuj.Text = "Tankuj";
            this.BtnTankuj.UseVisualStyleBackColor = true;
            this.BtnTankuj.Click += new System.EventHandler(this.BtnTankuj_Click);
            this.BtnTankuj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnTankuj_MouseDown);
            this.BtnTankuj.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnTankuj_MouseUp);
            // 
            // txtZaKwote
            // 
            this.txtZaKwote.Location = new System.Drawing.Point(106, 166);
            this.txtZaKwote.Name = "txtZaKwote";
            this.txtZaKwote.ReadOnly = true;
            this.txtZaKwote.Size = new System.Drawing.Size(100, 20);
            this.txtZaKwote.TabIndex = 17;
            this.txtZaKwote.Text = "0";
            // 
            // rbtZaKwote
            // 
            this.rbtZaKwote.AutoSize = true;
            this.rbtZaKwote.Location = new System.Drawing.Point(22, 166);
            this.rbtZaKwote.Name = "rbtZaKwote";
            this.rbtZaKwote.Size = new System.Drawing.Size(81, 17);
            this.rbtZaKwote.TabIndex = 16;
            this.rbtZaKwote.TabStop = true;
            this.rbtZaKwote.Text = "Tankuję za:";
            this.rbtZaKwote.UseVisualStyleBackColor = true;
            // 
            // rbt200
            // 
            this.rbt200.AutoSize = true;
            this.rbt200.Location = new System.Drawing.Point(22, 143);
            this.rbt200.Name = "rbt200";
            this.rbt200.Size = new System.Drawing.Size(55, 17);
            this.rbt200.TabIndex = 15;
            this.rbt200.TabStop = true;
            this.rbt200.Text = "200 zł";
            this.rbt200.UseVisualStyleBackColor = true;
            // 
            // rbt150
            // 
            this.rbt150.AutoSize = true;
            this.rbt150.Location = new System.Drawing.Point(22, 123);
            this.rbt150.Name = "rbt150";
            this.rbt150.Size = new System.Drawing.Size(55, 17);
            this.rbt150.TabIndex = 14;
            this.rbt150.TabStop = true;
            this.rbt150.Text = "150 zł";
            this.rbt150.UseVisualStyleBackColor = true;
            // 
            // rbt100
            // 
            this.rbt100.AutoSize = true;
            this.rbt100.Location = new System.Drawing.Point(22, 103);
            this.rbt100.Name = "rbt100";
            this.rbt100.Size = new System.Drawing.Size(55, 17);
            this.rbt100.TabIndex = 13;
            this.rbt100.TabStop = true;
            this.rbt100.Text = "100 zł";
            this.rbt100.UseVisualStyleBackColor = true;
            // 
            // rbt050
            // 
            this.rbt050.AutoSize = true;
            this.rbt050.Location = new System.Drawing.Point(22, 83);
            this.rbt050.Name = "rbt050";
            this.rbt050.Size = new System.Drawing.Size(49, 17);
            this.rbt050.TabIndex = 12;
            this.rbt050.TabStop = true;
            this.rbt050.Text = "50 zł";
            this.rbt050.UseVisualStyleBackColor = true;
            // 
            // rbt20
            // 
            this.rbt20.AutoSize = true;
            this.rbt20.Location = new System.Drawing.Point(22, 63);
            this.rbt20.Name = "rbt20";
            this.rbt20.Size = new System.Drawing.Size(49, 17);
            this.rbt20.TabIndex = 11;
            this.rbt20.TabStop = true;
            this.rbt20.Text = "20 zł";
            this.rbt20.UseVisualStyleBackColor = true;
            // 
            // zaplac
            // 
            this.zaplac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.zaplac.Location = new System.Drawing.Point(20, 207);
            this.zaplac.Name = "zaplac";
            this.zaplac.Size = new System.Drawing.Size(181, 38);
            this.zaplac.TabIndex = 20;
            this.zaplac.Text = "Zapłać";
            this.zaplac.UseVisualStyleBackColor = true;
            this.zaplac.Click += new System.EventHandler(this.zaplac_Click);
            // 
            // ladowanie
            // 
            this.ladowanie.Location = new System.Drawing.Point(248, 40);
            this.ladowanie.Name = "ladowanie";
            this.ladowanie.Size = new System.Drawing.Size(126, 130);
            this.ladowanie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ladowanie.TabIndex = 21;
            this.ladowanie.TabStop = false;
            // 
            // Tankowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 279);
            this.Controls.Add(this.ladowanie);
            this.Controls.Add(this.zaplac);
            this.Controls.Add(this.BtnTankuj);
            this.Controls.Add(this.txtZaKwote);
            this.Controls.Add(this.rbtZaKwote);
            this.Controls.Add(this.rbt200);
            this.Controls.Add(this.rbt150);
            this.Controls.Add(this.rbt100);
            this.Controls.Add(this.rbt050);
            this.Controls.Add(this.rbt20);
            this.Controls.Add(this.txtTankDoZaplaty);
            this.Controls.Add(this.txtTankIleL);
            this.Controls.Add(this.lblTankDoZaplaty);
            this.Controls.Add(this.lblTankIleL);
            this.Controls.Add(this.lblZaIleTankujesz);
            this.Name = "Tankowanie";
            this.Text = "Taknowanie";
            this.Load += new System.EventHandler(this.Taknowanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ladowanie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblZaIleTankujesz;
        private System.Windows.Forms.Label lblTankIleL;
        private System.Windows.Forms.Label lblTankDoZaplaty;
        private System.Windows.Forms.TextBox txtTankIleL;
        private System.Windows.Forms.TextBox txtTankDoZaplaty;
        private System.Windows.Forms.Button BtnTankuj;
        private System.Windows.Forms.TextBox txtZaKwote;
        private System.Windows.Forms.RadioButton rbtZaKwote;
        private System.Windows.Forms.RadioButton rbt200;
        private System.Windows.Forms.RadioButton rbt150;
        private System.Windows.Forms.RadioButton rbt100;
        private System.Windows.Forms.RadioButton rbt050;
        private System.Windows.Forms.RadioButton rbt20;
        private System.Windows.Forms.Button zaplac;
        private System.Windows.Forms.PictureBox ladowanie;
    }
}