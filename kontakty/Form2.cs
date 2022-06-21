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
    public partial class Form2 : Form
    {
        Form1 fr;
        public Form2(Form1 Fr)
        {
            InitializeComponent();
            this.fr = Fr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string imie = textBox1.Text;
                string nazwisko = textBox2.Text;
                int numertel = Convert.ToInt32(textBox3.Text);
                string zapytanie = "INSERT INTO kontakty(imie,nazwisko,numertel) VALUES('" + imie + "', '" + nazwisko + "', '" + numertel + "')";

                bazadanych db = new bazadanych();
                db.dodaj(zapytanie);
                MessageBox.Show("Informacja: Dodano "+imie,"tytuł",MessageBoxButtons.OK,MessageBoxIcon.Information);
                fr.refresh();
                this.Close();
        }
            catch
            {
                //MessageBox.Show("Błąd!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
