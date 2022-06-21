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
    public partial class Form3 : Form
    {
        Form1 fr;
        string id;
        string imie;
        string nazwisko;
        string numertel;
        public Form3(string ID, string Imie, string Nazwisko, string Numertel, Form1 Fr)
        {
            InitializeComponent();
            this.id = ID;
            this.imie = Imie;
            this.nazwisko = Nazwisko;
            this.numertel = Numertel;
            this.fr = Fr;

            textBox1.Text = imie;
            textBox2.Text = nazwisko;
            textBox3.Text = numertel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            int numertel = Convert.ToInt32(textBox3.Text);

            string zapytanie = "Update kontakty set imie = '" + imie + "', nazwisko = '" + nazwisko + "', numertel = '" + numertel + "' where id = '" + id + "'";

            bazadanych db = new bazadanych();
            db.aktualizuj(zapytanie);
            MessageBox.Show("Informacja: Zaktualizowano: " + imie, "tytuł", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fr.refresh();
            this.Close();
            
        }
    }
}
