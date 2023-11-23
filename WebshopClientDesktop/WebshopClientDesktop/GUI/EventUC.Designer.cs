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
            label1 = new Label();
            tbl_EventProd = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(496, 22);
            label1.Name = "label1";
            label1.Size = new Size(186, 68);
            label1.TabIndex = 0;
            label1.Text = "Events";
            label1.Click += label1_Click;
            // 
            // tbl_EventProd
            // 
            tbl_EventProd.AutoScroll = true;
            tbl_EventProd.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbl_EventProd.ColumnCount = 2;
            tbl_EventProd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2601624F));
            tbl_EventProd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.73984F));
            tbl_EventProd.Location = new Point(33, 93);
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
            button1.Location = new Point(956, 93);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 2;
            button1.Text = "Rediger produkt";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(956, 128);
            button2.Name = "button2";
            button2.Size = new Size(101, 29);
            button2.TabIndex = 3;
            button2.Text = "Slet produkt";
            button2.UseVisualStyleBackColor = true;
            // 
            // EventUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbl_EventProd);
            Controls.Add(label1);
            Name = "EventUC";
            Size = new Size(1178, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tbl_EventProd;
        private Button button1;
        private Button button2;
    }
}
