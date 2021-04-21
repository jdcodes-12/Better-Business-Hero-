using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBH___Class_Libraries
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool CSVfile)
        {
            if (database)
            {
                //TODO - Setup SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }


            if (CSVfile)
            {
                //TODO - Create CSV Connection
                CSVConnector csv = new CSVConnector();
                Connections.Add(csv);
            }
        }
    }
}
