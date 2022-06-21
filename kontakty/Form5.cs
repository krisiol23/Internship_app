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
    public partial class Form5 : Form
    {
        Form1 fr;
        string id;
        string imie;
        string nazwisko;
        string numertel;
        public Form5(string ID, string Imie, string Nazwisko, string Numertel, Form1 Fr)
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

        private void button1_Click(object sender, EventArgs e)
        {
            bazadanych db = new bazadanych();
            db.procedura("usun","id1", id);
            MessageBox.Show("Informacja: Usunięto: " + imie, "tytuł", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fr.refresh();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
