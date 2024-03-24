using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }



        private void StartForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.logo;
        }

        private void In_Click(object sender, EventArgs e)
        {
            Menu1Form newForm = new Menu1Form();
            newForm.Show();

            this.Hide();
        }
        private void takeout_Click(object sender, EventArgs e)
        {
            Menu1Form newForm = new Menu1Form();
            newForm.Show();

            this.Hide();
        }
    }
}