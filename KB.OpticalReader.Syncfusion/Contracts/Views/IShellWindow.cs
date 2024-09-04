using System.Windows.Forms;

namespace KB.OpticalReader.SyncfusionApp.Contracts.Views
{
    public interface IShellWindow
    {


        Panel GetNavigationFrame();

        void ShowWindow();

        void CloseWindow();
    }
}
