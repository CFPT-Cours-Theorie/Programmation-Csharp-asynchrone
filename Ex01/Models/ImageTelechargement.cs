using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Models
{
    internal class ImageTelechargement
    {
        public string Url { get; set; }
        public string NomFichier { get; set; }
        public string Statut { get; set; }
        public long TailleOctets { get; set; }
    }
}
