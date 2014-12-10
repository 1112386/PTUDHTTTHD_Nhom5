using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using QLThuVien.Models;
using System.Text;
namespace QLThuVien.Controllers
{
    public class SendMailerController : Controller
    {
        [HttpGet]
        public ActionResult Remind(int id)
        {

            QuanLyThuVienEntities db = new QuanLyThuVienEntities();
            docgia dg = db.docgias.Where(a => a.MaDocGia == id).FirstOrDefault();
           
            MailMessage mail = new MailMessage();
            mail.BodyEncoding = Encoding.UTF8;
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("librarynhom5@gmail.com");
            mail.To.Add(dg.Email);
            mail.Subject = "Thông báo quá hạn trả sách";
            
            mail.Body += " <html>";
            mail.Body+="<head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"></head>";
            mail.Body += "<body>";
            mail.Body += "<p>Sách bạn mượn đã quá hạn trả, yêu cầu bạn trả sách sớm nhất có thể.</p>";
            mail.Body += "</body>";
            mail.Body += "</html>";
            mail.IsBodyHtml = true;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("librarynhom5@gmail.com", "anhlavodich123");
            SmtpServer.EnableSsl = true;
            try
            {
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                return Content("0");
            }

            return Content("1");
        }

    }
}
