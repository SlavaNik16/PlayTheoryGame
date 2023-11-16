using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace PlayTheoryGame.Forms
{
    public partial class MenuForm : IMaterialForm
    {
        public MenuForm()
        {

            InitializeComponent();
        }

        private void butExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void butPlay_Click(object sender, System.EventArgs e)
        {
            var playForm = new MainForm();
            this.Hide();
            playForm.ShowDialog();
            this.Show();
        }
    }
}
