using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fluxor_generic.Store
{
    public class CounterFeature : Feature<GenericState<int>>
    {
        public override string GetName()
        {
            return "TestFeature";
        }

        protected override GenericState<int> GetInitialState()
        {
            return new GenericState<int>(new List<int>(), 0);
        }
    }
}
