using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using QLThuVien.Models;
namespace QLThuVien.Controllers
{
    public class SendMailerController : Controller
    {
        [HttpPost]
        public ViewResult SendMail(MailModel _objModelMail)
        {
            if (ModelState.IsValid)
            {
                //MailMessage mail = new MailMessage();
                //mail.To.Add(_objModelMail.To);
                //mail.From = new MailAddress(_objModelMail.From);
                //mail.Subject = _objModelMail.Subject;
                //string Body = _objModelMail.Body;
                //mail.Body = Body;
                //mail.IsBodyHtml = true;
                //SmtpClient smtp = new SmtpClient();
                //smtp.Host = "smtp.gmail.com";
                //smtp.Port = 587;
                //smtp.UseDefaultCredentials = false;
                //smtp.Credentials = new System.Net.NetworkCredential
                //("vitcapcap234567@gmail.com", "thangcho123");// Enter seders User name and password
                //smtp.EnableSsl = true;
                //smtp.Send(mail);
                //return View("Index", _objModelMail);


                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("librarynhom5@gmail.com");
                mail.To.Add(_objModelMail.To);
                mail.Subject = "Password Recovery ";
                mail.Body += " <html>";
                mail.Body += "<body>";
                mail.Body += "<table>";
                mail.Body += "<tr>";
                mail.Body += "<td>User Name : </td><td> HAi </td>";
                mail.Body += "</tr>";

                mail.Body += "<tr>";
                mail.Body += "<td>Password : </td><td>aaaaaaaaaa</td>";
                mail.Body += "</tr>";
                mail.Body += "</table>";
                mail.Body += "</body>";
                mail.Body += "</html>";
                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("librarynhom5@gmail.com", "anhlavodich123");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return View(_objModelMail);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ViewResult Index(MailModel _objModelMail)
        {
            if (ModelState.IsValid)
            {
                //MailMessage mail = new MailMessage();
                //mail.To.Add(_objModelMail.To);
                //mail.From = new MailAddress(_objModelMail.From);
                //mail.Subject = _objModelMail.Subject;
                //string Body = _objModelMail.Body;
                //mail.Body = Body;
                //mail.IsBodyHtml = true;
                //SmtpClient smtp = new SmtpClient();
                //smtp.Host = "smtp.gmail.com";
                //smtp.Port = 587;
                //smtp.UseDefaultCredentials = false;
                //smtp.Credentials = new System.Net.NetworkCredential
                //("vitcapcap234567@gmail.com", "thangcho123");// Enter seders User name and password
                //smtp.EnableSsl = true;
                //smtp.Send(mail);
                //return View("Index", _objModelMail);


                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("librarynhom5@gmail.com");
                mail.To.Add(_objModelMail.To);
                mail.Subject = "Password Recovery ";
                mail.Body += " <html>";
                mail.Body += "<body>";
                mail.Body += "<table>";
                mail.Body += "<tr>";
                mail.Body += "<td>User Name : </td><td> HAi </td>";
                mail.Body += "</tr>";

                mail.Body += "<tr>";
                mail.Body += "<td>Password : </td><td>aaaaaaaaaa</td>";
                mail.Body += "</tr>";
                mail.Body += "</table>";
                mail.Body += "</body>";
                mail.Body += "</html>";
                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("librarynhom5@gmail.com", "anhlavodich123");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return View(_objModelMail);
            }
            else
            {
                return View();
            }
        }

        public string Remind(string id)
        {
            string result = String.Empty;


            return result;
        }

    }
}
