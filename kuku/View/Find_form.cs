using kuku.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuku.View
{
    public partial class Find_form : Form
    {
        public Find_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => Model_notebook.finder = textBox1.Text;
       
    }
}
