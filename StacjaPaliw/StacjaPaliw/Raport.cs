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
using System.Drawing.Drawing2D;

namespace StacjaPaliw
{
    public partial class Raport : Form
    {
        SqlConnection conn;
        DataTable dt1,dt;
        int liczba,counter= 0 ;
        string wartoscS;

        public Raport(SqlConnection conn, DataTable dt)
        {
            InitializeComponent();
            this.conn = conn;
            this.dt1 = dt;
            Resize1(@"C:\Users\kacpe\Downloads\aisd\StacjaPaliw\StacjaPaliw\Resources\End.png", @"C:\Users\kacpe\Downloads\aisd\StacjaPaliw\StacjaPaliw\Resources\EndNowy.png");

        }

        public void Resize1(string imageFile, string outputFile)
        {
            using (var srcImage = Image.FromFile(imageFile))
            {
                var newWidth = (int)(srcImage.Width * 1.5);
                var newHeight = (int)(srcImage.Height * 1.5);
                using (var newImage = new Bitmap(newWidth, newHeight))
                using (var graphics = Graphics.FromImage(newImage))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    graphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
                    newImage.Save(outputFile);
                }
            }
        }

        private void btnNastepny_Click(object sender, EventArgs e)
        {
            try
            {
                if (!btnPoprzednie.Enabled) { btnPoprzednie.Enabled = true; }
                if (koniec.Visible) koniec.Visible = false;
                if (PoprzedniLabel.Visible) PoprzedniLabel.Visible = false;
                counter++;
                Wypelnij();
               
            }
            catch
            {
                btnNastepny.Enabled = false;
                NastepnyLabel.Visible = true;
                koniec.Visible = true;

            }


        }
        
        private void btnPoprzednie_Click(object sender, EventArgs e)
        {
            try
            {
                if (!btnNastepny.Enabled ) { btnNastepny.Enabled = true; }
                if(koniec.Visible) koniec.Visible = false;
                if (NastepnyLabel.Visible) NastepnyLabel.Visible = false;
                 counter--;
                Wypelnij();


            }
            catch
            {
                btnPoprzednie.Enabled = false;
                PoprzedniLabel.Visible = true;
                koniec.Visible = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Wartosci();
            Wypelnij();
        }

        private void btnNastepny_MouseEnter(object sender, EventArgs e)
        {
            koniec.Load(@"C: \Users\kacpe\Downloads\aisd\StacjaPaliw\StacjaPaliw\Resources\EndNowy.png");
        }

        private void btnNastepny_MouseLeave(object sender, EventArgs e)
        {
            koniec.Load(@"C:\Users\kacpe\Downloads\aisd\StacjaPaliw\StacjaPaliw\Resources\End.png");
        }

        private void Wartosci()
        {
            dt = new DataTable();
            dt.Clear();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*),sum(kwota)  FROM Tankowania ;", conn);
                sda.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }

            string liczbaS;
            liczbaS = dt.Rows[0][0].ToString();
           
            liczba = Convert.ToInt32(liczbaS);
            wartoscS = dt.Rows[0][1].ToString();
            wartoscS = wartoscS.Replace(".", ",");
           

            Ilosc.Text = liczbaS;
            Suma.Text = wartoscS;


        }
        private void Wypelnij()
        {
            txtCzasTankowania.Text = dt1.Rows[counter][4].ToString();
            txtIloscLitrow.Text = dt1.Rows[counter][2].ToString();
            txtZaplacono.Text = dt1.Rows[counter][1].ToString();
            txtRodzaj.Text = dt1.Rows[counter][3].ToString();

        }
        

    }
}
