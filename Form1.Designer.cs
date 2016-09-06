namespace SDF_Config
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_quitter
            // 
            this.but_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_quitter.Location = new System.Drawing.Point(676, 602);
            this.but_quitter.Name = "but_quitter";
            this.but_quitter.Size = new System.Drawing.Size(90, 47);
            this.but_quitter.TabIndex = 0;
            this.but_quitter.Text = "Quitter";
            this.but_quitter.UseVisualStyleBackColor = true;
            this.but_quitter.Click += new System.EventHandler(this.but_quitter_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(778, 661);
            this.Controls.Add(this.but_quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "SDF_Config";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_quitter;
    }
}

