using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace DAL.MailServer
{
   public abstract class MasterMailServer
    {
        private SmtpClient smtpclient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient()
        {
            smtpclient = new SmtpClient();
            smtpclient.Credentials = new NetworkCredential(senderMail,password);
            smtpclient.Host = host;
            smtpclient.Port = port;
            smtpclient.EnableSsl = ssl;
        }
        public void sendMail(string subject,string body,List<string> recipientMail) {

            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                foreach(string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpclient.Send(mailMessage);


            }catch(Exception ex)
            {

            }
            finally
            {
                mailMessage.Dispose();
                smtpclient.Dispose();

            }
        }
       
    }
}
