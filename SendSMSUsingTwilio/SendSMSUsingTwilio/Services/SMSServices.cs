using Microsoft.Extensions.Options;
using SendSMSUsingTwilio.Twilio_Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SendSMSUsingTwilio.Services
{
    public class SMSServices : ISMSServices
    {
        private readonly TwilioSettings _TwilioSettings;

        public SMSServices(IOptions<TwilioSettings> twilioSettings)
        {
            _TwilioSettings = twilioSettings.Value;
        }

        public MessageResource messageResource(string PhoneNumber, string Message)
        {
            TwilioClient.Init("AC9a96291f72e6de286a63476145cb1b59", "6924c0598e348dbd446677380763ec5e");
            var message = MessageResource.Create(
                body:Message,
                from:new Twilio.Types.PhoneNumber("+15342025572"),
                to:PhoneNumber
                );
            return message;
        }
    }
}
