using System;
using System.Windows.Forms;

namespace KB.OpticalReader.SyncfusionApp.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);

        UserControl GetPage(string key);
    }
}
