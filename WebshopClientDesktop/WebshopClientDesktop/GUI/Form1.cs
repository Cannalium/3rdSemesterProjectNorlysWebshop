using WebshopClientDesktop.BusinessLogicLayer;
using WebshopClientDesktop.Logging;
using WebshopClientDesktop.ModelLayer;

namespace WebshopClientDesktop
{
    public partial class Form1 : Form
    {
        private readonly ProductControl _productControl;
        private string selectedProductType;
        public Form1()
        {
            InitializeComponent();

            _productControl = new ProductControl();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await RefreshListBoxDataSource();
        }

        /* Handles the event when the selected item in the product list changes
         * Retrieves and displays details of the selected product, enabling/disabling UI elements accordingly */
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

        // Updates the selectedProductType based on the checked radio button (Event or Merch)
        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;

            if (selectedRadioButton.Checked)
            {
                selectedProductType = (selectedRadioButton == radioBtnEvent) ? "Event" : "Merch";
            }
        }

        // Handles the Click event for the "Delete Product" button. Initiates the process of deleting the selected product
        private async void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxProducts.SelectedItem == null)
                {
                    // Log and display a message
                    lblProcessText.Text = "Vælg venligst et event for at slette";
                    Logger.LogWarning("Delete operation canceled: No item selected.");
                    return;
                }

                // The user is asked for confirmation
                DialogResult result = MessageBox.Show("Er du sikker på, at du vil slette dette produkt?", "Bekræft sletning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    // Display a message
                    lblProcessText.Text = "Sletning afbrudt.";
                    return;
                }

                // Product deletion process
                Product selectedProduct = (Product)listBoxProducts.SelectedItem;

                // Attempt to delete the product
                bool isDeleted = await _productControl.DeleteProduct(selectedProduct.ProdId);

                // Refresh UI
                await RefreshListBoxDataSource();
                ResetUiTexts();

                // Log and display the result
                lblProcessText.Text = isDeleted ? "Event slettet!" : "Der er sket en uventet fejl.";
            }
            catch (Exception ex)
            {
                // Log and display the error
                Logger.LogError(ex);
                MessageBox.Show("Der opstod en fejl ved sletning af produkt.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles the Click event for the "Create Product" button. Initiates the process of creating a new product
        private async void BtnCreateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Values from textboxes fetched
                string inputProdName = txtBoxProductName.Text;
                string inputProdDescription = txtBoxProductDescription.Text;
                decimal inputProdPrice;
                int inputProdQuantity;

                // Validate and parse input
                if (!InputIsOk(inputProdName, inputProdDescription, txtBoxPrice.Text, txtBoxProductQuantity.Text, out inputProdPrice, out inputProdQuantity))
                {
                    // Log and display a message
                    lblProcessCreate.Text = "Venligst indtast valid information.";
                    Logger.LogWarning("Create operation canceled: Invalid input.");
                    return;
                }

                // Continue with product creation
                int insertedId = await _productControl.CreateProduct(inputProdName, inputProdDescription, inputProdPrice, inputProdQuantity, GetSelectedProductType());

                // Log and display the result
                string messageText = (insertedId > 0) ? $"Event oprettet!" : "Fejl: Der opstod en uventet fejl.";
                lblProcessCreate.Text = messageText;

                // Reset UI and refresh list
                ResetUiTexts();
                await RefreshListBoxDataSource();

                // Display a MessageBox with the created product message
                MessageBox.Show($"Produkt oprettet!", "Produkt oprettet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Log and display the error
                Logger.LogError(ex);
                MessageBox.Show("Der opstod en fejl ved oprettelse af produkt.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles the Click event for the "Edit Product" button. Initiates the process of updating a selected product
        private async void BtnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxProducts.SelectedItem is not null)
                {
                    // Get updated values from your textboxes or other input controls
                    string updatedProdName = txtBoxProductName.Text;
                    string updatedProdDescription = txtBoxProductDescription.Text;
                    decimal updatedProdPrice;
                    int updatedProdQuantity;

                    // Validate and parse input
                    if (!InputIsOk(updatedProdName, updatedProdDescription, txtBoxPrice.Text, txtBoxProductQuantity.Text, out updatedProdPrice, out updatedProdQuantity))
                    {
                        // Log and display a message
                        lblProcessCreate.Text = "Venligst indtast valid information.";
                        Logger.LogWarning("Edit operation canceled: Invalid input.");
                        return;
                    }

                    // Continue with product update
                    Product selectedProduct = (Product)listBoxProducts.SelectedItem;
                    selectedProduct.ProdName = updatedProdName;
                    selectedProduct.ProdDescription = updatedProdDescription;
                    selectedProduct.ProdPrice = updatedProdPrice;
                    selectedProduct.ProdQuantity = updatedProdQuantity;

                    // Call the update method from the service
                    bool isUpdated = await _productControl.UpdateProduct(selectedProduct);

                    ResetUiTexts();
                    await RefreshListBoxDataSource();

                    // Display the result
                    lblProcessCreate.Text = isUpdated ? $"Produkt opdateret!" : "Fejl: Der er sket en uventet fejl i opdateringen.";

                    // Display a MessageBox with the created product message
                    MessageBox.Show($"Produkt opdateret!", "Produkt opdateret!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Log and display a message
                    lblProcessCreate.Text = "Vælg venligst et event at opdatere.";
                    Logger.LogWarning("Edit operation canceled: No item selected.");
                }
            }
            catch (Exception ex)
            {
                // Log and display the error
                Logger.LogError(ex);
                MessageBox.Show("Der opstod en fejl ved opdatering af produkt.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles the Click event for the "Clear Details" button
        private void BtnClearDetails_Click(object sender, EventArgs e)
        {
            ResetUiTexts();
            btnCreateProduct.Enabled = true;

            //Clear the selected radio button
            radioBtnEvent.Checked = false;
            radioBtnMerch.Checked = false;

            //Clear combobox
            comboBoxProducts.SelectedIndex = -1;
        }

        // Resets various UI elements, including labels, text fields, and colors
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

        // Refreshes the data source of a ListBox with all products, clears selection, and unchecks a radio button
        public async Task RefreshListBoxDataSource()
        {
            List<Product> allProducts = await _productControl.GetAllProducts();
            listBoxProducts.DataSource = allProducts;
            radioBtnEvent.Checked = false;
            listBoxProducts.ClearSelected();
        }

        // Validates input for creating or editing a product, ensuring non-empty and valid values
        private bool InputIsOk(string prodName, string prodDescription, string prodPriceText, string prodQuantityText, out decimal prodPrice, out int prodQuantity)
        {
            prodPrice = 0;
            prodQuantity = 0;

            if (string.IsNullOrWhiteSpace(prodName) || string.IsNullOrWhiteSpace(prodDescription))
            {
                return false;
            }

            if (!decimal.TryParse(prodPriceText, out prodPrice) || !int.TryParse(prodQuantityText, out prodQuantity))
            {
                return false;
            }

            if (prodName.Length <= 1 || prodDescription.Length <= 1 || prodQuantity <= 0 || prodPrice <= 0)
            {
                return false;
            }

            return true;
        }

        // Returns the selected product type based on the checked radio button
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

        // Handles the selection change event of the ComboBox, updating the ListBox data source based on the selected option
        private async void ComboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedOption = comboBoxProducts.SelectedItem?.ToString();

            try
            {
                List<Product> productList = new List<Product>();

                if (selectedOption == "Alle produkter")
                {
                    productList = await _productControl.GetAllProducts();
                }
                else if (selectedOption == "Merch")
                {
                    productList = await _productControl.GetAllProductsByMerchType();
                }
                else if (selectedOption == "Events")
                {
                    productList = await _productControl.GetAllProductsByEventType();
                }

                UpdateListBoxDataSource(productList);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Updates the data source of the ListBox with the provided list of products
        private void UpdateListBoxDataSource(List<Product> productList)
        {
            listBoxProducts.DataSource = null; // Clear the current data source
            listBoxProducts.DataSource = productList;
            listBoxProducts.ClearSelected();
        }
    }
}
