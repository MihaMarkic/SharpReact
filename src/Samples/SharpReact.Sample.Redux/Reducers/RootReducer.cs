using Sharp.Redux;
using SharpReact.Sample.Redux.Actions;
using SharpReact.Sample.Redux.States;
using System.Threading;
using System.Threading.Tasks;

namespace SharpReact.Sample.Redux.Reducers
{
    public class RootReducer : IReduxReducer<RootState>
    {
        public Task<RootState> ReduceAsync(RootState state, ReduxAction action, CancellationToken ct)
        {
            RootState result;
            switch (action)
            {
                case IncreaseFirstPageNumberAction increaseFirstPageNumber:
                    result = state.Clone(firstPage: state.FirstPage.Clone(state.FirstPage.Number + increaseFirstPageNumber.Diff));
                    break;
                case ChangeSecondPageEntryTextAction changeSecondPageEntryText:
                    result = state.Clone(secondPage: state.SecondPage.Clone(text: changeSecondPageEntryText.Text));
                    break;
                default:
                    return Task.FromResult(state);
            }
            return Task.FromResult(result);
        }
    }
}
