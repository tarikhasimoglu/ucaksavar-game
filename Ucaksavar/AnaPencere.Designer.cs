namespace Ucaksavar
{
    partial class AnaPencere
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
            this.oyunAlani = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // oyunAlani
            // 
            this.oyunAlani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oyunAlani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oyunAlani.Location = new System.Drawing.Point(2, 54);
            this.oyunAlani.Name = "oyunAlani";
            this.oyunAlani.Size = new System.Drawing.Size(584, 369);
            this.oyunAlani.TabIndex = 0;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BackColor = System.Drawing.Color.Teal;
            this.infoPanel.Controls.Add(this.score);
            this.infoPanel.Controls.Add(this.infoLabel);
            this.infoPanel.Location = new System.Drawing.Point(2, 2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(584, 52);
            this.infoPanel.TabIndex = 1;
            // 
            // score
            // 
            this.score.AutoEllipsis = true;
            this.score.Dock = System.Windows.Forms.DockStyle.Right;
            this.score.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.score.Location = new System.Drawing.Point(524, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(60, 52);
            this.score.TabIndex = 1;
            this.score.Text = "0";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoLabel.Location = new System.Drawing.Point(10, 7);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(391, 39);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Oyunu BAŞLATMAK için ENTER tuşuna basın.\r\nUçaksavarı hareket ettirmek için SAĞ / " +
    "SOL YÖN TUŞLARINI kullanın.\r\nAteş etmek için BOŞLUK tuşuna basın.";
            // 
            // AnaPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 422);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.oyunAlani);
            this.Name = "AnaPencere";
            this.Text = "Form1";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oyunAlani;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label score;
    }
}

