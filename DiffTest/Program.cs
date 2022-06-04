using Diff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList1 = new List<string>();
            strList1.Add("123");
            strList1.Add("-1");
            strList1.Add("1");
            strList1.Add("8");
            strList1.Add("9");
            strList1.Add("999999");
            strList1.Add("999999");
            strList1.Add("*");
            strList1.Add("**");
            strList1.Add("***");
            strList1.Add("last");
            List<string> strList2 = new List<string>();
            // =
            strList2.Add("123");
            // +
            strList2.Add("456");
            strList2.Add("789");
            // =
            strList2.Add("-1");
            strList2.Add("1");
            // - 89
            // =
            strList2.Add("999999"); 
            strList2.Add("999999");
            // <>
            strList2.Add("2");
            strList2.Add("3");
            // =
            strList2.Add("last");

            List<DiffRes> res1 = DiffTool.Diff(strList1, strList2);
            List<GroupedDiffRes> grouped = DiffTool.GetGroupedResult(res1);
            List<SplitedDiffRes> splitedDiffRes = DiffTool.GetSplitedResult(grouped);

            List<DiffRes> res2 = DiffTool.Diff("Aple", "bAppe");
        }
    }
}
