
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using kuku.Model;

namespace kuku.View
{
    public class Notebook_comand
    {
        public void Create(TextBox sender  )
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
                        Model_notebook.path = dialog.FileName;
                        File.WriteAllText(Model_notebook.path, textBox.Text);
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
        public void Open(TextBox sender  )
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
                        Model_notebook.path = dialog.FileName;
                        sender.Text = File.ReadAllText(Model_notebook.path);
                    }
                }
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "TXT|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Model_notebook.path = dialog.FileName;
                    sender.Text = File.ReadAllText(Model_notebook.path);
                }
            }
        }
        public void Save(TextBox sender )
        {

            if (Model_notebook.path == "")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "TXT|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Model_notebook.path = dialog.FileName;
                    File.WriteAllText(Model_notebook.path, sender.Text);
                }
            }
            else
                File.WriteAllText(Model_notebook.path, sender.Text);
        }
        public void SaveAs(TextBox sender )
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "TXT|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Model_notebook.path = dialog.FileName;
                File.WriteAllText(Model_notebook.path, sender.Text);
            }
        }
        public void NewWindow() => new Form1().Show();
        public void Undo(TextBox sender  ) => sender.Undo();
        public void Cut(TextBox sender ) => sender.Cut();
        public void Copy(TextBox sender ) => sender.Copy();
        public void Paste(TextBox sender ) => sender.Paste();
    }
}
