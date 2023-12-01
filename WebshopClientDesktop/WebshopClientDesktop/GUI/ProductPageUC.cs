using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebshopClientDesktop.BusinessLogicLayer;
using WebshopClientDesktop.Logging;
using WebshopClientDesktop.ModelLayer;
//using Timer = System.Windows.Forms.Timer;

namespace WebshopClientDesktop.GUI
{
    public partial class ProductPageUC : UserControl
    {
        readonly ProductControl _productControl;
        private string selectedProductType;
        //private Timer updateTimer;

        public ProductPageUC()
        {
            InitializeComponent();

            _productControl = new ProductControl();

            ////Initiliazes the Timer
            //updateTimer = new Timer();
            //updateTimer.Interval = 5000; // 5 seconds
            //updateTimer.Tick += UpdateTimer_Tick;
            //updateTimer.Start();

        }

        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;

            if (selectedRadioButton.Checked)
            {
                selectedProductType = (selectedRadioButton == radioBtnEvent) ? "Event" : "Merch";
            }
        }

        private async void BtnGetProducts_Click(object sender, EventArgs e)
        {
            Logger.LogInfo("Button getProducts clicked");
            string processText = "OK";
            List<Product> fetchedProducts = await _productControl.GetAllProducts();

            if (fetchedProducts != null)
            {
                if (fetchedProducts.Count >= 1)
                {
                    processText = "Produkter hentet.";
                }
                else
                {
                    processText = "Ingen events fundet.";
                }
            }
            else
            {
                processText = "Der er sket en fejl.";
            }

            listBoxProducts.DataSource = fetchedProducts;

            ResetUiTexts();

            listBoxProducts.ClearSelected();

            lblProcessText.Text = processText;
        }

