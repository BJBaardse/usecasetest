using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usecases
{
    public partial class EditProperties : Form
    {
        public string naam;
        public string Samenvatting;
        public string Actoren;
        public string Aannamen;
        public string Beschrijving;
        public string Uitzonderingen;
        public string Resultaat;
        public Point plaats;
        public EditProperties(Point _plaats)
        {
            InitializeComponent();
            plaats = _plaats;
        }
        public EditProperties(UseCase a)
        {
            InitializeComponent();
            List<string> strings = new List<string>();
            plaats = a.plaats;
            strings = a.getprops();
            tbNaam.Text = strings[0];
            tbSamenvatting.Text = strings[1];
            tbActoren.Text = strings[2];
            tbAannamen.Text = strings[3];
            tbBeschrijving.Text = strings[4];
            tbUitzonderingen.Text = strings[5];
            tbResultaat.Text = strings[6];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            naam = tbNaam.Text;
            Samenvatting = tbSamenvatting.Text;
            Actoren = tbActoren.Text;
            Aannamen = tbAannamen.Text;
            Beschrijving = tbBeschrijving.Text;
            Uitzonderingen = tbUitzonderingen.Text;
            Resultaat = tbResultaat.Text;
            this.Hide();
        }
    }
}
