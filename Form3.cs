using System;
using System.Drawing;
using System.Windows.Forms;

namespace Диплом
{
    public partial class NewPresentation : Form
    {
        public NewPresentation()
        {
            InitializeComponent();
            cbTheme.SelectedIndex = 2;
            cbTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTheme.ForeColor = Color.Green;
            btnNewPresentationOK.ForeColor = Color.Green;
            btnNewPresentationOK.BackColor = Color.White;
            btnNewPresentationCancel.ForeColor = Color.Green;
            btnNewPresentationCancel.BackColor = Color.White;
            tbName.ForeColor = Color.Green;
            tbName.BackColor = Color.White;
            tbAuthor.ForeColor = Color.Green;
            tbAuthor.BackColor = Color.White;
            tbTheme.ForeColor = Color.Green;
            tbTheme.BackColor = Color.White;
            tbOrganization.ForeColor = Color.Green;
            tbOrganization.BackColor = Color.White;
            label1.ForeColor = Color.Green;
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Green;
            label4.ForeColor = Color.Green;
            label5.ForeColor = Color.Green;
        }

        private void btnNewPresentationCancel_Click(object sender, EventArgs e)
        {
            tbName.Text = "SpecialTextForExitOnPresentation";
            this.Close();
        }

        private void btnNewPresentationOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() == "" || tbAuthor.Text.Trim() == "" || tbOrganization.Text.Trim() == "" || tbTheme.Text.Trim() == "")
            {
                MessageBox.Show("Заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Close();
            }
        }
    }
}
