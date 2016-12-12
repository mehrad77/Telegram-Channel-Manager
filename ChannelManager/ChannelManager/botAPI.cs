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
        public static dynamic set(string token11, string Username)
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
            return ans;
        }


        /// <summary>
        /// This methoud will send get User Profile Photos
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        public static dynamic getUserProfilePhotos(string user_id)
        {
            // It used to be "sendLocation" but now it's "sendVenue"
            string doc = "";
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(httpReq + token + "/getUserProfilePhotos"
                + channelUserName + "&user_id=" + user_id);
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
                return "ERROR!! " + e.Message + "\r\n" + doc; //+ e.Status;
            }


            dynamic ans = JsonConvert.DeserializeObject(doc);
            string first_name = ans.result.photos;
            return first_name
        }





        /// <summary>
        /// This methoud will send a Message whith Markdown
        /// </summary>
        /// <param name="message">Text of the message to be sent</param>
        /// <param name="disable_notification">Sends the message silently. iOS users will not receive a notification, Android users will receive a notification with no sound.</param>
        public static string sendMessage(string message, Boolean disable_notification)
        {
            string doc = "";
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(httpReq + token + "/sendMessage"
                + channelUserName + "&text=" + message + "&parse_mode=HTML" + "&disable_notification=" + disable_notification);
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
                return "ERROR!! " + e.Message + "\r\n" + doc; //+ e.Status;
            }


            dynamic ans = JsonConvert.DeserializeObject(doc);
            //string id = ans.id;
            //string first_name = ans.result.first_name;
            return doc;
        }




        /// <summary>
        /// This methoud will send a picture whith caption
        /// </summary>
        /// <param name="photo">This is the photo URL</param>
        /// <param name="message">Photo caption, 0-200 characters</param>
        /// <param name="disable_notification">Sends the message silently. iOS users will not receive a notification, Android users will receive a notification with no sound.</param>
        public static string sendPhoto(string photo, string message, Boolean disable_notification)
        {
            string doc = "";
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(httpReq + token + "/sendPhoto"
                + channelUserName + "&photo=" + photo + "&caption=" + message + "&disable_notification=" + disable_notification);
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
                return "ERROR!! " + e.Message + "\r\n" + doc; //+ e.Status;
            }


            dynamic ans = JsonConvert.DeserializeObject(doc);
            //string id = ans.id;
            //string first_name = ans.result.first_name;
            return doc;
        }




        /// <summary>
        /// This methoud will send a Audio whith caption
        /// </summary>
        /// <param name="audio">This is the audio URL</param>
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
                return "ERROR!! " + e.Message + "\r\n" + doc; //+ e.Status;
            }


            dynamic ans = JsonConvert.DeserializeObject(doc);
            //string id = ans.id;
            //string first_name = ans.result.first_name;
            return doc;
        }





        /// <summary>
        /// This methoud will send a File (Just .Zip and .PDF in URL mode) whith caption
        /// </summary>
        /// <param name="document">This is the document URL</param>
        /// <param name="message">Document caption, 0-200 characters</param>
        /// <param name="disable_notification">Sends the message silently. iOS users will not receive a notification, Android users will receive a notification with no sound.</param>
        public static string sendDocument(string document, string message, Boolean disable_notification)
        {
            string doc = "";
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(httpReq + token + "/sendDocument"
                + channelUserName + "&document=" + document + "&caption=" + message + "&disable_notification=" + disable_notification);
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
                return "ERROR!! " + e.Message + "\r\n" + doc; //+ e.Status;
            }


            dynamic ans = JsonConvert.DeserializeObject(doc);
            //string id = ans.id;
            //string first_name = ans.result.first_name;
            return doc;
        }



        /// <summary>
        /// This methoud will send Geo Location
        /// </summary>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="disable_notification">Sends the message silently. iOS users will not receive a notification, Android users will receive a notification with no sound.</param>
        public static string sendLocation(string latitude, string longitude, string title, string address, Boolean disable_notification)
        {
            // It used to be "sendLocation" but now it's "sendVenue"
            string doc = "";
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(httpReq + token + "/sendVenue"
                + channelUserName + "&latitude=" + latitude + "&longitude=" + longitude + "&disable_notification=" + disable_notification);
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
                return "ERROR!! " + e.Message + "\r\n" + doc; //+ e.Status;
            }


            dynamic ans = JsonConvert.DeserializeObject(doc);
            //string id = ans.id;
            //string first_name = ans.result.first_name;
            return doc;
        }










    }
}
