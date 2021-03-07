using kuku.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kuku.View
{
   public class Notebook_comand
    {
        public void Create(ref TextBox sender, Model_notebook model)
        {
            TextBox textBox = sender;
            if (textBox.Text != "")
            {

                DialogResult rez = MessageBox.Show("Save", "Есть не сохраненный фаил", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rez == DialogResult.Yes)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "TXT|*.txt";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        model.path = dialog.FileName;
                        File.WriteAllText(model.path, textBox.Text);
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
        public void Open(ref TextBox sender, Model_notebook model)
        {

            if (sender.Text != "")
            {

                DialogResult rez = MessageBox.Show("Save", "Есть не сохраненный фаил", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rez == DialogResult.Yes)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "TXT|*.txt";
                    if (dialog.ShowDialog() == DialogResult.OK)
                        File.WriteAllText(dialog.FileName, sender.Text);
                    else
                        sender.Text = "";
                }
                if (rez == DialogResult.No)
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "TXT|*.txt";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        model.path = dialog.FileName;
                        sender.Text = File.ReadAllText(model.path);
                    }
                }
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "TXT|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    model.path = dialog.FileName;
                    sender.Text = File.ReadAllText(model.path);
                }
            }
        }
        public void Save(ref TextBox sender, Model_notebook model)
        {

            if (model.path == "")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "TXT|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    model.path = dialog.FileName;
                    File.WriteAllText(model.path, sender.Text);
                }
            }
            else
                File.WriteAllText(model.path, sender.Text);
        }
        public void SaveAs(ref TextBox sender, Model_notebook model)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "TXT|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                model.path = dialog.FileName;
                File.WriteAllText(model.path, sender.Text);
            }
        }
        public void NewWindow() => new Form1().Show();
        public void Undo(ref TextBox sender, Model_notebook model) => sender.Undo();
        public void Cut(ref TextBox sender, Model_notebook model) => sender.Cut();
        public void Copy(ref TextBox sender, Model_notebook model) => sender.Copy();
        public void Paste(ref TextBox sender, Model_notebook model) => sender.Paste();
    }
}
