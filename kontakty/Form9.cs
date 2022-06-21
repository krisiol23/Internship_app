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
    public partial class Form9 : Form
    {
        Form1 fr;
        string temat;
        string opis;
        string id;
        string id_klienta;

        public Form9(string Id, string Temat, string Opis, Form1 Fr)
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
            bazadanych db = new bazadanych();
            db.procedura("usunNotatke","id1", id);
            fr.refreshnote();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
