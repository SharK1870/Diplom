namespace Диплом
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewPresentation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenPresentation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSavePresentation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitPresentation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelElements = new System.Windows.Forms.Panel();
            this.btnDeleteAllSlide = new System.Windows.Forms.Button();
            this.btnDeleteSlide = new System.Windows.Forms.Button();
            this.btnShowPresentation = new System.Windows.Forms.Button();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.btnAddSlide = new System.Windows.Forms.Button();
            this.panelWorkingPresentation = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewPresentation,
            this.tsmiOpenPresentation,
            this.tsmiSavePresentation,
            this.tsmiExitPresentation});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiNewPresentation
            // 
            this.tsmiNewPresentation.Name = "tsmiNewPresentation";
            this.tsmiNewPresentation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.tsmiNewPresentation.Size = new System.Drawing.Size(280, 22);
            this.tsmiNewPresentation.Text = "Создать презентацию";
            this.tsmiNewPresentation.Click += new System.EventHandler(this.tsmiNewPresentation_Click);
            // 
            // tsmiOpenPresentation
            // 
            this.tsmiOpenPresentation.Name = "tsmiOpenPresentation";
            this.tsmiOpenPresentation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.tsmiOpenPresentation.Size = new System.Drawing.Size(280, 22);
            this.tsmiOpenPresentation.Text = "Открыть презентацию";
            this.tsmiOpenPresentation.Click += new System.EventHandler(this.tsmiOpenPresentation_Click);
            // 
            // tsmiSavePresentation
            // 
            this.tsmiSavePresentation.Name = "tsmiSavePresentation";
            this.tsmiSavePresentation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSavePresentation.Size = new System.Drawing.Size(280, 22);
            this.tsmiSavePresentation.Text = "Сохранить презентацию";
            this.tsmiSavePresentation.Click += new System.EventHandler(this.tsmiSavePresentation_Click);
            // 
            // tsmiExitPresentation
            // 
            this.tsmiExitPresentation.Name = "tsmiExitPresentation";
            this.tsmiExitPresentation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.tsmiExitPresentation.Size = new System.Drawing.Size(280, 22);
            this.tsmiExitPresentation.Text = "Выход";
            this.tsmiExitPresentation.Click += new System.EventHandler(this.tsmiExitPresentation_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAboutProgram});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(68, 20);
            this.tsmiHelp.Text = "Помощь";
            // 
            // tsmiAboutProgram
            // 
            this.tsmiAboutProgram.Name = "tsmiAboutProgram";
            this.tsmiAboutProgram.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.tsmiAboutProgram.Size = new System.Drawing.Size(224, 22);
            this.tsmiAboutProgram.Text = "О программе";
            this.tsmiAboutProgram.Click += new System.EventHandler(this.tsmiAboutProgram_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Презентация|*.html|Все файлы|*.*";
            // 
            // panelElements
            // 
            this.panelElements.Controls.Add(this.btnDeleteAllSlide);
            this.panelElements.Controls.Add(this.btnDeleteSlide);
            this.panelElements.Controls.Add(this.btnShowPresentation);
            this.panelElements.Controls.Add(this.btnAddElement);
            this.panelElements.Controls.Add(this.btnAddSlide);
            this.panelElements.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelElements.Location = new System.Drawing.Point(0, 24);
            this.panelElements.Name = "panelElements";
            this.panelElements.Size = new System.Drawing.Size(990, 70);
            this.panelElements.TabIndex = 1;
            this.panelElements.Visible = false;
            // 
            // btnDeleteAllSlide
            // 
            this.btnDeleteAllSlide.Location = new System.Drawing.Point(167, 32);
            this.btnDeleteAllSlide.Name = "btnDeleteAllSlide";
            this.btnDeleteAllSlide.Size = new System.Drawing.Size(149, 23);
            this.btnDeleteAllSlide.TabIndex = 12;
            this.btnDeleteAllSlide.Text = "Удалить все слайды";
            this.btnDeleteAllSlide.UseVisualStyleBackColor = true;
            this.btnDeleteAllSlide.Visible = false;
            this.btnDeleteAllSlide.Click += new System.EventHandler(this.btnDeleteAllSlide_Click);
            // 
            // btnDeleteSlide
            // 
            this.btnDeleteSlide.Location = new System.Drawing.Point(12, 32);
            this.btnDeleteSlide.Name = "btnDeleteSlide";
            this.btnDeleteSlide.Size = new System.Drawing.Size(149, 23);
            this.btnDeleteSlide.TabIndex = 11;
            this.btnDeleteSlide.Text = "Удалить слайд";
            this.btnDeleteSlide.UseVisualStyleBackColor = true;
            this.btnDeleteSlide.Visible = false;
            this.btnDeleteSlide.Click += new System.EventHandler(this.btnDeleteSlide_Click);
            // 
            // btnShowPresentation
            // 
            this.btnShowPresentation.Location = new System.Drawing.Point(322, 3);
            this.btnShowPresentation.Name = "btnShowPresentation";
            this.btnShowPresentation.Size = new System.Drawing.Size(149, 23);
            this.btnShowPresentation.TabIndex = 10;
            this.btnShowPresentation.Text = "Отобразить презентацию";
            this.btnShowPresentation.UseVisualStyleBackColor = true;
            this.btnShowPresentation.Visible = false;
            this.btnShowPresentation.Click += new System.EventHandler(this.btnShowPresentation_Click);
            // 
            // btnAddElement
            // 
            this.btnAddElement.Location = new System.Drawing.Point(167, 3);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(149, 23);
            this.btnAddElement.TabIndex = 9;
            this.btnAddElement.Text = "Добавить элемент";
            this.btnAddElement.UseVisualStyleBackColor = true;
            this.btnAddElement.Visible = false;
            // 
            // btnAddSlide
            // 
            this.btnAddSlide.Location = new System.Drawing.Point(12, 3);
            this.btnAddSlide.Name = "btnAddSlide";
            this.btnAddSlide.Size = new System.Drawing.Size(149, 23);
            this.btnAddSlide.TabIndex = 8;
            this.btnAddSlide.Text = "Добавить слайд";
            this.btnAddSlide.UseVisualStyleBackColor = true;
            this.btnAddSlide.Click += new System.EventHandler(this.btnAddSlide_Click);
            // 
            // panelWorkingPresentation
            // 
            this.panelWorkingPresentation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkingPresentation.Location = new System.Drawing.Point(0, 94);
            this.panelWorkingPresentation.Name = "panelWorkingPresentation";
            this.panelWorkingPresentation.Size = new System.Drawing.Size(990, 250);
            this.panelWorkingPresentation.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 344);
            this.Controls.Add(this.panelWorkingPresentation);
            this.Controls.Add(this.panelElements);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Редактор презентаций";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelElements.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutProgram;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewPresentation;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenPresentation;
        private System.Windows.Forms.ToolStripMenuItem tsmiSavePresentation;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitPresentation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelElements;
        private System.Windows.Forms.Button btnShowPresentation;
        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.Button btnAddSlide;
        private System.Windows.Forms.Panel panelWorkingPresentation;
        private System.Windows.Forms.Button btnDeleteSlide;
        private System.Windows.Forms.Button btnDeleteAllSlide;
    }
}

