using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuku.Model
{
    public static class Model_notebook
    {
        public static string finder { get; set; }
        public static string path { get; set; }
        public static string text { get; set; }
       // public static List<string> text { get; set; }
         static Model_notebook() { path = ""; finder = ""; }
    }

}
