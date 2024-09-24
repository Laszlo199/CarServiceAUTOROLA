using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class RestException : Exception
    {
        public HttpStatusCode Status { get; }
        public string? Error { get; }
        public string? Code { get; set; }

        public RestException(HttpStatusCode status, string? error = null) : base(error)
        {
            Status = status;
            Error = error;
        }
    }
}
