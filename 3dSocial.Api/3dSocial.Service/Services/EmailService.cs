using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3dSocial.Service.Services
{
    public class EmailService
    {
        //TODO: Config file???
        private readonly string _from = "ricardo.cmartin@gmail.com";
        private readonly string _fromName = "Impressão Coletiva";
        private readonly string _sendGridAPIKey = "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";
        private SendGridClient _client = null;

        public EmailService(){
        }

        private SendGridClient getClient() {
            if(_client == null)
                _client = new SendGridClient(_sendGridAPIKey);

            return _client;
        }

        /// <summary>
        /// Send an e-mail msg
        /// </summary>
        /// <param name="subject">The mail subject</param>
        /// <param name="content">The mail content</param>
        /// <param name="to">A list of destinations in this form: [mail,name]</param>
        public SendGridMessage CreteEmailMsg(string subject, string content, bool html, List<List<string>> destinations) {
            var msg = new SendGridMessage() { 
                From = new EmailAddress(_from, _fromName)
            };
            List<EmailAddress> recipients = new List<EmailAddress>();
            foreach (List<string> to in destinations) {
                recipients.Add(new EmailAddress(to[0], to[1]));
            }
            msg.AddTos(recipients);
            msg.SetSubject(subject);
            msg.AddContent(html ? MimeType.Html : MimeType.Text, content);

            return msg;
        }

        public void SendEmailMessage(SendGridMessage email) {
            getClient().SendEmailAsync(email);
        }
    }
}
