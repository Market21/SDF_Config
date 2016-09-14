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
            string sFileSDFNamePath = "";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Ouverture de la boite de dialogue
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
 

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_name_us.TextLength < 41 && tb_name_us.TextLength != 0)
            {
                userlist_2.Add(new User_Channel()
                {
                    Name = tb_name_us.Text,
                    Description = tb_desc_us.Text,
                    Valeur_Defaut = tb_valdef_us.Text            
                });

                listBox2.Items.Clear();

                foreach (User_Channel item in userlist_2)
                {
                
                    listBox2.Items.Add(item.Name);
                }
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

        private void tb_name_us_TextChanged(object sender, EventArgs e)
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
            }
        }

        private void but_fusion_Click(object sender, EventArgs e)
        {
            userlist.AddRange(userlist_2);

            foreach (User_Channel item in userlist)
            {
                listBox3.Items.Add(item.Name);
            }
        }


        XDocument xml_fin = new XDocument();
        private void but_ecrire_sdf_Click(object sender, EventArgs e)
        {
            XElement xml_fusionne = new XElement(xml_base);
            

            xml_fin.Add(new XElement("Channel", new XAttribute("Name", "tes"), new XAttribute("TypeGUID", "03D3B6C6-1485-13A6-56609EA3AE19E356"), new XAttribute("RowDim", "1"), new XAttribute("ColDim", "1"), new XAttribute("Units", ""), new XAttribute("BitFields", "7"),
            new XElement("Description"),
            new XElement("Properties"),
            new XElement("Errors"),
            new XElement("DefaultValue",
                new XElement("Elem")
                )
                )
            );




            /*
            foreach (User_Channel item in userlist)
            {
                xml_fin.Add(new XElement("Channel", new XAttribute("Name", item.Name), new XAttribute("TypeGUID", "03D3B6C6-1485-13A6-56609EA3AE19E356"), new XAttribute("RowDim", "1"), new XAttribute("ColDim", "1"), new XAttribute("Units", ""), new XAttribute("BitFields", "7"),
                new XElement("Description"),
                new XElement("Properties"),
                new XElement("Errors"),
                new XElement("DefaultValue",
                    new XElement("Elem")
                    )
                    )
                );
            }*/
        }
    }
}
