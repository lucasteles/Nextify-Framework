using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security.Tokens;
using System.ServiceModel.Security;
namespace Anbima.Galgo.Binding
{
    public class GalgoBinding : System.ServiceModel.Channels.Binding
    {

        public override BindingElementCollection CreateBindingElements()
        {

            BindingElementCollection be = new BindingElementCollection();
            
            X509SecurityTokenParameters initiator = new X509SecurityTokenParameters(X509KeyIdentifierClauseType.Thumbprint, SecurityTokenInclusionMode.AlwaysToRecipient);
            X509SecurityTokenParameters recipient = new X509SecurityTokenParameters(X509KeyIdentifierClauseType.Thumbprint, SecurityTokenInclusionMode.AlwaysToInitiator);
            AsymmetricSecurityBindingElement element = new AsymmetricSecurityBindingElement(recipient, initiator);

            element.SetKeyDerivation(false);
            element.IncludeTimestamp = true;
            element.AllowSerializedSigningTokenOnReply = true;
            element.MessageProtectionOrder = MessageProtectionOrder.SignBeforeEncrypt;
            element.MessageSecurityVersion = MessageSecurityVersion.WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10;

            UserNameSecurityTokenParameters tokenParameters = new UserNameSecurityTokenParameters();

            tokenParameters.InclusionMode = SecurityTokenInclusionMode.AlwaysToRecipient;
            tokenParameters.RequireDerivedKeys = false;
            element.EndpointSupportingTokenParameters.Signed.Add(tokenParameters);

            HttpsTransportBindingElement oTrans = new HttpsTransportBindingElement();
            oTrans.MaxBufferSize = 6000000;
            oTrans.MaxReceivedMessageSize = 6000000;

            be.Add(element);
            be.Add(new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8));
            be.Add(oTrans);

            return be;

        }

        public override string Scheme
        {
            get { return "https"; }
        }

    }
}
