using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificareUtilizatori
{
    class DAO
    {

        //Dictionary for login methods
        public Dictionary<string, List<Utilizator>> login_methods;

        //Constructor
        public DAO()
        {

            //Dictionary
            login_methods = new Dictionary<string, List<Utilizator>>();

            //Initialize Dictionary
            addLoginMethod("Windows");
            addLoginMethod("Temporari");
            addLoginMethod("Facebook");

            //Data
            login_methods["Windows"].Add(new Utilizator("Theo", "1234","Windows"));
            login_methods["Temporari"].Add(new Utilizator("Dani", "1234","Temporari"));
            login_methods["Facebook"].Add(new Utilizator("Petru", "1234","Facebook"));

        }

        //Add new login method
        public void addLoginMethod(string loginMethod)
        {
            login_methods.Add(loginMethod, new List<Utilizator>());
        }

        //LogIn
        public  bool login(Utilizator tempUser)
        {
            try
            {
                foreach (Utilizator u in login_methods[tempUser.MetodaAutentificare])
                {
                    if (u.UserName.Equals(tempUser.UserName) && u.Password.Equals(tempUser.Password))
                        return true;
                }
                
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Username-ul sau parola nu au fost gasite in baza de date");
            return false;
        }

    }
}
