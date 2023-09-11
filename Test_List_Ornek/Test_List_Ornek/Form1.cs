using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_List_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListele1_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();
            karakterler.Add("MAzhar");
            karakterler.Add("Ruhsar");
            karakterler.Add("Menkıbe");
            karakterler.Add("Müfit");
            karakterler.Add("Reyhan");
            karakterler.Add("Firdevs");

            karakterler.Remove("Mufit");

            foreach (string k in karakterler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void BtnListele2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(45);
            sayilar.Add(33);
            sayilar.Add(22);
            sayilar.Add(65);
            sayilar.Add(78);
            sayilar.Add(96);



            foreach (int s in sayilar)
            {
                if (s % 5 == 0)
                {
                    listBox2.Items.Add(s);
                }
            }

            if (sayilar.Contains(45))
            {
                MessageBox.Show("sayı var");
            }
            else
            {
                MessageBox.Show("sayı yok");
            }
        }

        private void BtnListele3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();

            kisi.Add(new Kisiler()
            {
                ADI = "ali",
                SOYADI = "ÇINAR",
                MESLEK = "ÖGRETMEN"
            });

            foreach (Kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI + " " + k.SOYADI + " " + k.MESLEK);
            }
        }
    }
}
