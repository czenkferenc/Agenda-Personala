using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Persoana
    {
        private int id;
        private string nume;
        private string preNume;
        private Data dataNasterii;
        private long nrTel;
        private string email;
       
        private Persoana() : base()
        {
            nextID();
            this.id = nextid;
        }

        public Persoana(string n, string p)
        {
            nextID();
            this.id = nextid;
            this.nume = n;
            this.preNume = p;

        }

        public Persoana(string n, string p, int a, int l, int d)
        {
            nextID();
            this.id = nextid;
            this.nume = n;
            this.preNume = p;
            this.dataNasterii = new Data(a, l, d);
        }

        public Persoana(string n, string p, Data d)
        {
            nextID();
            this.id = nextid;
            this.nume = n;
            this.preNume = p;
            this.dataNasterii = d;
        }

        public Persoana(string n, string p, int a, int l, int d, long nr)
        {
            nextID();
            this.id = nextid;
            this.nume = n;
            this.preNume = p;
            this.dataNasterii = new Data(a, l, d);
            this.nrTel = nr;
        }

        public Persoana(string n, string p, Data d, long nr)
        {
            nextID();
            this.id = nextid;
            this.nume = n;
            this.preNume = p;
            this.dataNasterii = d;
            this.nrTel = nr;
        }

        public Persoana(string n, string p, int a, int l, int d, string mail)
        {
            nextID();
            this.id = nextid;
            this.nume = n;
            this.preNume = p;
            this.dataNasterii = new Data(a, l, d);
            this.email = mail;
        }

        public Persoana(string n, string p, Data d, string mail)
        {
            nextID();
            this.id = nextid;
            this.nume = n;
            this.preNume = p;
            this.dataNasterii = d;
            this.email = mail;
        }

        public Persoana(string n, string p, int a, int l, int d, long nr, string mail)
        {
            nextID();
            this.id = nextid;
            this.nume = n;
            this.preNume = p;
            this.dataNasterii = new Data(a, l, d);
            this.nrTel = nr;
            this.email = mail;
        }

        public Persoana(string n, string p, Data d, long nr, string mail)
        {
            nextID();
            this.id = nextid;
            this.nume = n;
            this.preNume = p;
            this.dataNasterii = d;
            this.nrTel = nr;
            this.email = mail;
        }

        public Persoana modifica(string n, string p, int a, int l, int d, long nr, string mail)
        {
            Persoana newPers = new Persoana(n, p, a, l, d, nr, mail);
            return newPers;
        }

        private static int nextid;
        private static void nextID()
        {
            nextid++;
        }

        public int ID
        { get { return id; } }


        public string Nume
        {
            get { return nume; }
        }

        public string Prenume
        {
            get { return preNume; }
        }

        public Data DataNasterii
        {
            get { return dataNasterii; }
        }

        public long NumarTel
        {
            get { return nrTel; }
        }

        public string Email
        {
            get { return email; }
        }
    }
}