        private async void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem is not null)
            {
                Product selectedProduct = (Product)listBoxProducts.SelectedItem;

                bool isDeleted = await _productControl.DeleteProduct(selectedProduct.ProdId);

                await RefreshListBoxDataSource();
                ResetUiTexts();

                lblProcessText.Text = isDeleted ? "Event slettet!" : "Der er sket en uventet fejl.";
            }
            else
            {
                lblProcessText.Text = "Vælg venligst et event for at slette";
            }
        }

        private async void BtnCreateProduct_Click(object sender, EventArgs e)
        {
            int insertedId = -1;
            string messageText;

            //Values from textboxes fetched
            string inputProdName = txtBoxProductName.Text;
            string inputProdDescription = txtBoxProductDescription.Text;
            decimal inputProdPrice = decimal.Parse(txtBoxPrice.Text);
            int inputProdQuantity = int.Parse(txtBoxProductQuantity.Text);
            string selectedProductType = GetSelectedProductType();

            //Check if inputs are ok
            if (InputIsOk(inputProdName, inputProdDescription, inputProdPrice, inputProdQuantity))
            {
                //Controllayer is called to save data
                insertedId = await _productControl.CreateProduct(inputProdName, inputProdDescription, inputProdPrice, inputProdQuantity, selectedProductType);
                messageText = (insertedId > 0) ? $"Event oprettet!" : "Fejl: Der opstod en uventet fejl.";
                ResetUiTexts();
                await RefreshListBoxDataSource();

            }
            else
            {
                messageText = "Venligst indtast valid information.";
            }

            lblProcessCreate.Text = messageText;
        }

        private async void BtnEditProduct_Click(object sender, EventArgs e)
        {

            if (listBoxProducts.SelectedItem is not null)
            {
                // Get updated values from your textboxes or other input controls
                string updatedProdName = txtBoxProductName.Text;
                string updatedProdDescription = txtBoxProductDescription.Text;
                decimal updatedProdPrice = decimal.Parse(txtBoxPrice.Text);
                int updatedProdQuantity = int.Parse(txtBoxProductQuantity.Text);

                // Get the selected product from the list
                Product selectedProduct = (Product)listBoxProducts.SelectedItem;

                if (selectedProduct != null)
                {
                    selectedProduct.ProdName = updatedProdName;
                    selectedProduct.ProdDescription = updatedProdDescription;
                    selectedProduct.ProdPrice = updatedProdPrice;
                    selectedProduct.ProdQuantity = updatedProdQuantity;
                }

                // Call the update method from the service
                bool isUpdated = await _productControl.UpdateProduct(selectedProduct);

                ResetUiTexts();
                await RefreshListBoxDataSource();

                lblProcessCreate.Text = isUpdated ? "Event opdateret!" : "Fejl: Der er sket en uventet fejl i opdateringen.";
            }
            else
            {
                lblProcessCreate.Text = "Vælg venligst et event at opdatere.";
            }
        }

        private void BtnClearDetails_Click(object sender, EventArgs e)
        {
            ResetUiTexts();
            btnCreateProduct.Enabled = true;

            //Clear the selected radio button
            radioBtnEvent.Checked = false;
            radioBtnMerch.Checked = false;
        }

        private bool InputIsOk(string prodName, string prodDescription, decimal prodPrice, int prodQuantity)
        {
            bool isValidInput = false;

            if (!string.IsNullOrWhiteSpace(prodName) && !string.IsNullOrWhiteSpace(prodDescription))
            {
                if (prodName.Length > 1 && prodDescription.Length > 1 && prodQuantity > 0 && prodPrice > 0)
                {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }

        private string GetSelectedProductType()
        {
            if (radioBtnEvent.Checked)
            {
                return "Event";
            }
            else if (radioBtnMerch.Checked)
            {
                return "Merch";
            }

            return "";
        }

        public void ResetUiTexts()
        {
            lblProcessText.Text = null;
            lblProcessText.ForeColor = Color.Black;
            lblProcessCreate.Text = null;
            lblProcessCreate.ForeColor = Color.Black;

            // Clear text fields
            txtBoxProductName.Text = "";
            txtBoxProductDescription.Text = "";
            txtBoxPrice.Text = "";
            txtBoxProductQuantity.Text = "";
        }

        //private async void UpdateTimer_Tick(object sender, EventArgs e)
        //{
        //    //Refresh the product list every 3 seconds
        //    await RefreshListBoxDataSource();
        //}

        //public void StopUpdateTimer()
        //{
        //    updateTimer.Stop();
        //    updateTimer.Dispose();
        //}

        public async Task RefreshListBoxDataSource()
        {
            List<Product> allProducts = await _productControl.GetAllProducts();
            listBoxProducts.DataSource = allProducts;
            listBoxProducts.ClearSelected();
        }

        private void ListBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Store existing messages
            string processText = lblProcessText.Text;
            string createText = lblProcessCreate.Text;

            // Get the selected product from the list
            Product selectedProduct = (Product)listBoxProducts.SelectedItem;

            if (selectedProduct != null)
            {
                // Display details
                txtBoxProductName.Text = selectedProduct.ProdName.ToString();
                txtBoxProductDescription.Text = selectedProduct.ProdDescription.ToString();
                txtBoxPrice.Text = selectedProduct.ProdPrice.ToString();
                txtBoxProductQuantity.Text = selectedProduct.ProdQuantity.ToString();

                // Set the appropriate radio button based on the product type
                if (selectedProduct.ProdType == "Event")
                {
                    radioBtnEvent.Checked = true;
                }
                else if (selectedProduct.ProdType == "Merch")
                {
                    radioBtnMerch.Checked = true;
                }

                btnCreateProduct.Enabled = false; // Disable the create button
            }
            else
            {
                // No item is selected
                btnCreateProduct.Enabled = true; // Enable the create button
                ResetUiTexts(); // Clear fields when no item is selected
            }

            // Restore messages
            lblProcessText.Text = processText;
            lblProcessCreate.Text = createText;
        }

        private async void RadioBtnEventType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnEventType.Checked)
            {
                List<Product> productsByType = await _productControl.GetAllProductsByEventType();
                listBoxProducts.DataSource = productsByType;
                ResetUiTexts();
            }
        }

        private async void RadioBtnMerchType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnMerchType.Checked)
            {
                List<Product> productsByType = await _productControl.GetAllProductsByMerchType();
                listBoxProducts.DataSource = productsByType;
                ResetUiTexts();
            }
        }
    }
}
