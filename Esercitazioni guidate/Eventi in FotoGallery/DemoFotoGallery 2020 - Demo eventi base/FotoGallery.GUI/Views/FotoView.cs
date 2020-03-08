using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoGallery.GUI
{
    using Core;
    using System.IO;

    public partial class FotoView : UserControl
    {
        public FotoView()
        {
            InitializeComponent();
            Width = 250;
            Height = 200;
        }

        Color defaultFrameColor = Color.Bisque;
        Color selectedFrameColor = Color.Firebrick;

        Foto foto;
        public Foto Foto
        {
            get => foto;
            set
            {
                foto = value;
                picFoto.Image = ImageCache.Load(foto.FileName);
            }
        }

        private bool selected = false;
        public bool Selected
        {
            get => selected; 
            set
            {
                if (selected == value)
                    return;
                selected = value;
                BackColor = selected ? selectedFrameColor : defaultFrameColor;
            }
        }

        private void FotoView_Load(object sender, EventArgs e)
        {
            BackColor = defaultFrameColor;
            tipFoto.SetToolTip(picFoto, FotoTip());
            picFoto.Click += PicFoto_Click;
            picFoto.DoubleClick += PicFoto_DoubleClick;
        }

        private string FotoTip() => Foto.Caption != null ? Foto.Caption : Path.GetFileName(foto.FileName);

        private void PicFoto_DoubleClick(object sender, EventArgs e) => OnDoubleClick(e);
        private void PicFoto_Click(object sender, EventArgs e)=> OnClick(e);
        
    }
}
