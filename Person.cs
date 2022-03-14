using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innlevering3Klasser
{
    class Person
    {
        private string navn;
        private int alder;

        
        public Person(string navn, int alder)
        {
            this.navn = navn;
            this.alder = alder;
            antallPersoner++;
        }
        static int antallPersoner = 0; //Teller hvor mange ganger constructor har vært aktiv

        public static int GettantallPersoner() //metode for tilgang til private
        {
            return antallPersoner;
        }

        public string GetNavn()//getter
        {
            if (alder >= 18)
            {
                return navn;
            }
            else
                return "Person er under 18 år";
        }
        public void SettNavn(string navn) //setter
        {
            if (navn != "")
            {
                this.navn =  navn;
            }
        }
        public int GetAlder()
        {
            if (alder >= 18)
            {
                return alder;
            }
            else
                return -1;
        }
    }
}
