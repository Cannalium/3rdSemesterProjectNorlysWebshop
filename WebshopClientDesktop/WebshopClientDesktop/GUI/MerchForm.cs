using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebshopClientDesktop.GUI
{
    public partial class MerchForm : Form
    {
        private Form1 form1;
        private EventForm eventForm;
        public MerchForm(Form1 existingForm, EventForm existingEventForm)
        {
            InitializeComponent();

            //Relates to NorlysButton_Click method - home page
            form1 = existingForm;
            norlysButton.Click += NorlysButton_Click;

            //Relates to EventLbl_Click method - event page
            eventForm = existingEventForm;
            eventsLbl.Click += EventLbl_Click;
        }

        private void EventLbl_Click(object? sender, EventArgs e)
        {
            try
            {
                //If EventForm is not visible - that is, if Form1 is open - and we push the button "Events", EventForm is shown
                if (eventForm != null && !eventForm.Visible)
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

        private void NorlysButton_Click(object? sender, EventArgs e)
        {
            {
                try
                {
                    // If Form1 is not visible, show it
                    if (!form1.Visible)
                    {
                        form1.Show();
                    }

                    // Hide MerchForm
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error happened while trying to load Home page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
