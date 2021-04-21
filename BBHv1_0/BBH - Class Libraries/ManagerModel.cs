using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBH___Class_Libraries
{
    public class ManagerModel : UserProfileModel
    {
        //Fields
        private string username;
        private double salary;

        public string FirstName { get; set;}
        public string LastName { get; set; }

        //Constructors
        public ManagerModel()
        {
            setSecurityLevel(2);
            this.username = "";
            setPassword("");
        }

        //Getters
        public string getUsername()
        {
            return this.username;
        }

        public double getSalary()
        {
            return this.salary;
        }

        //Setters
        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public void viewManagerInfo()
        {
            //Display Manager Info via toString
        }


    }



}
