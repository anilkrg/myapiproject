using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapiproject.Contract.Response
{
    public class ApiResponse
    {
        public bool Ok { get; set; }
        public string message { get; set; }
        public int Status { get; set; }
        public string Token { get; set; }
        public dynamic Data { get; set; }
    }
}
