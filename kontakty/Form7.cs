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
    public partial class Form7 : Form
    {
        string temat;
        string opis;
        public Form7(string Temat,string Opis)
        {
            InitializeComponent();
            this.temat = Temat;
            this.opis = Opis;
            label1.Text = temat;
            label2.Text = opis;
        }
    }
}
