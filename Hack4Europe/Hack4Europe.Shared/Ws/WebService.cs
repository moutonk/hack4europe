using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Web.Http;
using Hack4Europe.Data;
using Hack4Europe.Other;
using Hack4Europe.Utils;

namespace Hack4Europe.Ws
{
    public enum WebServiceResponse
    {
        Success,
        Failure
    }

    public enum RequestType
    {
        Couple,
        User,
        Fantasy,
        FantasyId,
        FantasySeen,
        Feedback,
        Notification,
        Settings
    }

    public enum RequestContentType
    {
        Text,
        Image
    }

    public class WebServiceError
    {
        public System.Net.HttpStatusCode? ErrorCode { get; set; }
        public string CodeDescription { get; set; }
    }

    public class WebService
    {
        private CookieCollection _cookieColl = new CookieCollection();
        private readonly CookieContainer _cookieContainer = new CookieContainer();

        public string Result { get; private set; }
        public bool IsRequestOver { get; private set; }
        public WebServiceError Error { get; private set; }
        public RequestType ReqType { get; private set; }
        public RequestContentType ReqContentType { get; private set; }
        public HttpMethod HttpReqType { get; private set; }

        public WebService()
        {
            Result = null;
            IsRequestOver = false;
            Error = new WebServiceError { ErrorCode = null };
        }

        public void SendRequest(HttpMethod httpReqType,
                                RequestType reqType,
                                RequestContentType reqContentType,
                                Dictionary<string, string> bodyArgs,
                                List<string> urlArgs = null)
        {
            ReqType = reqType;
            ReqContentType = reqContentType;
            HttpReqType = httpReqType;
            Error.CodeDescription = null;
            Error.ErrorCode = null;

            Logs.Output.ShowOutput(Environment.NewLine + "SendRequest: " + httpReqType + " " + reqType + " " + bodyArgs.Aggregate("", (current, keyValuePair) => current + ("[" + keyValuePair.Key + " " + keyValuePair.Value + "]")));

            var dicoToString = FormateDictionnaryToString(bodyArgs);
            var url = Paths.ServerAddress + RequestTypeToUrlString(reqType, urlArgs);

            if (httpReqType == HttpMethod.Post)
                PostPutRequest(ref url, ref dicoToString);
            else if (httpReqType == HttpMethod.Put)
                PostPutRequest(ref url, ref dicoToString);
            else if (httpReqType == HttpMethod.Get)
                GetRequest(ref url, ref dicoToString);
        }

        private static string RequestTypeToUrlString(RequestType reqType, IReadOnlyList<string> rareArgs)
        {
            switch (reqType)
            {
                case RequestType.User:
                    return "user/";
                case RequestType.Couple:
                    return "couple/";
                case RequestType.Fantasy:
                    return "fantaisy/";
                case RequestType.FantasyId:
                    return string.Format("fantaisy/{0}/", rareArgs[0]);
                case RequestType.FantasySeen:
                    return "fantaisySeen/";
                case RequestType.Feedback:
                    return "feedback/";
                case RequestType.Notification:
                    return "notification/";
                case RequestType.Settings:
                    return "settings/";
                default:
                    return reqType.ToString();
            }
        }

        private void AddCookies(HttpWebRequest request)
        {
            //if (Data.Token != null)
            //    _cookieColl.Add(new Cookie { Name = "Token", Value = Data.Token });
            //_cookieContainer.Add(new Uri(Paths.ServerAddress), _cookieColl);
            //request.CookieContainer = _cookieContainer;
        }

        private void AddHeaderContent(WebRequest request)
        {
            if (DataManager.Token != null)
                request.Headers["Authorization"] = "Token " + DataManager.Token;
        }

        private void PostPutRequest(ref string url, ref string parameters)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            byte[] requestParams = null;

            Logs.Output.ShowOutput(url + " " + parameters);

            AddCookies(request);
            AddHeaderContent(request);
            request.Method = HttpReqType.ToString();

            switch (ReqContentType)
            {
                case RequestContentType.Text:
                    requestParams = Encoding.UTF8.GetBytes(parameters);
                    request.ContentType = "application/x-www-form-urlencoded";
                    //request.ContentLength = requestParams.Length;
                    break;

                case RequestContentType.Image:
                    const string boundary = "---MultiPartHeader---";
                    var head = Encoding.UTF8.GetBytes(String.Format("--{0}\r\n" + "Content-Disposition: form-data; name=\"file\"; filename=\"profilpic.jpg\"\r\n" + "\r\n", boundary));
                    var content = Convert.FromBase64String(parameters);
                    var tail = Encoding.UTF8.GetBytes(String.Format("\r\n" + "--{0}--\r\n", boundary));

                    requestParams = new byte[head.Length + tail.Length + content.Length];
                    Array.Copy(head, 0, requestParams, 0, head.Length);
                    Array.Copy(content, 0, requestParams, head.Length, content.Length);
                    Array.Copy(tail, 0, requestParams, head.Length + content.Length, tail.Length);
                    request.ContentType = "multipart/form-data; boundary=" + boundary;
                    //request.ContentLength = content.Length;
                    break;
            }
            request.BeginGetRequestStream(new AsyncCallback(WriteParamsInStreamCallBack), Tuple.Create(request, requestParams));
        }

