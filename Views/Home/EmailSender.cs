using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

public class EmailSender : IEmailSender
{
    private readonly string _smtpServer = "smtp.gmail.com"; // Your SMTP server
    private readonly int _port = 587; // Port for SMTP (Gmail uses 587)
    private readonly string _fromEmail = "behsereshtsaeed@gmail.com"; // Your email
    private readonly string _password = "xspksolutfokhyns"; // Use an App Password

    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        using (var client = new SmtpClient(_smtpServer, _port))
        {
            client.Credentials = new NetworkCredential(_fromEmail, _password);
            client.EnableSsl = true;

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_fromEmail),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            mailMessage.To.Add(email);

            await client.SendMailAsync(mailMessage);
        }
    }
}
