using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace QuanLyTiemGiatLa.Xuly
{
    class ResultHttp
    {
        public String Code { get; set; }
        public String Message { get; set; }
        public String Data { get; set; }
    }

    class HttpUtil
    {
        private static string m_userName = "";
        private static string m_password = "";
        private static string m_token = "";

        public static string Token() { return m_token; }

        public static ResultHttp Login(string baseUrl, string userName, string password)
        {
            ResultHttp result = new ResultHttp();
            try
            {
                m_userName = userName;
                m_password = password;
                string loginUrl = baseUrl + "/auth/login";
                // Create the web request
                WebRequest request = WebRequest.Create(loginUrl);
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
                using (WebResponse response = request.GetResponse())
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
                    result.Code = htmlAttributes["code"] == null ? "" : htmlAttributes["code"].ToString();
                    result.Message = htmlAttributes["message"] == null ? "" : htmlAttributes["message"].ToString();
                    result.Data = htmlAttributes["data"] == null ? "" : htmlAttributes["data"].ToString();
                    if (result.Code == "200")
                    {
                        Dictionary<string, object> dicData = JsonConvert.DeserializeObject<Dictionary<string, object>>(result.Data);
                        m_token = dicData["token"].ToString();
                    }
                    else
                    {
                        m_token = "";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        public static ResultHttp SyncOrder(string baseUrl, PhieuSyncEntity order)
        {
//{
//    "MaPhieu": 80,
//    "MaKhachHang": 32,
//    "NgayLap": "2010-11-28T15:46:59.39",
//    "NgayHenTra": "2010-11-29T15:46:59.39",
//    "GiamGia": 30,
//    "TongTien": 56000,
//    "DaThanhToan": true,
//    "DaTraDo": true,
//    "TenKhachHang": "NGUYỄN THANH NHÀN",
//    "GhiChu": "",
//    "UserName": "",
//    "SoLanIn": 0,
//    "PhiGiaoNhan": 0,
//    "IsPhieuHuy": false
//},
            ResultHttp result = new ResultHttp();
            try
            {
                string url = baseUrl + "/order";
                WebRequest request = WebRequest.Create(url);
                //var postData = "MaPhieu=" + order.MaPhieu +
                //    "&" + "MaKhachHang=" + order.MaKhachHang +
                //    "&" + "NgayLap=" + order.NgayLap +
                //    "&" + "NgayHenTra=" + order.NgayHenTra +
                //    "&" + "GiamGia=" + order.GiamGia +
                //    "&" + "TongTien=" + order.TongTien +
                //    "&" + "DaThanhToan=" + order.DaThanhToan +
                //    "&" + "DaTraDo=" + order.DaTraDo +
                //    "&" + "TenKhachHang=" + order.TenKhachHang +
                //    "&" + "GhiChu=" + order.GhiChu +
                //    "&" + "UserName=" + order.UserName +
                //    "&" + "SoLanIn=" + order.SoLanIn +
                //    "&" + "PhiGiaoNhan=" + order.PhiGiaoNhan +
                //    "&" + "IsPhieuHuy=" + order.IsPhieuHuy
                //    ;
                var postDataJson = JsonConvert.SerializeObject(order, Formatting.Indented);
                var dataEncode = Encoding.UTF8.GetBytes(postDataJson);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = dataEncode.Length;
                request.UseDefaultCredentials = true;
                request.PreAuthenticate = true;
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Headers["Authorization"] = "Token " + m_token;
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(dataEncode, 0, dataEncode.Length);
                    dataStream.Close();
                }
                // Get response
                using (WebResponse response = request.GetResponse())
                {
                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string json = reader.ReadToEnd();
                    reader.Close();
                    response.Close();
                    Dictionary<string, object> htmlAttributes = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                    result.Code = htmlAttributes["code"] == null ? "" : htmlAttributes["code"].ToString();
                    result.Message = htmlAttributes["message"] == null ? "" : htmlAttributes["message"].ToString();
                    result.Data = htmlAttributes["data"] == null ? "" : htmlAttributes["data"].ToString();
                    if (result.Code == "200")
                    {
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = "Exception: " + ex.Message;
            }
            return result;
        }

        public static ResultHttp SyncCustomer(String baseUrl, KhachHangEntity customer)
        {
//{
//    "MaKhachHang": 31,
//    "TenKhachHang": "NGUYỄN NGỌC TRÂM",
//    "DiaChi": "",
//    "DienThoai": "0912986988",
//    "MaVip": 0,
//    "TenVip": "",
//    "GiamGia": 0,
//    "DaTungThanhToan": 0,
//    "SoTheVip": ""
//},
            ResultHttp result = new ResultHttp();
            try
            {
                string url = baseUrl + "/customer";
                WebRequest request = WebRequest.Create(url);
                //var postData = "MaKhachHang=" + customer.MaKhachHang +
                //    "&" + "TenKhachHang=" + customer.TenKhachHang +
                //    "&" + "DiaChi=" + customer.DiaChi +
                //    "&" + "DienThoai=" + customer.DienThoai +
                //    "&" + "MaVip=" + customer.MaVip +
                //    "&" + "TenVip=" + customer.TenVip +
                //    "&" + "GiamGia=" + customer.GiamGia +
                //    "&" + "DaTungThanhToan=" + customer.DaTungThanhToan +
                //    "&" + "SoTheVip=" + customer.SoTheVip;
                var postDataJson = JsonConvert.SerializeObject(customer, Formatting.Indented);
                var dataEncode = Encoding.UTF8.GetBytes(postDataJson);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = dataEncode.Length;
                request.UseDefaultCredentials = true;
                request.PreAuthenticate = true;
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Headers["Authorization"] = "Token " + m_token;
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(dataEncode, 0, dataEncode.Length);
                    dataStream.Close();
                }
                // Get response
                using (WebResponse response = request.GetResponse())
                {
                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string json = reader.ReadToEnd();
                    reader.Close();
                    response.Close();
                    Dictionary<string, object> htmlAttributes = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                    result.Code = htmlAttributes["code"] == null ? "" : htmlAttributes["code"].ToString();
                    result.Message = htmlAttributes["message"] == null ? "" : htmlAttributes["message"].ToString();
                    result.Data = htmlAttributes["data"] == null ? "" : htmlAttributes["data"].ToString();
                    if (result.Code == "200")
                    {
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = "Exception: " + ex.Message;
            }
            return result;
        }

        public ResultHttp SyncOrderDetail(String baseUrl, ChiTietPhieuEntity ctphieu)
        {
//{
//    "IDChiTietPhieu": 92,
//    "MaPhieu": 81,
//    "MaHang": 32,
//    "Soluong": 1,
//    "MaKieuGiat": 1,
//    "DonGia": 35000,
//    "TenHang": "Áo giả da",
//    "TenKieuGiat": "Giặt nước",
//    "GhiChu": ""
//},
            ResultHttp result = new ResultHttp();
            try
            {
            }
            catch (Exception ex)
            {
                result.Message = "Exception: " + ex.Message;
            }
            return result;
        }
    }
}
