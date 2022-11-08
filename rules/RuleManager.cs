using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace term
{
    public static class RuleManager
    {
        private static List<fRule> allRules = new List<fRule>();

        public static int RuleCount
        {
            get { return allRules.Count; }
        }

        public static List<fRule> GetListOfRules
        {
            get { return allRules; }
        }

        public static fRule GetRuleFromName(string name)
        {
            foreach(fRule f in allRules)
            {
                if(name == f.keyWord)
                {
                    return f;
                }
            }

            return null;
        }

        public static void UpdateRule(fRule item)
        {
            // TODO: Keep index and update all necessary values.
        }

        public static void AddRule(fRule item)
        {
            allRules.Add(item);
        }
    }
}
