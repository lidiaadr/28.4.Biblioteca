using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4.Biblioteca
{
    internal class Prestito
    {
        public List< Documenti { get; set; }
        
        public string Titolo { get; set; }
        public string Anno { get; set; }
        public string Settore { get; set; }
        public List<Stato> Stati { get; set; }
        public List<ElencoAutore> ElencoAutori { get; set; }

        public string Scaffale { get; set; }



    }
}
