namespace Player
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.pHome = new System.Windows.Forms.Panel();
            this.pbKaraoke = new System.Windows.Forms.PictureBox();
            this.pbListen = new System.Windows.Forms.PictureBox();
            this.pbPlaylist = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbPower = new System.Windows.Forms.PictureBox();
            this.pHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKaraoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPower)).BeginInit();
            this.SuspendLayout();
            // 
            // pHome
            // 
            this.pHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHome.BackColor = System.Drawing.Color.Transparent;
            this.pHome.BackgroundImage = global::Player.Properties.Resources.HomeWall;
            this.pHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHome.Controls.Add(this.pbKaraoke);
            this.pHome.Controls.Add(this.pbListen);
            this.pHome.Controls.Add(this.pbPlaylist);
            this.pHome.Controls.Add(this.pbSearch);
            this.pHome.Controls.Add(this.pbPower);
            this.pHome.Location = new System.Drawing.Point(0, 0);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(755, 502);
            this.pHome.TabIndex = 0;
            // 
            // pbKaraoke
            // 
            this.pbKaraoke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbKaraoke.BackColor = System.Drawing.Color.Transparent;
            this.pbKaraoke.Image = ((System.Drawing.Image)(resources.GetObject("pbKaraoke.Image")));
            this.pbKaraoke.InitialImage = null;
            this.pbKaraoke.Location = new System.Drawing.Point(162, 316);
            this.pbKaraoke.Name = "pbKaraoke";
            this.pbKaraoke.Size = new System.Drawing.Size(160, 160);
            this.pbKaraoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbKaraoke.TabIndex = 5;
            this.pbKaraoke.TabStop = false;
            this.pbKaraoke.Click += new System.EventHandler(this.pbKaraoke_Click);
            this.pbKaraoke.MouseLeave += new System.EventHandler(this.pbKaraoke_MouseLeave);
            this.pbKaraoke.MouseHover += new System.EventHandler(this.pbKaraoke_MouseHover);
            // 
            // pbListen
            // 
            this.pbListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbListen.BackColor = System.Drawing.Color.Transparent;
            this.pbListen.Image = global::Player.Properties.Resources.Listen;
            this.pbListen.InitialImage = null;
            this.pbListen.Location = new System.Drawing.Point(20, 321);
            this.pbListen.Name = "pbListen";
            this.pbListen.Size = new System.Drawing.Size(135, 135);
            this.pbListen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbListen.TabIndex = 4;
            this.pbListen.TabStop = false;
            this.pbListen.Click += new System.EventHandler(this.pbListen_Click);
            this.pbListen.MouseLeave += new System.EventHandler(this.pbListen_MouseLeave);
            this.pbListen.MouseHover += new System.EventHandler(this.pbListen_MouseHover);
            // 
            // pbPlaylist
            // 
            this.pbPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.pbPlaylist.Image = global::Player.Properties.Resources.Playlist;
            this.pbPlaylist.InitialImage = null;
            this.pbPlaylist.Location = new System.Drawing.Point(354, 326);
            this.pbPlaylist.Name = "pbPlaylist";
            this.pbPlaylist.Size = new System.Drawing.Size(135, 135);
            this.pbPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPlaylist.TabIndex = 3;
            this.pbPlaylist.TabStop = false;
            this.pbPlaylist.Click += new System.EventHandler(this.pbPlaylist_Click);
            this.pbPlaylist.MouseLeave += new System.EventHandler(this.pbPlaylist_MouseLeave);
            this.pbPlaylist.MouseHover += new System.EventHandler(this.pbPlaylist_MouseHover);
            // 
            // pbSearch
            // 
            this.pbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbSearch.Image = global::Player.Properties.Resources.Search;
            this.pbSearch.InitialImage = null;
            this.pbSearch.Location = new System.Drawing.Point(499, 323);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(135, 135);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSearch.TabIndex = 2;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            this.pbSearch.MouseLeave += new System.EventHandler(this.pbSearch_MouseLeave);
            this.pbSearch.MouseHover += new System.EventHandler(this.pbSearch_MouseHover);
            // 
            // pbPower
            // 
            this.pbPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbPower.BackColor = System.Drawing.Color.Transparent;
            this.pbPower.Image = ((System.Drawing.Image)(resources.GetObject("pbPower.Image")));
            this.pbPower.InitialImage = null;
            this.pbPower.Location = new System.Drawing.Point(616, 318);
            this.pbPower.Name = "pbPower";
            this.pbPower.Size = new System.Drawing.Size(135, 135);
            this.pbPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPower.TabIndex = 1;
            this.pbPower.TabStop = false;
            this.pbPower.Click += new System.EventHandler(this.pbPower_Click);
            this.pbPower.MouseLeave += new System.EventHandler(this.pbPower_MouseLeave);
            this.pbPower.MouseHover += new System.EventHandler(this.pbPower_MouseHover);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 502);
            this.Controls.Add(this.pHome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Nice Player";
            this.Load += new System.EventHandler(this.Player_Load);
            this.pHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKaraoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHome;
        private System.Windows.Forms.PictureBox pbPlaylist;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.PictureBox pbPower;
        private System.Windows.Forms.PictureBox pbListen;
        private System.Windows.Forms.PictureBox pbKaraoke;
    }
}