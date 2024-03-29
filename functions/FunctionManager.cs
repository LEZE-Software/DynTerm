﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term
{
    public static class FunctionManager
    {
        private static List<Function> allFunctions = new List<Function>();

        public static int FunctionCount
        {
            get { return allFunctions.Count; }
        }

        public static void AddPanelToFunction(int idx, Panel pan)
        {
            allFunctions[idx].AddPanel(pan);
        }

        public static List<Function> GetListOfFunctions
        {
            get { return allFunctions; }
        }

        public static Function GetFunctionFromIndex(int idx)
        {
            return allFunctions[idx];
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

        public static void RemoveFunction(int idx, string name)
        {
            if(allFunctions[idx].name == name)
            {
                allFunctions.RemoveAt(idx);
            }
            else
            {
                Function f = GetFunctionFromName(name);
                allFunctions.Remove(f);
            }
        }

        public static void AddFunction(Function item)
        {
            allFunctions.Add(item);
            // TODO: Replace index with a new one.
        }
    }
}
