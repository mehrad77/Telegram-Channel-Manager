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

        private void button1_Click(object sender, EventArgs e)
        {
            txtBotName.Text = botAPI.set(txtToken.Text);
            System.IO.File.WriteAllText("token.txt", txtToken.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("token.txt"))
                txtToken.Text = System.IO.File.ReadAllText("token.txt");
        }
    }
}
