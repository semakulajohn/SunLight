using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Net.Mail;
using System.Text;
using SunLight.Helpers;
using SunLight.Models;
using CaptchaMvc.HtmlHelpers;

namespace SunLight.Web.Controllers
{
    public class ContactUsController : Controller
    {

        public ActionResult Contact(ContactUs model)
        {
            // Code for validating the CAPTCHA  
            if (this.IsCaptchaValid("Captcha is not valid"))
            {
                SendMailToSupportCenter(model);
                TempData.Add("Success", true);
            }

            ViewBag.ErrMessage = "Error: captcha is not valid.";
            TempData.Add("Captcha", false);


            return View();   

        }

        public void SendMailToSupportCenter(ContactUs model)
        {
            if (ModelState.IsValid)
            {
                MailAddress From = new MailAddress(ConfigurationManager.AppSettings["no-reply-email"]);
                MailAddress To = new MailAddress(ConfigurationManager.AppSettings["contactus-email"]);
                var mail = new Email();
                var sb = new StringBuilder();
                sb.AppendFormat("Names :{0} <br />", model.Name);
                sb.AppendFormat("Email address: {0} <br />", model.EmailAddress);
                sb.AppendFormat("Phone Number :{0} <br/>", model.PhoneNumber);
                sb.AppendFormat("Message: ", model.Message);
                sb.AppendFormat("Department :", model.Department);

                mail.MailFromAddress = ConfigurationManager.AppSettings["no-reply-email"];
                mail.MailBodyHtml = sb.ToString();
                mail.Subject = "ContactUs - From website";
                mail.MailToAddress = ConfigurationManager.AppSettings["contactus-email"];
                mail.SendMail();
            }
        }
    }
}