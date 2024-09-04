using System;
using System.Windows.Forms;

namespace KB.OpticalReader.SyncfusionApp.Contracts.Services
{
    public interface INavigationService
    {

        void Initialize(Panel shellFrame);


        bool NavigateTo(string pageKey, object parameter = null, bool clearNavigation = false);
    }
}
