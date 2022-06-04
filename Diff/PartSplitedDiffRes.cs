using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diff
{
    public enum GetFrom { Orig, Rev, Blank }
    public class PartSplitedDiffRes
    {
        private int index;
        private GetFrom getFrom;

        public int Index { get => index; set => index = value; }
        public GetFrom GetFrom { get => getFrom; set => getFrom = value; }

        public PartSplitedDiffRes(int index, GetFrom getFrom)
        {
            this.Index = index;
            this.GetFrom = GetFrom;
        }
    }
}
