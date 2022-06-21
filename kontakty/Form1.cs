using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblio;


namespace kontakty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bazadanych db = new bazadanych();
            db.polaczenie("Select id,imie,nazwisko, numertel from kontakty",dataGridView1);
            db.polaczenie("Select id,temat,opis, id_klienta from notatki", dataGridView2);
            przyciskdb();
            editBt();
            deltBt();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string numertel = textBox3.Text;
            string zapytanie = "SELECT id, imie, nazwisko, numertel from kontakty where imie like '%"+imie+"%' and nazwisko like '%"+nazwisko+"%' and numertel like '%"+numertel+"%'";

            bazadanych db = new bazadanych();

            db.polaczenie(zapytanie, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2(this);
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].FormattedValue.ToString();
            string imie = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["imie"].FormattedValue.ToString();
            string nazwisko = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nazwisko"].FormattedValue.ToString();
            string numertel = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["numertel"].FormattedValue.ToString();
            Form3 fr = new Form3(id,imie, nazwisko, numertel,this);
            fr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string imie = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["imie"].FormattedValue.ToString();
            string nazwisko = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nazwisko"].FormattedValue.ToString();
            string numertel = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["numertel"].FormattedValue.ToString();
            Form4 fr = new Form4(imie, nazwisko, numertel);
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].FormattedValue.ToString();
            string imie = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["imie"].FormattedValue.ToString();
            string nazwisko = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nazwisko"].FormattedValue.ToString();
            string numertel = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["numertel"].FormattedValue.ToString();
            Form5 fr = new Form5(id,imie, nazwisko, numertel,this);
            fr.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string imie = dataGridView1.Rows[e.RowIndex].Cells["imie"].FormattedValue.ToString();
                string nazwisko = dataGridView1.Rows[e.RowIndex].Cells["nazwisko"].FormattedValue.ToString();
                string numertel = dataGridView1.Rows[e.RowIndex].Cells["numertel"].FormattedValue.ToString();
                Form4 fr = new Form4(imie, nazwisko, numertel);
                fr.ShowDialog();
            }
        }

        public void refresh()
        {
            bazadanych db = new bazadanych();
            db.polaczenie("Select id, imie, nazwisko, numertel from kontakty", dataGridView1);
        }

        public void przyciskdb()
        {
            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            bt.Name = "bt";
            bt.HeaderText = "Notatki";
            bt.Text = "Dodaj notatkę";
            bt.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(bt);
        }
         
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
                if (e.ColumnIndex == dataGridView1.Columns["bt"].Index)
                {


                    string id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].FormattedValue.ToString();
             
                 // string  id_klienta = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["id_klienta"].FormattedValue.ToString();
                    Form6 fr = new Form6(id,  this);
                    fr.ShowDialog();
                
                }
            
        }
        public void refreshnote()
        {
            if (dataGridView2.CurrentRow != null)
            {
                string id_klienta = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["id_klienta"].FormattedValue.ToString();
                bazadanych db = new bazadanych();
                db.polaczenie("Select id,temat,opis,id_klienta from notatki where id_klienta = '" + id_klienta + "'", dataGridView2);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                string id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].FormattedValue.ToString();
                bazadanych db = new bazadanych();
                db.polaczenie("Select id,temat,opis,id_klienta from notatki where id_klienta = '" + id + "'", dataGridView2);
            }
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string temat = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["temat"].FormattedValue.ToString();
                string opis = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["opis"].FormattedValue.ToString();

                Form7 fr = new Form7(temat, opis);
                fr.ShowDialog();
            }
        }

        public void editBt()
        {
            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            bt.Name = "edit";
            bt.HeaderText = "Edytuj";
            bt.Text = "Edytuj notatkę";
            bt.UseColumnTextForButtonValue = true;
            this.dataGridView2.Columns.Add(bt);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.ColumnIndex == dataGridView2.Columns["edit"].Index)
            {
                string temat = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["temat"].FormattedValue.ToString();
                string opis = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["opis"].FormattedValue.ToString();
                string id = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["id"].FormattedValue.ToString();
                string id_klienta = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["id_klienta"].FormattedValue.ToString();

                Form8 fr = new Form8(id,temat,opis,this);
                fr.ShowDialog();
            }

            if (e.ColumnIndex == dataGridView2.Columns["delete"].Index)
            {
                string temat = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["temat"].FormattedValue.ToString();
                string opis = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["opis"].FormattedValue.ToString();
                string id = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["id"].FormattedValue.ToString();
                string id_klienta = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["id_klienta"].FormattedValue.ToString();

                Form9 fr = new Form9(id, temat, opis, this);
                fr.ShowDialog();
            }
        }
        public void deltBt()
        {
            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            bt.Name = "delete";
            bt.HeaderText = "Usuń";
            bt.Text = "Usuń notatkę";
            bt.UseColumnTextForButtonValue = true;
            this.dataGridView2.Columns.Add(bt);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            biblioteka b = new biblioteka();
            string tekst = textBox4.Text;
            b.wypisz(tekst);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 fr = new Form10();
            fr.ShowDialog();
        }
    }
}
