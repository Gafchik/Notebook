
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using kuku.View;

namespace kuku
{
    public class Control_notebook
    {

        Notebook_comand comand;
        public Control_notebook()
        {
            comand = new Notebook_comand();
        }
        public void Create(TextBox sender) => comand.Create(sender);
        public void Open(TextBox sender) => comand.Open(sender);
        public void Save(TextBox sender) => comand.Save(sender);
        public void SaveAs(TextBox sender) => comand.SaveAs(sender);
        public void NewWindow() => comand.NewWindow();
        public void Undo(TextBox sender) => comand.Undo(sender);
        public void Cut(TextBox sender) => comand.Cut(sender);
        public void Copy(TextBox sender) => comand.Copy(sender);
        public void Paste(TextBox sender) => comand.Paste(sender);

        public void Del() => comand.Del();

        public void Print( ) => comand.Print();

        public void Params() => comand.Params();

        public void Select_all(TextBox sender) => comand.Select_all(sender);

        public void Data_time(TextBox sender) => comand.Data_time(sender);

        internal void find(TextBox sender)=> comand.find(sender);

        internal void F3(TextBox sender) => comand.F3(sender);

        internal void F3_back(TextBox sender) => comand.F3_back(sender);

        internal void Replace(TextBox sender) => comand.Replace(sender);
       
    }
}
