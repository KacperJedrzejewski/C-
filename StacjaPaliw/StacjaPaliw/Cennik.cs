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

namespace StacjaPaliw
{
    public partial class StacjaPaliw : Form
    {

        SqlConnection conn;
        DataTable dt;
        public StacjaPaliw()
        {
            InitializeComponent();
            PobierzCeny();
            Polaczenie();
            Dane();
        }
       
        private void Wypelnij (string[] label)
        {
            txtLPG.Text = label[0].Substring(0, 4);
            txtON.Text = label[1].Substring(0, 4);
            txtPb95.Text = label[2].Substring(0, 4);
            txtPb98.Text = label[3].Substring(0, 4);
        }

        HtmlWeb web = new HtmlWeb();
        private  void PobierzCeny()
        {
            String url = "http://pstradymno.pl/tabela-cen-paliw";  //z tej strony pobieramy ceny paliw
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);    //pobieram cala strone 
            HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//td").ToArray(); // znajduje wzorce ktore sie koncza /td czyli w naszym przypadku cey paliw w tabeli
            int checker = 0; //kontrolna zmienna bo chcemy tylko 4 wartosci wczytac
            string[] label = new string[4]; //tablica na ceny
            foreach (HtmlNode item in nodes)
            {
                if (checker > 3) break;
                label[checker] = item.InnerHtml.ToString().Trim();//Trim usuwa wszystkei biale znaki
                
                checker++;
            }
            Wypelnij(label); //wypelniamy tabele wartosciami z tablicy
        }

        private void Polaczenie()
        {
            //tutaj musisz zmienic SqlConnection: view -> Server Explorer -> Properties -> ConnectionString 
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kacpe\Downloads\aisd\StacjaPaliw\StacjaPaliw\StacjaBenzynowa.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void Dane()
        {
            dt = new DataTable();
            dt.Clear();
            //tworzymy tabele na dane z zapytanie sql
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tankowania;", conn);
                sda.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void StartTimer()
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(Zegar_Tick);
            t.Start();
           
        }


        private void Zegar_Tick(object sender, EventArgs e)
        {
            lblZegar.Text =  DateTime.Now.ToString();
        }

       

        private void StacjaPaliw_Load(object sender, EventArgs e)
        {
            StartTimer();

        }

        private void BtnWyjdz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRaport_Click(object sender, EventArgs e)
        {
            Dane();
            Raport rapot = new Raport(conn,dt);
            rapot.Show();
        }

        private void BtnTankuj_Click(object sender, EventArgs e)
        {
            string rodzaj;
            double cena;
            if (Pb95.Checked) { cena = Convert.ToDouble(txtPb95.Text.Replace(".", ","));rodzaj = "Pb95"; }//konwet textu z ramki do doubla i zmiana '.' na ',' bo double jako separator pobiera ',' 
            else if (Pb98.Checked) { cena = Convert.ToDouble(txtPb98.Text.Replace(".", ",")); rodzaj = "Pb98"; }
            else if (ON.Checked) { cena = Convert.ToDouble(txtON.Text.Replace(".", ",")); rodzaj = "ON"; }
            else if (LPG.Checked) { cena = Convert.ToDouble(txtLPG.Text.Replace(".",",")); rodzaj = "LPG"; }
            else { MessageBox.Show("Prosze zaznaczyc rodzaj paliwa do zatankowania");
                return;
            }

            Tankowanie nowe = new Tankowanie(conn,dt,(float)cena,rodzaj);
            nowe.ShowDialog();
        }
      
    }
}
