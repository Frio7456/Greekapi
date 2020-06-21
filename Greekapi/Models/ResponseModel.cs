using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Greekapi.Models
{
    public class ResponseModel
    {
        public int code { get; set; }
        public string description { get; set; }
        public DateTime timestamp { get; set; }
    }
}