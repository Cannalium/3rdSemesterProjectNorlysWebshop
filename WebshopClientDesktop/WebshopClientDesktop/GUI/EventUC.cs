using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebshopClientDesktop.ControlLayer;
using WebshopClientDesktop.Logging;
using WebshopClientDesktop.ModelLayer;

namespace WebshopClientDesktop.GUI
{
    public partial class EventUC : UserControl
    {
        readonly ProductControl _productControl;
        public EventUC()
        {
            InitializeComponent();

            _productControl = new ProductControl();
        }

        //Slettes
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Slettes
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void BtnGetEventProducts_Click(object sender, EventArgs e)
        {
            Logger.LogInfo("Button getEvents clicked");
            string processText = "OK";
            List<Product> fetchedProducts = await _productControl.GetAllProductsByEventType();

            if (fetchedProducts != null)
            {
                if (fetchedProducts.Count >= 1)
                {
                    processText = "Produkter hentet.";
                }
                else
                {
                    processText = "No event products found.";
                }
            }
            else
            {
                processText = "Failure: An error occurred.";
            }
            lblProcessText.Text = processText;
            listBoxEventProducts.DataSource = fetchedProducts;
        }

        private async void BtnCreateProduct_Click(object sender, EventArgs e)
        {
            int insertedId = -1;
            string messageText;

            //Values from textboxes fetched
            string inputProdName = txtBoxProductName.Text;
            string inputProdDescription = txtBocProductDescription.Text;
            decimal inputProdPrice = decimal.Parse(txtBoxPrice.Text);
            int inputProdQuantity = int.Parse(txtBocProductQuantity.Text);
            string inputProdType = txtProductType.Text;

            //Check if inputs are ok
            if (InputIsOk(inputProdName, inputProdDescription, inputProdPrice, inputProdQuantity, inputProdType))
            {
                //Controllayer is called to save data
                insertedId = await _productControl.CreateProduct(inputProdName, inputProdDescription, inputProdPrice, inputProdQuantity, inputProdType);
                messageText = (insertedId > 0) ? $"Produt oprettet!" : "Fejl: Der opstod en uventet fejl.";
            }
            else
            {
                messageText = "Venligst indtast valid information.";
            }

            lblProcessCreate.Text = messageText;

        }

        private bool InputIsOk(string prodName, string prodDescription, decimal prodPrice, int prodQuantity, string prodType)
        {
            bool isValidInput = false;

            if (!string.IsNullOrWhiteSpace(prodName) && !string.IsNullOrWhiteSpace(prodDescription) && !string.IsNullOrWhiteSpace(prodType))
            {
                if (prodName.Length > 1 && prodDescription.Length > 1 && prodQuantity > 0 && prodPrice > 0)
                {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
