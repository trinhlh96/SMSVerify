using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.AspNet.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ActionSMS.Controllers
{
    public class SMSController : TwilioController
    {
        // GET: SMS
        public ActionResult SendSms(string code)
        {
            var accountID = "ACe39a71f89650340a9aa237831bfc0922";
            var authToken = "111d105ea27d5137032d6f3b8f519a85";
            TwilioClient.Init(accountID, authToken);

            var to = new PhoneNumber("+84911549898");
            var from = new PhoneNumber("+14073260480");

            var message = MessageResource.Create(
                to: to,
                from: from,
                body: code
                );
            return Content(message.Sid);
        }
    }
}