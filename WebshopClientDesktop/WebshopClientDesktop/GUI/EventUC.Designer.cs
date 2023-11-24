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
            tbl_EventProd = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            merchLbl = new Label();
            createProdBtn = new Button();
            SuspendLayout();
            // 
            // tbl_EventProd
            // 
            tbl_EventProd.AutoScroll = true;
            tbl_EventProd.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbl_EventProd.ColumnCount = 2;
            tbl_EventProd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2601624F));
            tbl_EventProd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.73984F));
            tbl_EventProd.Location = new Point(34, 128);
            tbl_EventProd.Name = "tbl_EventProd";
            tbl_EventProd.RowCount = 4;
            tbl_EventProd.RowStyles.Add(new RowStyle(SizeType.Percent, 49.62963F));
            tbl_EventProd.RowStyles.Add(new RowStyle(SizeType.Percent, 50.37037F));
            tbl_EventProd.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tbl_EventProd.RowStyles.Add(new RowStyle(SizeType.Absolute, 113F));
            tbl_EventProd.Size = new Size(904, 518);
            tbl_EventProd.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(956, 128);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 2;
            button1.Text = "Rediger produkt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(956, 167);
            button2.Name = "button2";
            button2.Size = new Size(101, 29);
            button2.TabIndex = 3;
            button2.Text = "Slet produkt";
            button2.UseVisualStyleBackColor = true;
            // 
            // merchLbl
            // 
            merchLbl.AutoSize = true;
            merchLbl.Font = new Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            merchLbl.Location = new Point(418, 36);
            merchLbl.Name = "merchLbl";
            merchLbl.Size = new Size(186, 68);
            merchLbl.TabIndex = 4;
            merchLbl.Text = "Events";
            // 
            // createProdBtn
            // 
            createProdBtn.Location = new Point(956, 60);
            createProdBtn.Name = "createProdBtn";
            createProdBtn.Size = new Size(118, 29);
            createProdBtn.TabIndex = 6;
            createProdBtn.Text = "Opret produkt";
            createProdBtn.UseVisualStyleBackColor = true;
            // 
            // EventUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(createProdBtn);
            Controls.Add(merchLbl);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbl_EventProd);
            Name = "EventUC";
            Size = new Size(1178, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tbl_EventProd;
        private Button button1;
        private Button button2;
        private Label merchLbl;
        private Button createProdBtn;
    }
}
