using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIOPZavrsniProjekt
{
    


    public partial class FormUnosFilma : Form
    {
        public FormUnosFilma()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Maximum = 5;
            Film noviFilm = new Film(trackBar1.Value, monthCalendar1.SelectionStart, textBox1.Text, textBox2.Text);
            FormPocetna.instance.richTextBoxPogledano.Items.Add(noviFilm);
            
        }
    }

    public class Film
    {
        private static int broj = 0;
        int ocjena;
        DateTime datum;
        string naziv, redatelj;

        public int Broj { get => broj; set => broj = value; }
        public int Ocjena { get => ocjena; set => ocjena = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Redatelj { get => redatelj; set => redatelj = value; }

        public Film(int ocjena, DateTime datum, string naziv, string redatelj)
        {
            this.Ocjena = ocjena;
            this.Datum = datum;
            this.Naziv = naziv;
            this.Redatelj = redatelj;
            Interlocked.Increment(ref broj);
            this.Broj = broj;
        }

        public Film()
        {

        }

        public override string ToString()
        {
            string rez = (this.Broj + "   " + this.datum + "   " + this.naziv + "   " + this.redatelj + "   " + this.ocjena +"/10");
            return rez;
        }
    }
}
