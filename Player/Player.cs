using Player.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Xml;

namespace Player
{
    public partial class Player : Form
    {
        Media obj = new Media();
        AxWMPLib.AxWindowsMediaPlayer wmp = new AxWMPLib.AxWindowsMediaPlayer();

        // 5 panel Listen, Playlist, Search, Karaoke, Power
        Panel pListen = new Panel();
        Panel pPlaylist = new Panel();
        Panel pSearch = new Panel();
        Panel pKaraoke = new Panel();
        Panel pPower = new Panel();


/***************************************************************************************/

        
        public Player()
        {
            // Giải quyết nháy hình
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            obj.wmp = wmp;
            this.Controls.Add(wmp);
            wmp.Dock = DockStyle.Fill;


            // Nút Shuffle
            PictureBox pbShuffle = new PictureBox();
            wmp.Controls.Add(pbShuffle);
            pbShuffle.Location = new Point(477, 377);
            pbShuffle.Size = new Size(32, 30);
            pbShuffle.BackColor = Color.Transparent;
            pbShuffle.Image = Resources.Shuffle;
            pbShuffle.SizeMode = PictureBoxSizeMode.CenterImage;

            // Zoom-in
            pbShuffle.MouseHover += (sender, args) =>
            {
                Bitmap bmp = new Bitmap(Resources.Shuffle.Width + 1, Resources.Shuffle.Height + 1);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(Resources.Shuffle, new Rectangle(Point.Empty, bmp.Size));
                pbShuffle.Image = bmp;
            };

            // Zoom-out
            pbShuffle.MouseLeave += (sender, args) =>
            {
                if (!obj.shuffle)
                    pbShuffle.Image = Resources.Shuffle;
            };

            // Click nút Shuttle
            pbShuffle.Click += (sender, args) =>
            {
                if (!obj.shuffle)  // Nếu chưa bật shuffle => Zoom-in + Bật shuffle
                {
                    Bitmap bmp = new Bitmap(Resources.Shuffle.Width + 1, Resources.Shuffle.Height + 1);
                    Graphics g = Graphics.FromImage(bmp);
                    g.DrawImage(Resources.Shuffle, new Rectangle(Point.Empty, bmp.Size));
                    pbShuffle.Image = bmp;

                    wmp.settings.setMode("shuffle", true);
                    obj.shuffle = true;
                }
                else  // Nếu đã bật shuffle => Zoom-out + Tắt shuffle
                {
                    pbShuffle.Image = Resources.Shuffle;
                    wmp.settings.setMode("shuffle", false);
                    obj.shuffle = false;
                }
            };


            // Nút Repeat
            PictureBox pbRepeat = new PictureBox();
            wmp.Controls.Add(pbRepeat);
            pbRepeat.Location = new Point(507, 377);
            pbRepeat.Size = new Size(32, 30);
            pbRepeat.BackColor = Color.Transparent;
            pbRepeat.Image = Resources.Repeat;
            pbRepeat.SizeMode = PictureBoxSizeMode.CenterImage;

            // Zoom-in
            pbRepeat.MouseHover += (sender, args) =>
            {
                Bitmap bmp = new Bitmap(Resources.Repeat.Width + 1, Resources.Repeat.Height + 1);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(Resources.Repeat, new Rectangle(Point.Empty, bmp.Size));
                pbRepeat.Image = bmp;
            };

            // Zoom-out
            pbRepeat.MouseLeave += (sender, args) =>
            {
                if (!obj.repeat)
                    pbRepeat.Image = Resources.Repeat;
            };

            // Click nút Repeat
            pbRepeat.Click += (sender, args) =>
            {
                if (!obj.repeat)  // Nếu chưa bật repeat => Zoom-in + Bật repeat
                {
                    Bitmap bmp = new Bitmap(Resources.Repeat.Width + 1, Resources.Repeat.Height + 1);
                    Graphics g = Graphics.FromImage(bmp);
                    g.DrawImage(Resources.Repeat, new Rectangle(Point.Empty, bmp.Size));
                    pbRepeat.Image = bmp;

                    wmp.settings.setMode("loop", true);
                    obj.repeat = true;
                }
                else  // Nếu đã bật repeat => Zoom-out + Tắt repeat
                {
                    pbRepeat.Image = Resources.Repeat;
                    wmp.settings.setMode("loop", false);
                    obj.repeat = false;
                }
            };


            // Nút Return
            PictureBox pbReturn = new PictureBox();
            wmp.Controls.Add(pbReturn);
            pbReturn.Location = new Point(539, 377);
            pbReturn.Size = new Size(26, 30);
            pbReturn.BackColor = Color.Transparent;
            pbReturn.Image = Resources.Return;
            pbReturn.SizeMode = PictureBoxSizeMode.CenterImage;

            // Zoom-in
            pbReturn.MouseHover += (sender, args) =>
            {
                Bitmap bmp = new Bitmap(Resources.Return.Width + 1, Resources.Return.Height + 1);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(Resources.Return, new Rectangle(Point.Empty, bmp.Size));
                pbReturn.Image = bmp;
            };

            // Zoom-out
            pbReturn.MouseLeave += (sender, args) =>
            {
                pbReturn.Image = Resources.Return;
            };

            // Click nút Return
            pbReturn.Click += (sender, args) =>
            {
                wmp.SendToBack();  // Ẩn wmp
            };
        }


        /***************************************************************************************/


        private void Player_Load(object sender, EventArgs e)
        {
            wmp.settings.volume = 100;  // Set âm lượng tối đa

            // Tạo thư mục chứa các file playlist *.txt
            if (!Directory.Exists(@"Playlist"))
                Directory.CreateDirectory(@"Playlist");

            // Tạo file Location.txt
            if (!File.Exists(@"Location.txt"))
                File.Create(@"Location.txt");

            // Tạo file Karaoke.txt
            if (!File.Exists(@"Karaoke.txt"))
                File.Create(@"Karaoke.txt");

            // Tạo file Log.txt => Lưu bài hát được chọn nghe
            if (!File.Exists(@"Log.txt"))
                File.Create(@"Log.txt");
        }


/***************************************************************************************/


        // Zoom-in 5 nút Listen, Playlist, Search, Karaoke, Power
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


        // Zoom-out 5 nút Listen, Playlist, Search, Karaoke, Power
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


        // Gửi nhật ký người dùng định kỳ trước khi đóng ứng dụng
        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            
            if (File.GetCreationTime(@"Log.txt").Month < DateTime.Now.Month || (File.GetCreationTime(@"Log.txt").Month == 12 && DateTime.Now.Month == 1))
            {
                try
                {
                    MailMessage mail = new MailMessage("niceplayer.log@gmail.com", "niceplayer.log@gmail.com");  // Gửi đến niceplayer.log@gmail.com
                    mail.Subject = "Statistical Data";
                    mail.Body = Environment.UserName;  // Tên người dùng
                    mail.Attachments.Add(new Attachment(@"Log.txt"));  // Đính kèm file Log.txt
                    mail.Attachments.Add(new Attachment(@"Karaoke.txt"));  // Đính kèm file Karaoke.txt
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("niceplayer.log@gmail.com", "14520799");  // Username + Password
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    mail.Dispose();
                    
                    File.Delete(@"Log.txt");  // Xóa file Log.txt => Sẽ tạo mới khi mở app lần sau
                }
                catch
                {

                }
            }
        }
    }
}
