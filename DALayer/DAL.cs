using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace DALayer
{
    public class DAL
    {
        SqlConnection conn = null;
        SqlCommand comm = null;
        string strCon = null;

        public DAL()
        {
            StreamReader reader = new StreamReader("ConnectString.con");
            strCon = reader.ReadLine();
            conn = new SqlConnection(strCon);
            comm = conn.CreateCommand();
        }
        public string Connection()
        {

            try
            {
                conn = new SqlConnection(strCon);
                comm = conn.CreateCommand();
                string f = "ok";
                return f;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
    }
}
