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
            btnProducts = new Button();
            picBoxAdminLogo = new PictureBox();
            picBoxNorlysLogo = new PictureBox();
            panelMain = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbl_Welcome = new Label();
            adminPageuc1 = new GUI.AdminPageUC();
            productPageuc1 = new GUI.ProductPageUC();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxAdminLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNorlysLogo).BeginInit();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.Window;
            panelHeader.Controls.Add(btnProducts);
            panelHeader.Controls.Add(picBoxAdminLogo);
            panelHeader.Controls.Add(picBoxNorlysLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1240, 87);
            panelHeader.TabIndex = 1;
            // 
            // btnProducts
            // 
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.Location = new Point(174, 28);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(115, 34);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Produkter";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += BtnProducts_Click;
            // 
            // picBoxAdminLogo
            // 
            picBoxAdminLogo.Cursor = Cursors.Hand;
            picBoxAdminLogo.Image = Properties.Resources.userNorlys;
            picBoxAdminLogo.Location = new Point(1170, 24);
            picBoxAdminLogo.Name = "picBoxAdminLogo";
            picBoxAdminLogo.Size = new Size(55, 46);
            picBoxAdminLogo.TabIndex = 1;
            picBoxAdminLogo.TabStop = false;
            picBoxAdminLogo.Click += AdminLogo_Click;
            // 
            // picBoxNorlysLogo
            // 
            picBoxNorlysLogo.Cursor = Cursors.Hand;
            picBoxNorlysLogo.Image = Properties.Resources.Norlyslogo;
            picBoxNorlysLogo.Location = new Point(21, 24);
            picBoxNorlysLogo.Name = "picBoxNorlysLogo";
            picBoxNorlysLogo.Size = new Size(125, 38);
            picBoxNorlysLogo.TabIndex = 0;
            picBoxNorlysLogo.TabStop = false;
            picBoxNorlysLogo.Click += PicBoxNorlysLogo_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.Window;
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(lbl_Welcome);
            panelMain.Controls.Add(adminPageuc1);
            panelMain.Controls.Add(productPageuc1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 87);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1240, 650);
            panelMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NorlysCom;
            pictureBox1.Location = new Point(434, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 337);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(404, 105);
            label1.Name = "label1";
            label1.Size = new Size(432, 49);
            label1.TabIndex = 4;
            label1.Text = "Alt det der bringer os sammen";
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.Font = new Font("Sans Serif Collection", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Welcome.Location = new Point(249, 49);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(743, 56);
            lbl_Welcome.TabIndex = 3;
            lbl_Welcome.Text = "Velkommen til Norlys' personale webshop!";
            // 
            // adminPageuc1
            // 
            adminPageuc1.Dock = DockStyle.Fill;
            adminPageuc1.Location = new Point(0, 0);
            adminPageuc1.Name = "adminPageuc1";
            adminPageuc1.Size = new Size(1240, 650);
            adminPageuc1.TabIndex = 2;
            // 
            // productPageuc1
            // 
            productPageuc1.Dock = DockStyle.Fill;
            productPageuc1.Location = new Point(0, 0);
            productPageuc1.Name = "productPageuc1";
            productPageuc1.Size = new Size(1240, 650);
            productPageuc1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1240, 737);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxAdminLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNorlysLogo).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Panel panelMain;
        private PictureBox picBoxNorlysLogo;
        private PictureBox picBoxAdminLogo;
        private GUI.AdminPageUC adminPageuc1;
        private GUI.ProductPageUC productPageuc1;
        private Label lbl_Welcome;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnProducts;
    }
}