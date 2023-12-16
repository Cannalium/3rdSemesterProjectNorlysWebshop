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
            panelHeader.Margin = new Padding(5, 5, 5, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2015, 139);
            panelHeader.TabIndex = 1;
            // 
            // btnAdministration
            // 
            btnAdministration.FlatAppearance.BorderSize = 0;
            btnAdministration.FlatStyle = FlatStyle.Flat;
            btnAdministration.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministration.Location = new Point(232, 38);
            btnAdministration.Margin = new Padding(5, 5, 5, 5);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.Size = new Size(395, 61);
            btnAdministration.TabIndex = 23;
            btnAdministration.Text = "Administration";
            btnAdministration.UseVisualStyleBackColor = true;
            // 
            // picBoxNorlysLogo
            // 
            picBoxNorlysLogo.Image = Properties.Resources.Norlyslogo;
            picBoxNorlysLogo.Location = new Point(34, 38);
            picBoxNorlysLogo.Margin = new Padding(5, 5, 5, 5);
            picBoxNorlysLogo.Name = "picBoxNorlysLogo";
            picBoxNorlysLogo.Size = new Size(203, 61);
            picBoxNorlysLogo.TabIndex = 0;
            picBoxNorlysLogo.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.Window;
            panelMain.Controls.Add(groupBoxCreateProduct);
            panelMain.Controls.Add(groupListBox);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 139);
            panelMain.Margin = new Padding(5, 5, 5, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(2015, 906);
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
            groupBoxCreateProduct.Location = new Point(1069, 43);
            groupBoxCreateProduct.Margin = new Padding(5, 5, 5, 5);
            groupBoxCreateProduct.Name = "groupBoxCreateProduct";
            groupBoxCreateProduct.Padding = new Padding(5, 5, 5, 5);
            groupBoxCreateProduct.Size = new Size(868, 822);
            groupBoxCreateProduct.TabIndex = 24;
            groupBoxCreateProduct.TabStop = false;
            groupBoxCreateProduct.Text = "Produktdetaljer";
            // 
            // radioBtnMerch
            // 
            radioBtnMerch.AutoSize = true;
            radioBtnMerch.Location = new Point(172, 648);
            radioBtnMerch.Margin = new Padding(5, 5, 5, 5);
            radioBtnMerch.Name = "radioBtnMerch";
            radioBtnMerch.Size = new Size(127, 42);
            radioBtnMerch.TabIndex = 22;
            radioBtnMerch.TabStop = true;
            radioBtnMerch.Text = "Merch";
            radioBtnMerch.UseVisualStyleBackColor = true;
            radioBtnMerch.CheckedChanged += RadioBtn_CheckedChanged;
            // 
            // radioBtnEvent
            // 
            radioBtnEvent.AutoSize = true;
            radioBtnEvent.Location = new Point(32, 648);
            radioBtnEvent.Margin = new Padding(5, 5, 5, 5);
            radioBtnEvent.Name = "radioBtnEvent";
            radioBtnEvent.Size = new Size(115, 42);
            radioBtnEvent.TabIndex = 21;
            radioBtnEvent.TabStop = true;
            radioBtnEvent.Text = "Event";
            radioBtnEvent.UseVisualStyleBackColor = true;
            radioBtnEvent.CheckedChanged += RadioBtn_CheckedChanged;
            // 
            // btnClearDetails
            // 
            btnClearDetails.Location = new Point(717, 731);
            btnClearDetails.Margin = new Padding(5, 5, 5, 5);
            btnClearDetails.Name = "btnClearDetails";
            btnClearDetails.Size = new Size(141, 46);
            btnClearDetails.TabIndex = 20;
            btnClearDetails.Text = "Ryd";
            btnClearDetails.UseVisualStyleBackColor = true;
            btnClearDetails.Click += BtnClearDetails_Click;
            // 
            // lblProcessCreate
            // 
            lblProcessCreate.AutoSize = true;
            lblProcessCreate.Location = new Point(31, 782);
            lblProcessCreate.Margin = new Padding(5, 0, 5, 0);
            lblProcessCreate.Name = "lblProcessCreate";
            lblProcessCreate.Size = new Size(29, 38);
            lblProcessCreate.TabIndex = 19;
            lblProcessCreate.Text = "..";
            // 
            // lblProductType
            // 
            lblProductType.AutoSize = true;
            lblProductType.Location = new Point(31, 595);
            lblProductType.Margin = new Padding(5, 0, 5, 0);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(182, 38);
            lblProductType.TabIndex = 17;
            lblProductType.Text = "Produkt type:";
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(263, 731);
            btnEditProduct.Margin = new Padding(5, 5, 5, 5);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(214, 46);
            btnEditProduct.TabIndex = 2;
            btnEditProduct.Text = "Opdater";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += BtnEditProduct_Click;
            // 
            // txtBoxProductQuantity
            // 
            txtBoxProductQuantity.Location = new Point(31, 512);
            txtBoxProductQuantity.Margin = new Padding(5, 5, 5, 5);
            txtBoxProductQuantity.Name = "txtBoxProductQuantity";
            txtBoxProductQuantity.Size = new Size(150, 44);
            txtBoxProductQuantity.TabIndex = 16;
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(31, 475);
            lblProductQuantity.Margin = new Padding(5, 0, 5, 0);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(87, 38);
            lblProductQuantity.TabIndex = 15;
            lblProductQuantity.Text = "Antal:";
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(31, 413);
            txtBoxPrice.Margin = new Padding(5, 5, 5, 5);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(150, 44);
            txtBoxPrice.TabIndex = 14;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(31, 376);
            lblPrice.Margin = new Padding(5, 0, 5, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(68, 38);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "Pris:";
            // 
            // txtBoxProductDescription
            // 
            txtBoxProductDescription.Location = new Point(31, 218);
            txtBoxProductDescription.Margin = new Padding(5, 5, 5, 5);
            txtBoxProductDescription.Multiline = true;
            txtBoxProductDescription.Name = "txtBoxProductDescription";
            txtBoxProductDescription.Size = new Size(628, 137);
            txtBoxProductDescription.TabIndex = 12;
            // 
            // txtBoxProductName
            // 
            txtBoxProductName.Location = new Point(31, 123);
            txtBoxProductName.Margin = new Padding(5, 5, 5, 5);
            txtBoxProductName.Name = "txtBoxProductName";
            txtBoxProductName.Size = new Size(628, 44);
            txtBoxProductName.TabIndex = 11;
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(31, 181);
            lblProductDescription.Margin = new Padding(5, 0, 5, 0);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(159, 38);
            lblProductDescription.TabIndex = 10;
            lblProductDescription.Text = "Beskrivelse:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(31, 82);
            lblProductName.Margin = new Padding(5, 0, 5, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(87, 38);
            lblProductName.TabIndex = 9;
            lblProductName.Text = "Navn:";
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(31, 731);
            btnCreateProduct.Margin = new Padding(5, 5, 5, 5);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(223, 46);
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
            groupListBox.Location = new Point(80, 43);
            groupListBox.Margin = new Padding(5, 5, 5, 5);
            groupListBox.Name = "groupListBox";
            groupListBox.Padding = new Padding(5, 5, 5, 5);
            groupListBox.Size = new Size(894, 822);
            groupListBox.TabIndex = 13;
            groupListBox.TabStop = false;
            groupListBox.Text = "Produktliste";
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.AccessibleDescription = "";
            comboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Items.AddRange(new object[] { "Alle produkter", "Events", "Merch" });
            comboBoxProducts.Location = new Point(670, 67);
            comboBoxProducts.Margin = new Padding(5, 5, 5, 5);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(212, 45);
            comboBoxProducts.TabIndex = 24;
            comboBoxProducts.SelectedIndexChanged += ComboBoxProducts_SelectedIndexChanged;
            // 
            // lblProcessText
            // 
            lblProcessText.AutoSize = true;
            lblProcessText.Location = new Point(37, 782);
            lblProcessText.Margin = new Padding(5, 0, 5, 0);
            lblProcessText.Name = "lblProcessText";
            lblProcessText.Size = new Size(29, 38);
            lblProcessText.TabIndex = 6;
            lblProcessText.Text = "..";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 37;
            listBoxProducts.Location = new Point(37, 67);
            listBoxProducts.Margin = new Padding(5, 5, 5, 5);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(620, 670);
            listBoxProducts.TabIndex = 4;
            listBoxProducts.SelectedIndexChanged += ListBoxProducts_SelectedIndexChanged;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(670, 726);
            btnDeleteProduct.Margin = new Padding(5, 5, 5, 5);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(202, 46);
            btnDeleteProduct.TabIndex = 3;
            btnDeleteProduct.Text = "Slet produkt";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2015, 1045);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Margin = new Padding(5, 5, 5, 5);
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