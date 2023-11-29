namespace WebshopClientDesktop.GUI
{
    partial class MerchUC
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
            merchLbl = new Label();
            btnDeleteProduct = new Button();
            listBoxMerchProducts = new ListBox();
            btnGetMerchProducts = new Button();
            lblProcessText = new Label();
            groupListBox = new GroupBox();
            groupBoxCreateProduct = new GroupBox();
            lblProcessCreate = new Label();
            txtProductType = new TextBox();
            lblProductType = new Label();
            btnEditMerchProducts = new Button();
            txtBocProductQuantity = new TextBox();
            lblProductQuantity = new Label();
            txtBoxPrice = new TextBox();
            lblPrice = new Label();
            txtBocProductDescription = new TextBox();
            txtBoxProductName = new TextBox();
            lblProductDescription = new Label();
            lblProductName = new Label();
            btnCreateProduct = new Button();
            btnClearDetails = new Button();
            groupListBox.SuspendLayout();
            groupBoxCreateProduct.SuspendLayout();
            SuspendLayout();
            // 
            // merchLbl
            // 
            merchLbl.AutoSize = true;
            merchLbl.Font = new Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            merchLbl.Location = new Point(493, 21);
            merchLbl.Name = "merchLbl";
            merchLbl.Size = new Size(170, 68);
            merchLbl.TabIndex = 0;
            merchLbl.Text = "Merch";
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
            // listBoxMerchProducts
            // 
            listBoxMerchProducts.FormattingEnabled = true;
            listBoxMerchProducts.ItemHeight = 20;
            listBoxMerchProducts.Location = new Point(23, 42);
            listBoxMerchProducts.Name = "listBoxMerchProducts";
            listBoxMerchProducts.Size = new Size(383, 444);
            listBoxMerchProducts.TabIndex = 4;
            listBoxMerchProducts.SelectedIndexChanged += ListBoxMerchProducts_SelectedIndexChanged;
            // 
            // btnGetMerchProducts
            // 
            btnGetMerchProducts.Location = new Point(412, 42);
            btnGetMerchProducts.Name = "btnGetMerchProducts";
            btnGetMerchProducts.Size = new Size(114, 29);
            btnGetMerchProducts.TabIndex = 5;
            btnGetMerchProducts.Text = "Se produkter";
            btnGetMerchProducts.UseVisualStyleBackColor = true;
            btnGetMerchProducts.Click += BtnGetMerchProducts_Click;
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
            // groupListBox
            // 
            groupListBox.Controls.Add(lblProcessText);
            groupListBox.Controls.Add(btnGetMerchProducts);
            groupListBox.Controls.Add(listBoxMerchProducts);
            groupListBox.Controls.Add(btnDeleteProduct);
            groupListBox.Location = new Point(36, 107);
            groupListBox.Name = "groupListBox";
            groupListBox.Size = new Size(550, 514);
            groupListBox.TabIndex = 8;
            groupListBox.TabStop = false;
            groupListBox.Text = "Merch";
            // 
            // groupBoxCreateProduct
            // 
            groupBoxCreateProduct.Controls.Add(btnClearDetails);
            groupBoxCreateProduct.Controls.Add(lblProcessCreate);
            groupBoxCreateProduct.Controls.Add(txtProductType);
            groupBoxCreateProduct.Controls.Add(lblProductType);
            groupBoxCreateProduct.Controls.Add(btnEditMerchProducts);
            groupBoxCreateProduct.Controls.Add(txtBocProductQuantity);
            groupBoxCreateProduct.Controls.Add(lblProductQuantity);
            groupBoxCreateProduct.Controls.Add(txtBoxPrice);
            groupBoxCreateProduct.Controls.Add(lblPrice);
            groupBoxCreateProduct.Controls.Add(txtBocProductDescription);
            groupBoxCreateProduct.Controls.Add(txtBoxProductName);
            groupBoxCreateProduct.Controls.Add(lblProductDescription);
            groupBoxCreateProduct.Controls.Add(lblProductName);
            groupBoxCreateProduct.Controls.Add(btnCreateProduct);
            groupBoxCreateProduct.Location = new Point(608, 107);
            groupBoxCreateProduct.Name = "groupBoxCreateProduct";
            groupBoxCreateProduct.Size = new Size(534, 514);
            groupBoxCreateProduct.TabIndex = 9;
            groupBoxCreateProduct.TabStop = false;
            groupBoxCreateProduct.Text = "Detaljer";
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
            // txtProductType
            // 
            txtProductType.Location = new Point(19, 395);
            txtProductType.Name = "txtProductType";
            txtProductType.Size = new Size(94, 27);
            txtProductType.TabIndex = 18;
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
            // btnEditMerchProducts
            // 
            btnEditMerchProducts.Location = new Point(143, 457);
            btnEditMerchProducts.Name = "btnEditMerchProducts";
            btnEditMerchProducts.Size = new Size(132, 29);
            btnEditMerchProducts.TabIndex = 2;
            btnEditMerchProducts.Text = "Opdater";
            btnEditMerchProducts.UseVisualStyleBackColor = true;
            btnEditMerchProducts.Click += BtnEditProduct_Click;
            // 
            // txtBocProductQuantity
            // 
            txtBocProductQuantity.Location = new Point(19, 320);
            txtBocProductQuantity.Name = "txtBocProductQuantity";
            txtBocProductQuantity.Size = new Size(94, 27);
            txtBocProductQuantity.TabIndex = 16;
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
            // txtBocProductDescription
            // 
            txtBocProductDescription.Location = new Point(19, 136);
            txtBocProductDescription.Multiline = true;
            txtBocProductDescription.Name = "txtBocProductDescription";
            txtBocProductDescription.Size = new Size(388, 87);
            txtBocProductDescription.TabIndex = 12;
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
            // btnClearDetails
            // 
            btnClearDetails.Location = new Point(441, 457);
            btnClearDetails.Name = "btnClearDetails";
            btnClearDetails.Size = new Size(87, 29);
            btnClearDetails.TabIndex = 20;
            btnClearDetails.Text = "Ryd";
            btnClearDetails.UseVisualStyleBackColor = true;
            btnClearDetails.Click += btnClearDetails_Click;
            // 
            // MerchUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxCreateProduct);
            Controls.Add(groupListBox);
            Controls.Add(merchLbl);
            Name = "MerchUC";
            Size = new Size(1178, 650);
            groupListBox.ResumeLayout(false);
            groupListBox.PerformLayout();
            groupBoxCreateProduct.ResumeLayout(false);
            groupBoxCreateProduct.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label merchLbl;
        private Button btnDeleteProduct;
        private ListBox listBoxMerchProducts;
        private Button btnGetMerchProducts;
        private Label lblProcessText;
        private GroupBox groupListBox;
        private GroupBox groupBoxCreateProduct;
        private Label lblProcessCreate;
        private TextBox txtProductType;
        private Label lblProductType;
        private Button btnEditMerchProducts;
        private TextBox txtBocProductQuantity;
        private Label lblProductQuantity;
        private TextBox txtBoxPrice;
        private Label lblPrice;
        private TextBox txtBocProductDescription;
        private TextBox txtBoxProductName;
        private Label lblProductDescription;
        private Label lblProductName;
        private Button btnCreateProduct;
        private Button btnClearDetails;
    }
}
