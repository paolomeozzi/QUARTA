using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoGallery.Core
{
    public class AlbumFoto
    {
        string[] imageFileExtension = { ".jpg", ".bmp", ".gif", ".png" };

        string folder;
        string captionExt;

        List<Foto> fotoList = new List<Foto>();
        public AlbumFoto(string folder, string captionExt = ".cap")
        {
            this.folder = folder;
            this.captionExt = captionExt;
        }

        public void Load()
        {
            fotoList.Clear();
            var imagefilesName = Directory.GetFiles(folder).Where(f => IsImageFile(f));

            foreach (var file in imagefilesName)
            {
                Foto f = new Foto { FileName = file, Caption = LoadCaption(file) };
                fotoList.Add(f);
            }
        }

        public int Count => fotoList.Count;
        public Foto this[int index]=> fotoList[index];
        
        private bool IsImageFile(string fileName)
        {
            return Array.IndexOf(imageFileExtension, Path.GetExtension(fileName).ToLower()) != -1;
        }

        private string LoadCaption(string fileName)
        {
            string capFileName = string.Format("{0}{1}", fileName, captionExt);
            if (!File.Exists(capFileName))
                return null;
            return File.ReadAllText(capFileName);
        }

    }

    
}
