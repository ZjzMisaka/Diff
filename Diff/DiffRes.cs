using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diff
{
    public enum Type {Add, Delete, None};
    public class DiffRes
    {
        private Type type;
        public Type Type
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

        public DiffRes(Type type, int index)
        {
            Type = type;
            Index = index;
        }
    }
}
