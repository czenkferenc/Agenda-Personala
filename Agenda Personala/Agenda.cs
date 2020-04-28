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
                Console.WriteLine("Activitate: " + a.ToString() + " a fost adaugata in agenda persoanei: " + this.proprietar.Nume + " " + this.proprietar.Prenume);
            }
        }

        public void StergeActivitate(Activitate a)
        {
            this.activitati.Remove(a);
            a.Participanti.Remove(this.proprietar);
            Console.WriteLine("Activitate " + a.ToString() + " a fost stearsa");
        }

        public void RaportActivitati(Data a, Data b)
        {
            Activitate tempAct = new Activitate("act temp", a, b);
            Console.WriteLine("Activitatile persoanei intre: " + a.ToString() + " - " + b.ToString());
            foreach (Activitate act in this.activitati)
            {
                if ((act.DataInceput <= tempAct.DataInceput && tempAct.DataInceput <= act.DataFinal) || (act.DataInceput <= tempAct.DataFinal && tempAct.DataFinal <= act.DataFinal))
                {
                    Console.WriteLine(act.ToString());
                }
            }
        }

        public void GasesteTimp(Agenda a, Agenda b)
        {

        }
    }
}
