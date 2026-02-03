using System;

using DemoUWPApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace DemoUWPApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
