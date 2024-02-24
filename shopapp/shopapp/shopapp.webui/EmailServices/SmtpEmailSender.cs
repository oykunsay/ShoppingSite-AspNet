using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace shopapp.webui.EmailServices{
    public class SmtpEmailSender : IEmailSender
    {
        private string _host { get; set; }
        private int _port { get; set; }
        private bool _enableSSL { get; set; }
        private string _username { get; set; }
        private string _password { get; set; }
        public SmtpEmailSender(string host, int port, bool enableSSL,string username, string password){
            this._host = host;
            this._port = port;
            this._enableSSL = enableSSL;
            this._username = username;
            this._password = password;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(this._host,this._port){
                Credentials = new NetworkCredential(_username,_password),
                EnableSsl = this._enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(this._username, email,subject, htmlMessage){
                    IsBodyHtml = true
                }
            );
        }
    }
}