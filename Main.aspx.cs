using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
         var lname = name.Value;
         var eadd = email.Value;
        var lcontent = message.Value;   
          
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(eadd);
            mail.To.Add("jhhanee03@gmail.com");
            mail.Subject = lname + " " + eadd;

            mail.IsBodyHtml = true;
            string htmlBody;

            htmlBody =lcontent;

            mail.Body = htmlBody;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhhanee03@gmail.com", "j1615dn303");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            //("mail Send");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //var fromAddress = new MailAddress("jhhanee03@gmail.com");
        //var fromPassword = "xxxxxx";
        //var toAddress = new MailAddress("jhhanee03@yourdoamain.com");

        //string subject = "subject";
        //string body = "body";

        //System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
        //{
        //    Host = "smtp.gmail.com",
        //    Port = 587,
        //    EnableSsl = true,
        //    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
        //    UseDefaultCredentials = false,
        //    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        //};

        //using (var message = new MailMessage(fromAddress, toAddress)
        //{
        //    Subject = subject,
        //    Body = body
        //})

        //    smtp.Send(message);

    }
}