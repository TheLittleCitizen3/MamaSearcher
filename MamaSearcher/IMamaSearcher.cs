using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    public interface IMamaSearcher
    {
        void Subscribe(string pattern, Action<int, string> actionToPerform);
        void PerfomSearch(string content);
    }
}
