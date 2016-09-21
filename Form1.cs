using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SDF_Config
{
    public partial class FormMain : Form
    {
        //Création de la List contenant les (object)userchannel lus du ficher SDF
        List<User_Channel> userlist = new List<User_Channel> { };

        //Création de la List contenant les (object)userchannel à ajouter
        List<User_Channel> userlist_2 = new List<User_Channel> { };

        //Creation de la base XML d'un user channel
        XElement xml_base =
            new XElement("Channel", new XAttribute("Name", ""), new XAttribute("TypeGUID", "03D3B6C6-1485-13A6-56609EA3AE19E356"), new XAttribute("RowDim", "1"), new XAttribute("ColDim", "1"), new XAttribute("Units", ""), new XAttribute("BitFields", "7"),
                new XElement("Description"),
                new XElement("Properties"),
                new XElement("Errors"),
                new XElement("DefaultValue",
                    new XElement("Elem")
            )
        );

        //Chemin du fichier SDF
        string sFileSDFNamePath = "";
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void but_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_reduit_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void but_charger_sdf_Click(object sender, EventArgs e)
        {
            //Création et option de la boîte de dialogue pour l'ouverture du fichier .SDF
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "NIVSSDF Files|*.nivssdf";
            openFileDialog1.Title = "Select a SDF File";
            
            //Ouverture de la boite de dialogue
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                sFileSDFNamePath = openFileDialog1.FileName;
                
                //Affichage du nom du ficher SDF
                string[] sFileSDFName = sFileSDFNamePath.Split('\\');
                for (int i = 0; i < sFileSDFName.Length; i++)
			    {
			        if (i == sFileSDFName.Length - 1)
	                {
		                label_name_sdf.Text = sFileSDFName[i];
	                }
			    }
                
                
                //Chargement du fichier SDF
                XElement xmtTree = XElement.Load(sFileSDFNamePath);

                //Trie du fichier SDF pour ne récupérer que les user channels du dossier REPORT
                var user_list =
                    from el in xmtTree.Descendants("Section")
                    where el.Attribute("Name").Value == "User Channels"
                    select el;

                var user_channels_list =
                    from el in user_list.Descendants("Section")
                    where el.Attribute("Name").Value == "Report"
                    select el;

                var user_channels_report_list =
                    from el in user_channels_list.Descendants("Channel")
                    select el;

                //Création des objets
                foreach (XElement item in user_channels_report_list)
                {
                    userlist.Add(new User_Channel() 
                        { 
                            Name = item.Attribute("Name").Value, 
                            Description = item.Element("Description").Value, 
                            Valeur_Defaut = item.Element("DefaultValue").Element("Elem").Value,
                            TypeGUID = item.Attribute("TypeGUID").Value,
                            RowDim = item.Attribute("RowDim").Value,
                            ColDim = item.Attribute("ColDim").Value,
                            Units = item.Attribute("Units").Value,
                            BitFields = item.Attribute("BitFields").Value
                        });
                }

                //Affichage des user channel dans la listbox
                foreach (User_Channel item in userlist)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
        }

        //Bouton d'ajout d'un nouveau user channel
        private void but_add_us_Click_1(object sender, EventArgs e)
        {
            //Test si le nom contient 40 caractères max et s'il n'est pas vide
            if (tb_name_us.TextLength < 41 && tb_name_us.TextLength != 0)
            {
                //Ajout d'un nouvel objet User_Channel dans la Lsit qui contient les éléments renseignés
                userlist_2.Add(new User_Channel()
                {
                    Name = tb_name_us.Text,
                    Description = tb_desc_us.Text,
                    Valeur_Defaut = tb_valdef_us.Text,
                    TypeGUID = "03D3B6C6-1485-13A6-56609EA3AE19E356",
                    RowDim = "1",
                    ColDim = "1",
                    Units = "",
                    BitFields = "7",


                });



                //Ajout à la listbox 
                listBox2.Items.Clear();

                foreach (User_Channel item in userlist_2)
                {
                    listBox2.Items.Add(item.Name);
                }
            }
            else
            {
                if (tb_name_us.TextLength == 0)
                {
                    label_max_char_us.ForeColor = Color.Red;
                    label_max_char_us.Visible = true;
                    string message;
                    message = "User channel vide";
                    label_max_char_us.Text = message;
                }
                this.but_add_us.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
                this.but_add_us.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Test si le nom du user channel fait moins de 41 caractères
        private void tb_name_us_TextChanged_1(object sender, EventArgs e)
        {
            if (tb_name_us.TextLength > 40)
            {
                tb_name_us.ForeColor = Color.Red;
                label_max_char_us.Visible = true;
                string message;
                message = "40 caractères maximum : " + tb_name_us.TextLength + "/40";
                label_max_char_us.Text = message;
            }
            else
            {
                tb_name_us.ForeColor = Color.Black;
                label_max_char_us.Visible = false;
                label_max_char_us.Text = "40 caractères maximum";
                this.but_add_us.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                this.but_add_us.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        //Fusion des 2 list des user_channel
        private void but_fusion_Click(object sender, EventArgs e)
        {

            if (userlist.Count != 0 && userlist_2.Count != 0)
            {
                userlist.AddRange(userlist_2);

                foreach (User_Channel item in userlist)
                {
                    listBox3.Items.Add(item.Name);
                }
            }

        }

        private void but_ecrire_sdf_Click(object sender, EventArgs e)
        {
            string file_name = "";            
            SaveFileDialog saveFileSDF = new SaveFileDialog();
            //Création et option de la boîte de dialogue pour l'écriture du fichier .SDF
            saveFileSDF.Filter = "NIVSSDF Files|*.nivssdf";
            saveFileSDF.Title = "Select a SDF File";



            if (userlist.Count != 0)
            {
                if (saveFileSDF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    file_name = saveFileSDF.FileName;
                    //Elément qui contient tous les user channel
                    XElement userchannel = new XElement("UserChannel");

                    //Elément : user channel
                    XElement channel = new XElement("Channel");
                    //Attribut : Nom , ..
                    XAttribute name = new XAttribute("Name", "test");
                    XAttribute typeGUID = new XAttribute("TypeGUID", "03D3B6C6-1485-13A6-56609EA3AE19E356");
                    XAttribute rowDim = new XAttribute("RowDim", "1");
                    XAttribute colDim = new XAttribute("ColDim", "1");
                    XAttribute units = new XAttribute("Units", "");
                    XAttribute bitFields = new XAttribute("BitFields", "7");
                    XElement description = new XElement("Description");
                    XElement properties = new XElement("Properties");
                    XElement errors = new XElement("Errors");
                    XElement defaultValue = new XElement("DefaultValue", new XElement("Elem"));

                    //Parcours de la List qui contient tous les user channel à écrire dans le fichier SDF
                    foreach (User_Channel item in userlist)
                    {
                        //Création des éléments et attributs avec les données du user channel
                        channel = new XElement("Channel");
                        name = new XAttribute("Name", item.Name);
                        typeGUID = new XAttribute("TypeGUID", item.TypeGUID);
                        rowDim = new XAttribute("RowDim", item.RowDim);
                        colDim = new XAttribute("ColDim", item.ColDim);
                        units = new XAttribute("Units", item.Units);
                        bitFields = new XAttribute("BitFields", item.BitFields);
                        description = new XElement("Description", item.Description);
                        properties = new XElement("Properties");
                        errors = new XElement("Errors");
                        defaultValue = new XElement("DefaultValue", new XElement("Elem"));

                        //Ajouts des éléments et attributs 
                        channel.Add(name);
                        channel.Add(typeGUID);
                        channel.Add(rowDim);
                        channel.Add(colDim);
                        channel.Add(units);
                        channel.Add(bitFields);
                        channel.Add(description);
                        channel.Add(properties);
                        channel.Add(errors);
                        channel.Add(defaultValue);

                        //Ajout de l'éléments complété dans le fichier SDF
                        userchannel.Add(channel);


                    }

                    //Sauvegarde du fichier créé
                    userchannel.Save(@"user_channel.xml");

                    System.IO.StreamReader fichier_sdf_read = new System.IO.StreamReader(sFileSDFNamePath);
                    System.IO.StreamReader fichier_xml = new System.IO.StreamReader(@"user_channel.xml");
                    System.IO.StreamWriter fichier_sdl_write = new System.IO.StreamWriter(file_name);

                    string line;
                    string line_fichier_user_channel;
                    string line_tab = ("\t\t\t\t\t");
                    string line_report = ("\t\t\t\t\t<Section Name=\"Report\" TypeGUID=\"7f9b2ef4-f3fc-4448-975a7018fe511e0d\">");
                    string line_1 = "\t\t\t\t\t\t<Description>Channel utilisés pour les séquences Véristand</Description>";
                    string line_2 = "\t\t\t\t\t\t<Properties />";
                    string line_3 = "\t\t\t\t\t\t<Errors />";
                    bool b_fin_us = false;
                    bool b_deb_us = false;
                    bool bool1 = false;
                    int numero_ligne_report = 0;
                    int numero_ligne = 0;

                    while (fichier_sdf_read.EndOfStream != true)
                    {
                        numero_ligne++;
                        if ((line = fichier_sdf_read.ReadLine()) == line_report)//Détection de la ligne report
                        {
                            b_deb_us = true;
                            numero_ligne = numero_ligne_report;

                            //Ajout des lignes du dossier report
                            fichier_sdl_write.WriteLine(line);
                            fichier_sdl_write.WriteLine(line_1);
                            fichier_sdl_write.WriteLine(line_2);
                            fichier_sdl_write.WriteLine(line_3);

                            //Ajout des user channels
                            while (fichier_xml.EndOfStream != true)
                            {
                                line_fichier_user_channel = fichier_xml.ReadLine();
                                if (line_fichier_user_channel != "<?xml version=\"1.0\" encoding=\"utf-8\"?>" && line_fichier_user_channel != "<UserChannel>" && line_fichier_user_channel != "</UserChannel>")
                                {
                                    fichier_sdl_write.WriteLine(line_tab + line_fichier_user_channel);
                                }

                            }

                        }
                        else if (b_deb_us == false)//Jusqu'au début du dossier report
                        {
                            fichier_sdl_write.WriteLine(line);
                        }
                        else if (b_fin_us)//Fin de l'ancienne list des user channel dans le dossier report
                        {
                            fichier_sdl_write.WriteLine(line);
                        }
                        else if (b_deb_us && bool1 == false)//Si on est dans le dossier report
                        {
                            if (line.Contains("/Section"))//Détection de la balise de fin
                            {
                                b_fin_us = true;
                                bool1 = true;
                                fichier_sdl_write.WriteLine(line);
                            }
                        }
                        else
                        { }

                    }

                    fichier_sdf_read.Close();
                    fichier_sdl_write.Close();
                    fichier_xml.Close();


                }
                else
                {
                }

            
            

                }

        }

        private void but_charg_f_Click(object sender, EventArgs e)
        {
            //Création et option de la boîte de dialogue pour l'ouverture du fichier .SDF
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSV Files|*.csv";
            openFileDialog1.Title = "Select a csv File";

            string sFileCSVNamePath;


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Ouverture de la boite de dialogue
                sFileCSVNamePath = openFileDialog1.FileName;


            }
        }


    }
}
