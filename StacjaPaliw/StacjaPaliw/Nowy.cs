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

namespace StacjaPaliw
{
    public partial class Nowy : Form
    {
        SqlConnection conn;
        public Nowy(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            int tmp = 0, id = 1;
            while (tmp != 1)
            {
                try
                {
                    SqlCommand sc = new SqlCommand();
                    sc.Connection = conn;
                    sc.CommandText = "INSERT INTO Klient (Id,Imie,Nazwisko) Values('" + id + "','" + Imie.Text + "','" +Nazwisko.Text + "')";
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Pomyslnie odano ");
                    tmp = 1;

                }
                catch 
                {
                    id++;


                }
            }
            this.Close();
            conn.Close();
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
            conn.Close();
        }
    }
}
