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
    public partial class OpenFormsView : UserControl
    {
        public event EventHandler<FotoClickedEventArgs> FotoClicked;
        public OpenFormsView()
        {
            InitializeComponent();            
        }

        public OpenFormsView(WindowsManager wManager)
        {
            InitializeComponent();
            wManager.FotoFormCreated += WManager_FotoFormCreated;
            wManager.FotoFormClosed += WManager_FotoFormClosed;
        }

        private void WManager_FotoFormClosed(object sender, Foto e)
        {
            Remove(e);
        }

        private void WManager_FotoFormCreated(object sender, Foto e)
        {
            Add(e);
        }

        void OpenFormsView_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        public void Add(Foto foto)
        {
            pnlPicture.Controls.Add(CreatePicture(foto));
        }

        public void Remove(Foto foto)
        {
            int index = IndexOfFoto(foto);
            pnlPicture.Controls.RemoveAt(index);
        }

        int IndexOfFoto(Foto foto)
        {
            int index = 0;
            foreach (FotoView fw in pnlPicture.Controls)
            {
                if (fw.Foto == foto)
                    return index;
                index++;
            }
            return -1;
        }

        FotoView CreatePicture(Foto foto)
        {
            var fw = new FotoView();
            fw.Padding = new Padding(2);
            fw.Height = Height - 2;
            fw.Width = fw.Height;
            fw.Foto = foto;
            fw.Click += Fw_Click;
            return fw;
        }

        private void Fw_Click(object sender, EventArgs e)
        {
            var fw = (FotoView)sender;
            var ex = new FotoClickedEventArgs { Foto = fw.Foto };
            FotoClicked?.Invoke(this, ex);
        }
    }

    public class FotoClickedEventArgs
    {
        public Foto Foto { get; set; }
    }

    
}
