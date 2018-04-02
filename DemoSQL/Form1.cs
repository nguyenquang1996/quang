using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DALayer;

namespace DemoSQL
{
    public partial class Form1 : Form
    {
        DAL s = null;
        public string Server;
        public string Database;
        public string UserID;
        public string Password;
        public string conn = "";
        public string f = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void bnttest_Click(object sender, EventArgs e)
        {
            Server = server.Text.ToString();
            UserID = username.Text.ToString();
            Password = password.Text.ToString();

            database.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=" + server.Text + ";Initial Catalog=QuanLyQuanCaFe;User Id=" + username.Text + ";Password=" + password.Text + ";");
            SqlCommand cmd = new SqlCommand("select name from sys.databases", con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    database.Items.Add(reader[0].ToString());
                }
                database.Enabled = true;

                MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi, vui lòng thử lại!");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Dispose();
                //cmd.Dispose();
            }
        }

        private void bntcon_Click(object sender, EventArgs e)
        {
            conn = @"Server=" + Server + ";Database=" + database.Text.ToString() + ";User ID=" + UserID + ";Password=" + Password;
            StreamWriter writer = new StreamWriter("ConnectString.con");
            writer.WriteLine(conn);
            writer.Close();
            s = new DAL();
            if (s.Connection() == "ok")
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Connect Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
