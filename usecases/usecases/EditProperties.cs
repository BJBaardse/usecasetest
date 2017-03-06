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
        public EditProperties()
        {
            InitializeComponent();
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
        }
    }
}
