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
            this.but_charger_sdf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_name_sdf = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_max_char_us = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_valdef_us = new System.Windows.Forms.TextBox();
            this.tb_desc_us = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name_us = new System.Windows.Forms.TextBox();
            this.but_add_us = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.but_ecrire_sdf = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.but_fusion = new System.Windows.Forms.Button();
            this.but_charg_f = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_charger_sdf
            // 
            this.but_charger_sdf.BackColor = System.Drawing.Color.White;
            this.but_charger_sdf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_charger_sdf.FlatAppearance.BorderSize = 3;
            this.but_charger_sdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_charger_sdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_charger_sdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_charger_sdf.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_charger_sdf.Location = new System.Drawing.Point(6, 19);
            this.but_charger_sdf.Name = "but_charger_sdf";
            this.but_charger_sdf.Size = new System.Drawing.Size(118, 54);
            this.but_charger_sdf.TabIndex = 5;
            this.but_charger_sdf.Text = "Charger *.sdf";
            this.but_charger_sdf.UseVisualStyleBackColor = false;
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
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(371, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 894);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fichier de noms";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(341, 221);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.label_max_char_us);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_valdef_us);
            this.tabPage1.Controls.Add(this.tb_desc_us);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_name_us);
            this.tabPage1.Controls.Add(this.but_add_us);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(333, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manuel";
            // 
            // label_max_char_us
            // 
            this.label_max_char_us.AutoSize = true;
            this.label_max_char_us.Location = new System.Drawing.Point(116, 63);
            this.label_max_char_us.Name = "label_max_char_us";
            this.label_max_char_us.Size = new System.Drawing.Size(67, 13);
            this.label_max_char_us.TabIndex = 19;
            this.label_max_char_us.Text = "40 car max";
            this.label_max_char_us.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Valeur par défaut";
            // 
            // tb_valdef_us
            // 
            this.tb_valdef_us.Location = new System.Drawing.Point(119, 159);
            this.tb_valdef_us.Name = "tb_valdef_us";
            this.tb_valdef_us.Size = new System.Drawing.Size(208, 20);
            this.tb_valdef_us.TabIndex = 22;
            // 
            // tb_desc_us
            // 
            this.tb_desc_us.Location = new System.Drawing.Point(119, 121);
            this.tb_desc_us.Name = "tb_desc_us";
            this.tb_desc_us.Size = new System.Drawing.Size(208, 20);
            this.tb_desc_us.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "User Channel";
            // 
            // tb_name_us
            // 
            this.tb_name_us.Location = new System.Drawing.Point(119, 79);
            this.tb_name_us.Name = "tb_name_us";
            this.tb_name_us.Size = new System.Drawing.Size(208, 20);
            this.tb_name_us.TabIndex = 16;
            this.tb_name_us.TextChanged += new System.EventHandler(this.tb_name_us_TextChanged_1);
            // 
            // but_add_us
            // 
            this.but_add_us.BackColor = System.Drawing.Color.White;
            this.but_add_us.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_add_us.FlatAppearance.BorderSize = 3;
            this.but_add_us.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_add_us.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_add_us.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add_us.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add_us.Location = new System.Drawing.Point(3, 3);
            this.but_add_us.Name = "but_add_us";
            this.but_add_us.Size = new System.Drawing.Size(118, 54);
            this.but_add_us.TabIndex = 15;
            this.but_add_us.Text = "Ajouter User Channel";
            this.but_add_us.UseVisualStyleBackColor = false;
            this.but_add_us.Click += new System.EventHandler(this.but_add_us_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.but_charg_f);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(333, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fichier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 252);
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
            this.but_ecrire_sdf.BackColor = System.Drawing.Color.White;
            this.but_ecrire_sdf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_ecrire_sdf.FlatAppearance.BorderSize = 3;
            this.but_ecrire_sdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_ecrire_sdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_ecrire_sdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ecrire_sdf.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ecrire_sdf.Location = new System.Drawing.Point(160, 19);
            this.but_ecrire_sdf.Name = "but_ecrire_sdf";
            this.but_ecrire_sdf.Size = new System.Drawing.Size(118, 54);
            this.but_ecrire_sdf.TabIndex = 16;
            this.but_ecrire_sdf.Text = "Ecrire SDF";
            this.but_ecrire_sdf.UseVisualStyleBackColor = false;
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
            this.but_fusion.BackColor = System.Drawing.Color.White;
            this.but_fusion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_fusion.FlatAppearance.BorderSize = 3;
            this.but_fusion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_fusion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_fusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_fusion.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_fusion.Location = new System.Drawing.Point(8, 19);
            this.but_fusion.Name = "but_fusion";
            this.but_fusion.Size = new System.Drawing.Size(118, 54);
            this.but_fusion.TabIndex = 6;
            this.but_fusion.Text = "Fusionner";
            this.but_fusion.UseVisualStyleBackColor = false;
            this.but_fusion.Click += new System.EventHandler(this.but_fusion_Click);
            // 
            // but_charg_f
            // 
            this.but_charg_f.BackColor = System.Drawing.Color.White;
            this.but_charg_f.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_charg_f.FlatAppearance.BorderSize = 3;
            this.but_charg_f.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_charg_f.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_charg_f.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_charg_f.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_charg_f.Location = new System.Drawing.Point(3, 3);
            this.but_charg_f.Name = "but_charg_f";
            this.but_charg_f.Size = new System.Drawing.Size(118, 54);
            this.but_charg_f.TabIndex = 6;
            this.but_charg_f.Text = "Charger fichier";
            this.but_charg_f.UseVisualStyleBackColor = false;
            this.but_charg_f.Click += new System.EventHandler(this.but_charg_f_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1024, 960);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDF_Config";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_charger_sdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_name_sdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button but_fusion;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button but_ecrire_sdf;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_max_char_us;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_valdef_us;
        private System.Windows.Forms.TextBox tb_desc_us;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name_us;
        private System.Windows.Forms.Button but_add_us;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button but_charg_f;
    }
}

