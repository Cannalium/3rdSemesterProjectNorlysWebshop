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
            panelLeft = new Panel();
            lblCategory = new Label();
            btnMerch = new Button();
            btnEvent = new Button();
            panelHeader = new Panel();
            panelMain = new Panel();
            picBoxNorlysLogo = new PictureBox();
            panelLeft.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxNorlysLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panelLeft.AccessibleRole = AccessibleRole.None;
            panelLeft.BackColor = Color.MistyRose;
            panelLeft.Controls.Add(lblCategory);
            panelLeft.Controls.Add(btnMerch);
            panelLeft.Controls.Add(btnEvent);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 87);
            panelLeft.Name = "panel1";
            panelLeft.Size = new Size(170, 650);
            panelLeft.TabIndex = 0;
            // 
            // lbl_category
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(0, 100);
            lblCategory.Name = "lbl_category";
            lblCategory.Size = new Size(163, 44);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Kategorier";
            // 
            // btn_merch
            // 
            btnMerch.Cursor = Cursors.Hand;
            btnMerch.FlatAppearance.BorderSize = 0;
            btnMerch.FlatStyle = FlatStyle.Flat;
            btnMerch.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            btnMerch.Location = new Point(12, 192);
            btnMerch.Name = "btn_merch";
            btnMerch.Size = new Size(147, 39);
            btnMerch.TabIndex = 1;
            btnMerch.Text = "Merch";
            btnMerch.UseVisualStyleBackColor = true;
            btnMerch.Click += MerchButton_Click;
            // 
            // btn_event
            // 
            btnEvent.Cursor = Cursors.Hand;
            btnEvent.FlatAppearance.BorderSize = 0;
            btnEvent.FlatStyle = FlatStyle.Flat;
            btnEvent.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            btnEvent.Location = new Point(12, 147);
            btnEvent.Name = "btn_event";
            btnEvent.Size = new Size(147, 39);
            btnEvent.TabIndex = 0;
            btnEvent.Text = "Events";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += EventButton_Click;
            // 
            // panel2
            // 
            panelHeader.BackColor = SystemColors.Window;
            panelHeader.Controls.Add(picBoxNorlysLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panel2";
            panelHeader.Size = new Size(1348, 87);
            panelHeader.TabIndex = 1;
            // 
            // panel3
            // 
            panelMain.BackColor = SystemColors.Window;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(170, 87);
            panelMain.Name = "panel3";
            panelMain.Size = new Size(1178, 650);
            panelMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            picBoxNorlysLogo.Image = Properties.Resources.Norlyslogo;
            picBoxNorlysLogo.Location = new Point(21, 24);
            picBoxNorlysLogo.Name = "pictureBox1";
            picBoxNorlysLogo.Size = new Size(125, 38);
            picBoxNorlysLogo.TabIndex = 0;
            picBoxNorlysLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1348, 737);
            Controls.Add(panelMain);
            Controls.Add(panelLeft);
            Controls.Add(panelHeader);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxNorlysLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Button btnEvent;
        private Button btnMerch;
        private Label lblCategory;
        private Panel panelHeader;
        private Panel panelMain;
        private PictureBox picBoxNorlysLogo;
    }
}