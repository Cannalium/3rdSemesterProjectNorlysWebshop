using WebshopClientDesktop.GUI;

namespace WebshopClientDesktop
{
    public partial class Form1 : Form
    {
        private EventForm eventForm;
        private MerchForm merchForm;
        public Form1()
        {
            InitializeComponent();

            //Relates to EventLbl_Click method
            eventForm = new EventForm(this, merchForm);
            eventsLbl.Click += EventLbl_Click;

            //Relates to MerchLbl_Click method
            merchForm = new MerchForm(this, eventForm);
            merchLbl.Click += MerchLbl_Click;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EventLbl_Click(object? sender, EventArgs e)
        {
            try
            {
                //If EventForm is not visible - that is, if Form1 is open - and we push the button "Events", EventForm is shown
                if (!eventForm.Visible)
                {
                    eventForm.Show();
                }

                //When EventForm is shown, this hides Form1
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error happened while trying to load Event page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MerchLbl_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!merchForm.Visible)
                {
                    merchForm.Show();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error happened while trying to load Merch page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NorlysHomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}