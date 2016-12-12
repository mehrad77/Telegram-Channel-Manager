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
            dynamic ans = botAPI.set(boxToken.Text, boxUser.Text);
            string username = ans.result.username;
            string botID = ans.result.id;
            botAPI.


            txtBotName.Text = username;
            txtChannelName.Text = boxUser.Text;
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
            //--

            //--- GMap
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.SetPositionByKeywords("Tehran, Iran");
            boxLatitude.Text = gmap.Position.Lat.ToString().Replace('/','.');;
            boxLongitude.Text = gmap.Position.Lng.ToString().Replace('/','.');;
            gmap.DragButton = MouseButtons.Left;
            /**
            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(48.8617774, 2.349272),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
             * **/
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
            AboutForm.ShowDialog();
        }

        private void aboutTelegramCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutThis AboutThisForm = new AboutThis();
            AboutThisForm.ShowDialog();
        }
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            help help = new help();
            help.Show();
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
        //---------------------------------------------------
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(botAPI.sendDocument(boxFileURL.Text, boxFileURL.Text, chkSilence4.Checked));
        }
        //---------------------------------------------------
        private void btnSendLocation_Click(object sender, EventArgs e)
        {
             MessageBox.Show(botAPI.sendLocation(boxLatitude.Text,boxLongitude.Text, boxName.Text, boxAddress.Text,chkSilence5.Checked));
        }
        //---------------------------------------------------



        //---------------------------------------------- Gmap Things ----------------------------------------------
        private void btnZoom_Click(object sender, EventArgs e)
        {
            gmap.Zoom += 1;
        }

        private void btnUnZoom_Click(object sender, EventArgs e)
        {
            gmap.Zoom -= 1;
        }

        private void gmap_Click(object sender, EventArgs e)
        {
            boxLatitude.Text = gmap.Position.Lat.ToString().Replace('/','.');
            boxLongitude.Text = gmap.Position.Lng.ToString().Replace('/','.');
        }
        private void GoogleMap_CheckedChanged(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
        }
        private void OpenStreetMap_CheckedChanged(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.OpenCycleMapProvider.Instance;
        }

        private void GoogleSatellite_CheckedChanged(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.BingHybridMapProvider.Instance;
        }
        //---------------------------------------------------




    }
}
