using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    [Serializable]
    public class RendezVous
    {
        private Patient p;
        private DateTime date;
        private TimeSpan heure;
        private string type;

        public RendezVous(Patient p,DateTime date,TimeSpan heure, int type)
        {
            this.p = p;
            this.Date = date;
            this.heure = heure;
            if (type == 0) this.type = "Consultation";
            else this.type = "Controle";
        }

        public string CIN { get => p.Cin; }
        public string Nom { get => p.Nom; }
        public string Prenom { get => p.Prenom; }
        public DateTime Date { get => date; set => date = value; }
        public string Type { get => type; set => type = value; }
        public TimeSpan Heure { get => heure; set => heure = value; }
    }
}
