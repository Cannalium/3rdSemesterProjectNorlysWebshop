namespace WebshopClientDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            btnAdministration = new Button();
            picBoxNorlysLogo = new PictureBox();
            panelMain = new Panel();
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
            groupListBox = new GroupBox();
            comboBoxProducts = new ComboBox();
            lblProcessText = new Label();
            listBoxProducts = new ListBox();
            btnDeleteProduct = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxNorlysLogo).BeginInit();
            panelMain.SuspendLayout();
            groupBoxCreateProduct.SuspendLayout();
            groupListBox.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.Window;
            panelHeader.Controls.Add(btnAdministration);
            panelHeader.Controls.Add(picBoxNorlysLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1184, 87);
            panelHeader.TabIndex = 1;
            // 
            // btnAdministration
            // 
            btnAdministration.FlatAppearance.BorderSize = 0;
            btnAdministration.FlatStyle = FlatStyle.Flat;
            btnAdministration.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministration.Location = new Point(143, 24);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.Size = new Size(243, 38);
            btnAdministration.TabIndex = 23;
            btnAdministration.Text = "Administration";
            btnAdministration.UseVisualStyleBackColor = true;
            // 
            // picBoxNorlysLogo
            // 
            picBoxNorlysLogo.Image = Properties.Resources.Norlyslogo;
            picBoxNorlysLogo.Location = new Point(21, 24);
            picBoxNorlysLogo.Name = "picBoxNorlysLogo";
            picBoxNorlysLogo.Size = new Size(125, 38);
            picBoxNorlysLogo.TabIndex = 0;
            picBoxNorlysLogo.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.Window;
            panelMain.Controls.Add(groupBoxCreateProduct);
            panelMain.Controls.Add(groupListBox);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 87);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1184, 566);
            panelMain.TabIndex = 2;
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
            groupBoxCreateProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxCreateProduct.Location = new Point(658, 27);
            groupBoxCreateProduct.Name = "groupBoxCreateProduct";
            groupBoxCreateProduct.Size = new Size(534, 514);
            groupBoxCreateProduct.TabIndex = 24;
            groupBoxCreateProduct.TabStop = false;
            groupBoxCreateProduct.Text = "Produktdetaljer";
            // 
            // radioBtnMerch
            // 
            radioBtnMerch.AutoSize = true;
            radioBtnMerch.Location = new Point(106, 405);
            radioBtnMerch.Name = "radioBtnMerch";
            radioBtnMerch.Size = new Size(79, 27);
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
            radioBtnEvent.Size = new Size(73, 27);
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
            lblProcessCreate.Size = new Size(18, 23);
            lblProcessCreate.TabIndex = 19;
            lblProcessCreate.Text = "..";
            // 
            // lblProductType
            // 
            lblProductType.AutoSize = true;
            lblProductType.Location = new Point(19, 372);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(112, 23);
            lblProductType.TabIndex = 17;
            lblProductType.Text = "Produkt type:";
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(162, 457);
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
            txtBoxProductQuantity.Size = new Size(94, 30);
            txtBoxProductQuantity.TabIndex = 16;
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(19, 297);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(54, 23);
            lblProductQuantity.TabIndex = 15;
            lblProductQuantity.Text = "Antal:";
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(19, 258);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(94, 30);
            txtBoxPrice.TabIndex = 14;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(19, 235);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 23);
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
            txtBoxProductName.Size = new Size(388, 30);
            txtBoxProductName.TabIndex = 11;
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(19, 113);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(95, 23);
            lblProductDescription.TabIndex = 10;
            lblProductDescription.Text = "Beskrivelse:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(19, 51);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(54, 23);
            lblProductName.TabIndex = 9;
            lblProductName.Text = "Navn:";
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(19, 457);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(137, 29);
            btnCreateProduct.TabIndex = 6;
            btnCreateProduct.Text = "Opret produkt";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += BtnCreateProduct_Click;
            // 
            // groupListBox
            // 
            groupListBox.Controls.Add(comboBoxProducts);
            groupListBox.Controls.Add(lblProcessText);
            groupListBox.Controls.Add(listBoxProducts);
            groupListBox.Controls.Add(btnDeleteProduct);
            groupListBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupListBox.Location = new Point(49, 27);
            groupListBox.Name = "groupListBox";
            groupListBox.Size = new Size(550, 514);
            groupListBox.TabIndex = 13;
            groupListBox.TabStop = false;
            groupListBox.Text = "Produktliste";
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.AccessibleDescription = "Vælg produkt";
            comboBoxProducts.AccessibleName = "Vælg produkt";
            comboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Items.AddRange(new object[] { "Alle produkter", "Events", "Merch" });
            comboBoxProducts.Location = new Point(412, 42);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(132, 31);
            comboBoxProducts.TabIndex = 24;
            comboBoxProducts.Text = "Vælg produkt";
            comboBoxProducts.SelectedIndexChanged += ComboBoxProducts_SelectedIndexChanged;
            // 
            // lblProcessText
            // 
            lblProcessText.AutoSize = true;
            lblProcessText.Location = new Point(23, 489);
            lblProcessText.Name = "lblProcessText";
            lblProcessText.Size = new Size(18, 23);
            lblProcessText.TabIndex = 6;
            lblProcessText.Text = "..";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 23;
            listBoxProducts.Location = new Point(23, 42);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(383, 418);
            listBoxProducts.TabIndex = 4;
            listBoxProducts.SelectedIndexChanged += ListBoxProducts_SelectedIndexChanged;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(412, 454);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(124, 29);
            btnDeleteProduct.TabIndex = 3;
            btnDeleteProduct.Text = "Slet produkt";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1184, 653);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Norlys";
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxNorlysLogo).EndInit();
            panelMain.ResumeLayout(false);
            groupBoxCreateProduct.ResumeLayout(false);
            groupBoxCreateProduct.PerformLayout();
            groupListBox.ResumeLayout(false);
            groupListBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Panel panelMain;
        private PictureBox picBoxNorlysLogo;
        private GroupBox groupListBox;
        private Label lblProcessText;
        private ListBox listBoxProducts;
        private Button btnDeleteProduct;
        private GroupBox groupBoxCreateProduct;
        private RadioButton radioBtnMerch;
        private RadioButton radioBtnEvent;
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
        private Button btnAdministration;
        private ComboBox comboBoxProducts;
    }
}