namespace StacjaPaliw
{
    partial class StacjaPaliw
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
            this.components = new System.ComponentModel.Container();
            this.lblPb95 = new System.Windows.Forms.Label();
            this.lblPb98 = new System.Windows.Forms.Label();
            this.lblON = new System.Windows.Forms.Label();
            this.lblLPG = new System.Windows.Forms.Label();
            this.txtPb95 = new System.Windows.Forms.TextBox();
            this.txtPb98 = new System.Windows.Forms.TextBox();
            this.txtON = new System.Windows.Forms.TextBox();
            this.txtLPG = new System.Windows.Forms.TextBox();
            this.btnTankuj = new System.Windows.Forms.Button();
            this.btnWyjdz = new System.Windows.Forms.Button();
            this.btnRaport = new System.Windows.Forms.Button();
            this.Zegar = new System.Windows.Forms.Timer(this.components);
            this.lblZegar = new System.Windows.Forms.Label();
            this.Pb95 = new System.Windows.Forms.RadioButton();
            this.Pb98 = new System.Windows.Forms.RadioButton();
            this.ON = new System.Windows.Forms.RadioButton();
            this.LPG = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblPb95
            // 
            this.lblPb95.AutoSize = true;
            this.lblPb95.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPb95.Location = new System.Drawing.Point(15, 30);
            this.lblPb95.Name = "lblPb95";
            this.lblPb95.Size = new System.Drawing.Size(43, 16);
            this.lblPb95.TabIndex = 0;
            this.lblPb95.Text = "Pb95";
            // 
            // lblPb98
            // 
            this.lblPb98.AutoSize = true;
            this.lblPb98.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPb98.Location = new System.Drawing.Point(15, 60);
            this.lblPb98.Name = "lblPb98";
            this.lblPb98.Size = new System.Drawing.Size(43, 16);
            this.lblPb98.TabIndex = 1;
            this.lblPb98.Text = "Pb98";
            // 
            // lblON
            // 
            this.lblON.AutoSize = true;
            this.lblON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblON.Location = new System.Drawing.Point(15, 90);
            this.lblON.Name = "lblON";
            this.lblON.Size = new System.Drawing.Size(30, 16);
            this.lblON.TabIndex = 2;
            this.lblON.Text = "ON";
            // 
            // lblLPG
            // 
            this.lblLPG.AutoSize = true;
            this.lblLPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLPG.Location = new System.Drawing.Point(15, 120);
            this.lblLPG.Name = "lblLPG";
            this.lblLPG.Size = new System.Drawing.Size(37, 16);
            this.lblLPG.TabIndex = 3;
            this.lblLPG.Text = "LPG";
            // 
            // txtPb95
            // 
            this.txtPb95.Location = new System.Drawing.Point(64, 30);
            this.txtPb95.Name = "txtPb95";
            this.txtPb95.ReadOnly = true;
            this.txtPb95.Size = new System.Drawing.Size(136, 20);
            this.txtPb95.TabIndex = 4;
            // 
            // txtPb98
            // 
            this.txtPb98.Location = new System.Drawing.Point(64, 60);
            this.txtPb98.Name = "txtPb98";
            this.txtPb98.ReadOnly = true;
            this.txtPb98.Size = new System.Drawing.Size(136, 20);
            this.txtPb98.TabIndex = 5;
            // 
            // txtON
            // 
            this.txtON.Location = new System.Drawing.Point(64, 90);
            this.txtON.Name = "txtON";
            this.txtON.ReadOnly = true;
            this.txtON.Size = new System.Drawing.Size(136, 20);
            this.txtON.TabIndex = 6;
            // 
            // txtLPG
            // 
            this.txtLPG.Location = new System.Drawing.Point(64, 120);
            this.txtLPG.Name = "txtLPG";
            this.txtLPG.ReadOnly = true;
            this.txtLPG.Size = new System.Drawing.Size(136, 20);
            this.txtLPG.TabIndex = 7;
            // 
            // btnTankuj
            // 
            this.btnTankuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTankuj.Location = new System.Drawing.Point(2, 175);
            this.btnTankuj.Name = "btnTankuj";
            this.btnTankuj.Size = new System.Drawing.Size(112, 30);
            this.btnTankuj.TabIndex = 8;
            this.btnTankuj.Text = "Tankuj";
            this.btnTankuj.UseVisualStyleBackColor = true;
            this.btnTankuj.Click += new System.EventHandler(this.BtnTankuj_Click);
            // 
            // btnWyjdz
            // 
            this.btnWyjdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnWyjdz.Location = new System.Drawing.Point(232, 175);
            this.btnWyjdz.Name = "btnWyjdz";
            this.btnWyjdz.Size = new System.Drawing.Size(100, 30);
            this.btnWyjdz.TabIndex = 10;
            this.btnWyjdz.Text = "Wyjdź";
            this.btnWyjdz.UseVisualStyleBackColor = true;
            this.btnWyjdz.Click += new System.EventHandler(this.BtnWyjdz_Click);
            // 
            // btnRaport
            // 
            this.btnRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRaport.Location = new System.Drawing.Point(120, 175);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(106, 30);
            this.btnRaport.TabIndex = 9;
            this.btnRaport.Text = "Raport";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.BtnRaport_Click);
            // 
            // Zegar
            // 
            this.Zegar.Tick += new System.EventHandler(this.Zegar_Tick);
            // 
            // lblZegar
            // 
            this.lblZegar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZegar.Location = new System.Drawing.Point(238, 73);
            this.lblZegar.Name = "lblZegar";
            this.lblZegar.Size = new System.Drawing.Size(89, 33);
            this.lblZegar.TabIndex = 11;
            this.lblZegar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pb95
            // 
            this.Pb95.AutoSize = true;
            this.Pb95.Location = new System.Drawing.Point(2, 32);
            this.Pb95.Name = "Pb95";
            this.Pb95.Size = new System.Drawing.Size(14, 13);
            this.Pb95.TabIndex = 12;
            this.Pb95.TabStop = true;
            this.Pb95.UseVisualStyleBackColor = true;
            // 
            // Pb98
            // 
            this.Pb98.AutoSize = true;
            this.Pb98.Location = new System.Drawing.Point(2, 60);
            this.Pb98.Name = "Pb98";
            this.Pb98.Size = new System.Drawing.Size(14, 13);
            this.Pb98.TabIndex = 13;
            this.Pb98.TabStop = true;
            this.Pb98.UseVisualStyleBackColor = true;
            // 
            // ON
            // 
            this.ON.AutoSize = true;
            this.ON.Location = new System.Drawing.Point(2, 92);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(14, 13);
            this.ON.TabIndex = 14;
            this.ON.TabStop = true;
            this.ON.UseVisualStyleBackColor = true;
            // 
            // LPG
            // 
            this.LPG.AutoSize = true;
            this.LPG.Location = new System.Drawing.Point(2, 123);
            this.LPG.Name = "LPG";
            this.LPG.Size = new System.Drawing.Size(14, 13);
            this.LPG.TabIndex = 15;
            this.LPG.TabStop = true;
            this.LPG.UseVisualStyleBackColor = true;
            // 
            // StacjaPaliw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 211);
            this.Controls.Add(this.LPG);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.Pb98);
            this.Controls.Add(this.Pb95);
            this.Controls.Add(this.lblZegar);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.btnWyjdz);
            this.Controls.Add(this.btnTankuj);
            this.Controls.Add(this.txtLPG);
            this.Controls.Add(this.txtON);
            this.Controls.Add(this.txtPb98);
            this.Controls.Add(this.txtPb95);
            this.Controls.Add(this.lblLPG);
            this.Controls.Add(this.lblON);
            this.Controls.Add(this.lblPb98);
            this.Controls.Add(this.lblPb95);
            this.Name = "StacjaPaliw";
            this.Text = "StacjaPaliw";
            this.Load += new System.EventHandler(this.StacjaPaliw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPb95;
        private System.Windows.Forms.Label lblPb98;
        private System.Windows.Forms.Label lblON;
        private System.Windows.Forms.Label lblLPG;
        private System.Windows.Forms.TextBox txtPb95;
        private System.Windows.Forms.TextBox txtPb98;
        private System.Windows.Forms.TextBox txtON;
        private System.Windows.Forms.TextBox txtLPG;
        private System.Windows.Forms.Button btnTankuj;
        private System.Windows.Forms.Button btnWyjdz;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.Timer Zegar;
        private System.Windows.Forms.Label lblZegar;
        private System.Windows.Forms.RadioButton Pb95;
        private System.Windows.Forms.RadioButton Pb98;
        private System.Windows.Forms.RadioButton ON;
        private System.Windows.Forms.RadioButton LPG;
    }
}

