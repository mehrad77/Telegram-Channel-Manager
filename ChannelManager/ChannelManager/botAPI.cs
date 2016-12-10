using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace ChannelManager
{
    public class botAPI
    {


        // Defining Base variables
        public static string token = "";
        //"184349764:AAHiUalPK5DlDj0zA6r236D13QGUtAJAPTs"; // The bot token
        public static string channelUserName = "?chat_id=@MehradTestChannel"; //The channel that bot has been added into it
        public static string httpReq = "https://api.telegram.org/bot";


        
         /// <summary>
        /// This methoud will take token from user
        /// </summary>
        /// <param name="token11">Your bot TOEKEN!</param>
        public static string set(string token11)
        {
            var doc = "";
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(httpReq + token11 + "/getMe");
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK) {
                    WebResponse response = myHttpWebRequest.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    doc = reader.ReadToEnd();
                    token = token11;
                    // ذخیره کردن جی‌سون بازگشتی از تلگرام
                }
                myHttpWebResponse.Close();
            }
            catch (WebException e)
            {
                return "ERROR!! Your Token is invalid!"; //+ e.Status;
            }


            dynamic ans = JsonConvert.DeserializeObject(doc);
            string id = ans.id;
            string first_name = ans.result.first_name;


            return first_name;
        }






        /// <summary>
        /// This methoud will send a picture whith caption
        /// </summary>
        /// <param name="photo">This is the photo URL</param>
        /// <param name="message">The caption of the picture</param>
        public static void sendPhoto(string photo, string message)
        {
            WebRequest req = WebRequest.Create(httpReq + "/sendPhoto"
                + channelUserName + "&photo=" + photo + "&caption=" + message);
            req.UseDefaultCredentials = true;

            var result = req.GetResponse();
            StreamReader reader = new StreamReader(result.GetResponseStream());
            string ans = reader.ReadToEnd();
            //Console.WriteLine(ans);
            req.Abort();
        }







        /// <summary>
        /// This methoud will send a file whith caption
        /// </summary>
        /// <param name="document">This is the document URL</param>
        /// <param name="message">The caption of the document</param>
        public static void sendDocument(string document, string message)
        {
            WebRequest req = WebRequest.Create(httpReq + "/sendDocument"
                + channelUserName + "&document=" + document + "&caption=" + message);
            req.UseDefaultCredentials = true;

            req.Abort();
        }



    }
}
