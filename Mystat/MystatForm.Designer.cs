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
            this.logout = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.LeaderList = new System.Windows.Forms.ListBox();
            this.leaderButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subject_nameLabel = new System.Windows.Forms.Label();
            this.teacher_nameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.start_atLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.finished_atLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lessionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.noclassLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.logout);
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
            this.panel1.Size = new System.Drawing.Size(1256, 100);
            this.panel1.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout.Location = new System.Drawing.Point(1029, 22);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(50, 50);
            this.logout.TabIndex = 8;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
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
            this.menuStrip2.Size = new System.Drawing.Size(1256, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "BOARD OF LEADERS";
            // 
            // LeaderList
            // 
            this.LeaderList.BackColor = System.Drawing.SystemColors.Window;
            this.LeaderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeaderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderList.FormattingEnabled = true;
            this.LeaderList.ItemHeight = 25;
            this.LeaderList.Location = new System.Drawing.Point(15, 172);
            this.LeaderList.Name = "LeaderList";
            this.LeaderList.Size = new System.Drawing.Size(281, 300);
            this.LeaderList.TabIndex = 3;
            // 
            // leaderButton
            // 
            this.leaderButton.Location = new System.Drawing.Point(221, 144);
            this.leaderButton.Name = "leaderButton";
            this.leaderButton.Size = new System.Drawing.Size(75, 23);
            this.leaderButton.TabIndex = 4;
            this.leaderButton.Text = "Group";
            this.leaderButton.UseVisualStyleBackColor = true;
            this.leaderButton.Click += new System.EventHandler(this.leaderButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lessionButton);
            this.panel3.Controls.Add(this.finished_atLabel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.start_atLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.teacher_nameLabel);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.subject_nameLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(357, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 214);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Today";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subject";
            // 
            // subject_nameLabel
            // 
            this.subject_nameLabel.AutoSize = true;
            this.subject_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_nameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.subject_nameLabel.Location = new System.Drawing.Point(87, 10);
            this.subject_nameLabel.Name = "subject_nameLabel";
            this.subject_nameLabel.Size = new System.Drawing.Size(59, 25);
            this.subject_nameLabel.TabIndex = 8;
            this.subject_nameLabel.Text = "None";
            // 
            // teacher_nameLabel
            // 
            this.teacher_nameLabel.AutoSize = true;
            this.teacher_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_nameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teacher_nameLabel.Location = new System.Drawing.Point(87, 49);
            this.teacher_nameLabel.Name = "teacher_nameLabel";
            this.teacher_nameLabel.Size = new System.Drawing.Size(59, 25);
            this.teacher_nameLabel.TabIndex = 10;
            this.teacher_nameLabel.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teacher";
            // 
            // start_atLabel
            // 
            this.start_atLabel.AutoSize = true;
            this.start_atLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_atLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.start_atLabel.Location = new System.Drawing.Point(87, 87);
            this.start_atLabel.Name = "start_atLabel";
            this.start_atLabel.Size = new System.Drawing.Size(59, 25);
            this.start_atLabel.TabIndex = 12;
            this.start_atLabel.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Start";
            // 
            // finished_atLabel
            // 
            this.finished_atLabel.AutoSize = true;
            this.finished_atLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finished_atLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.finished_atLabel.Location = new System.Drawing.Point(87, 129);
            this.finished_atLabel.Name = "finished_atLabel";
            this.finished_atLabel.Size = new System.Drawing.Size(59, 25);
            this.finished_atLabel.TabIndex = 14;
            this.finished_atLabel.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Finished";
            // 
            // lessionButton
            // 
            this.lessionButton.AutoSize = true;
            this.lessionButton.Enabled = false;
            this.lessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessionButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lessionButton.Location = new System.Drawing.Point(95, 162);
            this.lessionButton.Name = "lessionButton";
            this.lessionButton.Size = new System.Drawing.Size(106, 35);
            this.lessionButton.TabIndex = 15;
            this.lessionButton.Text = "Lession 0";
            this.lessionButton.UseVisualStyleBackColor = true;
            this.lessionButton.Click += new System.EventHandler(this.lessionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lession";
            // 
            // noclassLabel
            // 
            this.noclassLabel.AutoSize = true;
            this.noclassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noclassLabel.Location = new System.Drawing.Point(475, 144);
            this.noclassLabel.Name = "noclassLabel";
            this.noclassLabel.Size = new System.Drawing.Size(0, 25);
            this.noclassLabel.TabIndex = 7;
            // 
            // MystatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 730);
            this.Controls.Add(this.noclassLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.leaderButton);
            this.Controls.Add(this.LeaderList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MystatForm";
            this.Text = "Mystat.org";
            this.Load += new System.EventHandler(this.MystatForm_LoadAsync);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LeaderList;
        private System.Windows.Forms.Button leaderButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label subject_nameLabel;
        private System.Windows.Forms.Label teacher_nameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label start_atLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lessionButton;
        private System.Windows.Forms.Label finished_atLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label noclassLabel;
    }
}