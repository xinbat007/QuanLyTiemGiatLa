using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace QuanLyTiemGiatLa.Xuly
{
    class Http
    {
        private static string m_baseUrl = "http://139.180.211.168/api/v1.0";
        private static string m_userName = "machine_master";
        private static string m_password = "taolaadmin";
        private static string m_token = "";

        public static string Login(string userName, string password)
        {
            m_userName = userName;
            m_password = password;
            string loginUrl = m_baseUrl + "/auth/login";
            // Create the web request
            HttpWebRequest request = WebRequest.Create(loginUrl) as HttpWebRequest;
            //request.Accept = "application/atom+xml";
            var postData = "clientId=" + m_userName;
            postData += "&" + "password=" + m_password;
            var dataEncode = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = dataEncode.Length;
            request.Credentials = CredentialCache.DefaultCredentials;
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(dataEncode, 0, dataEncode.Length);
                dataStream.Close();
            }
            // Get response
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream  
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string json = reader.ReadToEnd();
                reader.Close();
                response.Close();

                //{
                //    "code": 200,
                //    "message": "success",
                //    "data": {
                //        "token": "f466e11b44afbfdaeb5e118a89a7085bcaf6c874"
                //    }
                //}
                Dictionary<string, object> htmlAttributes = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                string code = htmlAttributes["code"] == null ? "" : htmlAttributes["code"].ToString();
                string message = htmlAttributes["message"].ToString();
                string data = htmlAttributes["data"].ToString();
                if (code == "200")
                {
                    Dictionary<string, object> dicData = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
                    m_token = dicData["token"].ToString();
                }
                else
                {
                    m_token = "";
                }
                return message;
            }
        }

        public static string SyncOrder(PhieuEntity order)
        {
            string url = m_baseUrl + "/order";
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            var postData = "MaPhieu=" + 1 +
                "&" + "MaKhachHang=" + 1;
            var dataEncode = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = dataEncode.Length;
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Headers["Authorization"] = "Token " + m_token;
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(dataEncode, 0, dataEncode.Length);
                dataStream.Close();
            }
            // Get response
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream  
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string json = reader.ReadToEnd();
                reader.Close();
                response.Close();
                Dictionary<string, object> htmlAttributes = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                string code = htmlAttributes["code"] == null ? "" : htmlAttributes["code"].ToString();
                string message = htmlAttributes["message"].ToString();
                string data = htmlAttributes["data"].ToString();
                if (code == "200")
                {
                }
                else
                {
                    m_token = "";
                }
                return message;
            }
        }
    }
}
