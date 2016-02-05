using System.Drawing;
using System.Windows.Forms;

namespace Диплом
{
    public partial class AboutPresentationForm : Form
    {
        public AboutPresentationForm()
        {
            InitializeComponent();
            rtbAbout.ForeColor = Color.Green;
            rtbAbout.BackColor = Color.White;
        }
    }
}
