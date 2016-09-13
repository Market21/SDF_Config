using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDF_Config
{
    class User_Channel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Valeur_Defaut { get; set; }
        public string TypeGUID { get; set; }
        public string RowDim { get; set; }
        public string ColDim { get; set; }
        public string Units { get; set; }
        public string BitFields { get; set; }

        public User_Channel(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
            this.Valeur_Defaut = Valeur_Defaut;
            this.TypeGUID = TypeGUID;
            this.RowDim = RowDim;
            this.ColDim = ColDim;
            this.Units = Units;
            this.BitFields = BitFields;
        }

        public User_Channel() { }

        ~User_Channel() { }



    }
}
