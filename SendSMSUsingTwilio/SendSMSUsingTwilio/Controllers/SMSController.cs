using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendSMSUsingTwilio.Data;
using SendSMSUsingTwilio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendSMSUsingTwilio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        private readonly ISMSServices _SMSServices;

        public SMSController(ISMSServices smsServices)
        {
            _SMSServices = smsServices;
        }
        /*
         * https://console.twilio.com/us1/develop/sms/try-it-out/send-an-sms?frameUrl=%2Fconsole%2Fsms%2Fgetting-started%2Fbuild%3Fx-target-region%3Dus1
         * */
        [HttpPost("send")]
        public IActionResult SendSMS(TransferedData data)
        {
            var result = _SMSServices.messageResource(data.PhoneNumber, data.MessageBody);
            if (!string.IsNullOrEmpty(result.ErrorMessage))
            {
                return BadRequest(result.ErrorMessage);
            }
            return Ok(result);

        }
    }
}
