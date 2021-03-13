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
    public partial class Form_replace : Form
    {
        public Form_replace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model_notebook.finder = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model_notebook.finder = textBox1.Text;
            Model_notebook.replace = textBox2.Text;
            this.Close();
        }
    }
}
