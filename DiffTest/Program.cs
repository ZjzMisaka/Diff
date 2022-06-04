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
            //List<string> strList1 = new List<string>();
            //strList1.Add("123");
            //strList1.Add("-1");
            //strList1.Add("1");
            //strList1.Add("8");
            //strList1.Add("9");
            //strList1.Add("999999");
            //strList1.Add("999999");
            //strList1.Add("*");
            //strList1.Add("**");
            //strList1.Add("***");
            //strList1.Add("last");
            //List<string> strList2 = new List<string>();
            //// =
            //strList2.Add("123");
            //// +
            //strList2.Add("456");
            //strList2.Add("789");
            //// =
            //strList2.Add("-1");
            //strList2.Add("1");
            //// - 89
            //// =
            //strList2.Add("999999"); 
            //strList2.Add("999999");
            //// <>
            //strList2.Add("2");
            //strList2.Add("3");
            //// =
            //strList2.Add("last");

            //List<DiffRes> res1 = DiffTool.Diff(strList1, strList2);
            //List<GroupedDiffRes> grouped1 = DiffTool.GetGroupedResult(res1);
            //List<SplitedDiffRes> splitedDiffRes1 = DiffTool.GetSplitedResult(grouped1);

            //List<DiffRes> res2 = DiffTool.Diff("Aple", "bAppe");

            //List<DiffRes> res3 = DiffTool.Diff(new List<string>(), new List<string>());
            //List<GroupedDiffRes> grouped3 = DiffTool.GetGroupedResult(res3);
            //List<SplitedDiffRes> splitedDiffRes3 = DiffTool.GetSplitedResult(grouped3);

            List<DiffRes> res4 = DiffTool.Diff(
                new List<string>() { "11111111", "2222222",  "3333333",  "4444444",  "555", "666", "777", "888", "", "999" }, 
                new List<string>() { "11111111", "22222222", "33333333", "44444444",                             "", "666" });
            List<GroupedDiffRes> grouped4 = DiffTool.GetGroupedResult(res4);
            List<SplitedDiffRes> splitedDiffRes4 = DiffTool.GetSplitedResult(grouped4);
        }
    }
}
