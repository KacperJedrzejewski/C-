using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace StacjaPaliw
{
    public partial class Tankowanie : Form
    {
        SqlConnection conn;
        DataTable dt;
        Double cena,kwota,zalane;
        string rodzaj;
        int i1 = 0;
        public delegate void Tankuj();
        public Tankowanie(SqlConnection conn, DataTable dt, Double cena,String rodzaj)
        {
            InitializeComponent();
            this.cena = cena;
            this.conn = conn;
            this.dt = dt;
            this.rodzaj = rodzaj;
           
        }


        private void Taknowanie_Load(object sender, EventArgs e)
        {

        }

        private void ZapiszDoBazy()
        {
            int id = dt.Rows.Count-1;
            //bez klientów please
           
            //szukamy idKlienta w bazie zeby moc dodac wpis z jego id 
        

            string data = DateTime.Now.ToString().Substring(0, 16);//pobiera akutalna date .sybstring pobiera pierwsze 12 znakow w ktorych jest dzien miesiac i rok
            int tmp = 0;
            Double ile = kwota / cena;
            ile = Math.Round(ile, 4);
            string ileS =  ile.ToString().Replace(",", "."); // musimy zmienic , na . bo w c# double maja jako , jako zaznaczanie czesci ulamkowaj a sql korzysta z .
            
            while (tmp !=1)
            {
                try
                {
                    SqlCommand sc = new SqlCommand();
                    sc.Connection = conn;
                    sc.CommandText = "INSERT INTO Tankowania (Id,Kwota,Ilosc_litrow,Rodzaj_paliwa,Data) Values('" + id+"','"+ (float)kwota + "',CONVERT(float, '" + ileS + "'),'"+rodzaj+"','" + data+ "')";
                    sc.ExecuteNonQuery();
                   
                    tmp = 1;
                    
                }
                catch 
                {
                    id++;


                }
            }
            //dodajemy wpis na pierwszym wolnym id 
            this.Close();

        }

        private void BtnTankuj_Click(object sender, EventArgs e)
        {
            Tankuj tankuj;
            bool tmp=true; 
            if (rbt20.Checked) { kwota = 20.00; }
            else if (rbt050.Checked) { kwota = 50.00; }
            else if (rbt100.Checked) { kwota = 100.00; }
            else if (rbt150.Checked) { kwota = 150.00; }
            else if (rbt200.Checked) { kwota = 200.00; }
            else if (rbtZaKwote.Checked)
            {
                kwota = Convert.ToDouble(txtZaKwote.Text);

            }
            else { tankuj = new Tankuj(Zegar);tmp = false; }

            if(tmp) Wlewanie();

           


        }
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        private void Wlewanie() {

            i1 = 1;
            zalane = 0;
            Zaczekaj(t1);
            
        }

        private void Zaczekaj(System.Windows.Forms.Timer t1) {
            t1.Interval = 500;
            t1.Tick += new EventHandler(Zegar1_Tick);
            t1.Start();
           
        }
        private void Zegar1_Tick(object sender, EventArgs e)
        {
            i1++;
            zalane += kwota / 16;
            txtTankIleL.Text = zalane.ToString();
            txtTankDoZaplaty.Text = Math.Round(zalane / cena, 2).ToString();
            if (i1 > 4 && i1 < 8) ladowanie.Load(@"C:\Users\kacpe\Downloads\aisd\StacjaPaliw\StacjaPaliw\Resources\25.png");
            else if (i1 > 8 && i1 < 12) ladowanie.Load(@"C:\Users\kacpe\Downloads\aisd\StacjaPaliw\StacjaPaliw\Resources\50.png");
            else if (i1 > 12 && i1 < 15) ladowanie.Load(@"C:\Users\kacpe\Downloads\aisd\StacjaPaliw\StacjaPaliw\Resources\75.png");
           
            
            if (zalane == kwota) {
                ladowanie.Load(@"C:\Users\kacpe\Downloads\aisd\StacjaPaliw\StacjaPaliw\Resources\100.png");
                t1.Stop(); }
        }
        private void RbtZaKwote_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtZaKwote.Checked) txtZaKwote.ReadOnly = false;
            else txtZaKwote.ReadOnly = true;


        }

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        private void Zegar()
        {
            //tworzymy petle ktora bedize powiekszac nam cene o dopoku jest wsisniety przycisk
            t.Interval = 500;
            t.Tick += new EventHandler(Zegar_Tick);
            t.Start();
        }

       

            private void Zegar_Tick(object sender, EventArgs e)
        {
            double kwota;
            kwota = Convert.ToDouble(txtTankIleL.Text);
            kwota += cena / 3;
            
            txtTankIleL.Text = Math.Round(kwota, 2).ToString();
            txtTankDoZaplaty.Text = Math.Round(kwota/cena, 2).ToString();
            
        }
      

        private void BtnTankuj_MouseUp(object sender, MouseEventArgs e)
        {
            t.Stop();
        }

        private void BtnTankuj_MouseDown(object sender, MouseEventArgs e)
        {
            Zegar();
        }

        private void zaplac_Click(object sender, EventArgs e)
        {
            ZapiszDoBazy();
        }
    }
}