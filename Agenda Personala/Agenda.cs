using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Agenda
    {
        private Persoana proprietar;
        private List<Activitate> activitati = new List<Activitate>();

        private Agenda(): base()
        { }

        public Agenda(Persoana p)
        {
            this.proprietar = p;
        }

        public Agenda(Persoana p, List<Activitate> a)
        {
            this.proprietar = p;
            this.activitati = a;
        }

        public List<Activitate> Activitati
        { get { return activitati; } }
        public Persoana Proprietar
        { get { return proprietar; } }
    }
}
