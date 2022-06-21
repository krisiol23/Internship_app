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
    public partial class Form8 : Form
    {
        Form1 fr;
        string temat;
        string opis;
        string id;
        string id_klienta;

        public Form8(string Id,string Temat, string Opis, Form1 Fr)
        {
            InitializeComponent();
            this.fr = Fr;
            this.temat = Temat;
            this.opis = Opis;
            this.id = Id;
            

            textBox1.Text = temat;
            richTextBox1.Text = opis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temat = textBox1.Text;
            string opis = richTextBox1.Text;
            
            string zapytanie = "Update notatki set temat = '"+temat+"',opis = '"+opis+ "' where id = '" +id+"'";

            bazadanych db = new bazadanych();
            db.aktualizuj(zapytanie);
            fr.refreshnote();
            this.Close();
        }

    }
}
