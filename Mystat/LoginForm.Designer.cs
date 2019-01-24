namespace Mystat
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Passworld = new wmgCMS.WaterMark();
            this.Login = new wmgCMS.WaterMark();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(214, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phnom Penh";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Passworld
            // 
            this.Passworld.BackColor = System.Drawing.SystemColors.Window;
            this.Passworld.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passworld.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Passworld.Location = new System.Drawing.Point(75, 207);
            this.Passworld.Name = "Passworld";
            this.Passworld.Size = new System.Drawing.Size(488, 38);
            this.Passworld.TabIndex = 4;
            this.Passworld.UseSystemPasswordChar = true;
            this.Passworld.WaterMarkColor = System.Drawing.Color.Gray;
            this.Passworld.WaterMarkText = "Passworld";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.Window;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Login.Location = new System.Drawing.Point(75, 129);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(488, 38);
            this.Login.TabIndex = 3;
            this.Login.WaterMarkColor = System.Drawing.Color.Gray;
            this.Login.WaterMarkText = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passworld);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Mystat";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private wmgCMS.WaterMark Login;
        private wmgCMS.WaterMark Passworld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

