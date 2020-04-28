using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Data
    {
        int an;
        int luna;
        int zi;
        int ora;
        int minut;

        public Data() :base()
        {
            this.an = DateTime.Now.Year;
            this.luna = DateTime.Now.Month;
            this.zi = DateTime.Now.Day;
            this.ora = DateTime.Now.Hour;
            this.minut = DateTime.Now.Minute;
        }

        public Data(int y, int m, int d) 
        {
            this.an = y;
            if (0 < m && m < 13) this.luna = m;
            if (0 < d && d < 32) this.zi = d;
            this.ora = 0;
            this.minut = 0;
        }

        public Data(int y, int m, int d, int h, int M)
        {
            this.an = y;
            if (0 < m && m < 13) this.luna = m;
            if (0 < d && d < 32) this.zi = d;
            if (0 <= h && h <= 23) this.ora = h;
            if (0 <= M && M <= 59) this.minut = M;
        }

        public int An
        {
            get { return an; }
        }
        public int Luna
        {
            get { return luna; }
        }

        public int Zi
        { 
            get { return zi; }
        }

        public int Ora
        {
            get { return ora; }
        }

        public int Minut
        {
            get { return minut; }
        }

        public Data Modifica(int y, int m, int d, int h, int M)
        {
            Data newData = new Data(y,m,d,h,M);
            return newData;
        }

        public override string ToString()
        {
            return this.an + "." + this.luna + "." + this.zi + " " + this.ora + ":" + this.minut; 
        }
         
        public static bool operator <= (Data a, Data b)
        {
            DateTime date1 = new DateTime(a.an, a.luna, a.zi, a.ora, a.minut, 0);
            DateTime date2 = new DateTime(b.an, b.luna, b.zi, b.ora, b.minut, 0);
            return date1 <= date2;
        }

        public static bool operator >=(Data a, Data b)
        {
            DateTime date1 = new DateTime(a.an, a.luna, a.zi, a.ora, a.minut, 0);
            DateTime date2 = new DateTime(b.an, b.luna, b.zi, b.ora, b.minut, 0);
            return date1 >= date2;
        }
    }
}
