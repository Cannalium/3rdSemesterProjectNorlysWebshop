namespace WebshopClientDesktop.GUI
{
    partial class ProductPageUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productsLbl = new Label();
            groupListBox = new GroupBox();
            radioBtnMerchType = new RadioButton();
            radioBtnEventType = new RadioButton();
            lblProcessText = new Label();
            btnGetProducts = new Button();
            listBoxProducts = new ListBox();
            btnDeleteProduct = new Button();
            groupBoxCreateProduct = new GroupBox();
            radioBtnMerch = new RadioButton();
            radioBtnEvent = new RadioButton();
            btnClearDetails = new Button();
            lblProcessCreate = new Label();
            lblProductType = new Label();
            btnEditProduct = new Button();
            txtBoxProductQuantity = new TextBox();
            lblProductQuantity = new Label();
            txtBoxPrice = new TextBox();
            lblPrice = new Label();
            txtBoxProductDescription = new TextBox();
            txtBoxProductName = new TextBox();
            lblProductDescription = new Label();
            lblProductName = new Label();
            btnCreateProduct = new Button();
            groupListBox.SuspendLayout();
            groupBoxCreateProduct.SuspendLayout();
            SuspendLayout();
            // 
            // productsLbl
            // 
            productsLbl.AutoSize = true;
            productsLbl.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            productsLbl.Location = new Point(538, 11);
            productsLbl.Name = "productsLbl";
            productsLbl.Size = new Size(146, 32);
            productsLbl.TabIndex = 11;
            productsLbl.Text = "Produkter";
            // 
            // groupListBox
            // 
            groupListBox.Controls.Add(radioBtnMerchType);
            groupListBox.Controls.Add(radioBtnEventType);
            groupListBox.Controls.Add(lblProcessText);
            groupListBox.Controls.Add(btnGetProducts);
            groupListBox.Controls.Add(listBoxProducts);
            groupListBox.Controls.Add(btnDeleteProduct);
            groupListBox.Location = new Point(38, 72);
            groupListBox.Name = "groupListBox";
            groupListBox.Size = new Size(550, 514);
            groupListBox.TabIndex = 12;
            groupListBox.TabStop = false;
            groupListBox.Text = "Produkter";
            // 
            // radioBtnMerchType
            // 
            radioBtnMerchType.AutoSize = true;
            radioBtnMerchType.Location = new Point(412, 109);
            radioBtnMerchType.Name = "radioBtnMerchType";
            radioBtnMerchType.Size = new Size(71, 24);
            radioBtnMerchType.TabIndex = 23;
            radioBtnMerchType.TabStop = true;
            radioBtnMerchType.Text = "Merch";
            radioBtnMerchType.UseVisualStyleBackColor = true;
            radioBtnMerchType.CheckedChanged += RadioBtnMerchType_CheckedChanged;
            // 
            // radioBtnEventType
            // 
            radioBtnEventType.AutoSize = true;
            radioBtnEventType.Location = new Point(412, 80);
            radioBtnEventType.Name = "radioBtnEventType";
            radioBtnEventType.Size = new Size(66, 24);
            radioBtnEventType.TabIndex = 23;
            radioBtnEventType.TabStop = true;
            radioBtnEventType.Text = "Event";
            radioBtnEventType.UseVisualStyleBackColor = true;
            radioBtnEventType.CheckedChanged += RadioBtnEventType_CheckedChanged;
            // 
            // lblProcessText
            // 
            lblProcessText.AutoSize = true;
            lblProcessText.Location = new Point(23, 489);
            lblProcessText.Name = "lblProcessText";
            lblProcessText.Size = new Size(15, 20);
            lblProcessText.TabIndex = 6;
            lblProcessText.Text = "..";
            // 
            // btnGetProducts
            // 
            btnGetProducts.Location = new Point(412, 42);
            btnGetProducts.Name = "btnGetProducts";
            btnGetProducts.Size = new Size(114, 29);
            btnGetProducts.TabIndex = 5;
            btnGetProducts.Text = "Se produkter";
            btnGetProducts.UseVisualStyleBackColor = true;
            btnGetProducts.Click += BtnGetProducts_Click;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 20;
            listBoxProducts.Location = new Point(23, 42);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(383, 444);
            listBoxProducts.TabIndex = 4;
            listBoxProducts.SelectedIndexChanged += ListBoxProducts_SelectedIndexChanged;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(412, 457);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(101, 29);
            btnDeleteProduct.TabIndex = 3;
            btnDeleteProduct.Text = "Slet";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // groupBoxCreateProduct
            // 
            groupBoxCreateProduct.Controls.Add(radioBtnMerch);
            groupBoxCreateProduct.Controls.Add(radioBtnEvent);
            groupBoxCreateProduct.Controls.Add(btnClearDetails);
            groupBoxCreateProduct.Controls.Add(lblProcessCreate);
            groupBoxCreateProduct.Controls.Add(lblProductType);
            groupBoxCreateProduct.Controls.Add(btnEditProduct);
            groupBoxCreateProduct.Controls.Add(txtBoxProductQuantity);
            groupBoxCreateProduct.Controls.Add(lblProductQuantity);
            groupBoxCreateProduct.Controls.Add(txtBoxPrice);
            groupBoxCreateProduct.Controls.Add(lblPrice);
            groupBoxCreateProduct.Controls.Add(txtBoxProductDescription);
            groupBoxCreateProduct.Controls.Add(txtBoxProductName);
            groupBoxCreateProduct.Controls.Add(lblProductDescription);
            groupBoxCreateProduct.Controls.Add(lblProductName);
            groupBoxCreateProduct.Controls.Add(btnCreateProduct);
            groupBoxCreateProduct.Location = new Point(594, 72);
            groupBoxCreateProduct.Name = "groupBoxCreateProduct";
            groupBoxCreateProduct.Size = new Size(534, 514);
            groupBoxCreateProduct.TabIndex = 13;
            groupBoxCreateProduct.TabStop = false;
            groupBoxCreateProduct.Text = "Detaljer";
            // 
            // radioBtnMerch
            // 
            radioBtnMerch.AutoSize = true;
            radioBtnMerch.Location = new Point(106, 405);
            radioBtnMerch.Name = "radioBtnMerch";
            radioBtnMerch.Size = new Size(71, 24);
            radioBtnMerch.TabIndex = 22;
            radioBtnMerch.TabStop = true;
            radioBtnMerch.Text = "Merch";
            radioBtnMerch.UseVisualStyleBackColor = true;
            radioBtnMerch.CheckedChanged += RadioBtn_CheckedChanged;
            // 
            // radioBtnEvent
            // 
            radioBtnEvent.AutoSize = true;
            radioBtnEvent.Location = new Point(20, 405);
            radioBtnEvent.Name = "radioBtnEvent";
            radioBtnEvent.Size = new Size(66, 24);
            radioBtnEvent.TabIndex = 21;
            radioBtnEvent.TabStop = true;
            radioBtnEvent.Text = "Event";
            radioBtnEvent.UseVisualStyleBackColor = true;
            radioBtnEvent.CheckedChanged += RadioBtn_CheckedChanged;
            // 
            // btnClearDetails
            // 
            btnClearDetails.Location = new Point(441, 457);
            btnClearDetails.Name = "btnClearDetails";
            btnClearDetails.Size = new Size(87, 29);
            btnClearDetails.TabIndex = 20;
            btnClearDetails.Text = "Ryd";
            btnClearDetails.UseVisualStyleBackColor = true;
            btnClearDetails.Click += BtnClearDetails_Click;
            // 
            // lblProcessCreate
            // 
            lblProcessCreate.AutoSize = true;
            lblProcessCreate.Location = new Point(19, 489);
            lblProcessCreate.Name = "lblProcessCreate";
            lblProcessCreate.Size = new Size(15, 20);
            lblProcessCreate.TabIndex = 19;
            lblProcessCreate.Text = "..";
            // 
            // lblProductType
            // 
            lblProductType.AutoSize = true;
            lblProductType.Location = new Point(19, 372);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(96, 20);
            lblProductType.TabIndex = 17;
            lblProductType.Text = "Produkt type:";
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(143, 457);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(132, 29);
            btnEditProduct.TabIndex = 2;
            btnEditProduct.Text = "Opdater";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += BtnEditProduct_Click;
            // 
            // txtBoxProductQuantity
            // 
            txtBoxProductQuantity.Location = new Point(19, 320);
            txtBoxProductQuantity.Name = "txtBoxProductQuantity";
            txtBoxProductQuantity.Size = new Size(94, 27);
            txtBoxProductQuantity.TabIndex = 16;
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(19, 297);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(47, 20);
            lblProductQuantity.TabIndex = 15;
            lblProductQuantity.Text = "Antal:";
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(19, 258);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(94, 27);
            txtBoxPrice.TabIndex = 14;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(19, 235);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(35, 20);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "Pris:";
            // 
            // txtBoxProductDescription
            // 
            txtBoxProductDescription.Location = new Point(19, 136);
            txtBoxProductDescription.Multiline = true;
            txtBoxProductDescription.Name = "txtBoxProductDescription";
            txtBoxProductDescription.Size = new Size(388, 87);
            txtBoxProductDescription.TabIndex = 12;
            // 
            // txtBoxProductName
            // 
            txtBoxProductName.Location = new Point(19, 77);
            txtBoxProductName.Name = "txtBoxProductName";
            txtBoxProductName.Size = new Size(388, 27);
            txtBoxProductName.TabIndex = 11;
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(19, 113);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(84, 20);
            lblProductDescription.TabIndex = 10;
            lblProductDescription.Text = "Beskrivelse:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(19, 51);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(46, 20);
            lblProductName.TabIndex = 9;
            lblProductName.Text = "Navn:";
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(19, 457);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(118, 29);
            btnCreateProduct.TabIndex = 6;
            btnCreateProduct.Text = "Opret produkt";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += BtnCreateProduct_Click;
            // 
            // ProductPageUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxCreateProduct);
            Controls.Add(groupListBox);
            Controls.Add(productsLbl);
            Name = "ProductPageUC";
            Size = new Size(1173, 626);
            groupListBox.ResumeLayout(false);
            groupListBox.PerformLayout();
            groupBoxCreateProduct.ResumeLayout(false);
            groupBoxCreateProduct.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productsLbl;
        private GroupBox groupListBox;
        private Label lblProcessText;
        private Button btnGetProducts;
        private ListBox listBoxProducts;
        private Button btnDeleteProduct;
        private GroupBox groupBoxCreateProduct;
        private Button btnClearDetails;
        private Label lblProcessCreate;
        private Label lblProductType;
        private Button btnEditProduct;
        private TextBox txtBoxProductQuantity;
        private Label lblProductQuantity;
        private TextBox txtBoxPrice;
        private Label lblPrice;
        private TextBox txtBoxProductDescription;
        private TextBox txtBoxProductName;
        private Label lblProductDescription;
        private Label lblProductName;
        private Button btnCreateProduct;
        private RadioButton radioBtnEvent;
        private RadioButton radioBtnMerch;
        private RadioButton radioBtnMerchType;
        private RadioButton radioBtnEventType;
    }
}
