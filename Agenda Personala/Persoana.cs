using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Persoana
    {
        private string nume;
        private string prenumeNume;
        private Data dataNasterii;
        private long nrTel;
        private string email;

        private Persoana(): base()
        {

        }

        public Persoana(string n, string p, int a, int l, int d)
        {
            this.nume = n;
            this.prenumeNume = p;
            this.dataNasterii = new Data(a, l, d);
        }

        public Persoana(string n, string p, Data d)
        {
            this.nume = n;
            this.prenumeNume = p;
            this.dataNasterii = d;
        }

        public Persoana(string n, string p, int a, int l, int d, long nr)
        {
            this.nume = n;
            this.prenumeNume = p;
            this.dataNasterii = new Data(a, l, d);
            this.nrTel = nr;
        }

        public Persoana(string n, string p, Data d, long nr)
        {
            this.nume = n;
            this.prenumeNume = p;
            this.dataNasterii = d;
            this.nrTel = nr;
        }

        public Persoana(string n, string p, int a, int l, int d, string mail)
        {
            this.nume = n;
            this.prenumeNume = p;
            this.dataNasterii = new Data(a, l, d);
            this.email = mail;
        }

        public Persoana(string n, string p, Data d, string mail)
        {
            this.nume = n;
            this.prenumeNume = p;
            this.dataNasterii = d;
            this.email = mail;
        }

        public Persoana(string n, string p, int a, int l, int d, long nr, string mail)
        {
            this.nume = n;
            this.prenumeNume = p;
            this.dataNasterii = new Data(a, l, d);
            this.nrTel = nr;
            this.email = mail;
        }

        public Persoana(string n, string p, Data d, long nr, string mail)
        {
            this.nume = n;
            this.prenumeNume = p;
            this.dataNasterii = d;
            this.nrTel = nr;
            this.email = mail;
        }

        public Persoana modifica (string n, string p, int a, int l, int d, long nr, string mail)
        {
            Persoana newPers = new Persoana(n, p, a, l, d, nr, mail);
            return newPers;
        }
    }
}
