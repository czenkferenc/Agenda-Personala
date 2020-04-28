using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Activitate
    {
        private int actID;
        private string nume;
        private string descriere;
        private List<Persoana> participanti = new List<Persoana>();
        private Data dataInceput;
        private Data dataFinal;

        private Activitate(): base()
        {
            nextID();
            this.actID = nextid;
        }

        public Activitate(string nume, Data inceput, Data final)
        {
            nextID();
            this.actID = nextid;
            this.nume = nume;
            this.dataInceput = inceput;
            this.dataFinal = final;
        }

        public Activitate(string nume, Persoana participant, Data inceput, Data final)
        {
            nextID();
            this.actID = nextid;
            this.nume = nume;
            this.participanti.Add(participant);
            this.dataInceput = inceput;
            this.dataFinal = final;
        }

        public Activitate(string nume, Persoana[] participanti, Data inceput, Data final)
        {
            nextID();
            this.actID = nextid;
            this.nume = nume;
            this.participanti = participanti.ToList<Persoana>();
            this.dataInceput = inceput;
            this.dataFinal = final;
        }

        public Activitate(string nume, string descriere, Persoana participanti, Data inceput, Data final)
        {
            nextID();
            this.actID = nextid;
            this.nume = nume;
            this.descriere = descriere;
            this.participanti.Add(participanti);
            this.dataInceput = inceput;
            this.dataFinal = final;
        }

        public Activitate(string nume, string descriere, Persoana[] participanti, Data inceput, Data final)
        {
            nextID();
            this.actID = nextid;
            this.nume = nume;
            this.descriere = descriere;
            this.participanti = participanti.ToList<Persoana>();
            this.dataInceput = inceput;
            this.dataFinal = final;
        }

        public int ActivityID
        {
            get { return actID; }
        }

        public string Nume
        {
            get { return nume; }
        }

        public string Descriere
        {
            get { return descriere; }
        }

        public List<Persoana> Participanti
        {
            get { return participanti; }  
        }

        public Data DataInceput
        { get 
            { return dataInceput; }
        }

        public Data DataFinal
        { 
            get { return dataFinal; }
        }

        private static int nextid;
        private static void nextID()
        {
            nextid++;
        }

        public override string ToString()
        {
            if (this.descriere != null) return this.nume + " :\t " + this.descriere + " ;\t Inceput: " + dataInceput.ToString() + " ;\t Final: " + dataFinal.ToString(); 
            else return this.nume + " ;\t Inceput: " + dataInceput.ToString() + " ;\t Final: " + dataFinal.ToString(); 
        }

        public void AdaugaPersoana(Persoana p)
        {
            this.participanti.Add(p);
        }
        
        public void StergePersoana(Persoana p)
        {
            this.participanti.Remove(p);
        }
    }
}
