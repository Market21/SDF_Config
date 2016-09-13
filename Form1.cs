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
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "NIVSSDF Files|*.nivssdf";
            openFileDialog1.Title = "Select a SDF File";
            string sFileSDFName = "";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sFileSDFName = openFileDialog1.FileName;
                label_name_sdf.Text = sFileSDFName;
                
                XDocument doc = XDocument.Load(sFileSDFName);

                XElement xmtTree = XElement.Load(sFileSDFName);


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

                /*
                var user_channels_report_list_sorted =
                    from el in user_channels_report_list
                    orderby el descending
                    select el;
                */

                List<User_Channel> userlist = new List<User_Channel> { };

                foreach (XElement item in user_channels_report_list)
                {
                    userlist.Add(new User_Channel() { Name = item.Attribute("Name").Value, Description = "", Valeur_Defaut = "" });
                }


                


/*
                //XmlNodeList user_channel = doc.GetElementsByTagName("User Channels");
                //listBox1.Items.Add(user_channel.ToString());
                //Lecture XML
                XmlTextReader reader = new XmlTextReader(sFileSDFName);
                while (reader.Read())
                {
                    switch(reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name == "Section")
                            {
                                //listBox1.Items.Add(reader.Value);   
                            }
                            //listBox1.Items.Add(reader.Name);
                            break;

                        case XmlNodeType.Text:
                            //listBox1.Items.Add(reader.Value);
                            break;
                    }
                */
                }
            }
            

            
            
        

        private void button2_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select a File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }




    }
}
