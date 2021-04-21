using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBH___Class_Libraries
{
    public class EmployeeModel : UserProfileModel
    {
        private int EIN;
        private string socialSecurityNumber;
        private double dailyHours;
        private double weeklyHours;
        private double monthlyHours;
        private double yearlyHours;
        private double hours;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double HourlyWage { get; set; }
        public double HoursWorkedYTD { get;set; }
        public double HoursWorkedMonthly { get; set; }
        public double HoursWorkedWeekly { get; set; }
        public double HoursWorkedDaily { get; set; }

        public string CellphoneNumber { get; set; }

        public EmployeeModel()
        {
            FirstName = "";
            LastName = "";
            HourlyWage = 0.0;
            HoursWorkedYTD = 0.0;
            HoursWorkedMonthly = 0.0;
            HoursWorkedWeekly = 0.0;
            HoursWorkedYTD = 0.0;
            CellphoneNumber = "";
            this.EIN = 0;
            this.socialSecurityNumber = "";
            setSecurityLevel(1);
            setPassword("");
        }

        //Getters
      

        public int getEIN()
        {
            return this.EIN;
        }

        public string socialSecurityInfo()
        {
            return this.socialSecurityNumber;
        }

        //Setters
        public void setEIN(int EIN)
        {
            this.EIN = EIN;
        }

        public void setSocialSecurityNumber(string socialSecurityNumber)
        {
            this.socialSecurityNumber = socialSecurityNumber;
        }

        //Methods
        public void viewHoursWorked()
        {

        }
      
        public void displayEmployeeInfo()
        {

        }


        //Utility Methods
        private double calculateHoursWorkedYTD()
        {
            return 0.0;
        }

        private double calculateHoursWorkedMonthly()
        {
            return 0.0;
        }

        private double calculateHoursWorkedWeekly()
        {
            return 0.0;
        }

        private double calculateHoursWorkedDaily()
        {
            return 0.0;
        }
    }
}
