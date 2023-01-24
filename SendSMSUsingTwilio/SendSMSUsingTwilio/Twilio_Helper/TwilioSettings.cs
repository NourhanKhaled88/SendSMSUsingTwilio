using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendSMSUsingTwilio.Twilio_Helper
{
    public class TwilioSettings
    {
        /*
         * هحط 3 بروبرتي علشان تمااااب مع ال appsettings
         * نفس الاسماء
         * */
        public string AccountSID { get; set; }
        public string AuthToken { get; set; }
        public string TwilioPhoneNumber { get; set; }
    }
}
