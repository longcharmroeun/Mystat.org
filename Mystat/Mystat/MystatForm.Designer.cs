namespace Mystat
{
    partial class MystatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MystatForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Badges = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.Coin = new System.Windows.Forms.Label();
            this.Crytal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Point = new System.Windows.Forms.Label();
            this.GroupName = new System.Windows.Forms.Label();
            this.Fullname = new System.Windows.Forms.Label();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leadergrouplistview = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.Badges);
            this.panel1.Controls.Add(this.Coin);
            this.panel1.Controls.Add(this.Crytal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Point);
            this.panel1.Controls.Add(this.GroupName);
            this.panel1.Controls.Add(this.Fullname);
            this.panel1.Controls.Add(this.Profile);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 100);
            this.panel1.TabIndex = 0;
            // 
            // Badges
            // 
            this.Badges.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Badges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Badges.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Badges.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Badges.ImageIndex = 0;
            this.Badges.ImageList = this.imageList;
            this.Badges.Location = new System.Drawing.Point(809, 38);
            this.Badges.Name = "Badges";
            this.Badges.Size = new System.Drawing.Size(46, 25);
            this.Badges.TabIndex = 7;
            this.Badges.Text = "0";
            this.Badges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "badge.png");
            this.imageList.Images.SetKeyName(1, "christal.png");
            this.imageList.Images.SetKeyName(2, "coin.png");
            this.imageList.Images.SetKeyName(3, "star.png");
            // 
            // Coin
            // 
            this.Coin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Coin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Coin.ImageIndex = 2;
            this.Coin.ImageList = this.imageList;
            this.Coin.Location = new System.Drawing.Point(732, 38);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(46, 25);
            this.Coin.TabIndex = 6;
            this.Coin.Text = "0";
            this.Coin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Crytal
            // 
            this.Crytal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Crytal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crytal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Crytal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Crytal.ImageIndex = 1;
            this.Crytal.ImageList = this.imageList;
            this.Crytal.Location = new System.Drawing.Point(650, 38);
            this.Crytal.Name = "Crytal";
            this.Crytal.Size = new System.Drawing.Size(46, 25);
            this.Crytal.TabIndex = 5;
            this.Crytal.Text = "0";
            this.Crytal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(642, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 39);
            this.panel2.TabIndex = 4;
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Point.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Point.ImageIndex = 3;
            this.Point.ImageList = this.imageList;
            this.Point.Location = new System.Drawing.Point(545, 37);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(46, 25);
            this.Point.TabIndex = 3;
            this.Point.Text = "0";
            this.Point.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupName
            // 
            this.GroupName.AutoSize = true;
            this.GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupName.Location = new System.Drawing.Point(332, 36);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(118, 25);
            this.GroupName.TabIndex = 2;
            this.GroupName.Text = "GroupName";
            // 
            // Fullname
            // 
            this.Fullname.AutoSize = true;
            this.Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Fullname.Location = new System.Drawing.Point(126, 36);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(64, 25);
            this.Fullname.TabIndex = 1;
            this.Fullname.Text = "Name";
            // 
            // Profile
            // 
            this.Profile.Image = ((System.Drawing.Image)(resources.GetObject("Profile.Image")));
            this.Profile.Location = new System.Drawing.Point(9, 10);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(111, 77);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 0;
            this.Profile.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1147, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Point";
            this.columnHeader2.Width = 80;
            // 
            // leadergrouplistview
            // 
            this.leadergrouplistview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leadergrouplistview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leadergrouplistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.leadergrouplistview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadergrouplistview.FullRowSelect = true;
            this.leadergrouplistview.Location = new System.Drawing.Point(12, 141);
            this.leadergrouplistview.Name = "leadergrouplistview";
            this.leadergrouplistview.Size = new System.Drawing.Size(337, 559);
            this.leadergrouplistview.TabIndex = 2;
            this.leadergrouplistview.UseCompatibleStateImageBehavior = false;
            this.leadergrouplistview.View = System.Windows.Forms.View.Details;
            // 
            // MystatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1147, 730);
            this.Controls.Add(this.leadergrouplistview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MystatForm";
            this.Text = "MystatForm";
            this.Load += new System.EventHandler(this.MystatForm_LoadAsync);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Fullname;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Label GroupName;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label Point;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Crytal;
        private System.Windows.Forms.Label Badges;
        private System.Windows.Forms.Label Coin;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView leadergrouplistview;
    }
}