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
    public partial class Form6 : Form
    {
        Form1 fr;
        string id;
        string id_klienta;
        public Form6(string Id, Form1 Fr)
        {
            InitializeComponent();
            this.id = Id;
            this.fr = Fr;
          //  this.id_klienta = Id_klienta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temat = textBox1.Text;
            string opis = richTextBox1.Text;
            bazadanych db = new bazadanych();
            db.notatka("Insert into notatki(temat,opis,id_klienta) values('"+temat+"', '"+opis+"','"+id+"')");
            fr.refreshnote();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
