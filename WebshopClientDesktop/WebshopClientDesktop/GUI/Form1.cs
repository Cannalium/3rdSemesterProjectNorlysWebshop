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
            eventuc1.Hide();
            merchuc1.Hide();
            adminPageuc1.Hide();
        }

        //Buttons
        private void EventButton_Click(object sender, EventArgs e)
        {

            //Hide other user controls
            merchuc1.Hide();
            adminPageuc1.Hide();
            //Show current user control
            eventuc1.Show();
            eventuc1.BringToFront();
        }

        private void MerchButton_Click(object sender, EventArgs e)
        {
            //Hide other user controls
            eventuc1.Hide();
            adminPageuc1.Hide();
            //Show current user control
            merchuc1.Show();
            merchuc1.BringToFront();
        }

        private void AdminLogo_Click(object sender, EventArgs e)
        {
            //Hide other user controls
            eventuc1.Hide();
            merchuc1.Hide();
            //Show current user control
            adminPageuc1.Show();
            adminPageuc1.BringToFront();
        }

        private void picBoxNorlysLogo_Click(object sender, EventArgs e)
        {
            eventuc1.Hide();
            merchuc1.Hide();
            adminPageuc1.Hide();
        }
    }
}
