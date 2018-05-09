using SharpReact.Core.Services.Abstract;
using System;
using System.Collections.Generic;

namespace SharpReact.Core.Services.Implementation
{
    public class NavigationService: INavigationService
    {
        private readonly Stack<NavigationArgs> stack = new Stack<NavigationArgs>();
        public event EventHandler<NavigationEventArgs> Navigated;

        public void NavigateTo<T>(T args)
            where T: NavigationArgs
        {
            stack.Push(args);
            OnNavigated(args);
        }

        protected virtual void OnNavigated<T>(T args)
            where T: NavigationArgs
        {
            Navigated?.Invoke(this, new NavigationEventArgs(args));
        }

        public NavigationArgs Current => stack.Count > 0 ? stack.Peek() : null;

        public bool Back()
        {
            if (stack.Count > 0)
            {
                var args = stack.Pop();
                OnNavigated(args);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanGoBack => stack.Count > 0;
    }
}
