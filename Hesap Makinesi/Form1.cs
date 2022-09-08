using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1;
        double sayi2;
        string işlem;
        double sonuc;
        private void btn1_Click(object sender, EventArgs e)
        {
            txtsayi.Text+= "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtsayi.Text+= "2";


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtsayi.Text+= "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtsayi.Text+= "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtsayi.Text+= "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtsayi.Text+= "6";


        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtsayi.Text+= "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {    txtsayi.Text+= "8";


        }

    private void btn9_Click(object sender, EventArgs e)
        {
            txtsayi.Text+= "9";


        }

        private void btnbölü_Click(object sender, EventArgs e)
        {
             sayi1 = double.Parse(txtsayi.Text);
            işlem= "/";
            txtsayi.Clear();


        }

        private void btnvirgül_Click(object sender, EventArgs e)
        {
             sayi1 = double.Parse(txtsayi.Text);
            işlem= ",";
            txtsayi.Clear();


        }

        private void btncarpı_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(txtsayi.Text);
            işlem = "×";
            txtsayi.Clear();


        }

        private void btnarti_Click(object sender, EventArgs e)
        {

            sayi1 = double.Parse(txtsayi.Text);
            işlem= "+";
            txtsayi.Clear();

        }

        private void btneşittir_Click(object sender, EventArgs e)
        {
            sayi2= double.Parse(txtsayi.Text);

            if (işlem=="+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (işlem=="-")
            {
                sonuc= sayi1 - sayi2;   
            }
            else if (işlem=="/")
            {
                sonuc = sayi1 / sayi2;


            }
            else if (işlem== "×")
            {sonuc = sayi1 * sayi2;

            }
            txtsayi.Text = sonuc.ToString();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtsayi.Clear();
        }

        private void txtsayi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsıfır_Click(object sender, EventArgs e)
        {

        }

        private void btneksi_Click(object sender, EventArgs e)
        {

        }
    }
}
