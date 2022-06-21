using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontakty
{
    public partial class Form4 : Form
    {
      
        string imie;
        string nazwisko;
        string numertel;
        public Form4( string Imie, string Nazwisko, string Numertel)
        {
            InitializeComponent();

            this.imie = Imie;
            this.nazwisko = Nazwisko;
            this.numertel = Numertel;
            

            label1.Text = imie;
           label2.Text = nazwisko;
            label3.Text = numertel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
