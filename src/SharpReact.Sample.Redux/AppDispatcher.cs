using Sharp.Redux;
using SharpReact.Sample.Redux.States;
using System.Threading.Tasks;

namespace SharpReact.Sample.Redux
{
    public class AppDispatcher: ReduxDispatcher<RootState, IReduxReducer<RootState>>
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="AppDispatcher`2"/> that has initial state uses given reducer and runs synchronized event
        /// on <paramref name="notificationScheduler"/>.
        /// </summary>
        /// <param name="initialState">The initial state.</param>
        /// <param name="reducer">The reducer to use.</param>
        /// <param name="notificationScheduler">A scheduler for events.</param>
        public AppDispatcher(RootState initialState, IReduxReducer<RootState> reducer, TaskScheduler notificationScheduler) : base(initialState, reducer, notificationScheduler)
        {

        }
    }
}
