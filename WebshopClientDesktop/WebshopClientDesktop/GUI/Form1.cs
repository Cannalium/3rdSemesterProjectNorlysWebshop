using WebshopClientDesktop.GUI;

namespace WebshopClientDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Load_form(object form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);

            if (form is Form)
            {
                Form f1 = (Form)form;
                f1.TopLevel = false;
                f1.Dock = DockStyle.Fill;
                this.panelMain.Controls.Add(f1);
                this.panelMain.Tag = f1;
                f1.Show();
            }
        }
        private void EventButton_Click(object sender, EventArgs e)
        {
            Load_form(new EventForm());
        }

        private void MerchButton_Click(object sender, EventArgs e)
        {
            Load_form(new MerchForm());
        }

        //Slettes
        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        //Slettes
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminLogo_Click(object sender, EventArgs e)
        {
            Load_form(new AdminPageForm());
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
