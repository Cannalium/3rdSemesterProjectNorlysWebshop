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
            tbl_MerchProd = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            createProdBtn = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // merchLbl
            // 
            merchLbl.AutoSize = true;
            merchLbl.Font = new Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            merchLbl.Location = new Point(416, 36);
            merchLbl.Name = "merchLbl";
            merchLbl.Size = new Size(170, 68);
            merchLbl.TabIndex = 0;
            merchLbl.Text = "Merch";
            // 
            // tbl_MerchProd
            // 
            tbl_MerchProd.AutoScroll = true;
            tbl_MerchProd.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbl_MerchProd.ColumnCount = 2;
            tbl_MerchProd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2601624F));
            tbl_MerchProd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.73984F));
            tbl_MerchProd.Location = new Point(34, 129);
            tbl_MerchProd.Name = "tbl_MerchProd";
            tbl_MerchProd.RowCount = 4;
            tbl_MerchProd.RowStyles.Add(new RowStyle(SizeType.Percent, 49.62963F));
            tbl_MerchProd.RowStyles.Add(new RowStyle(SizeType.Percent, 50.37037F));
            tbl_MerchProd.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tbl_MerchProd.RowStyles.Add(new RowStyle(SizeType.Absolute, 113F));
            tbl_MerchProd.Size = new Size(904, 518);
            tbl_MerchProd.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(961, 127);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 3;
            button1.Text = "Rediger produkt";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(961, 162);
            button2.Name = "button2";
            button2.Size = new Size(101, 29);
            button2.TabIndex = 4;
            button2.Text = "Slet produkt";
            button2.UseVisualStyleBackColor = true;
            // 
            // createProdBtn
            // 
            createProdBtn.Location = new Point(961, 60);
            createProdBtn.Name = "createProdBtn";
            createProdBtn.Size = new Size(118, 29);
            createProdBtn.TabIndex = 5;
            createProdBtn.Text = "Opret produkt";
            createProdBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(961, 260);
            button3.Name = "button3";
            button3.Size = new Size(132, 29);
            button3.TabIndex = 6;
            button3.Text = "Rediger produkt";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(961, 295);
            button4.Name = "button4";
            button4.Size = new Size(101, 29);
            button4.TabIndex = 7;
            button4.Text = "Slet produkt";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(961, 399);
            button5.Name = "button5";
            button5.Size = new Size(132, 29);
            button5.TabIndex = 8;
            button5.Text = "Rediger produkt";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(961, 434);
            button6.Name = "button6";
            button6.Size = new Size(101, 29);
            button6.TabIndex = 9;
            button6.Text = "Slet produkt";
            button6.UseVisualStyleBackColor = true;
            // 
            // MerchUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(createProdBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbl_MerchProd);
            Controls.Add(merchLbl);
            Name = "MerchUC";
            Size = new Size(1178, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label merchLbl;
        private TableLayoutPanel tbl_MerchProd;
        private Button button1;
        private Button button2;
        private Button createProdBtn;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
