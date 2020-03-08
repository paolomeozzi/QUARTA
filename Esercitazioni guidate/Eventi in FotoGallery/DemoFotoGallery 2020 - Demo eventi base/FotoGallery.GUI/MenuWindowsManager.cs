using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoGallery.GUI
{
    using Core;
    using System.IO;

    public class MenuWindowsManager
    {
        public event EventHandler<Foto> MenuItemClicked;
        ToolStripMenuItem menuWindows;

        public MenuWindowsManager(ToolStripMenuItem menuWindows, WindowsManager wManager)
        {
            this.menuWindows = menuWindows;            
            menuWindows.DropDownItemClicked += MenuWindows_DropDownItemClicked;
            wManager.FotoFormClosed += WManager_FotoFormClosed;
            wManager.FotoFormCreated += WManager_FotoFormCreated;
        }

        private void WManager_FotoFormCreated(object sender, Foto e)
        {
            Add(e);
        }

        private void WManager_FotoFormClosed(object sender, Foto e)
        {
            Remove(e);
        }

        public void Add(Foto foto)
        {
            var name = Path.GetFileName(foto.FileName);
            var item = new ToolStripMenuItem(name);
            item.Name = name;
            item.Tag = foto;
            
            menuWindows.DropDownItems.Add(item);
        }

        public void Remove(Foto foto)
        {
            var items = menuWindows.DropDownItems.Find(Path.GetFileName(foto.FileName), false);
            if (items.Length == 0)
                return;
            menuWindows.DropDownItems.Remove(items[0]);
        }

        private void MenuWindows_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var item = e.ClickedItem;
            var foto = (Foto)item.Tag;
            MenuItemClicked?.Invoke(this, foto);
        }
    }
}
