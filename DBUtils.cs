using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class DBUtils
    {
        //
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\banking_activities.mdf;Integrated Security=True
        //
        public static SqlConnection GetDBConnection()
        {
            return DBSQLServerUtils.GetDBConnection();
        }
    }
}
