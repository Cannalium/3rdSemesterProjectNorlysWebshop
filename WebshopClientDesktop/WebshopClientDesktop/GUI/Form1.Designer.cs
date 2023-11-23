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
            merchuc1 = new GUI.MerchUC();
            eventuc1 = new GUI.EventUC();
            adminPageuc1 = new GUI.AdminPageUC();
            panelLeft.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxAdminLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNorlysLogo).BeginInit();
            panelMain.SuspendLayout();
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
            picBoxNorlysLogo.Cursor = Cursors.Hand;
            picBoxNorlysLogo.Image = Properties.Resources.Norlyslogo;
            picBoxNorlysLogo.Location = new Point(21, 24);
            picBoxNorlysLogo.Name = "picBoxNorlysLogo";
            picBoxNorlysLogo.Size = new Size(125, 38);
            picBoxNorlysLogo.TabIndex = 0;
            picBoxNorlysLogo.TabStop = false;
            picBoxNorlysLogo.Click += picBoxNorlysLogo_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.Window;
            panelMain.Controls.Add(adminPageuc1);
            panelMain.Controls.Add(merchuc1);
            panelMain.Controls.Add(eventuc1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(170, 87);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1178, 650);
            panelMain.TabIndex = 2;
            panelMain.Paint += panelMain_Paint;
            // 
            // merchuc1
            // 
            merchuc1.Dock = DockStyle.Fill;
            merchuc1.Location = new Point(0, 0);
            merchuc1.Name = "merchuc1";
            merchuc1.Size = new Size(1178, 650);
            merchuc1.TabIndex = 2;
            merchuc1.Load += merchuc1_Load;
            // 
            // eventuc1
            // 
            eventuc1.Location = new Point(-12, 6);
            eventuc1.Name = "eventuc1";
            eventuc1.Size = new Size(1178, 650);
            eventuc1.TabIndex = 0;
            // 
            // adminPageuc1
            // 
            adminPageuc1.Dock = DockStyle.Fill;
            adminPageuc1.Location = new Point(0, 0);
            adminPageuc1.Name = "adminPageuc1";
            adminPageuc1.Size = new Size(1178, 650);
            adminPageuc1.TabIndex = 2;
            adminPageuc1.Load += adminPageuc1_Load;
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
            Load += Form1_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxAdminLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNorlysLogo).EndInit();
            panelMain.ResumeLayout(false);
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
        private GUI.EventUC eventuc1;
        private GUI.MerchUC merchuc1;
        private GUI.AdminPageUC adminPageuc1;
    }
}