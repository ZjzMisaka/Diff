using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diff
{
    public enum DiffType {Add, Delete, None};
    public class DiffRes
    {
        private DiffType type;
        public DiffType Type
        {
            get { return type; }
            set { type = value; }
        }
        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public DiffRes(DiffType type, int index)
        {
            Type = type;
            Index = index;
        }
    }
}
