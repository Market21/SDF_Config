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


                IEnumerable<XElement> de =
                    from el in xmtTree.Elements("Section")
                        //doc.Descendants("Channel")
                    //where (string)el.Element("Name") == "Report"
                    //where (string)el.Attribute("Name") == "User Channels"
                    select el;

                foreach (XElement item in de)
                {
                    listBox1.Items.Add(item.Attribute("Name").Value);
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




    }
}
