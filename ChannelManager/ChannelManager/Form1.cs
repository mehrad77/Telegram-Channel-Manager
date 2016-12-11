﻿using System;
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
            txtBotName.Text = botAPI.set(boxToken.Text, boxUser.Text);
            System.IO.File.WriteAllText("token.txt", boxToken.Text);
            System.IO.File.WriteAllText("user.txt", boxUser.Text);
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

        //---------------------------------------------------
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show(botAPI.sendMessage(boxMsg.Text,chkSilence.Checked));
        }
        //---------------------------------------------------
        private void btnSendPicture_Click(object sender, EventArgs e)
        {
            MessageBox.Show(botAPI.sendPhoto(boxPictureURL.Text, boxCaption.Text, chkSilence2.Checked));
        }
        //---------------------------------------------------
        private void btnSendAudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show(botAPI.sendAudio(boxAudioURL.Text, boxAudioCaption.Text, chkSilence3.Checked, boxArtist.Text, boxTitle.Text));
        }
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(botAPI.sendDocument(boxFileURL.Text, boxFileURL.Text, chkSilence4.Checked));
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /**MessageBox.Show(
                "Hello World!",
                "About Developer",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
                );**/
            About AboutForm = new About();
            AboutForm.Show();
        }

        private void aboutTelegramCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutThis AboutThisForm = new AboutThis();
            AboutThisForm.Show();
        }
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            help help = new help();
            help.Show();
        }
        //---------------------------------------------------




    }
}
