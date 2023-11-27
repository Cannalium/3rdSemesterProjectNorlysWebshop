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
            btnEditMerchProducts = new Button();
            listBoxMerchProducts = new ListBox();
            btnGetMerchProducts = new Button();
            lblProcessText = new Label();
            groupListBox = new GroupBox();
            groupBoxCreateProduct = new GroupBox();
            btnCreateProduct = new Button();
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
            btnDeleteProduct.Location = new Point(412, 77);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(101, 29);
            btnDeleteProduct.TabIndex = 3;
            btnDeleteProduct.Text = "Slet produkt";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditMerchProducts
            // 
            btnEditMerchProducts.Location = new Point(412, 42);
            btnEditMerchProducts.Name = "btnEditMerchProducts";
            btnEditMerchProducts.Size = new Size(132, 29);
            btnEditMerchProducts.TabIndex = 2;
            btnEditMerchProducts.Text = "Rediger produkt";
            btnEditMerchProducts.UseVisualStyleBackColor = true;
            // 
            // listBoxMerchProducts
            // 
            listBoxMerchProducts.FormattingEnabled = true;
            listBoxMerchProducts.ItemHeight = 20;
            listBoxMerchProducts.Location = new Point(23, 42);
            listBoxMerchProducts.Name = "listBoxMerchProducts";
            listBoxMerchProducts.Size = new Size(383, 444);
            listBoxMerchProducts.TabIndex = 4;
            // 
            // btnGetMerchProducts
            // 
            btnGetMerchProducts.Location = new Point(412, 457);
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
            groupListBox.Controls.Add(btnEditMerchProducts);
            groupListBox.Controls.Add(btnDeleteProduct);
            groupListBox.Location = new Point(36, 107);
            groupListBox.Name = "groupListBox";
            groupListBox.Size = new Size(550, 514);
            groupListBox.TabIndex = 8;
            groupListBox.TabStop = false;
            groupListBox.Text = "Produkter";
            // 
            // groupBoxCreateProduct
            // 
            groupBoxCreateProduct.Controls.Add(btnCreateProduct);
            groupBoxCreateProduct.Location = new Point(611, 107);
            groupBoxCreateProduct.Name = "groupBoxCreateProduct";
            groupBoxCreateProduct.Size = new Size(534, 514);
            groupBoxCreateProduct.TabIndex = 9;
            groupBoxCreateProduct.TabStop = false;
            groupBoxCreateProduct.Text = "Opret produkt";
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(15, 457);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(118, 29);
            btnCreateProduct.TabIndex = 6;
            btnCreateProduct.Text = "Opret produkt";
            btnCreateProduct.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label merchLbl;
        private Button btnDeleteProduct;
        private Button btnEditMerchProducts;
        private ListBox listBoxMerchProducts;
        private Button btnGetMerchProducts;
        private Label lblProcessText;
        private GroupBox groupListBox;
        private GroupBox groupBoxCreateProduct;
        private Button btnCreateProduct;
    }
}
