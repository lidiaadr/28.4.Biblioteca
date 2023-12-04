using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _28._4.Biblioteca
{
    internal class Biblioteca
    {
        public string Nome { get; set; }
        public List<Documento> Documenti { get; set; }
        public List<Prestitoo> Prestiti { get; set; }
        public List<Utente> Utenti { get; set; }


    }

}
