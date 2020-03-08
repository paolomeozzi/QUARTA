using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    

namespace FotoGallery.GUI
{
    using Core;
    public partial class FotoForm : Form
    {
        public FotoForm()
        {
            InitializeComponent();
        }

        public static FotoForm Create(Foto foto)
        {
            FotoForm ff = new FotoForm();
            ff.Foto = foto;
            ff.Show();
            return ff;
        }

        private Foto _foto;
        public Foto Foto
        {
            get { return _foto; }
            set
            {
                _foto = value;
                picFoto.Image = ImageCache.Load(_foto.FileName);
                Text = Path.GetFileNameWithoutExtension(_foto.FileName);
                     
            }
        }

        private void FotoForm_Activated(object sender, EventArgs e)
        {
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
