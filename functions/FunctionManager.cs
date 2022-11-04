using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace term
{
    public static class FunctionManager
    {
        private static List<Function> allFunctions = new List<Function>();

        public static List<Function> GetListOfFunctions
        {
            get { return allFunctions; }
        }

        public static Function GetFunctionFromName(string name)
        {
            foreach (Function f in allFunctions)
            {
                if(f.name == name)
                {
                    return f;
                }
            }

            return null;
        }

        public static void UpdateFunction(Function item)
        {
            // TODO: Keep index and update all necessary values.
        }

        public static void AddFunction(Function item)
        {
            allFunctions.Add(item);
            // TODO: Replace index with a new one.
        }
    }
}
