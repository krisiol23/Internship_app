using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using System.Data;

namespace kontakty
{
    class bazadanych
    {
        string connection = "";
        public void polaczenie(string zapytanie, DataGridView gr)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection();
                connect.ConnectionString = connection;
                connect.Open();
                MySqlCommand zap = new MySqlCommand(zapytanie, connect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(zap);

                DataTable dt = new DataTable();
                DataSet ds = new DataSet();

                adapter.Fill(ds);
                dt = ds.Tables[0];

                gr.DataSource = dt;

                connect.Close();
            }
            catch
            {
                MessageBox.Show("brak polaczenia");
            }
        }

        public void dodaj(string zapytanie)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection();
                connect.ConnectionString = connection;
                connect.Open();
                MySqlCommand zap = new MySqlCommand(zapytanie, connect);

                zap.ExecuteNonQuery();

                connect.Close();
            }
            catch
            {
                MessageBox.Show("brak polaczenia");
            }
        }
        public void aktualizuj(string zapytanie)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection();
                connect.ConnectionString = connection;
                connect.Open();
                MySqlCommand zap = new MySqlCommand(zapytanie, connect);

                zap.ExecuteNonQuery();

                connect.Close();
            }
            catch
            {
                MessageBox.Show("brak polaczenia");
            }
        }
        public void procedura(string nazwa_proc, string zmienna, string parametr)
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                BindingSource bindingSource1 = new BindingSource();
                DataTable dt = new DataTable();

                using (MySqlCommand cmd = new MySqlCommand(nazwa_proc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(zmienna, MySqlDbType.VarChar).Value = parametr;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public void notatka(string zapytanie)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection();
                connect.ConnectionString = connection;
                connect.Open();
                MySqlCommand zap = new MySqlCommand(zapytanie, connect);

                zap.ExecuteNonQuery();

                connect.Close();
            }
            catch
            {
                MessageBox.Show("brak polaczenia");
            }
        }
    }
}
