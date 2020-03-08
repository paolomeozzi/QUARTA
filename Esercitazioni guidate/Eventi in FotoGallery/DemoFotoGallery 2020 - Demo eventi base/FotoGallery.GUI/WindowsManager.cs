using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoGallery.GUI
{
    using Core;
    public class WindowsManager
    {
        public event EventHandler<Foto> FotoFormCreated;
        public event EventHandler<Foto> FotoFormClosed;
        List<FotoForm> openForms = new List<FotoForm>();
        
        public void Open(Foto foto)
        {
            var ff = openForms.Find(f => f.Foto == foto);
            if (ff == null)
            {
                ff = FotoForm.Create(foto);
                ff.FormClosed += FotoForm_FormClosed;
                openForms.Add(ff);
                FotoFormCreated?.Invoke(this, foto);
            }
            ff.BringToFront();
        }

        public void Select(Foto foto)
        {
            var ff = openForms.Find(f => f.Foto == foto);
            ff?.Select();
        }

        private void FotoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var ff = (FotoForm) sender;
            openForms.Remove(ff);
            FotoFormClosed?.Invoke(this, ff.Foto);


        }
    }
}
