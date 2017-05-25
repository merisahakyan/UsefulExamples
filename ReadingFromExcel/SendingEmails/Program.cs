using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

using System.Web.Configuration;


namespace SendingEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string sendto = "merisahakyan1@gmail.com";
            MailMessage mailMsg = new MailMessage();
            mailMsg.To.Add(new MailAddress(sendto));
            mailMsg.Subject = "subject";

            System.Configuration.Configuration config = WebConfigurationManager.
                OpenWebConfiguration(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            MailSettingsSectionGroup settings = (MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");




            mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString("put template's text", null, MediaTypeNames.Text.Plain));

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(settings.Smtp.Network.UserName, settings.Smtp.Network.Password);

            smtpClient.Send(mailMsg);
            Console.WriteLine("sended");
        }
    }
}
