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
            navBarHome = new GroupBox();
            groupBox1 = new GroupBox();
            norlysButton = new Button();
            categoryGroupBox = new GroupBox();
            eventsLbl = new Label();
            merchLbl = new Label();
            kategoriLbl = new Label();
            welcomeLbl = new Label();
            sloganLbl = new Label();
            norlysImgLbl = new Label();
            norlysImg = new PictureBox();
            navBarHome.SuspendLayout();
            categoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)norlysImg).BeginInit();
            SuspendLayout();
            // 
            // navBarHome
            // 
            navBarHome.BackColor = SystemColors.Window;
            navBarHome.Controls.Add(groupBox1);
            navBarHome.Controls.Add(norlysButton);
            navBarHome.Location = new Point(0, 3);
            navBarHome.Name = "navBarHome";
            navBarHome.Size = new Size(1161, 86);
            navBarHome.TabIndex = 0;
            navBarHome.TabStop = false;
            navBarHome.Enter += groupBox1_Enter;
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
            // norlysButton
            // 
            norlysButton.Image = Properties.Resources.Norlyslogo;
            norlysButton.Location = new Point(22, 12);
            norlysButton.Name = "norlysButton";
            norlysButton.Size = new Size(161, 68);
            norlysButton.TabIndex = 0;
            norlysButton.UseVisualStyleBackColor = true;
            norlysButton.Click += NorlysHomeBtn_Click;
            // 
            // categoryGroupBox
            // 
            categoryGroupBox.BackColor = SystemColors.Window;
            categoryGroupBox.Controls.Add(eventsLbl);
            categoryGroupBox.Controls.Add(merchLbl);
            categoryGroupBox.Controls.Add(kategoriLbl);
            categoryGroupBox.Location = new Point(0, 86);
            categoryGroupBox.Name = "categoryGroupBox";
            categoryGroupBox.Size = new Size(235, 576);
            categoryGroupBox.TabIndex = 1;
            categoryGroupBox.TabStop = false;
            // 
            // eventsLbl
            // 
            eventsLbl.AutoSize = true;
            eventsLbl.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            eventsLbl.Location = new Point(61, 88);
            eventsLbl.Name = "eventsLbl";
            eventsLbl.Size = new Size(108, 44);
            eventsLbl.TabIndex = 3;
            eventsLbl.Text = "Events";
            eventsLbl.Click += EventLbl_Click;
            // 
            // merchLbl
            // 
            merchLbl.AutoSize = true;
            merchLbl.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            merchLbl.Location = new Point(61, 132);
            merchLbl.Name = "merchLbl";
            merchLbl.Size = new Size(100, 44);
            merchLbl.TabIndex = 2;
            merchLbl.Text = "Merch";
            merchLbl.Click += MerchLbl_Click;
            // 
            // kategoriLbl
            // 
            kategoriLbl.AutoSize = true;
            kategoriLbl.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            kategoriLbl.Location = new Point(22, 23);
            kategoriLbl.Name = "kategoriLbl";
            kategoriLbl.Size = new Size(179, 49);
            kategoriLbl.TabIndex = 0;
            kategoriLbl.Text = "Kategorier";
            kategoriLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Sans Serif Collection", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLbl.Location = new Point(302, 109);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(736, 56);
            welcomeLbl.TabIndex = 2;
            welcomeLbl.Text = "Velkommen til Norlys' personale webshop";
            // 
            // sloganLbl
            // 
            sloganLbl.AutoSize = true;
            sloganLbl.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            sloganLbl.Location = new Point(452, 165);
            sloganLbl.Name = "sloganLbl";
            sloganLbl.Size = new Size(395, 44);
            sloganLbl.TabIndex = 3;
            sloganLbl.Text = "Alt det der bringer os sammen";
            // 
            // norlysImgLbl
            // 
            norlysImgLbl.AutoSize = true;
            norlysImgLbl.Image = Properties.Resources.NorlysCom;
            norlysImgLbl.Location = new Point(531, 407);
            norlysImgLbl.Name = "norlysImgLbl";
            norlysImgLbl.Size = new Size(0, 20);
            norlysImgLbl.TabIndex = 4;
            // 
            // norlysImg
            // 
            norlysImg.Image = Properties.Resources.NorlysCom;
            norlysImg.Location = new Point(462, 232);
            norlysImg.Name = "norlysImg";
            norlysImg.Size = new Size(366, 319);
            norlysImg.TabIndex = 5;
            norlysImg.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1161, 662);
            Controls.Add(norlysImg);
            Controls.Add(norlysImgLbl);
            Controls.Add(sloganLbl);
            Controls.Add(welcomeLbl);
            Controls.Add(categoryGroupBox);
            Controls.Add(navBarHome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Norlys' personale webshop";
            Load += Form1_Load;
            navBarHome.ResumeLayout(false);
            categoryGroupBox.ResumeLayout(false);
            categoryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)norlysImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox navBarHome;
        private Button norlysButton;
        private GroupBox groupBox1;
        private GroupBox categoryGroupBox;
        private Label kategoriLbl;
        private Label merchLbl;
        private Label eventsLbl;
        private Label welcomeLbl;
        private Label sloganLbl;
        private Label norlysImgLbl;
        private PictureBox norlysImg;
    }
}