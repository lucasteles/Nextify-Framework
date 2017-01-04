using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Security;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.ServiceModel.Description;
using System.ServiceModel.Security.Tokens;

namespace Anbima.Galgo.Binding
{
    internal class MyServiceCredentialsSecurityTokenManager :
        ServiceCredentialsSecurityTokenManager
    {
        MyServiceCredentials credentials;

        public MyServiceCredentialsSecurityTokenManager(
            MyServiceCredentials credentials)
            : base(credentials)
        {
            this.credentials = credentials;
        }

        public override SecurityTokenProvider CreateSecurityTokenProvider(
            SecurityTokenRequirement requirement)
        {
            SecurityTokenProvider result = null;
            if (requirement.TokenType == SecurityTokenTypes.X509Certificate)
            {
                MessageDirection direction = requirement.
                    GetProperty<MessageDirection>(
                    ServiceModelSecurityTokenRequirement.
                    MessageDirectionProperty);
                if (direction == MessageDirection.Input)
                {
                    if (requirement.KeyUsage == SecurityKeyUsage.Exchange)
                    {
                        result = new X509SecurityTokenProvider(
                            credentials.ServiceEncryptingCertificate);
                    }
                    else
                    {
                        result = new X509SecurityTokenProvider(
                            credentials.ClientSigningCertificate);
                    }
                }
                else
                {
                    if (requirement.KeyUsage == SecurityKeyUsage.Signature)
                    {
                        result = new X509SecurityTokenProvider(
                            credentials.ServiceSigningCertificate);
                    }
                    else
                    {
                        result = new X509SecurityTokenProvider(
                            credentials.ClientEncryptingCertificate);
                    }
                }
            }
            else
            {
                result = base.CreateSecurityTokenProvider(requirement);
            }
            return result;
        }
    }

}
