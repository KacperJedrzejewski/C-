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
    public partial class Form1 : Form
    {  //tutaj musisz zmienic SqlConnection: view -> Server Explorer -> Properties -> ConnectionString 
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kacpe\\Documents\\PensjaDB.mdf;Integrated Security=True;Connect Timeout=30");
        int id,counter = 0;
        bool dochod;
        public delegate void pensja(Double sum);
        
        public Form1()
        {
            InitializeComponent();
            try
            {
                conn.Open();
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            Sad.Visible = false;
            Neutral.Visible = false;
            happy.Visible = false;
        }
        
        private void Wypisz(DataTable dt)
        {
            Imie.Text = dt.Rows[counter][1].ToString();
            Nazwisko.Text = dt.Rows[counter][2].ToString();
            Pensja.Text = dt.Rows[counter][3].ToString();
            id = Convert.ToInt32(dt.Rows[counter][0]);
            if (dt.Rows[counter][4].ToString() == "True") dochod = true;
            else dochod = false;

        }
        private DataTable Polaczenie()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Pensja;", conn);
                
                sda.Fill(dt);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
                

            }
            return dt;
        }
     
        private void Emocja(double pensja)
        {
            if (pensja < 2000) { Sad.Visible = true;
                Neutral.Visible = false;
                happy.Visible = false;
            }
            else if (pensja < 4500) {
                Sad.Visible = false;
                Neutral.Visible = true;
                happy.Visible = false;
            }
            else {
                Sad.Visible = false;
                Neutral.Visible = false;
                happy.Visible = true;
            }
        }

        private void Wypelnij(Double sum)
        {
            Double chorobowe, rentowe, emerytalne,pensja;
            Double zdrowotna, koszty, pit;
            pensja = sum;
            
            chorobowe = sum * 0.0245;
            rentowe = sum * 0.065;
            emerytalne = sum * 0.0976;
            zdrowotna = 0.09 * (sum - chorobowe - rentowe - emerytalne);
            if (dochod) koszty = 115.25;
            else koszty = 137.00;
           
            pit = 0.18 * (sum - koszty - chorobowe - rentowe - emerytalne) -
                46.33 - 0.0775 * (sum - chorobowe - rentowe - emerytalne);

            
            Chorobowe.Text = chorobowe.ToString("F2");
            Rentowe.Text = rentowe.ToString("F2");
            Emerytalne.Text = emerytalne.ToString("F2");
            Zdrowotna.Text = zdrowotna.ToString("F2");
            Koszty.Text = koszty.ToString("F2");
            Pit.Text = pit.ToString("F2");
            sum = chorobowe + rentowe + emerytalne + zdrowotna + koszty + pit;
            Suma.Text = sum.ToString("F2");
            if (NETTO.Checked) Pensja.Text = (pensja - sum).ToString("F2");
            Emocja( pensja);

        }

        private void WypelnijNetto(Double sum) {
            try
            {
                Pensja.Text = (sum - Convert.ToDouble(Suma.Text)).ToString("F2");
            }
            catch
            {
                Wypelnij(sum);
            }
        }


        private void Wyczysc()
        {
            Pensja.Text = "";
            Imie.Text = "";
            Nazwisko.Text = "";
            Chorobowe.Text = "";
            Rentowe.Text = "";
            Emerytalne.Text = "";
            Zdrowotna.Text = "";
            Koszty.Text = "";
            Pit.Text = "";
            Suma.Text = "";
        }

        private void Poprzedni_Click(object sender, EventArgs e)
        {
            DataTable dt = Polaczenie();

            try
            {
                counter--;
                Wypisz(dt);
                

            }
            catch
            {
                counter = dt.Rows.Count - 1;
                Wypisz(dt);
                if (dt.Rows.Count > 1) { counter--; }

            }

            Wypelnij(Convert.ToDouble(Pensja.Text));
        }

        private void Nastepny_Click(object sender, EventArgs e)
        {
            DataTable dt = Polaczenie();
            try
            {
                counter++;
                Wypisz(dt);
                

            }
            catch
            {
                counter = 0;
                Wypisz(dt);
                if (dt.Rows.Count > 1) { counter++; }
            }
            
            Wypelnij(Convert.ToDouble(Pensja.Text));
        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Close();
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
               
            }
            Application.Exit();
        }

        private void Nowy_Click(object sender, EventArgs e)
        {
            Nowy okno = new Nowy(conn);
            okno.Show();  
        }

        private void NETTO_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = Polaczenie();
           
            Wypisz(dt);
            pensja pensja;
            if (NETTO.Checked)
            {
                pensja = new pensja(WypelnijNetto);
            }
            else
            {
                pensja = new pensja(Wypelnij);
            }

            pensja(Convert.ToDouble(Pensja.Text));

        }


        private void Edytuj_Click(object sender, EventArgs e)
        {
            try
            {
                Edytuj edytuj = new Edytuj(Convert.ToDouble(Pensja.Text), Imie.Text, Nazwisko.Text, id, conn);
                edytuj.Show();
            }
            catch
            {
                MessageBox.Show("Wybierz najpierw pracownika do edycji");

            }
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand();
                
                    sc.Connection = conn;
                    sc.CommandText = "DELETE FROM Pensja where Id = '" + id + "'";
                    sc.ExecuteNonQuery();
                    
                
                Wyczysc();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

       
    }
}
