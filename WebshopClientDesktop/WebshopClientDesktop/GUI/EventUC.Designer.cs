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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(548, 22);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Events side";
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
            tbl_EventProd.Size = new Size(1107, 518);
            tbl_EventProd.TabIndex = 1;
            // 
            // EventUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
