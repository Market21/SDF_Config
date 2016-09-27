using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
namespace SDF_Config
{
    class List_Box_User_Chan : System.Windows.Forms.ListBox
    {
        private Hashtable Color_name = null;
        private SolidBrush sbText = null;
        private SolidBrush sbTextSelected = null;
        
        public List_Box_User_Chan()
        {
            Color_name = new Hashtable();
            this.DrawMode = DrawMode.OwnerDrawVariable;
            sbText = new SolidBrush(this.ForeColor);
            sbTextSelected = new SolidBrush(Color.FromKnownColor(KnownColor.HighlightText));
        }
        
        
        //ajoute un item en spécifiant ce qu'on doit écrire "sender" et 
        //en quelle couleur l'écrire
        public void ItemAdd(object sender, Color c)
        {
            Color_name.Add(this.Items.Count, new SolidBrush(c));
            this.Items.Add(sender);
        }

        // couleur de l'item
        public void ItemColor(int indice_item, Color c)
        {
            if (Color_name[indice_item] == null)
            {
                if (c == Color.Empty)
                    return;
                else
                    Color_name.Add(indice_item, new SolidBrush(c));
            }
            else
            {
                if (c == Color.Empty)
                    Color_name.Remove(indice_item);
                else
                    Color_name[indice_item] = new SolidBrush(c);
            }

            this.RefreshItem(indice_item);
        }
    }
}
