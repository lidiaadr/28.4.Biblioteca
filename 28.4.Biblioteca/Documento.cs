using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4.Biblioteca
{
    internal class Documento
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public string Anno { get; set; }
        public string Settore { get; set; }
        public string Stato { get; set; }
        public List<Scaffale> Scaffali { get; set; }
        public List<Autore> Autori { get; set; }

        

    }
}
