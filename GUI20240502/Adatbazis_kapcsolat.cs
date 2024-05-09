using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI20240502

{
    internal class Adatbazis_kapcsolat
    {
        MySqlCommand sql_parancsok = null;
        public MySqlConnection adatbazis_kapcsolat = null;

        public Adatbazis_kapcsolat()
        {
            MySqlConnectionStringBuilder mscsb = new MySqlConnectionStringBuilder();
            mscsb.Server = "localhost";
            mscsb.UserID = "root";
            mscsb.Password = "";
            mscsb.Database = "tallest_buildings";
            mscsb.CharacterSet = "utf8";

            adatbazis_kapcsolat = new MySqlConnection(mscsb.ConnectionString);
            sql_parancsok = adatbazis_kapcsolat.CreateCommand();
        }
    }
}
