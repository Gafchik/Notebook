using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuku.Model
{
    public class Model_notebook
    {
        public string path { get; set; }
        public List<string> text { get; set; }
        public Model_notebook() { path = ""; }
    }

}
