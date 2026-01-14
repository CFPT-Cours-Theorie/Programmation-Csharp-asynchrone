using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex01.Models;

namespace Ex01.Services
{
    internal class ImageService
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<ImageTelechargement> TelechargerImageAsync(string url, string nomFichier)
        {
            var image = new ImageTelechargement
            {
                Url = url,
                NomFichier = nomFichier
            };

            try
            {
                byte[] data = await _httpClient.GetByteArrayAsync(url);
                await File.WriteAllBytesAsync(nomFichier, data);

                image.TailleOctets = data.Length;
                image.Statut = "Succès";
            }
            catch (Exception ex)
            {
                image.Statut = $"Erreur : {ex.Message}";
                image.TailleOctets = 0;
            }

            return image;
        }
    }
}
