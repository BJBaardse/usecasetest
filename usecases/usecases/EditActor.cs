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
    public partial class EditActor : Form
    {
        public string actorNaam;
        public Point clicklocatie;

        public EditActor(Point locatie)
        {
            InitializeComponent();
            clicklocatie = locatie;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            actorNaam = tbNaam.Text;
            this.Hide();
        }
    }
}
