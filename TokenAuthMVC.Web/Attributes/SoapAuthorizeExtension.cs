using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace TokenAuthMVC.Attributes
{
    // Define a SOAP Extension that traces the SOAP request and SOAP
    // response for the XML Web service method the SOAP extension is
    // applied to.
    public class SoapAuthorizeExtension : SoapExtension
    {
        public override object GetInitializer(LogicalMethodInfo methodInfo, SoapExtensionAttribute attribute)
        {
            throw new NotImplementedException();
        }

        public override object GetInitializer(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public override void Initialize(object initializer)
        {
            throw new NotImplementedException();
        }

        public override void ProcessMessage(SoapMessage message)
        {
            throw new NotImplementedException();
        }
    }
}