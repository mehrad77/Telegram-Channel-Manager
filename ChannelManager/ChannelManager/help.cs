using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChannelManager
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            /**
            string doc = "";
            WebRequest myHttpWebRequest = WebRequest.Create("https://rawgit.com/mehrad77/Telehram-Channel-Manager/master/Toturial.html");
            WebResponse response = myHttpWebRequest.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            doc = reader.ReadToEnd();
            webBrowser1.DocumentText = doc;
             * **/
        }
    }
}
