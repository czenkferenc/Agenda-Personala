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

        public List<Activitate> Activitati
        { get { return activitati; } }
        public Persoana Proprietar
        { get { return proprietar; } }

        public void AdaugaActivitate(Activitate a)
        {
            bool adauga = true;
            foreach (Activitate act in this.activitati)
            {
                if ((act.DataInceput <= a.DataInceput && a.DataInceput <= act.DataFinal) || (act.DataInceput <= a.DataFinal && a.DataFinal <= act.DataFinal))
                {
                    adauga = false;
                    Console.WriteLine("Deja exisata o activitate in acest interval: ");
                    Console.WriteLine(act.ToString());
                }
            }
            if(adauga == true)
            {
                this.activitati.Add(a);
                a.Participanti.Add(this.proprietar);
                Console.WriteLine("Activitate " + a.ToString() + " a fost adaugata " + this.proprietar.Nume);
            }
        }

        public void StergeActivitate(Activitate a)
        {
            this.activitati.Remove(a);
            a.Participanti.Remove(this.proprietar);
            Console.WriteLine("Activitate " + a.ToString() + " a fost stearsa");
        }
    }
}
