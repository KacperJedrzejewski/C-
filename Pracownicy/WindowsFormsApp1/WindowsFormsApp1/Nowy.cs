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
    public partial class Nowy : Form
    {
        SqlConnection conn;

        public Nowy(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.conn.Close();
            this.Close();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            string imie, nazwisko;
            double pensja;
            bool dochod;
            int checker = 0,id = 1;
            imie = Imie.Text.ToString();
            nazwisko = Nazwisko.Text.ToString();
            pensja = Convert.ToDouble(Pensja.Text);

            if (pensja < 0) {
                MessageBox.Show("Pensja musi byc dodatnia");
                return;

            }

            if (Miejski.Checked) dochod = true;
            else if (Wiejski.Checked) dochod = false;
            else
            {
                MessageBox.Show("Prosze zaznaczyc miejsce pracy");
                return;
            }

            while (checker != 1)
            {
                try
                {
                    SqlCommand sc = new SqlCommand();
                    sc.Connection = conn;
                    sc.CommandText = "INSERT INTO Pensja (Id,Imie,Nazwisko,Pensja,Dochod) Values('" + id + "','"
                     + imie + "','" + nazwisko + "','" + pensja + "','" + dochod + "')";
                    sc.ExecuteNonQuery();
                    
                    checker = 1;
                }
                catch
                {
                    id++;
                }
            }
            this.Close();
        }

        
    }
}
