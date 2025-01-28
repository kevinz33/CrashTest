namespace MauiAppCrashTest.Pages;

public partial class CrashTestPage : ContentPage
{
	public CrashTestPage(CrashTestPageModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}