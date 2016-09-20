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
            this.but_quit = new System.Windows.Forms.Button();
            this.but_reduit = new System.Windows.Forms.Button();
            this.but_charger_sdf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_name_sdf = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_max_char_us = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_valdef_us = new System.Windows.Forms.TextBox();
            this.tb_desc_us = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name_us = new System.Windows.Forms.TextBox();
            this.but_add_us = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.but_ecrire_sdf = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.but_fusion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_quit
            // 
            this.but_quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_quit.FlatAppearance.BorderSize = 0;
            this.but_quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.but_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_quit.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_quit.Location = new System.Drawing.Point(974, 10);
            this.but_quit.Margin = new System.Windows.Forms.Padding(1);
            this.but_quit.Name = "but_quit";
            this.but_quit.Size = new System.Drawing.Size(40, 40);
            this.but_quit.TabIndex = 3;
            this.but_quit.TabStop = false;
            this.but_quit.Text = "x";
            this.but_quit.UseVisualStyleBackColor = true;
            this.but_quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_reduit
            // 
            this.but_reduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_reduit.FlatAppearance.BorderSize = 0;
            this.but_reduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_reduit.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_reduit.Location = new System.Drawing.Point(896, 9);
            this.but_reduit.Margin = new System.Windows.Forms.Padding(0);
            this.but_reduit.Name = "but_reduit";
            this.but_reduit.Size = new System.Drawing.Size(40, 40);
            this.but_reduit.TabIndex = 4;
            this.but_reduit.Text = "-";
            this.but_reduit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.but_reduit.UseVisualStyleBackColor = true;
            this.but_reduit.Click += new System.EventHandler(this.but_reduit_Click);
            // 
            // but_charger_sdf
            // 
            this.but_charger_sdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_charger_sdf.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_charger_sdf.Location = new System.Drawing.Point(6, 19);
            this.but_charger_sdf.Name = "but_charger_sdf";
            this.but_charger_sdf.Size = new System.Drawing.Size(118, 54);
            this.but_charger_sdf.TabIndex = 5;
            this.but_charger_sdf.Text = "Charger *.sdf";
            this.but_charger_sdf.UseVisualStyleBackColor = true;
            this.but_charger_sdf.Click += new System.EventHandler(this.but_charger_sdf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label_name_sdf);
            this.groupBox1.Controls.Add(this.but_charger_sdf);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 894);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fichier SDF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Liste des User_Channel";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 1;
            this.listBox1.Location = new System.Drawing.Point(6, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(341, 767);
            this.listBox1.TabIndex = 7;
            // 
            // label_name_sdf
            // 
            this.label_name_sdf.AutoSize = true;
            this.label_name_sdf.Location = new System.Drawing.Point(6, 89);
            this.label_name_sdf.Name = "label_name_sdf";
            this.label_name_sdf.Size = new System.Drawing.Size(73, 13);
            this.label_name_sdf.TabIndex = 6;
            this.label_name_sdf.Text = "Fichier SDF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_max_char_us);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_valdef_us);
            this.groupBox2.Controls.Add(this.tb_desc_us);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_name_us);
            this.groupBox2.Controls.Add(this.but_add_us);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(371, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 894);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fichier de noms";
            // 
            // label_max_char_us
            // 
            this.label_max_char_us.AutoSize = true;
            this.label_max_char_us.Location = new System.Drawing.Point(126, 99);
            this.label_max_char_us.Name = "label_max_char_us";
            this.label_max_char_us.Size = new System.Drawing.Size(67, 13);
            this.label_max_char_us.TabIndex = 10;
            this.label_max_char_us.Text = "40 car max";
            this.label_max_char_us.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Liste des User_Channel ajoutés";
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalExtent = 1;
            this.listBox2.Location = new System.Drawing.Point(6, 274);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(341, 611);
            this.listBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valeur par défaut";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_valdef_us
            // 
            this.tb_valdef_us.Location = new System.Drawing.Point(129, 195);
            this.tb_valdef_us.Name = "tb_valdef_us";
            this.tb_valdef_us.Size = new System.Drawing.Size(218, 20);
            this.tb_valdef_us.TabIndex = 13;
            // 
            // tb_desc_us
            // 
            this.tb_desc_us.Location = new System.Drawing.Point(129, 155);
            this.tb_desc_us.Name = "tb_desc_us";
            this.tb_desc_us.Size = new System.Drawing.Size(218, 20);
            this.tb_desc_us.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Channel";
            // 
            // tb_name_us
            // 
            this.tb_name_us.Location = new System.Drawing.Point(129, 115);
            this.tb_name_us.Name = "tb_name_us";
            this.tb_name_us.Size = new System.Drawing.Size(218, 20);
            this.tb_name_us.TabIndex = 8;
            this.tb_name_us.TextChanged += new System.EventHandler(this.tb_name_us_TextChanged);
            // 
            // but_add_us
            // 
            this.but_add_us.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add_us.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add_us.Location = new System.Drawing.Point(8, 19);
            this.but_add_us.Name = "but_add_us";
            this.but_add_us.Size = new System.Drawing.Size(118, 54);
            this.but_add_us.TabIndex = 6;
            this.but_add_us.Text = "Ajouter User Channel";
            this.but_add_us.UseVisualStyleBackColor = true;
            this.but_add_us.Click += new System.EventHandler(this.but_add_us_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.but_ecrire_sdf);
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.but_fusion);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(730, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 894);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exécuter";
            // 
            // but_ecrire_sdf
            // 
            this.but_ecrire_sdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ecrire_sdf.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ecrire_sdf.Location = new System.Drawing.Point(160, 19);
            this.but_ecrire_sdf.Name = "but_ecrire_sdf";
            this.but_ecrire_sdf.Size = new System.Drawing.Size(118, 54);
            this.but_ecrire_sdf.TabIndex = 16;
            this.but_ecrire_sdf.Text = "Ecrire SDF";
            this.but_ecrire_sdf.UseVisualStyleBackColor = true;
            this.but_ecrire_sdf.Click += new System.EventHandler(this.but_ecrire_sdf_Click);
            // 
            // listBox3
            // 
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalExtent = 1;
            this.listBox3.Location = new System.Drawing.Point(8, 274);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox3.Size = new System.Drawing.Size(270, 611);
            this.listBox3.TabIndex = 15;
            // 
            // but_fusion
            // 
            this.but_fusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_fusion.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_fusion.Location = new System.Drawing.Point(8, 19);
            this.but_fusion.Name = "but_fusion";
            this.but_fusion.Size = new System.Drawing.Size(118, 54);
            this.but_fusion.TabIndex = 6;
            this.but_fusion.Text = "Fusionner";
            this.but_fusion.UseVisualStyleBackColor = true;
            this.but_fusion.Click += new System.EventHandler(this.but_fusion_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(933, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "¤";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1024, 960);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_reduit);
            this.Controls.Add(this.but_quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDF_Config";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_quit;
        private System.Windows.Forms.Button but_reduit;
        private System.Windows.Forms.Button but_charger_sdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_name_sdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_add_us;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button but_fusion;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_name_us;
        private System.Windows.Forms.TextBox tb_desc_us;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_valdef_us;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label_max_char_us;
        private System.Windows.Forms.Button but_ecrire_sdf;
    }
}

