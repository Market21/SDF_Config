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

        public User_Channel(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

        public User_Channel() { }

        ~User_Channel() { }



    }
}
