using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mojaKontrolka;

namespace kontakty
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            kontrolka k = new kontrolka();
            this.Controls.Add(k);
            k.Dock = DockStyle.Fill;
        }
    }
}
