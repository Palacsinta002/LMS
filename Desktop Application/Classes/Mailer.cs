using System.Net;
using System.Net.Mail;
using System.Text;

namespace Desktop_Application.Classes;

class Mailer
{
    public static void SendMail(string email, string username, string password)
    {
        try
        {
            NetworkCredential credentials = new("librarymanagementsystem.emailer@gmail.com", "cfjncbaukrqfvtzb");
            SmtpClient smtpClient = new("smtp.gmail.com", 587)
            {
                // Set up smtp client with basic credentials
                UseDefaultCredentials = false,
                Credentials = credentials,
                EnableSsl = true
            };

            // Create from-to, subject and the body of the email
            MailAddress from = new("librarymanagementsystem.emailer@gmail.com", "LMS");
            MailAddress to = new(email, username);
            MailMessage myMail = new(from, to)
            {
                Subject = "Account activation",
                SubjectEncoding = Encoding.UTF8,

                Body = $"<b>Account activation</b>" +
                $"<br>" +
                $"<b>Your account's password is: </b>{password}" +
                $"<br>" +
                $"Sign in with your username or email address and with the randomly generated password <a href='http://localhost:5173/login'>here.</a>" +
                $"<br>" +
                $"If you would like to change your password you can do it in you Profile Settings.",
                BodyEncoding = Encoding.UTF8,
                IsBodyHtml = true
            };

            smtpClient.Send(myMail);
        }
        catch (SmtpException ex)
        {
            MessageBox.Show("Error with sending email: " + ex.Message);
        }
    }
}