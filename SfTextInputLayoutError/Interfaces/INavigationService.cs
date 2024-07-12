
namespace SfTextInputLayoutError.Interfaces;

public interface INavigationService
{
        Task GoBackAsync();
        Task NavigateToAsync(string route);
}
