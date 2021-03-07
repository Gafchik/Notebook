﻿using System;
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


        private void CreateToolStripMenuItem_Click(object sender, EventArgs e) => control.Create(ref textBox);
       

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) => control.Open(ref textBox);


        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => control.Save(ref textBox);


        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) => control.SaveAs(ref textBox);
       

        private void NewWindowToolStripMenuItem_Click(object sender, EventArgs e) => control.NewWindow();
       

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e) => control.Undo(ref textBox);



        private void CutToolStripMenuItem_Click(object sender, EventArgs e) => control.Cut(ref textBox);


        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) => control.Copy(ref textBox);


        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) => control.Paste(ref textBox);




    }
}
