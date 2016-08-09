using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificareUtilizatori
{
    class Utilizator
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string MetodaAutentificare { get; set; }

        public Utilizator(string User, string Password,string Met)
        {
            this.UserName = User;
            this.Password = Password;
            this.MetodaAutentificare = Met;
        }
    }
}
