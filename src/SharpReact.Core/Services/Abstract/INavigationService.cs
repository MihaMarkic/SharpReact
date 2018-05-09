using System;

namespace SharpReact.Core.Services.Abstract
{
    public interface INavigationService
    {
        event EventHandler<NavigationEventArgs> Navigated;
        void NavigateTo<T>(T args) where T: NavigationArgs;
        bool Back();
        bool CanGoBack { get; }
        NavigationArgs Current { get; }
    }
}
