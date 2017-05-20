using System;
using System.Windows.Forms;


namespace Player
{
    public partial class Playlist : Form
    {
        string message = string.Empty;  // Biến lưu trữ tên playlist
        
        public Playlist()
        {
            InitializeComponent();
        }


        // Click OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                message = "Untitled";
            else
                message = txtName.Text;
        }


        // Bấm enter
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                btnOK_Click(sender, e);
            }
        }


        // Lấy tên playlist
        public string getName()
        {
            return message;
        }


        // Click Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
