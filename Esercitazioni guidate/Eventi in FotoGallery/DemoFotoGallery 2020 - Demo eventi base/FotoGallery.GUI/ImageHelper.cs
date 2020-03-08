using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FotoGallery.GUI
{
    public class ImageCache
    {
        

        static Dictionary<string, Image> cache = new Dictionary<string, Image>();
        public static Image Load(string filePath)
        {
            Image img;
            if (!cache.TryGetValue(filePath, out img))
            {
                var b = Image.FromFile(filePath);
                img = new Bitmap(b);
                cache.Add(filePath, img);
                b.Dispose();
            }
            return img;
        }

    }
}
