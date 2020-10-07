using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fluxor_generic.Store
{
    /// <summary>
    /// For any type that you want to use w/ generic state, you need to derive
    /// a class from this w/ a concrete impl for that type.
    /// These are functionally all static/pure functions
    /// They are only instance methods so that they can be discovered
    /// by flux DI engine.
    /// All actions need to be generic data type bound - otherwise they will fire for all grids when dispatched
    /// </summary>
    public class GenericReducers<TData>
    {
        [ReducerMethod]
        public GenericState<TData> ReduceIncrementCount(GenericState<TData> state, IncrementCountAction<TData> __)
        {
            return new GenericState<TData>(state.SomeList, state.Counter + 1);
        }
    }
}
