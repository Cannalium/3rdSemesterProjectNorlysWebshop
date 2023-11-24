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
            btnMerch = new Button();
            btnEvent = new Button();
            panelHeader = new Panel();
            picBoxAdminLogo = new PictureBox();
            picBoxNorlysLogo = new PictureBox();
            panelMain = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbl_Welcome = new Label();
            adminPageuc1 = new GUI.AdminPageUC();
            merchuc1 = new GUI.MerchUC();
            eventuc1 = new GUI.EventUC();
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
            panelLeft.BackColor = Color.White;
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 87);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(170, 650);
            panelLeft.TabIndex = 0;
            // 
            // btnMerch
            // 
            btnMerch.Cursor = Cursors.Hand;
            btnMerch.FlatAppearance.BorderSize = 0;
            btnMerch.FlatStyle = FlatStyle.Flat;
            btnMerch.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMerch.Location = new Point(281, 28);
            btnMerch.Name = "btnMerch";
            btnMerch.Size = new Size(111, 34);
            btnMerch.TabIndex = 1;
            btnMerch.Text = "Merch";
            btnMerch.TextAlign = ContentAlignment.MiddleLeft;
            btnMerch.UseVisualStyleBackColor = true;
            btnMerch.Click += MerchButton_Click;
            // 
            // btnEvent
            // 
            btnEvent.Cursor = Cursors.Hand;
            btnEvent.FlatAppearance.BorderSize = 0;
            btnEvent.FlatStyle = FlatStyle.Flat;
            btnEvent.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEvent.Location = new Point(194, 28);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(93, 34);
            btnEvent.TabIndex = 0;
            btnEvent.Text = "Events";
            btnEvent.TextAlign = ContentAlignment.MiddleLeft;
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += EventButton_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.Window;
            panelHeader.Controls.Add(picBoxAdminLogo);
            panelHeader.Controls.Add(btnMerch);
            panelHeader.Controls.Add(picBoxNorlysLogo);
            panelHeader.Controls.Add(btnEvent);
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
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(lbl_Welcome);
            panelMain.Controls.Add(adminPageuc1);
            panelMain.Controls.Add(merchuc1);
            panelMain.Controls.Add(eventuc1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(170, 87);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1178, 650);
            panelMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NorlysCom;
            pictureBox1.Location = new Point(403, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 337);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(373, 105);
            label1.Name = "label1";
            label1.Size = new Size(432, 49);
            label1.TabIndex = 4;
            label1.Text = "Alt det der bringer os sammen";
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.Font = new Font("Sans Serif Collection", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Welcome.Location = new Point(218, 49);
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
            adminPageuc1.Size = new Size(1178, 650);
            adminPageuc1.TabIndex = 2;
            // 
            // merchuc1
            // 
            merchuc1.Dock = DockStyle.Fill;
            merchuc1.Location = new Point(0, 0);
            merchuc1.Name = "merchuc1";
            merchuc1.Size = new Size(1178, 650);
            merchuc1.TabIndex = 2;
            // 
            // eventuc1
            // 
            eventuc1.Location = new Point(-12, 6);
            eventuc1.Name = "eventuc1";
            eventuc1.Size = new Size(1178, 650);
            eventuc1.TabIndex = 0;
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
        private Panel panelHeader;
        private Panel panelMain;
        private PictureBox picBoxNorlysLogo;
        private PictureBox picBoxAdminLogo;
        private GUI.EventUC eventuc1;
        private GUI.MerchUC merchuc1;
        private GUI.AdminPageUC adminPageuc1;
        private Label lbl_Welcome;
        private Label label1;
        private PictureBox pictureBox1;
    }
}