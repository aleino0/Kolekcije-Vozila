using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_ui
{
    class Vozilo
    {
        string marka, model, vrsta;
        string voziPo;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Vrsta { get => vrsta; set => vrsta = value; }
        public string VoziPo { get => voziPo; set => voziPo = value; }

        public Vozilo(string marka, string model, string vrsta)
        {
            this.marka = marka;
            this.model = model;
            this.vrsta = vrsta;
        }
        public override string ToString()
        {
            return "Marka: " + this.marka + "\tModel: " + this.model + "\tVrsta: " + this.vrsta +"\r\n";
        }
    }
}
