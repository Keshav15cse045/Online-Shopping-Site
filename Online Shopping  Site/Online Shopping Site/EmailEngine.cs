using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Configuration;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Net;

namespace WebApplication14
{
    public class EmailEngine
    {
        public static void sendemail(string recipentemail, string subject, string body)
        {
            using (MailMessage mailmessage = new MailMessage("abc@gmail.com", recipentemail))
            {
              //  mailmessage.From = new MailAddress("abc@gmail.com",);
                mailmessage.Subject = subject;
                mailmessage.Body = body;
                mailmessage.IsBodyHtml = true;

                //mailmessage.To.Add(new MailAddress(recipentemail));
                SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
                smtp.Credentials = new System.Net.NetworkCredential()
                {
                    UserName = "abc@gmail.com",
                    Password = "xyz"
                };

                //smtp.Host=ConfigurationManager.AppSettings["Host"];
                //smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
                //System.Net.NetworkCredential Networkcred= new System.Net.NetworkCredential();
                //Networkcred.UserName = ConfigurationManager.AppSettings["username"];
                //Networkcred.Password = ConfigurationManager.AppSettings["password"];
                // smtp.UseDefaultCredentials = true;
                // smtp.Credentials = Networkcred;
                // smtp.Port = int.Parse(ConfigurationManager.AppSettings["port"]);
                smtp.EnableSsl = true;
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.Send(mailmessage);
            }
        }
    }
}