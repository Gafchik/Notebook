using kuku.Model;
using kuku.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuku
{
    public partial class Form1 : Form
    {
        Control_notebook control;

        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += Form1_SizeChanged;
            this.ContextMenuStrip = contextMenuStrip1;
            textBox.Size = new Size(this.Size.Width, this.Size.Height);
            textBox.Text = "";
            textBox.TextChanged += TextBox_TextChanged;
            control = new Control_notebook();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                UndoToolStripMenuItem.Enabled = false;
                CopyToolStripMenuItem.Enabled = false;
                PasteToolStripMenuItem.Enabled = false;
                CutToolStripMenuItem.Enabled = false;
            }
            else
            {
                UndoToolStripMenuItem.Enabled = true;
                CopyToolStripMenuItem.Enabled = true;
                PasteToolStripMenuItem.Enabled = true;
                CutToolStripMenuItem.Enabled = true;
            }
            Model_notebook.text = (sender as TextBox).Text;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)=> textBox.Size = new Size(this.Size.Width, this.Size.Height);
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e) => control.Create(textBox);
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) => control.Open(textBox);
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => control.Save(textBox);
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) => control.SaveAs(textBox);
        private void NewWindowToolStripMenuItem_Click(object sender, EventArgs e) => control.NewWindow();
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e) => control.Undo(textBox);
        private void CutToolStripMenuItem_Click(object sender, EventArgs e) => control.Cut(textBox);
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) => control.Copy(textBox);
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) => control.Paste(textBox);
        private void delToolStripMenuItem_Click(object sender, EventArgs e) => control.Del();
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e) => control.Print();
        private void ParamsToolStripMenuItem_Click(object sender, EventArgs e) => control.Params();
        private void select_all_ToolStripMenuItem_Click(object sender, EventArgs e) => control.Select_all(textBox);
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.Save(textBox);
            this.Close();
            GC.Collect(GC.GetGeneration(this));
        }
        private void Data_timeToolStripMenuItem_Click(object sender, EventArgs e) => control.Data_time(textBox);
        private void findToolStripMenuItem_Click(object sender, EventArgs e) => control.find(textBox);

        private void F3ToolStripMenuItem_Click(object sender, EventArgs e) => control.F3(textBox);
        private void F3_backToolStripMenuItem_Click(object sender, EventArgs e) => control.F3_back(textBox);

        private void Replace_ToolStripMenuItem_Click(object sender, EventArgs e) => control.Replace(textBox);
       
    }
}

