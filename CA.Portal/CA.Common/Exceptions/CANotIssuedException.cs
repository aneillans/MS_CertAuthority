using System;

namespace CA.Common.Exceptions
{
    [Serializable]
    class CANotIssuedException : Exception
    {
         public CANotIssuedException(CA.RequestDisposition disposition)
        {
            Disposition = disposition;
        }

        public CA.RequestDisposition Disposition { get; private set; }

    }
}
