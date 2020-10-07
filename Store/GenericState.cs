using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fluxor_generic.Store
{
    public class GenericState<TData>
    {
        public GenericState(IEnumerable<TData> someList, int counter)
        {
            SomeList = someList;
            Counter = counter;
        }

        public IEnumerable<TData> SomeList { get; }
        public int Counter { get; }
    }
}
