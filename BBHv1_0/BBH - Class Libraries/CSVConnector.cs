using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBH___Class_Libraries
{
    public class CSVConnector : IDataConnection
    {
        public UserProfileModel createUserProfile(UserProfileModel model)
        {
            model.setId(1);

            return model;
        }
    }
}
