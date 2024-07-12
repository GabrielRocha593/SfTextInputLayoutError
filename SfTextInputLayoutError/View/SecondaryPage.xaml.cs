using SfTextInputLayoutError.Interfaces;
using Volo.Abp.DependencyInjection;

namespace SfTextInputLayoutError;

public partial class SecondaryPage : ContentPage, ITransientDependency
{
    private readonly INavigationService _navigationService1;
    public SecondaryPage(INavigationService navigationService)
	{
        _navigationService1 = navigationService;

        InitializeComponent();
	}

    private async void NavigationBtn_Clicked(object sender, EventArgs e)
    {
        await _navigationService1.GoBackAsync();
    }
}