using System;using System.Collections.Generic;
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
        /// <param name="token11">Your bot Token</param>
        /// <param name="Username">Your channel username</param>
        /// <returns>The Bot Name</returns>
        public static string set(string token11, string Username)
        {
            var doc = "";
            channelUserName = "?chat_id=@" + Username;
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
        /// This methoud will send a Message whith Markdown
        /// </summary>
        /// <param name="message">Text of the message to be sent</param>
        /// <param name="disable_notification">Sends the message silently. iOS users will not receive a notification, Android users will receive a notification with no sound.</param>
        public static void sendMessage(string message, Boolean disable_notification)
        {
            WebRequest req = WebRequest.Create(httpReq + token + "/sendMessage"
                + channelUserName + "&text=" + message + "&parse_mode=HTML" + "&disable_notification=" + disable_notification);
            req.UseDefaultCredentials = true;

            var result = req.GetResponse();
            StreamReader reader = new StreamReader(result.GetResponseStream());
            string ans = reader.ReadToEnd();
            //Console.WriteLine(ans);
            req.Abort();
        }




        /// <summary>
        /// This methoud will send a picture whith caption
        /// </summary>
        /// <param name="photo">This is the photo URL</param>
        /// <param name="message">Photo caption, 0-200 characters</param>
        /// <param name="disable_notification">Sends the message silently. iOS users will not receive a notification, Android users will receive a notification with no sound.</param>
        public static void sendPhoto(string photo, string message, Boolean disable_notification)
        {
            WebRequest req = WebRequest.Create(httpReq + token + "/sendPhoto"
                + channelUserName + "&photo=" + photo + "&caption=" + message + "&disable_notification=" + disable_notification);
            req.UseDefaultCredentials = true;

            var result = req.GetResponse();
            StreamReader reader = new StreamReader(result.GetResponseStream());
            string ans = reader.ReadToEnd();
            //Console.WriteLine(ans);
            req.Abort();
        }




        /// <summary>
        /// This methoud will send a Audio whith caption
        /// </summary>
        /// <param name="audio">This is the photo URL</param>
        /// <param name="message">Audio caption, 0-200 characters</param>
        /// <param name="disable_notification">Sends the message silently. iOS users will not receive a notification, Android users will receive a notification with no sound.</param>
        /// <param name="duration">Duration of the audio in seconds</param>
        /// <param name="performer">The audio performer, Artist</param>
        /// <param name="title">The track name</param>
        public static string sendAudio(string audio, string message, Boolean disable_notification, string performer, string title)
        {
            string doc = "";
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(httpReq + token + "/sendAudio"
                + channelUserName + "&audio=" + audio + "&caption=" + message + "&disable_notification=" + disable_notification + "&performer=" + performer + "&title=" + title);
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    WebResponse response = myHttpWebRequest.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    doc = reader.ReadToEnd();
                    // ذخیره کردن جی‌سون بازگشتی از تلگرام
                }
                myHttpWebResponse.Close();
            }
            catch (WebException e)
            {
                return "ERROR!! " + e.Message; //+ e.Status;
            }


            dynamic ans = JsonConvert.DeserializeObject(doc);
            //string id = ans.id;
            //string first_name = ans.result.first_name;


            return doc;



        }





        /// <summary>
        /// This methoud will send a file whith caption
        /// </summary>
        /// <param name="document">This is the document URL</param>
        /// <param name="message">The caption of the document</param>
        public static void sendDocument(string document, string message)
        {
            WebRequest req = WebRequest.Create(httpReq + token + "/sendDocument"
                + channelUserName + "&document=" + document + "&caption=" + message);
            req.UseDefaultCredentials = true;

            req.Abort();
        }



    }
}
