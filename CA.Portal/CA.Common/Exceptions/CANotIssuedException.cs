using System;

namespace CA.Common.Exceptions
{
    class CANotIssuedException : Exception
    {
         public CANotIssuedException(CA.RequestDisposition disposition)
        {
            Disposition = disposition;
        }

        public CA.RequestDisposition Disposition { get; private set; }

    }
}
