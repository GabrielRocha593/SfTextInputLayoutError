using SfTextInputLayoutError.Interfaces;

namespace SfTextInputLayoutError
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigationBtn_Clicked(object sender, EventArgs e)
        {
            IServiceProvider? serviceProvider = Application.Current?.Handler?.MauiContext?.Services;
            var _navigationService = serviceProvider?.GetRequiredService<INavigationService>();
            await _navigationService.NavigateToAsync("SecondaryPage");
        }
    }

}
