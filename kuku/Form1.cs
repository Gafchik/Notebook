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
        string path = "";
        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += Form1_SizeChanged;
            this.ContextMenuStrip = contextMenuStrip1;
            textBox.Size = new Size(this.Size.Width, this.Size.Height);
            textBox.Text = "";
            textBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
           if((sender as TextBox).Text == "")
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
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            textBox.Size = new Size(this.Size.Width, this.Size.Height);
        }


        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {

                DialogResult rez = MessageBox.Show("Save", "Есть не сохраненный фаил", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rez == DialogResult.Yes)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                     dialog.Filter = "TXT|*.txt";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                         path = dialog.FileName;
                        File.WriteAllText(path, textBox.Text);
                    }
                    else
                        textBox.Text = "";
                }
                if (rez == DialogResult.No)
                    textBox.Text = "";
            }
            else
                textBox.Text = "";
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {

                DialogResult rez = MessageBox.Show("Save", "Есть не сохраненный фаил", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rez == DialogResult.Yes)
                {
                    SaveFileDialog dialog = new SaveFileDialog();   
                     dialog.Filter = "TXT|*.txt";
                    if (dialog.ShowDialog() == DialogResult.OK)                     
                        File.WriteAllText(dialog.FileName, textBox.Text);                   
                    else
                        textBox.Text = "";
                }
                if (rez == DialogResult.No)
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                     dialog.Filter = "TXT|*.txt";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        path = dialog.FileName;
                        textBox.Text = File.ReadAllText(path);
                    }
                }
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                 dialog.Filter = "TXT|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    textBox.Text = File.ReadAllText(path);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (path == "")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "TXT|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                     path = dialog.FileName;
                    File.WriteAllText(path, textBox.Text);
                }
            }
            else
                File.WriteAllText(path, textBox.Text);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "TXT|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
                File.WriteAllText(path, textBox.Text);
            }
        }

        private void NewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

       
    }
}

