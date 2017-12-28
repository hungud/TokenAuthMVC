using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace TokenAuthMVC.Attributes
{
    // Create a SoapExtensionAttribute for the SOAP Extension that can be
    // applied to an XML Web service method.
    [AttributeUsage(AttributeTargets.Method)]
    public class SoapAuthorizeAttribute : SoapExtensionAttribute
    {
        public override Type ExtensionType
        {
            get { return typeof(TraceExtension); }
        }

        public override int Priority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}