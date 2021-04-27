using Borjomi.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borjomi.Data
{
    public class SQLOperation
    {
        private SqlConnection connect = null;

        public void OpenConnection(string connectionString)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
        }

        public void CloseConnection()
        {
            connect.Close();
        }

        public void Update(Staff staff)
        {
            string sql = string.Format("Update Staff Set first-name = '{0}' Where id = '{1}'",
                   staff.first_name, staff.id);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                cmd.ExecuteNonQuery();
            }
        }




    }
}
