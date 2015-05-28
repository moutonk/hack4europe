using System;
using Hack4Europe.Ws;

namespace Hack4Europe.Model
{
    public class ModelDalBase
    {
        protected Action<WebServiceResponse> Callback { get; set; }

        protected ModelDalBase(Action<WebServiceResponse> callback)
        {
            Callback = callback;
        }
    }
}
