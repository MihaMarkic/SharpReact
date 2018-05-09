using SharpReact.Core.Services.Abstract;
using SharpReact.Core.Services.Implementation;

namespace SharpReact.Core
{
    public static class ReactServices
    {
        public static INavigationService Navigation { get; set; } = new NavigationService();
    }
}
