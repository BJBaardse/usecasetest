using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace usecases
{
    public class UseCase
    {
        public string naam;
        string Samenvatting;
        string Actoren;
        string Aannamen;
        string Beschrijving;
        string Uitzonderingen;
        string Resultaat;
        public Point plaats;
        public PictureBox dezepicturebox;

        
        public UseCase(string _naam, string _samenvatting, string _actoren, string _aannamen, string _beschrijving, string _uitzonderingen, string _resultaat, Point _plaats)
        {
            naam = _naam;
            Samenvatting = _samenvatting;
            Actoren = _actoren;
            Aannamen = _aannamen;
            Beschrijving = _beschrijving;
            Uitzonderingen = _uitzonderingen;
            Resultaat = _resultaat;
            plaats = _plaats;
        }
        public List<string> getprops()
        {
            List<string> items = new List<string>();
            items.AddRange(new List<string> { naam, Samenvatting, Actoren, Aannamen, Beschrijving, Uitzonderingen, Resultaat});
            return items;
        }
    }
}
