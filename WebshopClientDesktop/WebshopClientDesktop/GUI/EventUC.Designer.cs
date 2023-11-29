namespace WebshopClientDesktop.GUI
{
    partial class EventUC
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
            btnEditEventProducts = new Button();
            btnDeleteProduct = new Button();
            merchLbl = new Label();
            btnCreateProduct = new Button();
            groupListBox = new GroupBox();
            lblProcessText = new Label();
            btnGetEventProducts = new Button();
            listBoxEventProducts = new ListBox();
            groupBoxCreateProduct = new GroupBox();
            btnClearDetails = new Button();
            lblProcessCreate = new Label();
            txtProductType = new TextBox();
            lblProductType = new Label();
            txtBocProductQuantity = new TextBox();
            lblProductQuantity = new Label();
            txtBoxPrice = new TextBox();
            lblPrice = new Label();
            txtBocProductDescription = new TextBox();
            txtBoxProductName = new TextBox();
            lblProductDescription = new Label();
            lblProductName = new Label();
            groupListBox.SuspendLayout();
            groupBoxCreateProduct.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditEventProducts
            // 
            btnEditEventProducts.Location = new Point(143, 457);
            btnEditEventProducts.Name = "btnEditEventProducts";
            btnEditEventProducts.Size = new Size(132, 29);
            btnEditEventProducts.TabIndex = 2;
            btnEditEventProducts.Text = "Opdater";
            btnEditEventProducts.UseVisualStyleBackColor = true;
            btnEditEventProducts.Click += BtnEditProduct_Click;
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
            // merchLbl
            // 
            merchLbl.AutoSize = true;
            merchLbl.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            merchLbl.Location = new Point(496, 0);
            merchLbl.Name = "merchLbl";
            merchLbl.Size = new Size(107, 32);
            merchLbl.TabIndex = 4;
            merchLbl.Text = "Events";
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(19, 457);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(118, 29);
            btnCreateProduct.TabIndex = 6;
            btnCreateProduct.Text = "Opret event";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += BtnCreateProduct_Click;
            // 
            // groupListBox
            // 
            groupListBox.Controls.Add(lblProcessText);
            groupListBox.Controls.Add(btnGetEventProducts);
            groupListBox.Controls.Add(listBoxEventProducts);
            groupListBox.Controls.Add(btnDeleteProduct);
            groupListBox.Location = new Point(44, 71);
            groupListBox.Name = "groupListBox";
            groupListBox.Size = new Size(550, 514);
            groupListBox.TabIndex = 7;
            groupListBox.TabStop = false;
            groupListBox.Text = "Events";
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
            // btnGetEventProducts
            // 
            btnGetEventProducts.Location = new Point(412, 42);
            btnGetEventProducts.Name = "btnGetEventProducts";
            btnGetEventProducts.Size = new Size(114, 29);
            btnGetEventProducts.TabIndex = 5;
            btnGetEventProducts.Text = "Se events";
            btnGetEventProducts.UseVisualStyleBackColor = true;
            btnGetEventProducts.Click += BtnGetEventProducts_Click;
            // 
            // listBoxEventProducts
            // 
            listBoxEventProducts.FormattingEnabled = true;
            listBoxEventProducts.ItemHeight = 20;
            listBoxEventProducts.Location = new Point(23, 42);
            listBoxEventProducts.Name = "listBoxEventProducts";
            listBoxEventProducts.Size = new Size(383, 444);
            listBoxEventProducts.TabIndex = 4;
            listBoxEventProducts.SelectedIndexChanged += ListBoxEventProducts_SelectedIndexChanged;
            // 
            // groupBoxCreateProduct
            // 
            groupBoxCreateProduct.Controls.Add(btnClearDetails);
            groupBoxCreateProduct.Controls.Add(lblProcessCreate);
            groupBoxCreateProduct.Controls.Add(txtProductType);
            groupBoxCreateProduct.Controls.Add(lblProductType);
            groupBoxCreateProduct.Controls.Add(btnEditEventProducts);
            groupBoxCreateProduct.Controls.Add(txtBocProductQuantity);
            groupBoxCreateProduct.Controls.Add(lblProductQuantity);
            groupBoxCreateProduct.Controls.Add(txtBoxPrice);
            groupBoxCreateProduct.Controls.Add(lblPrice);
            groupBoxCreateProduct.Controls.Add(txtBocProductDescription);
            groupBoxCreateProduct.Controls.Add(txtBoxProductName);
            groupBoxCreateProduct.Controls.Add(lblProductDescription);
            groupBoxCreateProduct.Controls.Add(lblProductName);
            groupBoxCreateProduct.Controls.Add(btnCreateProduct);
            groupBoxCreateProduct.Location = new Point(600, 71);
            groupBoxCreateProduct.Name = "groupBoxCreateProduct";
            groupBoxCreateProduct.Size = new Size(534, 514);
            groupBoxCreateProduct.TabIndex = 8;
            groupBoxCreateProduct.TabStop = false;
            groupBoxCreateProduct.Text = "Detaljer";
            // 
            // btnClearDetails
            // 
            btnClearDetails.Location = new Point(437, 457);
            btnClearDetails.Name = "btnClearDetails";
            btnClearDetails.Size = new Size(91, 29);
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
            lblProductType.Location = new Point(19, 363);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(81, 20);
            lblProductType.TabIndex = 17;
            lblProductType.Text = "Event type:";
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
            lblProductDescription.Size = new Size(120, 20);
            lblProductDescription.TabIndex = 10;
            lblProductDescription.Text = "Eventbeskrivelse:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(19, 51);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(79, 20);
            lblProductName.TabIndex = 9;
            lblProductName.Text = "Eventnavn:";
            // 
            // EventUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxCreateProduct);
            Controls.Add(groupListBox);
            Controls.Add(merchLbl);
            Name = "EventUC";
            Size = new Size(1173, 613);
            groupListBox.ResumeLayout(false);
            groupListBox.PerformLayout();
            groupBoxCreateProduct.ResumeLayout(false);
            groupBoxCreateProduct.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditEventProducts;
        private Button btnDeleteProduct;
        private Label merchLbl;
        private Button btnCreateProduct;
        private GroupBox groupListBox;
        private ListBox listBoxEventProducts;
        private GroupBox groupBoxCreateProduct;
        private Button btnGetEventProducts;
        private Label lblProcessText;
        private Label lblProductName;
        private TextBox txtBocProductQuantity;
        private Label lblProductQuantity;
        private TextBox txtBoxPrice;
        private Label lblPrice;
        private TextBox txtBocProductDescription;
        private TextBox txtBoxProductName;
        private Label lblProductDescription;
        private TextBox txtProductType;
        private Label lblProductType;
        private Label lblProcessCreate;
        private Button btnClearDetails;
    }
}
