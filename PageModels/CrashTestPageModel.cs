using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAppCrashTest.PageModels;

public partial class CrashTestPageModel : ObservableObject
{
  
    [RelayCommand]
    async Task Back()
    {
        await Shell.Current.GoToAsync($"..");
    }
    private static async Task NavigatingBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    public ICommand NavigateBack  => new Command(async () => await NavigatingBack());
}
