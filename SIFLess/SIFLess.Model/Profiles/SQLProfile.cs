using System;
using System.ComponentModel;

namespace SIFLess.Model.Profiles
{
    public class SqlProfile
    {
       

        [Browsable(false)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ServerName { get; set; }

        public string Login { get; set; }

        [Browsable(false)]
        public string Password { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
