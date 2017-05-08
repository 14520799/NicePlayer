using Player.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Player
{
    public partial class Player : Form
    {
        AxWMPLib.AxWindowsMediaPlayer wmp = new AxWMPLib.AxWindowsMediaPlayer();

        Panel pListen = new Panel();
        Panel pPlaylist = new Panel();
        Panel pSearch = new Panel();
        Panel pPower = new Panel();
        
        Media obj = new Media();

        //bool shuffle = false;
        //bool repeat = false;

        
        public Player()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            obj.wmp = wmp;

            this.Controls.Add(wmp);
            wmp.Dock = DockStyle.Fill;

            this.Controls.Add(pListen);
            pListen.Dock = DockStyle.Fill;

            this.Controls.Add(pPlaylist);
            pPlaylist.Dock = DockStyle.Fill;

            this.Controls.Add(pSearch);
            pSearch.Dock = DockStyle.Fill;

            this.Controls.Add(pPower);
            pPower.Dock = DockStyle.Fill;


            /*// Nút Shuffle
            PictureBox pbShuffle = new PictureBox();
            wmp.Controls.Add(pbShuffle);
            pbShuffle.Location = new Point(479, 379);
            pbShuffle.Size = new Size(30, 30);
            pbShuffle.SizeMode = PictureBoxSizeMode.CenterImage;
            pbShuffle.BackColor = Color.Transparent;
            pbShuffle.Image = Resources.Shuffle;

            // Zoom-in
            pbShuffle.MouseHover += (sender, args) =>
            {
                obj.mouseHover(Resources.Shuffle, pbShuffle);
            };

            // Zoom-out
            pbShuffle.MouseLeave += (sender, args) =>
            {
                if(!shuffle)
                    obj.mouseLeave(Resources.Shuffle, pbShuffle);
            };

            // Click nút Shuttle
            pbShuffle.Click += (sender, args) =>
            {
                if(!shuffle)
                {
                    obj.mouseHover(Resources.Shuffle, pbShuffle);
                    wmp.settings.setMode("shuffle", true);
                    shuffle = true;
                }
                else
                {
                    obj.mouseLeave(Resources.Shuffle, pbShuffle);
                    wmp.settings.setMode("shuffle", false);
                    shuffle = false;
                }
            };


            // Nút Repeat
            PictureBox pbRepeat = new PictureBox();
            wmp.Controls.Add(pbRepeat);
            pbRepeat.Location = new Point(505, 379);
            pbRepeat.Size = new Size(30, 30);
            pbRepeat.SizeMode = PictureBoxSizeMode.CenterImage;
            pbRepeat.BackColor = Color.Transparent;
            pbRepeat.Image = Resources.Repeat;

            // Zoom-in
            pbRepeat.MouseHover += (sender, args) =>
            {
                obj.mouseHover(Resources.Repeat, pbRepeat);
            };

            // Zoom-out
            pbRepeat.MouseLeave += (sender, args) =>
            {
                if (!repeat)
                    obj.mouseLeave(Resources.Repeat, pbRepeat);
            };

            // Click nút Repeat
            pbRepeat.Click += (sender, args) =>
            {
                if (!repeat)
                {
                    obj.mouseHover(Resources.Repeat, pbRepeat);
                    wmp.settings.setMode("loop", true);
                    repeat = true;
                }
                else
                {
                    obj.mouseLeave(Resources.Repeat, pbRepeat);
                    wmp.settings.setMode("loop", false);
                    repeat = false;
                }
            };*/

            
            // Nút Return
            PictureBox pbReturn = new PictureBox();
            wmp.Controls.Add(pbReturn);
            pbReturn.Location = new Point(537, 379);
            pbReturn.Size = new Size(30, 30);
            pbReturn.SizeMode = PictureBoxSizeMode.CenterImage;
            pbReturn.BackColor = Color.Transparent;
            pbReturn.Image = Resources.Return;

            // Zoom-in
            pbReturn.MouseHover += (sender, args) =>
            {
                obj.mouseHover(Resources.Return, pbReturn);
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


        private void Player_Load(object sender, EventArgs e)
        {
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

            wmp.settings.volume = 100;
        }


        // Zoom-in 4 nút Listen, Playlist, Search, Power
        private void pbListen_MouseHover(object sender, EventArgs e)
        {
            obj.mouseHover(Resources.Listen, pbListen);
        }


        private void pbPlaylist_MouseHover(object sender, EventArgs e)
        {
            obj.mouseHover(Resources.Playlist, pbPlaylist);
        }


        private void pbSearch_MouseHover(object sender, EventArgs e)
        {
            obj.mouseHover(Resources.Search, pbSearch);
        }

        
        private void pbPower_MouseHover(object sender, EventArgs e)
        {
            obj.mouseHover(Resources.Power, pbPower);
        }


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


        private void pbPower_MouseLeave(object sender, EventArgs e)
        {
            obj.mouseLeave(Resources.Power, pbPower);
        }


        // Xử lý click chuột vào 4 nút Listen, Playlist, Search, Power
        private void pbListen_Click(object sender, EventArgs e)
        {
            obj.listen(pListen);
            pListen.BringToFront();
        }


        private void pbPlaylist_Click(object sender, EventArgs e)
        {
            obj.playlist(pPlaylist);
            pPlaylist.BringToFront();
        }


        private void pbSearch_Click(object sender, EventArgs e)
        {
            obj.search(pSearch);
            pSearch.BringToFront();
        }
        

        private void pbPower_Click(object sender, EventArgs e)
        {
            obj.power(this, pPower);
            pPower.BringToFront();
        }
    }
}
