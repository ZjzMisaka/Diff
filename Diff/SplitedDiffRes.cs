using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diff
{
    public class SplitedDiffRes
    {
        private List<PartSplitedDiffRes> origPartSplitedDiffResList;
        private List<PartSplitedDiffRes> revPartSplitedDiffResList;

        public List<PartSplitedDiffRes> OrigPartSplitedDiffResList { get => origPartSplitedDiffResList; set => origPartSplitedDiffResList = value; }
        public List<PartSplitedDiffRes> RevPartSplitedDiffResList { get => revPartSplitedDiffResList; set => revPartSplitedDiffResList = value; }
    }
}
