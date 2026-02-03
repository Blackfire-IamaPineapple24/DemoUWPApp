using System;
using System.Linq;
using System.Threading.Tasks;

using DemoUWPApp.Core.Models;
using DemoUWPApp.Core.Services;

using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace DemoUWPApp.ViewModels
{
    public class ContentGridDetailViewModel : ObservableObject
    {
        private SampleOrder _item;

        public SampleOrder Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }

        public ContentGridDetailViewModel()
        {
        }

        public async Task InitializeAsync(long orderID)
        {
            var data = await SampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }
}
