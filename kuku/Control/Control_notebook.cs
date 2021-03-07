
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using kuku.Model;
using kuku.View;

namespace kuku
{
    public class Control_notebook
    {
        Model_notebook model;
        Notebook_comand comand;
        public Control_notebook()
        {
            model = new Model_notebook();
            comand = new Notebook_comand();
        }

    }
}
