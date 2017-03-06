using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usecases
{
    class UseCase
    {
        string naam;
        string Samenvatting;
        string Actoren;
        string Aannamen;
        string Beschrijving;
        string Uitzonderingen;
        string Resultaat;
        public UseCase(string _naam, string _samenvatting, string _actoren, string _aannamen, string _beschrijving, string _uitzonderingen, string _resultaat)
        {
            naam = _naam;
            Samenvatting = _samenvatting;
            Actoren = _actoren;
            Aannamen = _aannamen;
            Beschrijving = _beschrijving;
            Uitzonderingen = _uitzonderingen;
            Resultaat = _resultaat;
        }
    }
}
