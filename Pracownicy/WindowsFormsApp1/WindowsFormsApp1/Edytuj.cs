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

namespace WindowsFormsApp1
{
    public partial class Edytuj : Form
    {
        SqlConnection conn;
        int id;
        public Edytuj(Double pensja, String imie, String nazwisko,int id, SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.id = id;
            Imie.Text = imie;
            Nazwisko.Text = nazwisko;
            Pensja.Text = pensja.ToString("F2");

        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand();

                sc.Connection = conn;
                sc.CommandText = "UPDATE Pensja SET Imie ='"+Imie.Text+"', Nazwisko = '"+Nazwisko.Text +"',Pensja = '"+Convert.ToDouble(Pensja.Text)+"' where Id = '" + id + "'";
                sc.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            this.Close();
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.conn.Close();
            this.Close();
        }
    }
}
