using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBH___Class_Libraries
{
    public class OwnerModel : UserProfileModel
    {
        //Fields
        private string username;

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellphoneNumber { get; set; }

        //Constructors
        public OwnerModel()
        {
            this.username = "";
            setPassword("");
            setSecurityLevel(3);
            FirstName = "";
            LastName = "";
        }

        //Getters
        public string getUsername()
        {
            return this.username;
        }

        //Setters
        public void setUsername(string username)
        {
            this.username = username;
        }

    }

}
