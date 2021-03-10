namespace kuku
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиДалееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиРанееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.select_all_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Data_timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переносПоСловамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextCreatrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.NewWindowToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsКакToolStripMenuItem,
            this.toolStripSeparator1,
            this.ParamsToolStripMenuItem,
            this.PrintToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // NewWindowToolStripMenuItem
            // 
            this.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem";
            this.NewWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.NewWindowToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.NewWindowToolStripMenuItem.Text = "Новое окно";
            this.NewWindowToolStripMenuItem.Click += new System.EventHandler(this.NewWindowToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsКакToolStripMenuItem
            // 
            this.SaveAsКакToolStripMenuItem.Name = "SaveAsКакToolStripMenuItem";
            this.SaveAsКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsКакToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.SaveAsКакToolStripMenuItem.Text = "Сохранить как...";
            this.SaveAsКакToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // ParamsToolStripMenuItem
            // 
            this.ParamsToolStripMenuItem.Name = "ParamsToolStripMenuItem";
            this.ParamsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.ParamsToolStripMenuItem.Text = "Параметры страницы";
            this.ParamsToolStripMenuItem.Click += new System.EventHandler(this.ParamsToolStripMenuItem_Click);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.PrintToolStripMenuItem.Text = "Печать...";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.toolStripSeparator3,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.delToolStripMenuItem,
            this.toolStripSeparator4,
            this.findToolStripMenuItem,
            this.найтиДалееToolStripMenuItem,
            this.найтиРанееToolStripMenuItem,
            this.заменитьToolStripMenuItem,
            this.перейтиToolStripMenuItem,
            this.toolStripSeparator5,
            this.select_all_ToolStripMenuItem,
            this.Data_timeToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.UndoToolStripMenuItem.Text = "Отменить";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Enabled = false;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Enabled = false;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Enabled = false;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.delToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.delToolStripMenuItem.Text = "Удалить";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.findToolStripMenuItem.Text = "Найти ...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // найтиДалееToolStripMenuItem
            // 
            this.найтиДалееToolStripMenuItem.Name = "найтиДалееToolStripMenuItem";
            this.найтиДалееToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.найтиДалееToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.найтиДалееToolStripMenuItem.Text = "Найти далее";
            // 
            // найтиРанееToolStripMenuItem
            // 
            this.найтиРанееToolStripMenuItem.Name = "найтиРанееToolStripMenuItem";
            this.найтиРанееToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.найтиРанееToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.найтиРанееToolStripMenuItem.Text = "Найти ранее";
            // 
            // заменитьToolStripMenuItem
            // 
            this.заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
            this.заменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.заменитьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.заменитьToolStripMenuItem.Text = "Заменить ...";
            // 
            // перейтиToolStripMenuItem
            // 
            this.перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            this.перейтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.перейтиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.перейтиToolStripMenuItem.Text = "Перейти ...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(191, 6);
            // 
            // select_all_ToolStripMenuItem
            // 
            this.select_all_ToolStripMenuItem.Name = "select_all_ToolStripMenuItem";
            this.select_all_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.select_all_ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.select_all_ToolStripMenuItem.Text = "Выделить все";
            this.select_all_ToolStripMenuItem.Click += new System.EventHandler(this.select_all_ToolStripMenuItem_Click);
            // 
            // Data_timeToolStripMenuItem
            // 
            this.Data_timeToolStripMenuItem.Name = "Data_timeToolStripMenuItem";
            this.Data_timeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.Data_timeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.Data_timeToolStripMenuItem.Text = "Время и дата";
            this.Data_timeToolStripMenuItem.Click += new System.EventHandler(this.Data_timeToolStripMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переносПоСловамToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // переносПоСловамToolStripMenuItem
            // 
            this.переносПоСловамToolStripMenuItem.Name = "переносПоСловамToolStripMenuItem";
            this.переносПоСловамToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.переносПоСловамToolStripMenuItem.Text = "Перенос по словам";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт ...";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(0, 27);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(800, 421);
            this.textBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextCreatrToolStripMenuItem,
            this.ContextNewToolStripMenuItem,
            this.ContextOpenToolStripMenuItem,
            this.ContextSaveToolStripMenuItem,
            this.ContextSaveAs});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 114);
            // 
            // ContextCreatrToolStripMenuItem
            // 
            this.ContextCreatrToolStripMenuItem.Name = "ContextCreatrToolStripMenuItem";
            this.ContextCreatrToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ContextCreatrToolStripMenuItem.Text = "Создать";
            this.ContextCreatrToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // ContextNewToolStripMenuItem
            // 
            this.ContextNewToolStripMenuItem.Name = "ContextNewToolStripMenuItem";
            this.ContextNewToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ContextNewToolStripMenuItem.Text = "Новое окно";
            this.ContextNewToolStripMenuItem.Click += new System.EventHandler(this.NewWindowToolStripMenuItem_Click);
            // 
            // ContextOpenToolStripMenuItem
            // 
            this.ContextOpenToolStripMenuItem.Name = "ContextOpenToolStripMenuItem";
            this.ContextOpenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ContextOpenToolStripMenuItem.Text = "Открыть";
            this.ContextOpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ContextSaveToolStripMenuItem
            // 
            this.ContextSaveToolStripMenuItem.Name = "ContextSaveToolStripMenuItem";
            this.ContextSaveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ContextSaveToolStripMenuItem.Text = "Сохранить";
            this.ContextSaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ContextSaveAs
            // 
            this.ContextSaveAs.Name = "ContextSaveAs";
            this.ContextSaveAs.Size = new System.Drawing.Size(153, 22);
            this.ContextSaveAs.Text = "Сохранить как";
            this.ContextSaveAs.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Безимянный";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ParamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиДалееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиРанееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem select_all_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Data_timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переносПоСловамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContextCreatrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextSaveAs;
    }
}

