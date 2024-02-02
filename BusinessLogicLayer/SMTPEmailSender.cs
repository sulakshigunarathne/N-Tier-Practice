using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class SMTPEmailSender : IEmailSender
    {
        public async void SendEmail(Email email)
        {
            try
            {
                
                using (var smtpClient = new SmtpClient("your-smtp-server.com"))
                {
                    smtpClient.Port = 587; 
                    smtpClient.Credentials = new NetworkCredential("sulakshigunarathne@gmail.com", "dxbs stdr chay tfth");
                    smtpClient.EnableSsl = true; 

                    var message = new MailMessage
                    {
                        From = new MailAddress("sulakshigunarathne@gmail.com"),
                        Subject = email.subject,
                        Body = email.body,
                        IsBodyHtml = true,
                    };

                    message.To.Add(email.emailAddress);

                    // Send the email
                    await smtpClient.SendMailAsync(message);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions or log errors
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }
    }
   }

