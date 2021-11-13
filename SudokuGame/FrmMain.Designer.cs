namespace Sudoku
{
    partial class FrmMain
    {
        /// <summary>
        /// variabile richiesta
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGioco = new System.Windows.Forms.Panel();
            this.btnNuovaPartita = new System.Windows.Forms.Button();
            this.btnControlla = new System.Windows.Forms.Button();
            this.btnRicomincia = new System.Windows.Forms.Button();
            this.difficoltàFacile = new System.Windows.Forms.RadioButton();
            this.difficoltàMedia = new System.Windows.Forms.RadioButton();
            this.difficoltàDifficile = new System.Windows.Forms.RadioButton();
            this.lblLivello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlGioco
            // 
            this.pnlGioco.Location = new System.Drawing.Point(15, 15);
            this.pnlGioco.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGioco.Name = "pnlGioco";
            this.pnlGioco.Size = new System.Drawing.Size(450, 450);
            this.pnlGioco.TabIndex = 0;
            // 
            // btnNuovaPartita
            // 
            this.btnNuovaPartita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuovaPartita.Location = new System.Drawing.Point(469, 394);
            this.btnNuovaPartita.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuovaPartita.Name = "btnNuovaPartita";
            this.btnNuovaPartita.Size = new System.Drawing.Size(119, 67);
            this.btnNuovaPartita.TabIndex = 1;
            this.btnNuovaPartita.Text = "Nuova Partita";
            this.btnNuovaPartita.UseVisualStyleBackColor = true;
            this.btnNuovaPartita.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // btnControlla
            // 
            this.btnControlla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlla.Location = new System.Drawing.Point(469, 15);
            this.btnControlla.Margin = new System.Windows.Forms.Padding(2);
            this.btnControlla.Name = "btnControlla";
            this.btnControlla.Size = new System.Drawing.Size(119, 65);
            this.btnControlla.TabIndex = 2;
            this.btnControlla.Text = "Controlla";
            this.btnControlla.UseVisualStyleBackColor = true;
            this.btnControlla.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // btnRicomincia
            // 
            this.btnRicomincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRicomincia.Location = new System.Drawing.Point(469, 91);
            this.btnRicomincia.Margin = new System.Windows.Forms.Padding(2);
            this.btnRicomincia.Name = "btnRicomincia";
            this.btnRicomincia.Size = new System.Drawing.Size(119, 38);
            this.btnRicomincia.TabIndex = 2;
            this.btnRicomincia.Text = "Ricomincia";
            this.btnRicomincia.UseVisualStyleBackColor = true;
            this.btnRicomincia.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // difficoltàFacile
            // 
            this.difficoltàFacile.AutoSize = true;
            this.difficoltàFacile.Checked = true;
            this.difficoltàFacile.Location = new System.Drawing.Point(469, 335);
            this.difficoltàFacile.Margin = new System.Windows.Forms.Padding(2);
            this.difficoltàFacile.Name = "difficoltàFacile";
            this.difficoltàFacile.Size = new System.Drawing.Size(53, 17);
            this.difficoltàFacile.TabIndex = 3;
            this.difficoltàFacile.TabStop = true;
            this.difficoltàFacile.Text = "Facile";
            this.difficoltàFacile.UseVisualStyleBackColor = true;
            // 
            // difficoltàMedia
            // 
            this.difficoltàMedia.AutoSize = true;
            this.difficoltàMedia.Location = new System.Drawing.Point(469, 355);
            this.difficoltàMedia.Margin = new System.Windows.Forms.Padding(2);
            this.difficoltàMedia.Name = "difficoltàMedia";
            this.difficoltàMedia.Size = new System.Drawing.Size(54, 17);
            this.difficoltàMedia.TabIndex = 3;
            this.difficoltàMedia.Text = "Medio";
            this.difficoltàMedia.UseVisualStyleBackColor = true;
            // 
            // difficoltàDifficile
            // 
            this.difficoltàDifficile.AutoSize = true;
            this.difficoltàDifficile.Location = new System.Drawing.Point(469, 374);
            this.difficoltàDifficile.Margin = new System.Windows.Forms.Padding(2);
            this.difficoltàDifficile.Name = "difficoltàDifficile";
            this.difficoltàDifficile.Size = new System.Drawing.Size(57, 17);
            this.difficoltàDifficile.TabIndex = 3;
            this.difficoltàDifficile.Text = "Difficie";
            this.difficoltàDifficile.UseVisualStyleBackColor = true;
            // 
            // lblLivello
            // 
            this.lblLivello.AutoSize = true;
            this.lblLivello.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivello.Location = new System.Drawing.Point(465, 310);
            this.lblLivello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLivello.Name = "lblLivello";
            this.lblLivello.Size = new System.Drawing.Size(67, 25);
            this.lblLivello.TabIndex = 4;
            this.lblLivello.Text = "Livello";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 471);
            this.Controls.Add(this.lblLivello);
            this.Controls.Add(this.difficoltàDifficile);
            this.Controls.Add(this.difficoltàMedia);
            this.Controls.Add(this.difficoltàFacile);
            this.Controls.Add(this.btnRicomincia);
            this.Controls.Add(this.btnControlla);
            this.Controls.Add(this.btnNuovaPartita);
            this.Controls.Add(this.pnlGioco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 510);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGioco;
        private System.Windows.Forms.Button btnNuovaPartita;
        private System.Windows.Forms.Button btnControlla;
        private System.Windows.Forms.Button btnRicomincia;
        private System.Windows.Forms.RadioButton difficoltàFacile;
        private System.Windows.Forms.RadioButton difficoltàMedia;
        private System.Windows.Forms.RadioButton difficoltàDifficile;
        private System.Windows.Forms.Label lblLivello;
    }
}

