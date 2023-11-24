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
            groupListBox.SuspendLayout();
            groupBoxCreateProduct.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditEventProducts
            // 
            btnEditEventProducts.Location = new Point(412, 42);
            btnEditEventProducts.Name = "btnEditEventProducts";
            btnEditEventProducts.Size = new Size(132, 29);
            btnEditEventProducts.TabIndex = 2;
            btnEditEventProducts.Text = "Rediger produkt";
            btnEditEventProducts.UseVisualStyleBackColor = true;
            btnEditEventProducts.Click += button1_Click;
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
            // merchLbl
            // 
            merchLbl.AutoSize = true;
            merchLbl.Font = new Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            merchLbl.Location = new Point(496, 36);
            merchLbl.Name = "merchLbl";
            merchLbl.Size = new Size(186, 68);
            merchLbl.TabIndex = 4;
            merchLbl.Text = "Events";
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
            // groupListBox
            // 
            groupListBox.Controls.Add(lblProcessText);
            groupListBox.Controls.Add(btnGetEventProducts);
            groupListBox.Controls.Add(listBoxEventProducts);
            groupListBox.Controls.Add(btnEditEventProducts);
            groupListBox.Controls.Add(btnDeleteProduct);
            groupListBox.Location = new Point(36, 107);
            groupListBox.Name = "groupListBox";
            groupListBox.Size = new Size(550, 514);
            groupListBox.TabIndex = 7;
            groupListBox.TabStop = false;
            groupListBox.Text = "Produkter";
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
            btnGetEventProducts.Location = new Point(412, 457);
            btnGetEventProducts.Name = "btnGetEventProducts";
            btnGetEventProducts.Size = new Size(114, 29);
            btnGetEventProducts.TabIndex = 5;
            btnGetEventProducts.Text = "Se produkter";
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
            // 
            // groupBoxCreateProduct
            // 
            groupBoxCreateProduct.Controls.Add(btnCreateProduct);
            groupBoxCreateProduct.Location = new Point(592, 107);
            groupBoxCreateProduct.Name = "groupBoxCreateProduct";
            groupBoxCreateProduct.Size = new Size(534, 514);
            groupBoxCreateProduct.TabIndex = 8;
            groupBoxCreateProduct.TabStop = false;
            groupBoxCreateProduct.Text = "Opret produkt";
            // 
            // EventUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxCreateProduct);
            Controls.Add(groupListBox);
            Controls.Add(merchLbl);
            Name = "EventUC";
            Size = new Size(1178, 650);
            groupListBox.ResumeLayout(false);
            groupListBox.PerformLayout();
            groupBoxCreateProduct.ResumeLayout(false);
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
    }
}
