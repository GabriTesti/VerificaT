using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGIT
{
    internal class Libro
    {
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Editore { get; set; }
        public int NumeroPagine { get; set; }

        public Libro(string autore, string titolo, int anno, string editore, int numeroPagine)
        {
            Autore = autore;
            Titolo = titolo;
            Anno = anno;
            Editore = editore;
            NumeroPagine = numeroPagine;
        }
        public override string ToString()
        {
            return Autore + " " + Titolo + " " + Anno + " " + Editore + " " + NumeroPagine;  
        }
        public string ReadingTime()
        {
            string TempoDiLettura = "";
            if(NumeroPagine<100)
            {
                TempoDiLettura = "1h";
            }
            if(NumeroPagine>100&&NumeroPagine<200)
            {
                TempoDiLettura = "2h";
            }
            if(NumeroPagine>200)
            {
                TempoDiLettura = "piu di 2 ore";
            }
            return "";
        }
    }
}
