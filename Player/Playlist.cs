using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Player
{
    public partial class Playlist : Form
    {
        string message = string.Empty;  // Biến truyền tên playlist


        public Playlist()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                message = "Untitled Playlist";
            else
                message = txtName.Text;
        }


        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                btnOK_Click(sender, e);
            }
        }


        public string getName()
        {
            return message;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
