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

namespace WebshopClientDesktop.GUI
{
    public partial class MerchUC : UserControl
    {
        readonly ProductControl _productControl;

        public MerchUC()
        {
            InitializeComponent();

            _productControl = new ProductControl();

            txtProductType.Text = "Merch";
        }

        private async void BtnGetMerchProducts_Click(object sender, EventArgs e)
        {
            Logger.LogInfo("Button getMerch clicked");
            string processText = "OK";
            List<Product> fetchedProducts = await _productControl.GetAllProductsByMerchType();

            if (fetchedProducts != null)
            {
                if (fetchedProducts.Count >= 1)
                {
                    processText = "Produkter hentet.";
                }
                else
                {
                    processText = "Ingen merch fundet";
                }
            }
            else
            {
                processText = "Der er sket en fejl.";
            }

            listBoxMerchProducts.DataSource = fetchedProducts;

            ResetUiTexts();

            listBoxMerchProducts.ClearSelected();

            lblProcessText.Text = processText;
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
                messageText = (insertedId > 0) ? $"Event oprettet!" : "Fejl: Der opstod en uventet fejl.";
                ResetUiTexts();
                RefreshListBoxDataSource();
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

        private async void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (listBoxMerchProducts.SelectedItem is not null)
            {
                Product selectedProduct = (Product)listBoxMerchProducts.SelectedItem;

                bool isDeleted = await _productControl.DeleteProduct(selectedProduct.ProdId);

                RefreshListBoxDataSource();
                ResetUiTexts();

                lblProcessText.Text = isDeleted ? "Merch slettet!" : "Der er sket en uventet fejl.";
            }
            else
            {
                lblProcessText.Text = "Vælg venligst et event for at slette";
            }
        }
        private async void BtnEditProduct_Click(object sender, EventArgs e)
        {
            if (listBoxMerchProducts.SelectedItem is not null)
            {
                // Get updated values from your textboxes or other input controls
                string updatedProdName = txtBoxProductName.Text;
                string updatedProdDescription = txtBocProductDescription.Text;
                decimal updatedProdPrice = decimal.Parse(txtBoxPrice.Text);
                int updatedProdQuantity = int.Parse(txtBocProductQuantity.Text);
                string updatedProdType = txtProductType.Text;

                // Get the selected product from the list
                Product selectedProduct = (Product)listBoxMerchProducts.SelectedItem;

                if (selectedProduct != null)
                {
                    selectedProduct.ProdName = updatedProdName;
                    selectedProduct.ProdDescription = updatedProdDescription;
                    selectedProduct.ProdPrice = updatedProdPrice;
                    selectedProduct.ProdQuantity = updatedProdQuantity;
                    selectedProduct.ProdType = updatedProdType;
                }

                // Call the update method from the service
                bool isUpdated = await _productControl.UpdateProduct(selectedProduct);

                ResetUiTexts();
                RefreshListBoxDataSource();

                lblProcessCreate.Text = isUpdated ? "Event opdateret!" : "Fejl: Der er sket en uventet fejl i opdateringen.";
            }
            else
            {
                lblProcessCreate.Text = "Vælg venligst et event at opdatere.";
            }
        }

        private void btnClearDetails_Click(object sender, EventArgs e)
        {
            ResetUiTexts();
            btnCreateProduct.Enabled = true;
        }

        private void ListBoxMerchProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Store existing messages
            string processText = lblProcessText.Text;
            string createText = lblProcessCreate.Text;

            // Get the selected product from the list
            Product selectedProduct = (Product)listBoxMerchProducts.SelectedItem;

            if (selectedProduct != null)
            {
                // Display details
                txtBoxProductName.Text = selectedProduct.ProdName.ToString();
                txtBocProductDescription.Text = selectedProduct.ProdDescription.ToString();
                txtBoxPrice.Text = selectedProduct.ProdPrice.ToString();
                txtBocProductQuantity.Text = selectedProduct.ProdQuantity.ToString();
                txtProductType.Text = selectedProduct.ProdType.ToString();

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


        public void ResetUiTexts()
        {
            lblProcessText.Text = null;
            lblProcessText.ForeColor = Color.Black;
            lblProcessCreate.Text = null;
            lblProcessCreate.ForeColor = Color.Black;

            // Clear text fields
            txtBoxProductName.Text = "";
            txtBocProductDescription.Text = "";
            txtBoxPrice.Text = "";
            txtBocProductQuantity.Text = "";
        }

        public async void RefreshListBoxDataSource()
        {
            List<Product> allMerchProducts = await _productControl.GetAllProductsByMerchType();
            listBoxMerchProducts.DataSource = allMerchProducts;
            listBoxMerchProducts.ClearSelected();

        }
    }
}
