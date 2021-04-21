using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBH___Class_Libraries
{
    public abstract class UserProfileModel
    {
        private int id;
        private int securityLevel;
        private string password;

        
        //Getters
        public int getId() 
        {
            return this.id;
        }


        public int getSecurityLevel()
        {
            return this.securityLevel;
        }

        public string getPassword()
        {
            return this.password;
        }

        //Setters
        public void setId(int id)
        {
            this.id = id;
        }

        public void setSecurityLevel(int securityLevel)
        {
            this.securityLevel = securityLevel;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        //Methods

        //Used to go to navigation page
        public void login()
        {

        }

        //Used to go back to login screen
        public void logout()
        {

        }

        public void viewUserInfo()
        {

        }

        //Utility Methods
        public void toString()
        {

        }

        public bool exists()
        {
            return true;
        }
    }
}
