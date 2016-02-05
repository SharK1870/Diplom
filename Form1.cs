using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace Диплом
{
    public partial class Form1 : Form
    {
        TabControl tc = new TabControl();
        PictureBox pb = new PictureBox();
        int theme, ImageWidth, ImageHeight;
        string WorkingDirectory, PresentationName, PresentationTheme, PresentationAuthor, PresentationOrganization, MainPage, ThemePage, PresentationText, Header, Footer;
        string SpecialCancelText = "SpecialTextForExitOnPresentation";

        public Form1()
        {
            InitializeComponent();
            Footer = string.Empty;
            Footer += "\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t<script src=\"lib/js/head.min.js\"></script>"
            + "\r\n\t\t<script src=\"js/reveal.min.js\"></script>\r\n\r\n\t\t<script>"
            + "\r\n\t\t\tReveal.initialize({\r\n\t\t\t\tcontrols: true,\r\n\t\t\t\tprogress: true,"
            + "\r\n\t\t\t\thistory: true,\r\n\t\t\t\tcenter: true,\r\n\r\n\t\t\t\ttheme: Reveal.getQueryHash().theme,"
            + "\r\n\t\t\t\ttransition: Reveal.getQueryHash().transition || 'default',\r\n\t\t\t\tdependencies: ["
            + "\r\n\t\t\t\t\t{ src: 'lib/js/classList.js', condition: function() { return !document.body.classList; } },"
            + "\r\n\t\t\t\t\t{ src: 'plugin/markdown/marked.js', condition: function() { return !!document.querySelector( '[data-markdown]' ); } },"
            + "\r\n\t\t\t\t\t{ src: 'plugin/markdown/markdown.js', condition: function() { return !!document.querySelector( '[data-markdown]' ); } },"
            + "\r\n\t\t\t\t\t{ src: 'plugin/highlight/highlight.js', async: true, callback: function() { hljs.initHighlightingOnLoad(); } },"
            + "\r\n\t\t\t\t\t{ src: 'plugin/zoom-js/zoom.js', async: true, condition: function() { return !!document.body.classList; } },"
            + "\r\n\t\t\t\t\t{ src: 'plugin/notes/notes.js', async: true, condition: function() { return !!document.body.classList; } }"
            + "\r\n\t\t\t\t]\r\n\t\t\t});\r\n\t\t</script>\r\n\t</body>\r\n</html>";
        }

        private void tsmiAboutProgram_Click(object sender, EventArgs e)
        {
            AboutPresentationForm about = new AboutPresentationForm();
            about.ShowDialog();
        }

        private void tsmiExitPresentation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiNewPresentation_Click(object sender, EventArgs e)
        {
            if (tc.TabPages.Count != 0)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                panelElements.Visible = true;
                NewPresentation newP = new NewPresentation();
                newP.ShowDialog();
                PresentationName = newP.tbName.Text.Trim();
                if (newP.tbName.Text != "" && newP.Text != SpecialCancelText)
                {
                    while (PresentationName == "")
                    {
                        MessageBox.Show("Введите имя презентации!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        newP.ShowDialog();
                    }
                    Form1.ActiveForm.Text = "Текущая презентация : " + newP.tbName.Text.Trim();
                    PresentationName = newP.tbName.Text.Trim();
                    PresentationAuthor = newP.tbAuthor.Text.Trim();
                    PresentationTheme = newP.tbTheme.Text.Trim();
                    PresentationOrganization = newP.tbOrganization.Text.Trim();

                    // Выбор темы по умолчанию
                    theme = newP.cbTheme.SelectedIndex;
                    switch (theme)
                    {
                        case 0: { ThemePage = "beige"; } break;
                        case 1: { ThemePage = "blood"; } break;
                        case 2: { ThemePage = "default"; } break;
                        case 3: { ThemePage = "moon"; } break;
                        case 4: { ThemePage = "night"; } break;
                        case 5: { ThemePage = "serif"; } break;
                        case 6: { ThemePage = "shark"; } break;
                        case 7: { ThemePage = "simple"; } break;
                        case 8: { ThemePage = "sky"; } break;
                        case 9: { ThemePage = "solarized"; } break;
                    }

                    Header = string.Empty;
                    Header += "<!doctype html>\r\n<html lang=\"ru\">\r\n\t<head>\r\n\t\t<meta charset=\"utf-8\">"
                        + "\r\n\t\t<title>" + PresentationName + "</title>\r\n\t\t<meta name=\"author\" content=\"" + PresentationAuthor
                        + "\">\r\n\t\t<meta name=\"apple-mobile-web-app-capable\" content=\"yes\" />"
                        + "\r\n\t\t<meta name=\"apple-mobile-web-app-status-bar-style\" content=\"black-translucent\" />"
                        + "\r\n\t\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no\">"
                        + "\r\n\t\t<link rel=\"stylesheet\" href=\"css/reveal.min.css\">"
                        + "\r\n\t\t<link rel=\"stylesheet\" href=\"css/theme/" + PresentationTheme
                        + ".css\" id=\"theme\">\r\n\t\t<link rel=\"stylesheet\" href=\"lib/css/zenburn.css\">\r\n\t</head>"
                        + "\r\n\r\n\t<body>\r\n\t\t<div class=\"reveal\">\r\n\t\t\t<div class=\"slides\">";


                    MainPage = "\r\n\t<section>\r\n\t\t<p>Название: " + PresentationName + "</p>\r\n\t\t<p>Автор: " + PresentationAuthor + "</p>\r\n\t\t<p>Тема: " + PresentationTheme + "</p>\r\n\t\t<p>Огранизация: " + PresentationOrganization + "</p>\r\n\t</section>";
                    MessageBox.Show("Выберите место размещения рабочей директории", "Выбор рабочей директории!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string dir = string.Empty;
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        dir = folderBrowserDialog1.SelectedPath + "\\" + PresentationName;
                        WorkingDirectory = dir;
                        CopyDir(AppDomain.CurrentDomain.BaseDirectory + "reveal.js", dir);
                    }
                }
            }
        }

        // Рекурсивный вызов копирования папок и файлов рабочего фреймворка. begin_dir-источник. end_dir-приёмник.
        void CopyDir(string begin_dir, string end_dir)
        {
            if (Directory.Exists(end_dir) != true)
            {
                Directory.CreateDirectory(end_dir);
                foreach (string s1 in Directory.GetFiles(begin_dir))
                {
                    string s2 = end_dir + @"\" + Path.GetFileName(s1);
                    File.Delete(s2);
                    File.Copy(s1, s2);
                }
                foreach (string s in Directory.GetDirectories(begin_dir))
                {
                    CopyDir(s, end_dir + @"\" + Path.GetFileName(s));
                }
            }
        }

        private void tsmiOpenPresentation_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string text = File.ReadAllText(openFileDialog1.FileName);
                MessageBox.Show("Открыт файл: " + openFileDialog1.FileName, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form1.ActiveForm.Text = "Текущая презентация: " + openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("Файл не выбран!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form1.ActiveForm.Text = "Редактор презентаций";
            }
        }

        private void tsmiSavePresentation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке!", "В разработке!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddSlide_Click(object sender, EventArgs e)
        {
            int CountSlide = tc.TabPages.Count;
            tc.Parent = panelWorkingPresentation;
            tc.Dock = DockStyle.Fill;
            tc.TabPages.Add("Слайд " + (CountSlide + 1));
            tc.SelectedIndex = CountSlide;
            CountSlide++;
            btnAddElement.Visible = true;
            btnDeleteSlide.Visible = true;
            btnDeleteAllSlide.Visible = true;
            btnDeleteSlide.Enabled = true;
            btnDeleteAllSlide.Enabled = true;
        }

        void SavePresentation(string WorkingDirectory)
        {
            MessageBox.Show("В разработке", "В разработке", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowPresentation_Click(object sender, EventArgs e)
        {
            Process.Start(WorkingDirectory + @"\index.html");
        }

        private void btnDeleteSlide_Click(object sender, EventArgs e)
        {
            if (tc.TabPages.Count != 0)
            {
                if (MessageBox.Show("Пересчитать номера слайдов?", "Пересчитать номера слайдов?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int DeleteSlide = tc.SelectedIndex;
                    tc.TabPages.Remove(tc.SelectedTab);
                    tc.SelectedIndex = DeleteSlide;
                    int count = tc.TabPages.Count;
                    for (int i = 0; i < count; i++) 
                    {
                        tc.TabPages[i].Text = "Слайд " + (i + 1).ToString(); 
                    }
                }
                else
                {
                    int DeleteSlide = tc.SelectedIndex;
                    tc.TabPages.Remove(tc.SelectedTab);
                    if (DeleteSlide >= tc.TabPages.Count) 
                    {
                        tc.SelectedIndex = tc.TabPages.Count;
                    }
                    else
                    {
                        tc.SelectedIndex = DeleteSlide;
                    }
                }
            }
            else 
            {
                btnDeleteSlide.Enabled = false;
                btnDeleteAllSlide.Enabled = false;
            }
        }

        private void btnDeleteAllSlide_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить все слайды?", "Удалить все слайды?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tc.TabPages.Clear();
                MessageBox.Show("Все слайды удалены!");
                btnDeleteSlide.Enabled = false;
                btnDeleteAllSlide.Enabled = false;
            }
        }
    }
}
