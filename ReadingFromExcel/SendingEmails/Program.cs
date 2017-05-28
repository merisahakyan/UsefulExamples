using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Web.Configuration;


namespace SendingEmails
{
    class Program
    {
        public static void SendMail(string to, string subject, string body)
        {
            Configuration oConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var mailSettings = oConfig.GetSectionGroup("system.net/mailSettings") as MailSettingsSectionGroup;

            if (mailSettings != null)
            {
                int port = mailSettings.Smtp.Network.Port;
                string from = mailSettings.Smtp.From;
                string host = mailSettings.Smtp.Network.Host;
                string pwd = Crypting.Decrypt(mailSettings.Smtp.Network.Password);
                string uid = Crypting.Decrypt(mailSettings.Smtp.Network.UserName);

                var message = new MailMessage
                {
                    From = new MailAddress(@from)
                };
                message.To.Add(new MailAddress(to));
                message.CC.Add(new MailAddress(from));
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = body;

                var client = new SmtpClient
                {
                    Host = host,
                    Port = port,
                    Credentials = new NetworkCredential(uid, pwd),
                    EnableSsl = true
                };

                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                }
            }
        }
        static void Main(string[] args)
        {
            string[] mails = { "sahakyan_m@bk.ru", "msahakyan1997@gmail.com", "yegoryan.narek@gmail.com", "tigran_vardanyan@yahoo.com", "vanhakobyan1996@gmail.com" ,"meri.sahakyan@yahoo.com"};

            //SendMail(mails[0], "sub", "hello");
            //SendMail(mails[1], "sub", "hello");
            //SendMail(mails[2], "sub", "hello");
            //SendMail(mails[3], "sub", "hello");
            //SendMail(mails[4], "sub", "hello");
            SendMail(mails[5], "sub", "hello");
            Console.WriteLine("sended");


            //Console.WriteLine(Crypting.EncodePassword("crmd_team"));
            //string pass = Crypting.Encrypt("p42Zmx39");
            //Console.WriteLine(pass);

            //string p = Crypting.Decrypt(pass);
            //Console.WriteLine(p);
        }
    }
}
