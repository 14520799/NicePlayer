using Player.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Player
{
    public partial class Player : Form
    {
        Media obj = new Media();
        AxWMPLib.AxWindowsMediaPlayer wmp = new AxWMPLib.AxWindowsMediaPlayer();

        Panel pListen = new Panel();
        Panel pPlaylist = new Panel();
        Panel pSearch = new Panel();
        Panel pKaraoke = new Panel();
        Panel pPower = new Panel();


/***************************************************************************************/


        public Player()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            obj.wmp = wmp;
            this.Controls.Add(wmp);
            wmp.Dock = DockStyle.Fill;
            
            
            // Nút Return
            PictureBox pbReturn = new PictureBox();
            wmp.Controls.Add(pbReturn);
            pbReturn.Location = new Point(539, 377);
            pbReturn.Size = new Size(26, 30);
            pbReturn.SizeMode = PictureBoxSizeMode.CenterImage;
            pbReturn.BackColor = Color.Transparent;
            pbReturn.Image = Resources.Return;

            // Zoom-in
            pbReturn.MouseHover += (sender, args) =>
            {
                obj.mouseHover(Resources.Return, pbReturn, "Return");
            };

            // Zoom-out
            pbReturn.MouseLeave += (sender, args) =>
            {
                
                obj.mouseLeave(Resources.Return, pbReturn);
            };

            // Click nút Return
            pbReturn.Click += (sender, args) =>
            {
                wmp.SendToBack();
            };
        }


/***************************************************************************************/


        private void Player_Load(object sender, EventArgs e)
        {
            wmp.settings.volume = 100;
            
            // Kiểm tra và tạo thư mục chứa các file playlist *.txt
            if (!Directory.Exists(@"Playlist"))
            {
                Directory.CreateDirectory(@"Playlist");
            }

            // Kiểm tra và tạo file Location.txt
            if (!File.Exists(@"Location.txt"))
            {
                File.Create(@"Location.txt");
            }

            // Kiểm tra và tạo file Karaoke.txt
            if (!File.Exists(@"Karaoke.txt"))
            {
                File.Create(@"Karaoke.txt");
            }
        }


/***************************************************************************************/


        // Zoom-in 4 nút Listen, Playlist, Search, Power
        private void pbListen_MouseHover(object sender, EventArgs e)
        {
            obj.mouseHover(Resources.Listen, pbListen, "Listen");
        }


        private void pbPlaylist_MouseHover(object sender, EventArgs e)
        {
            obj.mouseHover(Resources.Playlist, pbPlaylist, "Playlist");
        }


        private void pbSearch_MouseHover(object sender, EventArgs e)
        {
            obj.mouseHover(Resources.Search, pbSearch, "Search");
        }


        private void pbKaraoke_MouseHover(object sender, EventArgs e)
        {
            obj.mouseHover(Resources.Karaoke, pbKaraoke, "Karaoke");
        }


        private void pbPower_MouseHover(object sender, EventArgs e)
        {
            obj.mouseHover(Resources.Power, pbPower, "Power");
        }


/***************************************************************************************/


        // Zoom-out 4 nút Listen, Playlist, Search, Power
        private void pbListen_MouseLeave(object sender, EventArgs e)
        {
            obj.mouseLeave(Resources.Listen, pbListen);
        }


        private void pbPlaylist_MouseLeave(object sender, EventArgs e)
        {
            obj.mouseLeave(Resources.Playlist, pbPlaylist);
        }


        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            obj.mouseLeave(Resources.Search, pbSearch);
        }


        private void pbKaraoke_MouseLeave(object sender, EventArgs e)
        {
            obj.mouseLeave(Resources.Karaoke, pbKaraoke);
        }


        private void pbPower_MouseLeave(object sender, EventArgs e)
        {
            obj.mouseLeave(Resources.Power, pbPower);
        }


/***************************************************************************************/


        // Xử lý click chuột vào 5 nút Listen, Playlist, Search, Karaoke, Power
        private void pbListen_Click(object sender, EventArgs e)
        {
            this.Controls.Add(pListen);
            pListen.Dock = DockStyle.Fill;
            obj.listen(pListen);
            pListen.BringToFront();
        }

        
        private void pbPlaylist_Click(object sender, EventArgs e)
        {
            this.Controls.Add(pPlaylist);
            pPlaylist.Dock = DockStyle.Fill;
            obj.playlist(pPlaylist);
            pPlaylist.BringToFront();
        }


        private void pbSearch_Click(object sender, EventArgs e)
        {
            this.Controls.Add(pSearch);
            pSearch.Dock = DockStyle.Fill;
            obj.search(pSearch);
            pSearch.BringToFront();
        }


        private void pbKaraoke_Click(object sender, EventArgs e)
        {
            this.Controls.Add(pKaraoke);
            pKaraoke.Dock = DockStyle.Fill;
            obj.karaoke(pKaraoke);
            pKaraoke.BringToFront();
        }


        private void pbPower_Click(object sender, EventArgs e)
        {
            this.Controls.Add(pPower);
            pPower.Dock = DockStyle.Fill;
            obj.power(this, pPower);
            pPower.BringToFront();
        }
    }
}
