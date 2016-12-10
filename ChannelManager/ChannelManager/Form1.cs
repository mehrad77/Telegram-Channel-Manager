using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChannelManager;

namespace ChannelManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            txtBotName.Text = botAPI.set(boxToken.Text);
            System.IO.File.WriteAllText("token.txt", boxToken.Text);
            if (txtBotName.Text != "ERROR!! Your Token is invalid!") tabControl1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("token.txt"))
                boxToken.Text = System.IO.File.ReadAllText("token.txt");
            if (System.IO.File.Exists("user.txt"))
                boxUser.Text = System.IO.File.ReadAllText("user.txt");
            //--
            if (boxUser.Text != "" && boxToken.Text != "")
                btnSet.Enabled = true;

        }

        private void boxUser_TextChanged(object sender, EventArgs e)
        {
            if (boxUser.Text != "" && boxToken.Text != "")
                btnSet.Enabled = true;
            else
                btnSet.Enabled = false;
        }

        private void boxToken_TextChanged(object sender, EventArgs e)
        {
            if (boxUser.Text != "" && boxToken.Text != "")
                btnSet.Enabled = true;
            else
                btnSet.Enabled = false;
        }
    }
}
