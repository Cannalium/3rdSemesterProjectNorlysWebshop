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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NavBarHome = new GroupBox();
            groupBox1 = new GroupBox();
            NorlysButton = new Button();
            CategoryGroupBox = new GroupBox();
            EventsLbl = new Label();
            MerchLbl = new Label();
            label1 = new Label();
            WelcomeLbl = new Label();
            SloganLbl = new Label();
            NorlysImgLbl = new Label();
            NorlysImg = new PictureBox();
            NavBarHome.SuspendLayout();
            CategoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NorlysImg).BeginInit();
            SuspendLayout();
            // 
            // NavBarHome
            // 
            NavBarHome.BackColor = SystemColors.Window;
            NavBarHome.Controls.Add(groupBox1);
            NavBarHome.Controls.Add(NorlysButton);
            NavBarHome.Location = new Point(0, 0);
            NavBarHome.Name = "NavBarHome";
            NavBarHome.Size = new Size(1161, 86);
            NavBarHome.TabIndex = 0;
            NavBarHome.TabStop = false;
            NavBarHome.Enter += groupBox1_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 564);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // NorlysButton
            // 
            NorlysButton.Image = Properties.Resources.Norlyslogo;
            NorlysButton.Location = new Point(22, 12);
            NorlysButton.Name = "NorlysButton";
            NorlysButton.Size = new Size(161, 68);
            NorlysButton.TabIndex = 0;
            NorlysButton.UseVisualStyleBackColor = true;
            NorlysButton.Click += NorlysHomeBtn_Click;
            // 
            // CategoryGroupBox
            // 
            CategoryGroupBox.BackColor = SystemColors.Window;
            CategoryGroupBox.Controls.Add(EventsLbl);
            CategoryGroupBox.Controls.Add(MerchLbl);
            CategoryGroupBox.Controls.Add(label1);
            CategoryGroupBox.Location = new Point(0, 86);
            CategoryGroupBox.Name = "CategoryGroupBox";
            CategoryGroupBox.Size = new Size(235, 576);
            CategoryGroupBox.TabIndex = 1;
            CategoryGroupBox.TabStop = false;
            // 
            // EventsLbl
            // 
            EventsLbl.AutoSize = true;
            EventsLbl.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            EventsLbl.Location = new Point(61, 88);
            EventsLbl.Name = "EventsLbl";
            EventsLbl.Size = new Size(108, 44);
            EventsLbl.TabIndex = 3;
            EventsLbl.Text = "Events";
            EventsLbl.Click += EventLbl_Click;
            // 
            // MerchLbl
            // 
            MerchLbl.AutoSize = true;
            MerchLbl.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            MerchLbl.Location = new Point(61, 132);
            MerchLbl.Name = "MerchLbl";
            MerchLbl.Size = new Size(100, 44);
            MerchLbl.TabIndex = 2;
            MerchLbl.Text = "Merch";
            MerchLbl.Click += MerchLbl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(179, 49);
            label1.TabIndex = 0;
            label1.Text = "Kategorier";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WelcomeLbl
            // 
            WelcomeLbl.AutoSize = true;
            WelcomeLbl.Font = new Font("Sans Serif Collection", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeLbl.Location = new Point(302, 109);
            WelcomeLbl.Name = "WelcomeLbl";
            WelcomeLbl.Size = new Size(736, 56);
            WelcomeLbl.TabIndex = 2;
            WelcomeLbl.Text = "Velkommen til Norlys' personale webshop";
            // 
            // SloganLbl
            // 
            SloganLbl.AutoSize = true;
            SloganLbl.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            SloganLbl.Location = new Point(452, 165);
            SloganLbl.Name = "SloganLbl";
            SloganLbl.Size = new Size(395, 44);
            SloganLbl.TabIndex = 3;
            SloganLbl.Text = "Alt det der bringer os sammen";
            // 
            // NorlysImgLbl
            // 
            NorlysImgLbl.AutoSize = true;
            NorlysImgLbl.Image = Properties.Resources.NorlysCom;
            NorlysImgLbl.Location = new Point(531, 407);
            NorlysImgLbl.Name = "NorlysImgLbl";
            NorlysImgLbl.Size = new Size(0, 20);
            NorlysImgLbl.TabIndex = 4;
            // 
            // NorlysImg
            // 
            NorlysImg.Image = Properties.Resources.NorlysCom;
            NorlysImg.Location = new Point(462, 232);
            NorlysImg.Name = "NorlysImg";
            NorlysImg.Size = new Size(366, 319);
            NorlysImg.TabIndex = 5;
            NorlysImg.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1161, 662);
            Controls.Add(NorlysImg);
            Controls.Add(NorlysImgLbl);
            Controls.Add(SloganLbl);
            Controls.Add(WelcomeLbl);
            Controls.Add(CategoryGroupBox);
            Controls.Add(NavBarHome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Norlys' personale webshop";
            Load += Form1_Load;
            NavBarHome.ResumeLayout(false);
            CategoryGroupBox.ResumeLayout(false);
            CategoryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NorlysImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox NavBarHome;
        private Button NorlysButton;
        private GroupBox groupBox1;
        private GroupBox CategoryGroupBox;
        private Label label1;
        private Label MerchLbl;
        private Label EventsLbl;
        private Label WelcomeLbl;
        private Label SloganLbl;
        private Label NorlysImgLbl;
        private PictureBox NorlysImg;
    }
}