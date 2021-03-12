
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
        public void Create(TextBox sender)
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

        public void Select_all(TextBox sender)
        {
            sender.SelectionStart = 0;
            sender.SelectionLength = sender.Text.Length;
            sender.Focus();
        }

        internal void F3(TextBox sender)
        {
            if (Model_notebook.finder != "")
            {
                try
                {
                   
                    int i = sender.Text.IndexOf(Model_notebook.finder, sender.SelectionStart + Model_notebook.finder.Length);
                    /*if (i == -1)
                        throw ArgumentNullException;*/
                    sender.SelectionStart = i;
                    sender.SelectionLength = Model_notebook.finder.Length;
                    sender.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("ничего не найдено", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("нечего искать нажмите 'Ctrl+f' и введите искомую строку", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void find(TextBox sender)
        {
           
            Find_form f =new Find_form();
            f.ShowDialog();
            if (Model_notebook.finder != "")
            {
                try
                {
                    int i = sender.Text.IndexOf(Model_notebook.finder);
                    sender.SelectionStart = i;
                    sender.SelectionLength = Model_notebook.finder.Length;
                    sender.Focus();
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("ничего не найдено", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Data_time(TextBox sender) => sender.Paste(DateTime.Now.ToString());


        public void Params() => MessageBox.Show("Мы типа задали параметры", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        public void Print()
        {
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Мы типа распечатали", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Open(TextBox sender)
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
        public void Save(TextBox sender)
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
        public void SaveAs(TextBox sender)
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
        public void Undo(TextBox sender) => sender.Undo();
        public void Cut(TextBox sender) => sender.Cut();
        public void Copy(TextBox sender) => sender.Copy();
        public void Paste(TextBox sender) => sender.Paste();
        public void Del()
        {
            if (Model_notebook.path != "")
            {
                File.Delete(Model_notebook.path);
                Model_notebook.path = "";
                MessageBox.Show("Сохранение удален", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("У нас еще не выбран фаил", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
