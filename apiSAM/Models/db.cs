using System;
using MySql.Data.MySqlClient;

namespace apiSAM.Models
{

    public class db{
        public MySqlConnection connection;
        public db(){
            this.connection = new MySqlConnection("datasource=localhost;port=3306;username=sam;password=sam2004;database=ourMall;");
        }
    }
}

