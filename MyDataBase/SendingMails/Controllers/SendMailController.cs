using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Mail;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace SendingMails.Controllers
{
    public class SendMailController : Controller
    {
        [System.Web.Http.HttpPost]
        public void SendMailTo(string sendto)
        {
            var client = new SendGridClient("sendgrid_key");

            var myMessage = new SendGridMessage();
            myMessage.AddTo(sendto);
            myMessage.From = new EmailAddress("mssend@ms.com");
            myMessage.Subject = "subject";
            myMessage.PlainTextContent = "body";

            var response=client.SendEmailAsync(myMessage);

        }
    }
}