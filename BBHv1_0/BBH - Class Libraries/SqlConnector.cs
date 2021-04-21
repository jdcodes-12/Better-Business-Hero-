using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBH___Class_Libraries
{
    public class SqlConnector : IDataConnection
    {

        public UserProfileModel createUserProfile(UserProfileModel user)
        {
            //Create Employee Profile
            if(user.getSecurityLevel() == 1)
            {

            }

            //Create Mangager Profile
            if(user.getSecurityLevel() == 2)
            {

            }

            //Create Owner Profile
            if(user.getSecurityLevel() == 3)
            {

            }

            //Creeate Financial Depart Profile
            if (user.getSecurityLevel() == 4)
            {

            }
        }
    }
}
