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
            picBoxAdminLogo = new PictureBox();
            picBoxNorlysLogo = new PictureBox();
            panelMain = new Panel();
            lblWelcome = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelLeft.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxAdminLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNorlysLogo).BeginInit();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.AccessibleRole = AccessibleRole.None;
            panelLeft.BackColor = Color.MistyRose;
            panelLeft.Controls.Add(lblCategory);
            panelLeft.Controls.Add(btnMerch);
            panelLeft.Controls.Add(btnEvent);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 87);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(170, 650);
            panelLeft.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(5, 15);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(163, 44);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Kategorier";
            lblCategory.Click += lblCategory_Click;
            // 
            // btnMerch
            // 
            btnMerch.Cursor = Cursors.Hand;
            btnMerch.FlatAppearance.BorderSize = 0;
            btnMerch.FlatStyle = FlatStyle.Flat;
            btnMerch.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            btnMerch.Location = new Point(12, 117);
            btnMerch.Name = "btnMerch";
            btnMerch.Size = new Size(147, 39);
            btnMerch.TabIndex = 1;
            btnMerch.Text = "Merch";
            btnMerch.UseVisualStyleBackColor = true;
            btnMerch.Click += MerchButton_Click;
            // 
            // btnEvent
            // 
            btnEvent.Cursor = Cursors.Hand;
            btnEvent.FlatAppearance.BorderSize = 0;
            btnEvent.FlatStyle = FlatStyle.Flat;
            btnEvent.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            btnEvent.Location = new Point(12, 72);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(147, 39);
            btnEvent.TabIndex = 0;
            btnEvent.Text = "Events";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += EventButton_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.Window;
            panelHeader.Controls.Add(picBoxAdminLogo);
            panelHeader.Controls.Add(picBoxNorlysLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1348, 87);
            panelHeader.TabIndex = 1;
            // 
            // picBoxAdminLogo
            // 
            picBoxAdminLogo.Cursor = Cursors.Hand;
            picBoxAdminLogo.Image = Properties.Resources.userNorlys;
            picBoxAdminLogo.Location = new Point(1268, 24);
            picBoxAdminLogo.Name = "picBoxAdminLogo";
            picBoxAdminLogo.Size = new Size(55, 46);
            picBoxAdminLogo.TabIndex = 1;
            picBoxAdminLogo.TabStop = false;
            picBoxAdminLogo.Click += AdminLogo_Click;
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
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(lblWelcome);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(170, 87);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1178, 650);
            panelMain.TabIndex = 2;
            panelMain.Paint += panelMain_Paint;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Sans Serif Collection", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(212, 72);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(743, 56);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Velkommen til Norlys' personale webshop!";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(378, 128);
            label1.Name = "label1";
            label1.Size = new Size(395, 44);
            label1.TabIndex = 1;
            label1.Text = "Alt det der bringer os sammen";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NorlysCom;
            pictureBox1.Location = new Point(378, 264);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 291);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            ((System.ComponentModel.ISupportInitialize)picBoxAdminLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNorlysLogo).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox picBoxAdminLogo;
        private Label lblWelcome;
        private Label label1;
        private PictureBox pictureBox1;
    }
}