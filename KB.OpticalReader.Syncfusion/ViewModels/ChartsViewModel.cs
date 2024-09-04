using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KB.OpticalReader.SyncfusionApp.Models;

namespace KB.OpticalReader.SyncfusionApp.ViewModels
{
    public class ChartsViewModel
    {
        public ObservableCollection<ChartsModel> CanadaData { get; }

        public ObservableCollection<ChartsModel> FranceData { get; }

        public ObservableCollection<ChartsModel> PlantDetails { get; set; }

        public ChartsViewModel()
        {
            this.CanadaData = new ObservableCollection<ChartsModel>();
            CanadaData.Add(new ChartsModel() { Year = "2000", Value = 26.8 });
            CanadaData.Add(new ChartsModel() { Year = "2001", Value = 29 });
            CanadaData.Add(new ChartsModel() { Year = "2002", Value = 27.5 });
            CanadaData.Add(new ChartsModel() { Year = "2003", Value = 28.4 });
            CanadaData.Add(new ChartsModel() { Year = "2004", Value = 26.5 });
            CanadaData.Add(new ChartsModel() { Year = "2005", Value = 25.1 });


            this.FranceData = new ObservableCollection<ChartsModel>();
            FranceData.Add(new ChartsModel() { Year = "2000", Value = 9.3 });
            FranceData.Add(new ChartsModel() { Year = "2001", Value = 8.3 });
            FranceData.Add(new ChartsModel() { Year = "2002", Value = 9.2 });
            FranceData.Add(new ChartsModel() { Year = "2003", Value = 9.9 });
            FranceData.Add(new ChartsModel() { Year = "2004", Value = 9.6 });
            FranceData.Add(new ChartsModel() { Year = "2005", Value = 10.8 });

            PlantDetails = new ObservableCollection<ChartsModel>()
            {
                new ChartsModel(){ Direction = "North", Tree = 80 },
                new ChartsModel(){ Direction = "NorthWest", Tree = 87 },
                new ChartsModel(){ Direction = "West", Tree = 78 },
                new ChartsModel(){ Direction = "SouthWest", Tree = 85 },
                new ChartsModel(){ Direction = "South", Tree = 81 },
                new ChartsModel(){ Direction = "SouthEast", Tree = 88 },
                new ChartsModel(){ Direction = "East", Tree = 80 },
                new ChartsModel(){ Direction = "NorthEast", Tree = 85 },
            };
        }
    }
}
