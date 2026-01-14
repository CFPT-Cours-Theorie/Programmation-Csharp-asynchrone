using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex01.Models;

namespace Ex01.Views
{
    internal class ConsoleView
    {
        public void AfficherResultat(ImageTelechargement image)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"URL        : {image.Url}");
            Console.WriteLine($"Fichier    : {image.NomFichier}");
            Console.WriteLine($"Statut     : {image.Statut}");
            Console.WriteLine($"Taille     : {image.TailleOctets} octets");
        }
    }
}
