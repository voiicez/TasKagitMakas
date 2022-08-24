using TasKagitMakas.Models;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {

        El _el = new El();
        public Form1()
        {
            InitializeComponent();
            rbKagit.Checked = true;
            lKazanan.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListeleriDoldur();
        }

        void ListeleriDoldur()
        {
            cb1.DataSource = _el.Hareketler; 
            //foreach (string hareket in _el.Hareketler)
            //{
            //    cb1.DataSource = _el.Hareketler;
            //}
            
                rbKagit.Text = _el.Hareketler[0];
            rbTas.Text = _el.Hareketler[1];
            rbMakas.Text = _el.Hareketler[2];
        }

        private void bOyna_Click(object sender, EventArgs e)
        {
            Basla();
        }

        void Basla()
        {
            string bilgisayarHareket = _el.HareketOlustur();//Local deðiþken
            /*string kullaniciHareket = cb1.SelectedValue.ToString();*/ //DropdownList.Text kullanýcýnýn seçtiði metni döner.

            string kullaniciHareket = _el.Hareketler[0];
            if (rbTas.Checked)
            {
                kullaniciHareket = _el.Hareketler[1];
            }
            else if (rbMakas.Checked)
                kullaniciHareket = _el.Hareketler[2];

            lKazanan.Text = "Siz: " + kullaniciHareket + "\n" +
                "Bilgisayar: " + bilgisayarHareket + "\n" +
                "Kazanan: " + KazananiBul(bilgisayarHareket,kullaniciHareket);
        }

        string KazananiBul(string bilgisayarHareket, string kullaniciHareket)
        {
            string kazanan;
            if (bilgisayarHareket == "Kaðýt" && kullaniciHareket != "Kaðýt")
            {
                if (kullaniciHareket == "Taþ")
                    kazanan = "Bilgisayar";
                else
                    kazanan = "Kullanýcý";
            }
            else if (bilgisayarHareket == "Makas" && kullaniciHareket != "Makas")
            {
                if (kullaniciHareket == "Kaðýt")
                    kazanan = "Bilgisayar";
                else
                    kazanan = "Kullanýcý";
            }
            else if (bilgisayarHareket == "Taþ" && kullaniciHareket != "Taþ")
            {
                if (kullaniciHareket == "Makas")
                    kazanan = "Bilgisayar";
                else
                    kazanan = "Kullanýcý";

            }
            else kazanan = "Berabere";
            return kazanan;

        } 
    }
            
                

        }
 
