using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana p1 = new Persoana("a", "b");
            Persoana p2 = new Persoana("c", "d");
            Persoana p3 = new Persoana("e", "f");

            Data data1 = new Data(2020, 12, 23, 10, 00);
            Data data2 = new Data(2020, 12, 23, 12, 00);
            Data data3 = new Data(2020, 12, 23, 16, 00);
            Data data4 = new Data(2020, 12, 23, 21, 00);

            Activitate act1 = new Activitate("asd", p1, data1, data2);
            Activitate act2 = new Activitate("fgh", p3, data3, data4);

            Agenda ag1 = new Agenda(p2);

            ag1.AdaugaActivitate(act1);
            ag1.AdaugaActivitate(act2);

            ag1.RaportActivitati(data1, data4);
        }
    }
}