        private void GetRequest(ref string url, ref string parameters)
        {
            var request = (HttpWebRequest)WebRequest.Create(url + "?" + parameters);

            Logs.Output.ShowOutput(url + "?" + parameters);

            AddCookies(request);
            AddHeaderContent(request);
            request.Method = HttpReqType.ToString();
            request.BeginGetResponse(new AsyncCallback(ManageResponse), Tuple.Create(request, new byte[1]));
        }

        private async void WriteParamsInStreamCallBack(IAsyncResult ar)
        {
            Logs.Output.ShowOutput("Writing request BEGIN...");
            var tuple = (Tuple<HttpWebRequest, byte[]>)ar.AsyncState;

            using (var postStream = tuple.Item1.EndGetRequestStream(ar))
            {
                await postStream.WriteAsync(tuple.Item2, 0, tuple.Item2.Length);
                postStream.Flush();
            }

            Logs.Output.ShowOutput("Writing request END...");
            tuple.Item1.BeginGetResponse(new AsyncCallback(ManageResponse), ar.AsyncState);
        }

        private string FormateDictionnaryToString(IReadOnlyCollection<KeyValuePair<string, string>> dict)
        {
            var builder = new StringBuilder();

            Logs.Output.ShowOutput("-------------------------------------------");
            for (var dicoLine = 0; dicoLine < dict.Count; dicoLine++)
            {
                builder.Append(dict.ElementAt(dicoLine).Key.Equals("") == false ? dict.ElementAt(dicoLine).Key + "=" + dict.ElementAt(dicoLine).Value : dict.ElementAt(dicoLine).Value);
                if (dicoLine + 1 < dict.Count)
                    builder.Append("&");
            }
            Logs.Output.ShowOutput("-------------------------------------------");

            return builder.ToString();
        }

        private static void ShowCookiesInfos(HttpWebResponse response)
        {
            foreach (Cookie cook in response.Cookies)
            {
                Logs.Output.ShowOutput("Cookie:");
                Logs.Output.ShowOutput(cook.Name + "=" + cook.Value);
                Logs.Output.ShowOutput("Domain: " + cook.Domain);
                Logs.Output.ShowOutput("Path: " + cook.Path);
                Logs.Output.ShowOutput("Port: " + cook.Port);
                Logs.Output.ShowOutput("Secure: " + cook.Secure);
                Logs.Output.ShowOutput("When issued:" + cook.TimeStamp);
                Logs.Output.ShowOutput("Expires: (expired?)" + cook.Expires + " " + cook.Expired);
                Logs.Output.ShowOutput("Don't save:" + cook.Discard);
                Logs.Output.ShowOutput("Comment: " + cook.Comment);
                Logs.Output.ShowOutput("Uri for comments: " + cook.CommentUri);
                Logs.Output.ShowOutput("Version: RFC " + (cook.Version == 1 ? "2109" : "2965"));
                Logs.Output.ShowOutput("String: " + cook.ToString());
            }
        }

        private async void ManageResponse(IAsyncResult ar)
        {
            Logs.Output.ShowOutput("Waiting answer BEGIN...");
            var tuple = (Tuple<HttpWebRequest, byte[]>)ar.AsyncState;

            try
            {
                using (var response = (HttpWebResponse)tuple.Item1.EndGetResponse(ar))
                using (var streamResponse = response.GetResponseStream())
                using (var streamRead = new StreamReader(streamResponse))
                {
                    var responseString = streamRead.ReadToEndAsync();

                    _cookieColl = response.Cookies;
                    if (response.Cookies != null)
                        ShowCookiesInfos(response);

                    Result = await responseString;
                    Logs.Output.ShowOutput("Answer: " + Result);
                }
            }
            catch (WebException e)
            {
                ManageResponseExplicitError(e);
            }
            finally
            {
                Logs.Output.ShowOutput("Waiting answer END...");
                IsRequestOver = true;
            }
        }

        private void ManageResponseExplicitError(WebException e)
        {
            Logs.Output.ShowOutput("GetResponseCallback: " + e.Message + ": " + e.InnerException.Message);
            var aResp = e.Response as HttpWebResponse;

            if (aResp == null)
                return;

            Logs.Output.ShowOutput("statusCode: " + (int)aResp.StatusCode);
            Error.ErrorCode = aResp.StatusCode;
            Error.CodeDescription = aResp.StatusDescription;
            using (var reader = new StreamReader(aResp.GetResponseStream()))
            {
                Result = reader.ReadToEnd();
                Logs.Output.ShowOutput(Result);
            }
        }

        public BitmapImage DownloadImageUrl(string url)
        {
            var uri = new Uri(url, UriKind.Absolute);
            return new BitmapImage(uri);
        }
    }
}