using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace SendingEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string sendto = "sahakyan_m@bk.ru";
            MailMessage mailMsg = new MailMessage();
            mailMsg.To.Add(new MailAddress(sendto));
            mailMsg.From = new MailAddress("forproj@ms.com");
            mailMsg.Subject = "subject";
            //mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString("put template's text", null, MediaTypeNames.Text.Plain));
            mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString("put template's text", null, MediaTypeNames.Text.Html));
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = CredentialCache.DefaultNetworkCredentials;
            //System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("sahakyan_meri", "p42Zmx39");
            //smtpClient.Credentials = credentials;
            smtpClient.Send(mailMsg);
            Console.WriteLine("sended");
        }
    }
}
