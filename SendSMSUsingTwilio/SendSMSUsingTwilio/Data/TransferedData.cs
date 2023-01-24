using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SendSMSUsingTwilio.Data
{
    public class TransferedData
    {
        public string PhoneNumber { get; set; }
        public string MessageBody { get; set; }
    }
}
