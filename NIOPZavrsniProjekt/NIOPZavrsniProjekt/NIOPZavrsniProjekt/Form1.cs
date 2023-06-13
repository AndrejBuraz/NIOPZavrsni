using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIOPZavrsniProjekt
{
    public partial class FormPocetna : Form
    {
        public static FormPocetna instance;
        public FormPocetna()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
            FormUnosFilma form = new FormUnosFilma();
            form.ShowDialog();
        }
    }
}
