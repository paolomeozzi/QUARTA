using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoGallery.GUI
{
    using Core;
    using System.IO;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AlbumFoto album;

        WindowsManager wManager;
        MenuWindowsManager menuManager;
        OpenFormsView openForms;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            wManager = new WindowsManager();
            //wManager.FotoFormCreated += WManager_FotoFormCreated;
            //wManager.FotoFormClosed += WManager_FotoFormClosed;

            menuManager = new MenuWindowsManager(menuWindows, wManager);
            menuManager.MenuItemClicked += MenuManager_MenuItemClicked;

            openForms = new OpenFormsView(wManager);
            openForms.FotoClicked += OpenForms_FotoClicked;
            

            pnlOpenForms.Controls.Add(openForms);
            
            album = new AlbumFoto(@"..\..\Images");
            album.Load();

            LoadGallery();
        }

        private void OpenForms_FotoClicked(object sender, FotoClickedEventArgs e)
        {
            wManager.Select(e.Foto);
        }

        private void MenuManager_MenuItemClicked(object sender, Foto e)
        {
            wManager.Select(e);
        }

        //private void WManager_FotoFormClosed(object sender, Foto e)
        //{
        //    menuManager.Remove(e);
        //    openForms.Remove(e);
        //}

        //private void WManager_FotoFormCreated(object sender, Foto e)
        //{
        //    menuManager.Add(e);
        //    openForms.Add(e);
        //}

        void LoadGallery()
        {
            pnlGallery.Controls.Clear();
            for (int i = 0; i < album.Count; i++)
            {
                var fotoView = CreateFotoView(album[i]);
                pnlGallery.Controls.Add(fotoView);
            }
        }

        FotoView CreateFotoView(Foto foto)
        {
            var fw = new FotoView();
            fw.Click += Fw_FotoClicked;
            fw.DoubleClick  += Fw_FotoDoubleClicked;
            fw.Foto = foto;
            return fw;
        }

        private void Fw_FotoDoubleClicked(object sender, EventArgs e)
        {
            FotoView fw = (FotoView)sender;
            wManager.Open(fw.Foto);
        }

        FotoView lastSelected = null;
        private void Fw_FotoClicked(object sender, EventArgs e)
        {
            FotoView fw = (FotoView)sender;
            if (fw == lastSelected)
                return;

            fw.Selected = true;

            if (lastSelected != null)
                lastSelected.Selected = false;

            lastSelected = fw;
            statFotoSelected.Text = Path.GetFileName(fw.Foto.FileName);
        }

        private void txtTags_TextChanged(object sender, EventArgs e)
        {
            string tag = txtTags.Text.ToLower();
            foreach (FotoView fw in pnlGallery.Controls)
            {
                fw.Visible = fw.Foto.FileName.ToLower().Contains(tag);
            }
        }
    }
}
