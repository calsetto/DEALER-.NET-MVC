using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealer.Models
{
    public class error
    {

        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}