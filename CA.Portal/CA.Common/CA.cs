using CERTCLILib;
using System;

namespace CA.Common
{
    public class CA
    {
        public enum RequestDisposition
        {
            CR_DISP_INCOMPLETE = 0,
            CR_DISP_ERROR = 0x1,
            CR_DISP_DENIED = 0x2,
            CR_DISP_ISSUED = 0x3,
            CR_DISP_ISSUED_OUT_OF_BAND = 0x4,
            CR_DISP_UNDER_SUBMISSION = 0x5,
            CR_DISP_REVOKED = 0x6,
            CCP_DISP_INVALID_SERIALNBR = 0x7,
            CCP_DISP_CONFIG = 0x8,
            CCP_DISP_DB_FAILED = 0x9
        }

        /// <summary>
        /// The reference to the Enterprise CA Server; i.e. SERVER.DOMAIN\DOMAIN-SERVER-CA<br/>
        /// Needs to match what is used in the configuration of the server, or be set to the HTTP Enrollment URL
        /// </summary>
        public string Server
        {
            get; set;
        }

        public string Request(string csr, string templateName = "WebServer", string additionalAttributes = "")
        {
            if (string.IsNullOrEmpty(Server))
            {
                throw new Exceptions.CANotDefinedException();
            }

            string attributes = string.Format("CertificateTemplate: {0}", templateName);

            if (!string.IsNullOrEmpty(additionalAttributes))
            {
                attributes += "\n" + additionalAttributes;
            }

            CCertRequest objCertRequest = new CCertRequestClass();

            // Submit request to CA Server; 0xff flags will accept and try any encoding type
            RequestDisposition requestResult = (RequestDisposition)objCertRequest.Submit(0xff, csr, attributes, Server);

            if (requestResult == RequestDisposition.CR_DISP_ISSUED)
            {
                // Retreive the new certificate

                return objCertRequest.GetCertificate(0); // Get the certificate in BASE64 with header.
            }

            throw new Exceptions.CANotIssuedException(requestResult);
        }

        public void Retrieve(string commonName)
        {
            throw new NotImplementedException();
        }
    }
}
