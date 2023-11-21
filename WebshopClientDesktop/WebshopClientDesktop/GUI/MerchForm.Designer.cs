namespace WebshopClientDesktop.GUI
{
    partial class MerchForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MerchForm));
            categoryGroupBox = new GroupBox();
            eventsLbl = new Label();
            merchLbl = new Label();
            categoryLbl = new Label();
            NavBarHome = new GroupBox();
            groupBox1 = new GroupBox();
            norlysButton = new Button();
            categoryGroupBox.SuspendLayout();
            NavBarHome.SuspendLayout();
            SuspendLayout();
            // 
            // categoryGroupBox
            // 
            categoryGroupBox.BackColor = SystemColors.Window;
            categoryGroupBox.Controls.Add(eventsLbl);
            categoryGroupBox.Controls.Add(merchLbl);
            categoryGroupBox.Controls.Add(categoryLbl);
            categoryGroupBox.Location = new Point(2, 64);
            categoryGroupBox.Name = "categoryGroupBox";
            categoryGroupBox.Size = new Size(235, 554);
            categoryGroupBox.TabIndex = 3;
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
            // 
            // categoryLbl
            // 
            categoryLbl.AutoSize = true;
            categoryLbl.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLbl.Location = new Point(22, 23);
            categoryLbl.Name = "categoryLbl";
            categoryLbl.Size = new Size(179, 49);
            categoryLbl.TabIndex = 0;
            categoryLbl.Text = "Kategorier";
            categoryLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NavBarHome
            // 
            NavBarHome.BackColor = SystemColors.Window;
            NavBarHome.Controls.Add(groupBox1);
            NavBarHome.Controls.Add(norlysButton);
            NavBarHome.Location = new Point(2, -2);
            NavBarHome.Name = "NavBarHome";
            NavBarHome.Size = new Size(1161, 86);
            NavBarHome.TabIndex = 4;
            NavBarHome.TabStop = false;
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
            norlysButton.Click += NorlysButton_Click;
            // 
            // MerchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 615);
            Controls.Add(NavBarHome);
            Controls.Add(categoryGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MerchForm";
            Text = "Norlys Admin Desktop";
            categoryGroupBox.ResumeLayout(false);
            categoryGroupBox.PerformLayout();
            NavBarHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox categoryGroupBox;
        private Label eventsLbl;
        private Label merchLbl;
        private Label categoryLbl;
        private GroupBox NavBarHome;
        private GroupBox groupBox1;
        private Button norlysButton;
    }
}