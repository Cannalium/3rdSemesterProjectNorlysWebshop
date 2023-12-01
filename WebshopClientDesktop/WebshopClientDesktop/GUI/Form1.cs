using System.Windows.Forms;
using WebshopClientDesktop.GUI;

namespace WebshopClientDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adminPageuc1.Hide();
            productPageuc1.Hide();
        }

        private void AdminLogo_Click(object sender, EventArgs e)
        {
            //Hide productpage
            productPageuc1.Hide();
            //Show current user control
            adminPageuc1.Show();
            adminPageuc1.BringToFront();
        }

        private void PicBoxNorlysLogo_Click(object sender, EventArgs e)
        {
            adminPageuc1.Hide();
            productPageuc1.Hide();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            productPageuc1.Show();
            productPageuc1.BringToFront();
        }

        //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    productPageuc1.StopUpdateTimer();
        //}
    }
}
