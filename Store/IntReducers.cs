using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fluxor_generic.Store
{
    /// <summary>
    /// There might be idiosyncratic reducers here for a given type, but for this example this only serves to allow for the fluxor type discovery to find these specialized reducers.
    /// </summary>
    public class IntReducers:GenericReducers<int>
    {
    }
}
