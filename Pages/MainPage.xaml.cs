using MauiAppCrashTest.Models;
using MauiAppCrashTest.PageModels;

namespace MauiAppCrashTest.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}