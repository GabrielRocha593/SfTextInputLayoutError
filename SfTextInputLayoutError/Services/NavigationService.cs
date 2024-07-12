using SfTextInputLayoutError.Interfaces;

namespace SfTextInputLayoutError.Services
{
    public class NavigationService : INavigationService
    {
        public NavigationService()
        {
            _obj = Application.Current.MainPage as Page;
        }

        private readonly Page _obj;

        public async Task GoBackAsync()
        {
            await _obj.Navigation.PopAsync();
        }

        public async Task NavigateToAsync(string route)
        {
            switch (route)
            {
                case "SecondaryPage":
                    {
                        await _obj.Navigation.PushAsync(new SecondaryPage(this));
                        return;
                    }
                default: throw new NotImplementedException($"Navegação para {route} não implementada.");
            }
        }
    }
}
