using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    class MamaSearcher : IMamaSearcher
    {
        public Dictionary<string, Action<int, string>> PatternActionRunner{get; set ;}
        public MamaSearcher()
        {
            PatternActionRunner = new Dictionary<string, Action<int, string>>();
        }
        public void PerfomSearch(string content)
        {
            if (content == null)
            {
                Console.WriteLine("cant search pattern on null string");
                return;
            }
            foreach (var stringPattern in PatternActionRunner.Keys)
            {
                if (content.Contains(stringPattern))
                {
                    PatternActionRunner[stringPattern](content.IndexOf(stringPattern), stringPattern);
                }
            }
        }

        public void Subscribe(string pattern, Action<int, string> actionToPerform)
        {
            if (pattern == null)
            {
                Console.WriteLine("Cant get null string ad pattern");
                return;
            }
            if (!PatternActionRunner.ContainsKey(pattern))
            {
                PatternActionRunner.Add(pattern, actionToPerform);
            }
            else
            {
                PatternActionRunner[pattern] += actionToPerform;
            }
            

        }
    }
}
