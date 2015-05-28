using System;
using System.Collections.Generic;
using Windows.Web.Http;
using Hack4Europe.Ws;

namespace Hack4Europe.Model
{
    class SignInModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class SignInModelDal : ModelDalBase
    {
        public SignInModelDal(Action<WebServiceResponse> callback) : base(callback) { }

        public void SignIn(string login, string password)
        {
            var ws = new WebService();

            ws.SendRequest(HttpMethod.Put, RequestType.User, RequestContentType.Text, new Dictionary<string, string>
            {
                {"username", login},
                {"password", password}
            },
            Callback);
        }
    }
}
