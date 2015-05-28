using System;
using System.Collections.Generic;
using Windows.Web.Http;
using Hack4Europe.Ws;

namespace Hack4Europe.Model
{
    public class SignUpModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class SignUpModelDal : ModelDalBase 
    {
        public SignUpModelDal(Action<WebServiceResponse> callback) : base(callback) {}

        public void SignUp(string login, string password1, string password2)
        {
            var ws = new WebService();

            ws.SendRequest(HttpMethod.Post, RequestType.User, RequestContentType.Text, new Dictionary<string, string>
            {
                {"username", login},
                {"password", password1}
            },
            Callback);
        }
    }
}
