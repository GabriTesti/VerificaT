using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGIT
{
    internal class Biblioteca
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string OrarioApertura { get; set; }
        public string OrarioChiusura { get; set; }
        public List<Libro> Libri { get; set; }

        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            Libri = new List<Libro>();
        }
    }
}
